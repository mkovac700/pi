using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class FormIzradaPovratnice : Form
    {
        Database entities = new Database();
        private int idSkladiste;
        private int idTrgovina;
        private int idKorisnik;

        private List<ArtiklSkladiste> artikliSkladisteList = new List<ArtiklSkladiste>();
        private List<ArtiklPovratnica> artikliPovratniceList = new List<ArtiklPovratnica>();

        public FormIzradaPovratnice()
        {
            InitializeComponent();
        }

        private void FormIzradaPovratnice_Load(object sender, EventArgs e)
        {
            idSkladiste = Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault().Skladistes.FirstOrDefault().id;
            idTrgovina = Autentifikator.DohvatiPrijavljenogKorisnika().Trgovinas.FirstOrDefault().id;
            idKorisnik = Autentifikator.DohvatiPrijavljenogKorisnika().id;

            entities.Dobavljacs.Load();
            entities.Primkas.Load();
            cbDobavljac.DataSource = (from primke in entities.Primkas.Local
                                      where primke.skladisteId == idSkladiste
                                      select primke.Dobavljac).Distinct().ToList();
        }

        private void cbDobavljac_SelectedValueChanged(object sender, EventArgs e)
        {
            btnGenerirajPovratnicu.Enabled = true;
            artikliSkladisteList.Clear();

            entities.ArtiklPrimkas.Load();
            entities.ArtiklSkladistes.Load();
            var artikliPrimke = from ap in entities.ArtiklPrimkas.Local
                                where ap.dobavljacId == (cbDobavljac.SelectedItem as Dobavljac).id
                                && ap.skladisteId == idSkladiste
                                select ap.Artikl;

            foreach(var artiklSkladiste in entities.ArtiklSkladistes.Local) 
            {
                foreach(var artiklPrimka in artikliPrimke)
                {
                    if(artiklPrimka.id == artiklSkladiste.artiklId && artiklSkladiste.skaldisteId == idSkladiste)
                    {
                        artikliSkladisteList.Add(artiklSkladiste);
                    }
                }
            }

            artikliSkladisteList = artikliSkladisteList.Distinct().ToList();

            OsvjeziDGVArtikliDobavljaca();
        }

        private void tbSifraArtikla_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbSifraArtikla.Text, out int sifra);

            dgvArtikliDobavljaca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach(DataGridViewRow row in dgvArtikliDobavljaca.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(sifra.ToString()))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var odabraniArtikl = (dgvArtikliDobavljaca.CurrentRow.DataBoundItem as ArtiklSkladiste);

            if ((int)numKolicina.Value > (int)odabraniArtikl.kolicina)
            {
                MessageBox.Show("Nije moguće vratiti više artikala nego što je na skladištu!");
            }
            else
            {
                long artiklId = odabraniArtikl.artiklId;
                int kolicina = (int)numKolicina.Value;
                decimal cijena = odabraniArtikl.Artikl.ArtiklCijenas.OrderByDescending(x => x.vrijediOd).FirstOrDefault().cijena;

                artikliPovratniceList.Add(new ArtiklPovratnica { artiklId = artiklId, kolicina = kolicina, cijena = cijena });
                odabraniArtikl.kolicina -= kolicina;

                OsvjeziDGVArtikliPovratnice();
                OsvjeziDGVArtikliDobavljaca();

                cbDobavljac.Enabled = false;
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var odabraniArtikl = (dgvArtikliPovratnice.CurrentRow.DataBoundItem as ArtiklPovratnica);

            artikliSkladisteList.FirstOrDefault(x => x.artiklId == odabraniArtikl.artiklId).kolicina += odabraniArtikl.kolicina;
            artikliPovratniceList.Remove(odabraniArtikl);

            if (artikliPovratniceList.Count == 0) cbDobavljac.Enabled = true;

            OsvjeziDGVArtikliPovratnice();
            OsvjeziDGVArtikliDobavljaca();
        }

        private void btnGenerirajPovratnicu_Click(object sender, EventArgs e)
        {
            var odabraniDobavljac = (cbDobavljac.SelectedValue as Dobavljac);
            if (artikliPovratniceList.Count != 0)
            {
                entities.Povratnicas.Load();
                var novaPovratnica = new Povratnica
                {
                    datumVrijeme = DateTime.Now,
                    dobavljacId = odabraniDobavljac.id,
                    korisnikId = idKorisnik,
                    trgovinaId = idTrgovina
                };
                entities.Povratnicas.Add(novaPovratnica);
                entities.SaveChanges();

                entities.ArtiklPovratnicas.Load();

                int idNovePovratnice = novaPovratnica.id;

                foreach (var item in artikliPovratniceList)
                {
                    entities.ArtiklPovratnicas.Add(new ArtiklPovratnica { artiklId = item.artiklId, povratnicaId = idNovePovratnice, kolicina = item.kolicina, cijena = item.cijena });
                }

                entities.SaveChanges();

                entities.ArtiklPovratnicas.Load();

                var noviArtikliPovratnice = from artikli in entities.ArtiklPovratnicas.Local
                                            where artikli.povratnicaId == idNovePovratnice
                                            select artikli;

                btnGenerirajPovratnicu.Enabled = false;

                FormPovratnicaIzvjestaj formPovratnicaIzvjestaj = new FormPovratnicaIzvjestaj(novaPovratnica, noviArtikliPovratnice, odabraniDobavljac);
                formPovratnicaIzvjestaj.Show();
            }
        }

        private void OsvjeziDGVArtikliDobavljaca()
        {
            dgvArtikliDobavljaca.DataSource = null;
            dgvArtikliDobavljaca.DataSource = artikliSkladisteList;
            dgvArtikliDobavljaca.Columns[1].Visible = false;
            dgvArtikliDobavljaca.Columns[4].Visible = false;
            dgvArtikliDobavljaca.Columns[0].HeaderText = "Šifra artikla";
            dgvArtikliDobavljaca.Columns[2].HeaderText = "Količina";
            dgvArtikliDobavljaca.Columns[3].HeaderText = "Naziv artikla";
            dgvArtikliDobavljaca.Columns[3].Width = 200;
            dgvArtikliDobavljaca.Columns[3].DisplayIndex = 2;
            dgvArtikliDobavljaca.Columns[2].DisplayIndex = 3;
        }

        private void OsvjeziDGVArtikliPovratnice()
        {
            dgvArtikliPovratnice.DataSource = null;
            dgvArtikliPovratnice.DataSource = artikliPovratniceList;
            dgvArtikliPovratnice.Columns[1].Visible = false;
            dgvArtikliPovratnice.Columns[4].Visible = false;
            dgvArtikliPovratnice.Columns[5].Visible = false;
            dgvArtikliPovratnice.Columns[0].HeaderText = "Šifra artikla";
            dgvArtikliPovratnice.Columns[2].HeaderText = "Količina";
            dgvArtikliPovratnice.Columns[3].HeaderText = "Cijena";
            dgvArtikliPovratnice.Columns[3].DefaultCellStyle.Format = "C2";
        }
    }
}
