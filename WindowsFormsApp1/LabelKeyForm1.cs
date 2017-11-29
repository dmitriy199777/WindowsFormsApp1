using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LabelKeyForm1 : Form
    {
        public LabelKeyForm1()
        {
            InitializeComponent();
        }

        private void LabelKeyForm1_Load(object sender, EventArgs e)
        {
            txtKey.Text = Functions.Key;
        }

        private void btnChangePas_Click(object sender, EventArgs e)
        {
            /* 
                1) Открытие формы "ChangePasForm".
            */

            // (1).
            ChangePasForm f = new ChangePasForm();

            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        

        
    }
}
