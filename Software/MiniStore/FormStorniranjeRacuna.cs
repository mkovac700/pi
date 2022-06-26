using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class FormStorniranjeRacuna : Form
    {
        public int TrgovinaId { get; set; }
        public int SkladisteId { get; set; }
        public FormStorniranjeRacuna()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            if (tbRacunId.Text.Length < 1)
            {
                MessageBox.Show("Unesite šifru računa!");
                return;
            }

            var sifra = int.Parse(tbRacunId.Text);
            Racun racun;

            using (var db = new Database())
            {
                racun = db.Racuns.Include("RacunArtikls").FirstOrDefault(p => p.id == sifra);

                if (racun == null)
                {
                    MessageBox.Show("Račun s ovom šifrom ne postoji!");
                    tbRacunId.Clear();
                    return;
                }

                var stornoString = $"Storno računa {racun.id}";

                if (db.Racuns.Count(r => r.nacinPlacanja.Contains(stornoString)) > 0)
                {
                    MessageBox.Show("Ovaj račun je već bio storniran!");
                    tbRacunId.Clear();
                    return;
                }

               

                var artikliRacuna = racun.RacunArtikls.Select(r => new
                {
                    artiklId = r.artiklId,
                    kolicina = r.kolicina,
                }).ToList();


                foreach (var artikl in artikliRacuna)
                {
                    var trenutniArtikl = db.Artikls.Include("ArtiklSkladistes").First(p => p.id == artikl.artiklId);
                    var trenutnoSkladiste = trenutniArtikl.ArtiklSkladistes.First(s => s.skaldisteId == SkladisteId);
                    trenutnoSkladiste.kolicina += artikl.kolicina;
                }

                db.Racuns.Add(new Racun
                {
                    datumVrijeme = DateTime.Now,
                    iznos = -1 * racun.iznos,
                    korisnikId = racun.korisnikId,
                    nacinPlacanja = $"STORNO računa {racun.id} - {racun.nacinPlacanja}",
                    trgovinaId = racun.trgovinaId,
                });

                db.SaveChanges();
            }

            MessageBox.Show("Račun uspješno storniran!");
            Close();
        }
    }
}
