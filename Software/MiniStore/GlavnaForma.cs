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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnUpravljanjeArtiklima_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormUpravljanjeArtiklima formUpravljanjeArtiklima = new FormUpravljanjeArtiklima();
            formUpravljanjeArtiklima.TopLevel = false;
            formUpravljanjeArtiklima.AutoScroll = true;
            formUpravljanjeArtiklima.FormBorderStyle = FormBorderStyle.None;
            formUpravljanjeArtiklima.WindowState = FormWindowState.Maximized;
            formUpravljanjeArtiklima.Dock = DockStyle.Fill;
            panel1.Controls.Add(formUpravljanjeArtiklima);
            formUpravljanjeArtiklima.Show();
        }

        private void btnZaprimanjeArtikala_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormZaprimanjeArtikala formZaprimanjeArtikala = new FormZaprimanjeArtikala
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                Dock = DockStyle.Fill
            };
            panel1.Controls.Add(formZaprimanjeArtikala);
            formZaprimanjeArtikala.Show();
        }

        private void btnNarucivanjeArtikala_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormNarucivanjeArtikala formNarucivanjeArtikala = new FormNarucivanjeArtikala();
            formNarucivanjeArtikala.TopLevel = false;
            formNarucivanjeArtikala.AutoScroll = true;
            formNarucivanjeArtikala.FormBorderStyle = FormBorderStyle.None;
            formNarucivanjeArtikala.WindowState = FormWindowState.Maximized;
            formNarucivanjeArtikala.Dock = DockStyle.Fill;
            panel1.Controls.Add(formNarucivanjeArtikala);
            formNarucivanjeArtikala.Show();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormIzradaRacuna formIzradaRacuna = new FormIzradaRacuna();
            formIzradaRacuna.TopLevel = false;
            formIzradaRacuna.AutoScroll = true;
            formIzradaRacuna.FormBorderStyle = FormBorderStyle.None;
            formIzradaRacuna.WindowState = FormWindowState.Maximized;
            formIzradaRacuna.Dock = DockStyle.Fill;
            panel1.Controls.Add(formIzradaRacuna);
            formIzradaRacuna.Show();
        }

        private void btnInventura_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormInventura formInventura = new FormInventura();
            formInventura.TopLevel = false;
            formInventura.AutoScroll = true;
            formInventura.FormBorderStyle = FormBorderStyle.None;
            formInventura.WindowState = FormWindowState.Maximized;
            formInventura.Dock = DockStyle.Fill;
            panel1.Controls.Add(formInventura);
            formInventura.Show();
        }

        private void btnStatistikaProdaje_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormStatistikaProdaje formStatistikaProdaje = new FormStatistikaProdaje();
            formStatistikaProdaje.TopLevel = false;
            formStatistikaProdaje.AutoScroll = true;
            formStatistikaProdaje.FormBorderStyle = FormBorderStyle.None;
            formStatistikaProdaje.WindowState = FormWindowState.Maximized;
            formStatistikaProdaje.Dock = DockStyle.Fill;
            panel1.Controls.Add(formStatistikaProdaje);
            formStatistikaProdaje.Show();
        }

        private void btnUpravljanjeSatnicom_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormUpravljanjeSatnicom formUpravljanjeSatnicom = new FormUpravljanjeSatnicom();
            formUpravljanjeSatnicom.TopLevel = false;
            formUpravljanjeSatnicom.AutoScroll = true;
            formUpravljanjeSatnicom.FormBorderStyle = FormBorderStyle.None;
            formUpravljanjeSatnicom.WindowState = FormWindowState.Maximized;
            formUpravljanjeSatnicom.Dock = DockStyle.Fill;
            panel1.Controls.Add(formUpravljanjeSatnicom);
            formUpravljanjeSatnicom.Show();
        }

        private void btnIzradaPovratnice_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormIzradaPovratnice formIzradaPovratnice = new FormIzradaPovratnice();
            formIzradaPovratnice.TopLevel = false;
            formIzradaPovratnice.AutoScroll = true;
            formIzradaPovratnice.FormBorderStyle = FormBorderStyle.None;
            formIzradaPovratnice.WindowState = FormWindowState.Maximized;
            formIzradaPovratnice.Dock = DockStyle.Fill;
            panel1.Controls.Add(formIzradaPovratnice);
            formIzradaPovratnice.Show();
        }
    }
}
