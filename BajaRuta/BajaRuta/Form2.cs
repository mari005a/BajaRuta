using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BajaRuta
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 miFormulario = new Form1();
            miFormulario.Show(); // Esto abre Form1
            this.Hide();
            miFormulario.Show(); // Esto cierra el Form en deshuso
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 miFormulario = new Form2();
            miFormulario.Show(); // Esto abre Form2
            this.Hide();
            miFormulario.Show(); // Esto cierra el Form en deshuso
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
