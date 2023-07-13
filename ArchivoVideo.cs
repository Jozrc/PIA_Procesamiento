using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace PIA_Procesamiento
{
    internal class ArchivoVideo
    {
        public VideoCapture video = null;
        public Image<Bgr, Byte> frame;
        public double duracion;
        public double cantFrame;
        public bool isVideoLoad = false, isPlay = false;
        public int filterName { get; set; }

        PictureBox imgOriginal;
        PictureBox imgFinal;

        public ArchivoVideo(string file, PictureBox picOriginal, PictureBox picFinal)
        {
            video = new VideoCapture(file);
            video.QueryFrame(); //Ayuda a obtener los frames.

            Mat m = new Mat();
            video.Read(m);

            frame = new Image<Bgr, Byte>(m.Bitmap);
            frame.Resize(picOriginal.Width, picOriginal.Height, Inter.Cubic);//Redimenciona al tamaño del picturebox.

            picOriginal.Image = frame.Bitmap;

            duracion = video.GetCaptureProperty(CapProp.FrameCount);

            cantFrame = video.GetCaptureProperty(CapProp.PosFrames);

            imgOriginal = picOriginal;
            imgFinal = picFinal;
        }

        public ArchivoVideo()
        {
        }

        private void aplicaFiltro()
        {
            switch (filterName)
            {
                case 0:
                    {
                        Image img = frame.Bitmap;
                        Bitmap bmpResult = new Bitmap(img.Width, img.Height);
                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                            new float[]{0.33f, 0.33f, 0.33f, 0, 0},
                            new float[]{0.59f, 0.59f, 0.59f, 0, 0},
                            new float[]{0.11f, 0.11f, 0.11f, 0, 0},
                            new float[]{0, 0, 0, 1, 0},
                            new float[]{0, 0, 0, 0, 1}
                        });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpResult);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        imgFinal.Image = bmpResult;
                    }
                    break;

                case 1:
                    {
                        Image img = frame.Bitmap;
                        Bitmap bmpResult = new Bitmap(img.Width, img.Height);
                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                                new float[]{-1, 0, 0, 0, 0},
                                new float[]{0, -1, 0, 0, 0},
                                new float[]{0, 0, -1, 0, 0},
                                new float[]{0, 0, 0, 1, 0},
                                new float[]{1, 1, 1, 0, 1}
                        });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpResult);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        imgFinal.Image = bmpResult;
                    }
                    break;

                case 2:
                    {
                        Image img = frame.Bitmap;
                        Bitmap bmpResult = new Bitmap(img.Width, img.Height);
                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                                new float[]{0, 0, 1, 0, 0},
                                new float[]{0, 1, 0, 0, 0},
                                new float[]{1, 0, 0, 0, 0},
                                new float[]{0, 0, 0, 1, 0},
                                new float[]{0, 0, 0, 0, 1}
                        });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpResult);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        imgFinal.Image = bmpResult;
                    }
                    break;

                case 3:
                    {
                        Image img = frame.Bitmap;
                        Bitmap bmpResult = new Bitmap(img.Width, img.Height);
                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                                new float[]{0.393f, 0.349f, 0.272f, 0, 0},
                                new float[]{0.769f, 0.686f, 0.534f, 0, 0},
                                new float[]{0.189f, 0.168f, 0.131f, 0, 0},
                                new float[]{0, 0, 0, 1, 0},
                                new float[]{0, 0, 0, 0, 1}
                        });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpResult);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        imgFinal.Image = bmpResult;
                    }
                    break;

                case 4:
                    {
                        Image img = frame.Bitmap;
                        Bitmap bmpResult = new Bitmap(img.Width, img.Height);
                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                                new float[]{1.5f, 1.5f, 1.5f, 0, 0},
                                new float[]{1.5f, 1.5f, 1.5f, 0, 0},
                                new float[]{1.5f, 1.5f, 1.5f, 0, 0},
                                new float[]{0, 0, 0, 1, 0},
                                new float[]{-1, -1, -1, 0, 1}
                        });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpResult);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        imgFinal.Image = bmpResult;
                    }
                    break;

                case 5:
                    {
                        Image img = frame.Bitmap;
                        Bitmap bmpResult = new Bitmap(img.Width, img.Height);
                        ImageAttributes Ia = new ImageAttributes();
                        ColorMatrix cmPicture = new ColorMatrix(new float[][]
                        {
                                new float[]{1.438f, -0.062f, -0.062f, 0, 0},
                                new float[]{-0.122f, 1.378f, -0.122f, 0, 0},
                                new float[]{-0.016f, -0.016f, 1.483f, 0, 0},
                                new float[]{0, 0, 0, 1, 0},
                                new float[]{-0.06f, 0.05f, -0.04f, 0, 1}
                        });
                        Ia.SetColorMatrix(cmPicture);
                        Graphics gr = Graphics.FromImage(bmpResult);

                        gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
                        gr.Dispose();
                        imgFinal.Image = bmpResult;
                    }
                    break;

                default:
                    MessageBox.Show("Selecciona una opcion dispobnible");
                    break;
            }
        }

        public void reproducir(object sender, EventArgs e)
        {
            if (video != null && isPlay)
            {
                if (cantFrame < duracion - 2)
                {
                    Mat m = new Mat();
                    video.Read(m);

                    frame = new Image<Bgr, Byte>(m.Bitmap);
                    frame.Resize(imgOriginal.Width, imgOriginal.Height, Inter.Cubic);
                    cantFrame = video.GetCaptureProperty(CapProp.PosFrames);
                }
                else
                {
                    cantFrame = 0;
                    video.SetCaptureProperty(CapProp.PosFrames, 0);
                }
            }

            if (video != null)
            {
                aplicaFiltro();

                imgOriginal.Image = frame.Bitmap;
            }
        }
    }
}
