using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Model;

namespace GUI
{
    public partial class LoggaIn : Form
    {
        public LoggaIn()
        {
            InitializeComponent();
        }
        Expedit ex = new Expedit();
        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            var inloggningsiD = txtAnvändarID.Text;
            var lösen = txtLösenord.Text;

            if(!string.IsNullOrEmpty(inloggningsiD) && !string.IsNullOrEmpty(lösen))
            {
                var flag = ex.LoggaIn();
                if(flag)
                {
                    MessageBox.Show("Fel användarid eller lösenord!");

                }
            }
        }
    }
}
