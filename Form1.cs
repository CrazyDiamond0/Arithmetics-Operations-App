using Emgu.CV;
using Emgu.CV.Structure;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using Emgu.CV.CvEnum;

namespace AlgorithmOperations
{
    public partial class Form1 : Form
    {
        
        List<string> filenamesOriginal = new List<string>();
        List<string> filenamesFBGS = new List<string>();
        Image<Gray, byte> image1;
        Image<Gray, byte> image2;
        Image<Gray, byte> image3;
        Mat matricea1;
        Mat matricea2;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filenamesOriginal.Clear();//curata lista cadre orinale
            filenamesFBGS.Clear();//curata lista cadre substracted

            /*Verifica daca exista gif-urile si daca da,se vor sterge*/
            if (File.Exists("OriginalAnimation.gif")) {
            
                File.Delete("OriginalAnimation.gif"); 
            }
            if (File.Exists("SubedBackground.gif"))
            {
                File.Delete("SubedBackground.gif");
            }
            /*----------------*/

            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)//pop-ul pt selectarea fisierelor
            {

                addFilesToList();//adaugare in lista originala

                substractie();//scadere background

                mediere();//medierea cadrelor

                afisare();//afisarea imaginilor
                
            }
        }


        public void addFilesToList()
        {
            foreach (string filename in openFileDialog1.FileNames)//ia locatia fisierelor
            {
                filenamesOriginal.Add(filename);//adaugare cadre in lista originala
            }
        }


        public void substractie() {
            for (int i = 0; i < filenamesOriginal.Count - 1; i++)
            {

                image1 = new Image<Gray, byte>(filenamesOriginal[i]); //intializare prima imagine
                image2 = new Image<Gray, byte>(filenamesOriginal[i + 1]);//initializare a doua imagine
                image3 = image1 - image2; //scaderea dintre 2 imagini
                CvInvoke.Threshold(image3, image3, (int)thresholdtext.Value, 255, 0);//threshold-ul imaginii

                image3.ToBitmap().Save("FramesBGSub\\Gif" + i + ".jpeg", ImageFormat.Jpeg);//Salvarea imaginii

                filenamesFBGS.Add("FramesBGSub\\Gif" + i + ".jpeg");//adaugare cadru in lista de substractie


            }

          

        }

        public void mediere()
        {
            matricea1 = (new Image<Gray, byte>(filenamesOriginal[0])).Mat;
            matricea1.ConvertTo(matricea1, DepthType.Cv32F); // conversie in CV_32F
            for (int i = 1; i < filenamesOriginal.Count - 1; i++)
            {
                image2 = new Image<Gray, byte>(filenamesOriginal[i]);
                matricea2 = matricea2 = image2.Mat;

                matricea2.ConvertTo(matricea2, DepthType.Cv32F);

                matricea1 = (1 - (double)alphatext.Value) * matricea1 + ((double)alphatext.Value) * matricea2;//formula de mediere
            }

        }

        public void afisare()

        {
            create_gif("OriginalAnimation.gif", filenamesOriginal);
            create_gif("SubedBackground.gif", filenamesFBGS);//creare GIF pentru substractie

            /*Afisare in UI*/
            imageMediere.Image = matricea1.ToImage<Gray, byte>();

            imageMediere.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureOriginal.ImageLocation = "OriginalAnimation.gif";

            pictureOriginal.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBGSub.ImageLocation = "SubedBackground.gif";

            pictureBGSub.SizeMode = PictureBoxSizeMode.StretchImage;
            /*---------------------*/
        }




        /*functie de creare gif*/
        private void create_gif(string name, List<string> filenames)
        {
            using (MagickImageCollection collection = new MagickImageCollection())
            {
                for (int i = 0; i < filenames.Count; i++)
                {
                    collection.Add(filenames[i]);
                    collection[i].AnimationDelay = (int)Gifspeedtext.Value;
                }

                collection.Write(name);

            }
        }
        /*---------------------------*/

        /*  hn=hist(D) // hist(.) returns the histogram of the data set
            csum= 0 // csum is the cumulative function of the histogram
            for i=0 to 255
                if hn[i] > 0
                    csum+=hn[i]
                        if csum ≥ OMid then
                            lb = csum − hn[i]+1, ub = csum
                            break
                        endif
                end if
            end for
            return i,lb,ub

        OMid = (N − 1)/2 (N must be odd)
        */

        public void mediana(Image<Gray, byte> D) {
            Mat cumulativeimage = new Mat();
            Mat hn = D.Mat;  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelBS_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
