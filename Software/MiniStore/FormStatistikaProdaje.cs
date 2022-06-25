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
    public partial class FormStatistikaProdaje : Form
    {
        List<Artikl> artikli = new List<Artikl>();
        List<string> kategorije = new List<string>();
        public FormStatistikaProdaje()
        {
            InitializeComponent();
        }

        private void FormStatistikaProdaje_Load(object sender, EventArgs e)
        {
            

            using(var db = new Database())
            {
                artikli = db.Artikls.ToList();
                kategorije= artikli.Select(p=>p.kategorija).Distinct().ToList();
            }
            cbArtikli.DataSource = artikli;
            cbArtikli.DisplayMember = "naziv";
            cbKategorija.DataSource = kategorije;
        }
    }
}
