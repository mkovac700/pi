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
    public partial class FormPostavkeSucelja : Form
    {
        string fileLocation;
        public FormPostavkeSucelja()
        {
            InitializeComponent();
        }

        private void FormPostavkeSucelja_Load(object sender, EventArgs e)
        {
            fileLocation = Properties.Settings.Default.FileString;
            if(fileLocation != "")
            {
                try
                {
                    Image image = Image.FromFile(Properties.Settings.Default.FileString);
                    this.pbPregled.Image = image;
                }
                catch (System.IO.FileNotFoundException)
                {
                    var result = MessageBox.Show("Neuspješno učitavanje slike! Želite li obrisati sliku?", "Greška", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        Properties.Settings.Default.Reset();
                    }
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string fileLocation = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Odaberite logotip aplikacije";
            openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG) | *.BMP;*.JPG;*.GIF;*.PNG | All Files(*.*) | *.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileLocation = openFileDialog.FileName;
            }

            Putanja.putanja = fileLocation;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(Putanja.putanja != "")
            {
                Properties.Settings.Default.FileString = Putanja.putanja;
                Properties.Settings.Default.Save();
            }

            Image image = Image.FromFile(Properties.Settings.Default.FileString);
            this.pbPregled.Image = image;
        }
    }
}
