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
    public partial class FormUpravljanjeSatnicom : Form
    {
        public FormUpravljanjeSatnicom()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        private void SetMyCustomFormat()
        {
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            //dateTimePicker1.ShowUpDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSatnica formSatnica = new FormSatnica();
            formSatnica.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSatnica formSatnica = new FormSatnica();
            formSatnica.ShowDialog();
        }
    }
}
