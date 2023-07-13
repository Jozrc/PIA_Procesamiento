using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_Procesamiento
{
    internal class VideoCamara
    {
        public string path { get; set; }
        private bool hayDispositivos;
        public FilterInfoCollection misDispositivos;
        public VideoCaptureDevice miWebCam;
        public PictureBox img { get; set; }

        public VideoCamara()
        {
            path = @"C:\Users\janto\Documents\FCFM\Ene-Jun 2022\ProcesamientoImagenes\ImagenesProyecto\";
            hayDispositivos = false;
        }

        public void cargaDispositivos(ComboBox combo)
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misDispositivos.Count > 0)
            {
                hayDispositivos = true;
                combo.Items.Clear();
                combo.Items.Add("Seleccionar");
                for (int i = 0; i < misDispositivos.Count; i++)
                {
                    combo.Items.Add(misDispositivos[i].Name.ToString());
                }

                combo.SelectedIndex = 0;
            }
            else
            {
                hayDispositivos = false;
            }
        }

        public void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            img.Image = imagen;
        }

        public void cerrarWebCam()
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
                img.Image = null;
            }
        }

    }
}
