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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = (5000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Form.ActiveForm.Visible = false;
            FormMenu frm = new FormMenu();
            frm.Show();
        }
    }
}
