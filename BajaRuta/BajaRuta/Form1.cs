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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los micros amarillos operan en diversas rutas dentro de Ensenada, por ejemplo la casa del marco xddd.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los micros rojos cubren diversas rutas en Ensenada, incluyendo zonas como Lázaro Cárdenas, Márquez de León, Popular, CBTIS, entre otras.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los micros azules de El Vigía operan en varias rutas dentro de Ensenada, por ejemplo la casita de memo.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los micros naranjas son una de las líneas de transporte público que operan en Ensenada, ofreciendo rutas que conectan diversas zonas de la ciudad aunque sea una zona olvidada por dios.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Transporte Violeta es un servicio de transporte público gratuito y exclusivo para mujeres, niñas y niños menores de 12 años, implementado por el gobierno de Baja California como parte de sus políticas de movilidad segura y con perspectiva de género. Este programa busca ofrecer un medio de transporte seguro y accesible para las mujeres y sus hijos en el municipio de Ensenada.");
        }
    }
}
