using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using static PIA_Procesamiento.ArchivoVideo;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Emgu.Util.TypeEnum;
using OpenTK.Audio.OpenAL;
using System.Security.Cryptography;

namespace PIA_Procesamiento
{
    public partial class Form1 : Form
    {
        private Bitmap Image, Image2;
        private BitmapData ImageData, ImageData2;
        private byte[] buffer, buffer2;
        private byte R, G, B;
        private int b, g, r, r_x, g_x, b_x, r_y, g_y, b_y, grayscale, location, location2;
        private bool isVideo = false;
        private sbyte weight_x, weight_y;
        private sbyte[,] weights_x;
        private sbyte[,] weights_y;
        private IntPtr pointer, pointer2;

        private void button1_Click(object sender, EventArgs e)
        {
            DetectorForm detectorForm = new DetectorForm();
            this.Hide();
            detectorForm.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private double gammacorrection;
        private Random rng = new Random();
        private bool hayImagen = false;
        VideoCamara camara = null;

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza la ventana
        }

        ArchivoVideo fileVideo = null;
        private void stopButton_Click(object sender, EventArgs e)
        {
            if (fileVideo != null)
            {
                fileVideo.isPlay = false;
            }
        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (fileVideo != null)
            {
                fileVideo.isPlay = false;
                fileVideo.cantFrame = 0;
                fileVideo.video.SetCaptureProperty(CapProp.PosFrames, 0);
            }

        }
        private void playVideo_Click(object sender, EventArgs e)
        {
            if (fileVideo != null)
            {
                fileVideo.isPlay = true;
                Application.Idle += new EventHandler(fileVideo.reproducir);
            }
            else
            {
                MessageBox.Show("No hay video cargado");
            }
        }
        private void comboFiltrosVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileVideo != null)
            {
                fileVideo.filterName = comboFiltrosVideo.SelectedIndex;
            }
        }

        private void imagenCargada_Click(object sender, EventArgs e)
        {

        }

        private void comboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApplyCoolFilter()
        {

            BitmapData imageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] buffer = new byte[3 * Image.Width * Image.Height];
            IntPtr pointer = imageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);

            for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
            {
                int b = (int)((buffer[i]) * 0.393 + (buffer[i + 1]) * 0.769 + (buffer[i + 2]) * 0.189); // Coeficiente azul
                int g = (int)((buffer[i]) * 0.349 + (buffer[i + 1]) * 0.686 + (buffer[i + 2]) * 0.168); // Coeficiente verde
                int r = (int)((buffer[i]) * 0.272 + (buffer[i + 1]) * 0.534 + (buffer[i + 2]) * 0.131); // Coeficiente rojo

                b = (b > 255) ? 255 : b;
                g = (g > 255) ? 255 : g;
                r = (r > 255) ? 255 : r;

                buffer[i] = (byte)b;
                buffer[i + 1] = (byte)g;
                buffer[i + 2] = (byte)r;
            }

            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(imageData);
            imagenCargada.Image = Image;
        }


        private void ApplyPixelateFilter(Bitmap image, int pixelSize)
        {
            for (int y = 0; y < image.Height; y += pixelSize)
            {
                for (int x = 0; x < image.Width; x += pixelSize)
                {
                    Color averageColor = CalculateAverageColor(image, x, y, pixelSize);
                    FillPixelsWithColor(image, x, y, pixelSize, averageColor);
                }
            }
        }

        private Color CalculateAverageColor(Bitmap image, int startX, int startY, int pixelSize)
        {
            int sumR = 0, sumG = 0, sumB = 0;
            int pixelsCount = 0;

            for (int y = startY; y < startY + pixelSize; y++)
            {
                for (int x = startX; x < startX + pixelSize; x++)
                {
                    if (x < image.Width && y < image.Height)
                    {
                        Color pixelColor = image.GetPixel(x, y);
                        sumR += pixelColor.R;
                        sumG += pixelColor.G;
                        sumB += pixelColor.B;
                        pixelsCount++;
                    }
                }
            }

            int avgR = sumR / pixelsCount;
            int avgG = sumG / pixelsCount;
            int avgB = sumB / pixelsCount;

            return Color.FromArgb(avgR, avgG, avgB);
        }

        private void FillPixelsWithColor(Bitmap image, int startX, int startY, int pixelSize, Color color)
        {
            for (int y = startY; y < startY + pixelSize; y++)
            {
                for (int x = startX; x < startX + pixelSize; x++)
                {
                    if (x < image.Width && y < image.Height)
                    {
                        image.SetPixel(x, y, color);
                    }
                }
            }
        }

        private void ApplyEdgeDetectionFilter()
        {

            BitmapData imageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] buffer = new byte[3 * Image.Width * Image.Height];
            IntPtr pointer = imageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);

            for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
            {
                int b = buffer[i];
                int g = buffer[i + 1];
                int r = buffer[i + 2];

                if (i > 0 && i < Image.Height * 3 * Image.Width - 3)
                {
                    int bNext = buffer[i + 3];
                    int gNext = buffer[i + 4];
                    int rNext = buffer[i + 5];

                    int bDiff = Math.Abs(bNext - b);
                    int gDiff = Math.Abs(gNext - g);
                    int rDiff = Math.Abs(rNext - r);

                    int totalDiff = bDiff + gDiff + rDiff;

                    if (totalDiff > 100)
                    {
                        // Resaltar el borde con el color original
                    }
                    else
                    {
                        // No es un borde, establecer en negro (0, 0, 0)
                        b = 0;
                        g = 0;
                        r = 0;
                    }
                }
                else
                {
                    // No es un borde, establecer en negro (0, 0, 0)
                    b = 0;
                    g = 0;
                    r = 0;
                }

                buffer[i] = (byte)b;
                buffer[i + 1] = (byte)g;
                buffer[i + 2] = (byte)r;
            }

            Marshal.Copy(buffer, 0, pointer, buffer.Length);
            Image.UnlockBits(imageData);
            imagenCargada.Image = Image;
        }

        private void ApplyVignetteEffect()
        {    

            // Bloqueo los datos de píxeles de la imagen
            BitmapData imageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            // Obtengo el buffer de píxeles en formato byte[]
            byte[] buffer = new byte[3 * Image.Width * Image.Height];
            IntPtr pointer = imageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);

            // Calculo el centro de la imagen
            int centerX = Image.Width / 2;
            int centerY = Image.Height / 2;

            // Calculo el radio del efecto de viñeta
            double radius = Math.Sqrt(centerX * centerX + centerY * centerY);

            // Recorro todos los píxeles de la imagen
            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    // Obtengo el índice del píxel actual en el buffer
                    int index = y * Image.Width + x;

                    // Obtengo los componentes de color del píxel
                    int b = buffer[index * 3];
                    int g = buffer[index * 3 + 1];
                    int r = buffer[index * 3 + 2];

                    // Calculo la distancia del píxel al centro de la imagen
                    double distance = Math.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY));

                    // Calculo la intensidad del efecto en función de la distancia al radio
                    double intensity = 1 - distance / radius;

                    // Ajusto los componentes de color del píxel utilizando la intensidad
                    b = (int)(b * intensity);
                    g = (int)(g * intensity);
                    r = (int)(r * intensity);

                    // Actualizo los componentes de color en el buffer
                    buffer[index * 3] = (byte)b;
                    buffer[index * 3 + 1] = (byte)g;
                    buffer[index * 3 + 2] = (byte)r;
                }
            }

            // Copio los datos del buffer de píxeles de vuelta a la imagen
            Marshal.Copy(buffer, 0, pointer, buffer.Length);

            // Desbloqueo los datos de píxeles de la imagen
            Image.UnlockBits(imageData);

            // Actualizo la imagen en el control PictureBox
            imagenCargada.Image = Image;
        }

        private void ApplyGammaFilter(double gamma)
        {
            // Bloqueo los datos de píxeles de la imagen
            BitmapData imageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            // Obtengo el buffer de píxeles en formato byte[]
            byte[] buffer = new byte[3 * Image.Width * Image.Height];
            IntPtr pointer = imageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);

            // Calculo el valor de corrección gamma
            double gammaCorrection = 1.0 / gamma;

            // Recorro todos los píxeles de la imagen
            for (int i = 0; i < buffer.Length; i += 3)
            {
                // Obtengo los componentes de color del píxel y los normalizo en el rango de 0.0 a 1.0
                double red = buffer[i] / 255.0;
                double green = buffer[i + 1] / 255.0;
                double blue = buffer[i + 2] / 255.0;

                // Aplico la corrección gamma a cada componente de color
                red = Math.Pow(red, gammaCorrection);
                green = Math.Pow(green, gammaCorrection);
                blue = Math.Pow(blue, gammaCorrection);

                // Vuelvo a escalar los componentes de color al rango de 0 a 255 y los almaceno en el buffer
                buffer[i] = (byte)(red * 255);
                buffer[i + 1] = (byte)(green * 255);
                buffer[i + 2] = (byte)(blue * 255);
            }

            // Copio los datos del buffer de píxeles de vuelta a la imagen
            Marshal.Copy(buffer, 0, pointer, buffer.Length);

            // Desbloqueo los datos de píxeles de la imagen
            Image.UnlockBits(imageData);

            // Actualizo la imagen en el control PictureBox
            imagenCargada.Image = Image;
        }

        private void ApplyWarmFilter()
        {
            // Bloquear los datos de píxeles de la imagen
            BitmapData imageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            // Obtener el buffer de píxeles en formato byte[]
            byte[] buffer = new byte[3 * Image.Width * Image.Height];
            IntPtr pointer = imageData.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);

            // Recorrer todos los píxeles de la imagen
            for (int i = 0; i < buffer.Length; i += 3)
            {
                // Aumentar el componente rojo
                buffer[i] = (byte)(buffer[i] * 1.2);

                // Disminuir los componentes azul y verde
                buffer[i + 1] = (byte)(buffer[i + 1] * 0.8);
                buffer[i + 2] = (byte)(buffer[i + 2] * 0.8);
            }

            // Copiar los datos del buffer de píxeles de vuelta a la imagen
            Marshal.Copy(buffer, 0, pointer, buffer.Length);

            // Desbloquear los datos de píxeles de la imagen
            Image.UnlockBits(imageData);

            // Actualizar la imagen en el control PictureBox
            imagenCargada.Image = Image;
        }

        private Bitmap originalImage;

        private void filtros(int opcion)
        {
            // Restaurar la imagen original al cambiar de filtro
            if (originalImage != null)
            {
                Image = new Bitmap(originalImage); // Copia de la imagen original
                imagenCargada.Image = Image; // Mostrar la imagen original sin filtros
            }

            switch (opcion)
            {
                case 1:
                    // Aplicar filtro frío
                    ApplyCoolFilter();
                    break;

                case 2:
                    // Aplicar filtro de pixelado
                    Bitmap imagen2 = (Bitmap)Image.Clone(); // Crear una copia de la imagen original
                    int pixelSize = 10; // Tamaño de píxel a utilizar en el efecto de pixelado
                    ApplyPixelateFilter(imagen2, pixelSize);
                    imagenCargada.Image = imagen2; // Mostrar la imagen con el filtro aplicado
                    break;

                case 3:
                    // Aplicar filtro de detección de bordes
                    ApplyEdgeDetectionFilter();
                    break;

                case 4:
                    // Aplicar filtro Efecto de viñeta
                    ApplyVignetteEffect();
                    break;

                case 5:
                    // Aplicar filtro Gamma con un valor de gamma más alto, por ejemplo, 3.0
                    ApplyGammaFilter(3.9);
                    break;

                case 6:
                    // Aplicar filtro Calido
                    ApplyWarmFilter();
                    break;

                default:
                    MessageBox.Show("No hay operación que hacer");
                    break;
            }
        }

        private void aceptarFiltro_Click(object sender, EventArgs e)
        {
            switch (comboFiltro.SelectedIndex)
            {
                case 0:
                    if (hayImagen)
                        filtros(1);
                    else
                        MessageBox.Show("Selecciona una imagen primero");
                    break;
                case 1:
                    if (hayImagen)
                        filtros(2);
                    else
                        MessageBox.Show("Selecciona una imagen primero");
                    break;
                case 2:
                    if (hayImagen)
                        filtros(3);
                    else
                        MessageBox.Show("Selecciona una imagen primero");
                    break;
                case 3:
                    if (hayImagen)
                        filtros(4);
                    else
                        MessageBox.Show("Selecciona una imagen primero");
                    break;
                case 4:
                    if (hayImagen)
                        filtros(5);
                    else
                        MessageBox.Show("Selecciona una imagen primero");
                    break;

                case 5:
                    if (hayImagen)
                        filtros(6);
                    else
                        MessageBox.Show("Selecciona una imagen primero");
                    break;
                default:
                    MessageBox.Show("Selecciona un filtro");
                    break;
            }
        }
       /* private void camaraVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = camaraVideo.SelectedIndex;

            camara.cerrarWebCam();
            if (index > 0)
            {
                string dispositivo = camara.misDispositivos[index - 1].MonikerString;
                camara.miWebCam = new VideoCaptureDevice(dispositivo);
                camara.img = imagenCargada;
                camara.miWebCam.NewFrame += new NewFrameEventHandler(camara.capturando);
                camara.miWebCam.Start();
            }
        }

        */
        private void boton_descargar_Click(object sender, EventArgs e)
        {
            if (!isVideo)
            {
                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
                Image imagen = imagenCargada.Image;
                Guardar.ShowDialog();
                imagen.Save(Guardar.FileName);
            }

        }
        private void checkVideo_CheckedChanged(object sender, EventArgs e)
        {
            isVideo = checkVideo.Checked;
            
        }
        private void botonCargarImagen_Click(object sender, EventArgs e)
        {
            if (!isVideo)
            {
                OpenFileDialog nuevaImagen = new OpenFileDialog();
                nuevaImagen.Filter = "Archivos de Imagen|*.jpg";
                nuevaImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                nuevaImagen.Title = "Seleccionar imagen";
                if (nuevaImagen.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(nuevaImagen.FileName); // Guardar la imagen original
                    Image = new Bitmap(originalImage); // Crear una copia de la imagen original
                    Image2 = new Bitmap(Image.Width, Image.Height);
                    imagenOriginal.Image = originalImage; // Mostrar la imagen original
                    imagenCargada.Image = Image; // Mostrar la copia de la imagen original
                    hayImagen = true;
                }
            }
            else if (isVideo)
            {
                OpenFileDialog nuevoVideo = new OpenFileDialog();
                nuevoVideo.Filter = "Archivos de Video (*.mp4)|*.mp4";
                nuevoVideo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (nuevoVideo.ShowDialog() == DialogResult.OK)
                {
                    fileVideo = new ArchivoVideo(nuevoVideo.FileName, imagenOriginal, imagenCargada);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de archivo");
            }
        }
            public Form1()
        {
            InitializeComponent();
         //   camara = new VideoCamara();
         //   weights_x = new sbyte[,] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
         //   weights_y = new sbyte[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          //  camara.cargaDispositivos(camaraVideo);
            comboFiltrosVideo.SelectedIndex = 0;
        }
    }
}
