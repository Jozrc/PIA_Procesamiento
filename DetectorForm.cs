using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_Procesamiento
{
    public partial class DetectorForm : Form
    {
        Detector deteccion = null;
        private double gammacorrection;
        private Random rng = new Random();
        private bool hayImagen = false;
        VideoCamara camara = null;
        private sbyte[,] weights_x;
        private sbyte[,] weights_y;

        public DetectorForm()
        {
            InitializeComponent();
            deteccion = new Detector(pictureBox1);
            camara = new VideoCamara();
            weights_x = new sbyte[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            weights_y = new sbyte[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            deteccion.encenderCamara();
        }

        private void buttonDetect_Click(object sender, EventArgs e)
        {
            deteccion.toggleDeteccion();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            deteccion.cerrarCamara();
            Form1 FormInicio = new Form1();
            FormInicio.Show();
            this.Close();
        }

        private void DetectorForm_Load(object sender, EventArgs e)
        {
            camara.cargaDispositivos(camaraVideo);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; // Restaura el tamaño normal de la ventana
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; // Maximiza la ventana
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            Form1 otraVentana = new Form1();
        
            otraVentana.Show();

            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void camaraVideo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
