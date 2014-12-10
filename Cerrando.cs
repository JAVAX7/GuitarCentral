using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarCentral
{
    public partial class Cerrando : Form
    {
        public Cerrando()
        {
            InitializeComponent();
        }

        private void Cerrando_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = (2500);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Application.Restart();
        }
    }
}
