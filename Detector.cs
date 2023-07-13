using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Windows.Forms;

namespace PIA_Procesamiento
{
    internal class Detector
    {
        Color[] bands_rgb;
        public Rectangle[] band_caras;
        public VideoCapture videoCapture = null;
        Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool facesDetectionEnabled = false;
        CascadeClassifier faceCasacdeClassifier = new CascadeClassifier(@"..\..\haarcascade_frontalface_alt.xml");

        public PictureBox imgDetection { get; set; }

        public Detector(PictureBox pictureBox)
        {
            // Constructor de la clase Detector
            // Inicializa algunas variables y configura el PictureBox para mostrar los resultados

            Random r = new Random();
            Color[] _rgb = {
                Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)),
                // ...
                Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)),
            };
            bands_rgb = _rgb;

            imgDetection = pictureBox;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            // Método que procesa cada fotograma del video capturado

            // Paso 1: Captura de video
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(imgDetection.Width, imgDetection.Height, Inter.Cubic);

            // Paso 2: Detección de caras
            if (facesDetectionEnabled)
            {
                // Convertir la imagen actual a escala de grises
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                // Mejorar la imagen para obtener mejores resultados
                CvInvoke.EqualizeHist(grayImage, grayImage);

                // Detectar caras utilizando un clasificador de cascada de Haar
                Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                band_caras = faces;

                // Si se detectan caras
                if (faces.Length > 0)
                {
                    for (int i = 0; i < faces.Length; i++)
                    {
                        // Dibujar un rectángulo alrededor de cada cara
                        CvInvoke.Rectangle(currentFrame, faces[i], new Bgr(bands_rgb[i]).MCvScalar, 2);
                    }
                }
            }

            // Mostrar el video capturado en el PictureBox imgDetection
            imgDetection.Image = currentFrame.Bitmap;
        }

        public void encenderCamara()
        {
            // Método para encender la cámara

            if (videoCapture == null)
                videoCapture = new VideoCapture();

            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }

        public void toggleDeteccion()
        {
            // Método para habilitar/deshabilitar la detección de caras

            if (facesDetectionEnabled)
                facesDetectionEnabled = false;
            else
                facesDetectionEnabled = true;
        }

        public void cerrarCamara()
        {
            // Método para cerrar la cámara y limpiar los recursos

            if (videoCapture != null)
            {
                videoCapture.Stop();
                videoCapture.Dispose();
                videoCapture = null;
                imgDetection.Image = null;
                facesDetectionEnabled = false;
            }
        }
    }
}
