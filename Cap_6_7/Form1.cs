using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap_6_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio = new Ejercicio1();
            ejercicio.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
