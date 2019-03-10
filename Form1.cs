using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System;
using iTextSharp;
using iTextSharp.text.pdf;



namespace signature
{
    public partial class Form1 : Form
    {

        Image myImage;
       // AnimatedGif myGif;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;

            // Open the PDF file to be signed
            pdfReader = new PdfReader(@"E:\test.pdf");

            // Output stream to write the stamped PDF to
            using (FileStream outStream = new FileStream(@"E:\test4.pdf", FileMode.Create))
            {
                try
                {
                    // Stamper to stamp the PDF with a signature
                    pdfStamper = new PdfStamper(pdfReader, outStream);

                    // Load signature image
                    iTextSharp.text.Image sigImg = iTextSharp.text.Image.GetInstance(@"E:\v.png");

                    // Scale image to fit
                    sigImg.ScaleToFit(283, 110);

                    // Set signature position on page
                    sigImg.SetAbsolutePosition(100, 300);

                    // Add signatures to desired page
                    PdfContentByte over = pdfStamper.GetOverContent(1);
                    over.AddImage(sigImg);
                }
                finally
                {
                    // Clean up
                    if (pdfStamper != null)
                        pdfStamper.Close();

                    if (pdfReader != null)
                        pdfReader.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // resizeImage(@"E:\", "v.png", 400, 500);
            try
            {
                Bitmap bmp = null;
                bmp = (Bitmap)Image.FromFile(@"E:\v.png");
                bmp = ChangeColor(bmp);
                bmp = RotateImageByAngle(bmp, 25);
                bmp = Resize(bmp, 800, 600, "aza");
                bmp.Save(@"E:\azad.png");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }            

            //Image image = new Bitmap(@"E:\v.png");
            //RotateImageByAngle(image, 70);
            //image.Save();
            //ImageAttributes imageAttributes = new ImageAttributes();
            //int width = image.Width;
            //int height = image.Height;
            //ColorMap colorMap = new ColorMap();

            //colorMap.OldColor = Color.FromArgb(255, 255, 0, 0);  // opaque red
            //colorMap.NewColor = Color.FromArgb(255, 0, 0, 255);  // opaque blue

            //ColorMap[] remapTable = { colorMap };

            //imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

            //e.Graphics.DrawImage(image, 10, 10, width, height);

            //e.Graphics.DrawImage(
            //   image,
            //   new Rectangle(150, 10, width, height),  // destination rectangle 
            //   0, 0,        // upper-left corner of source rectangle 
            //   width,       // width of source rectangle
            //   height,      // height of source rectangle
            //   GraphicsUnit.Pixel,
            //   imageAttributes);
            //Bitmap a = new System.Drawing.Bitmap(@"E:\b.png");
            //Graphics s = Graphics.FromImage(a);
            //s.DrawString("", new Font("tahoma",13,FontStyle.Strikeout), new SolidBrush(Color.Aqua), new PointF(3, 5));
            //a.Save(@"E:\c.png");
        }
        public static Bitmap ChangeColor(Bitmap scrBitmap)
        {
            //You can change your new color here. Red,Green,LawnGreen any..
            Color newColor = Color.Coral;
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actualColor = scrBitmap.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            return newBitmap;
        }
        private static Bitmap RotateImageByAngle(System.Drawing.Image oldBitmap, float angle)
        {
            var newBitmap = new Bitmap(oldBitmap.Width, oldBitmap.Height);
            var graphics = Graphics.FromImage(newBitmap);
            graphics.TranslateTransform((float)oldBitmap.Width / 2, (float)oldBitmap.Height / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-(float)oldBitmap.Width / 2, -(float)oldBitmap.Height / 2);
            graphics.DrawImage(oldBitmap, new Point(0, 0));
            return newBitmap;
        }
        private void resizeImage(string path, string originalFilename,
                         int width, int height)
        {
            Image image = Image.FromFile(path + originalFilename);

            System.Drawing.Image thumbnail = new Bitmap(width, height);
            System.Drawing.Graphics graphic =
                         System.Drawing.Graphics.FromImage(thumbnail);

            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;

            graphic.DrawImage(image, 0, 0, width, height);

            System.Drawing.Imaging.ImageCodecInfo[] info =
                             ImageCodecInfo.GetImageEncoders();
            EncoderParameters encoderParameters;
            encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality,
                             100L);
            thumbnail.Save(path + width + "." + originalFilename, info[1],
                             encoderParameters);
        }
        public Bitmap Resize(Bitmap image, int newWidth, int newHeight, string message)
        {
            try
            {
                Bitmap newImage = new Bitmap(newWidth, newHeight);

                using (Graphics gr = Graphics.FromImage(newImage))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.DrawImage(image, new Rectangle(0, 0, newImage.Width, newImage.Height));

                    var myBrush = new SolidBrush(Color.FromArgb(70, 205, 205, 205));

                    double diagonal = Math.Sqrt(newImage.Width * newImage.Width + newImage.Height * newImage.Height);

                    //Rectangle containerBox = new Rectangle();

                    //containerBox.X = (int)(diagonal / 10);
                    //float messageLength = (float)(diagonal / message.Length * 1);
                    //containerBox.Y = -(int)(messageLength / 1.6);

                    //Font stringFont = new Font("verdana", messageLength);

                    //StringFormat sf = new StringFormat();

                    //float slope = (float)(Math.Atan2(newImage.Height, newImage.Width) * 180 / Math.PI);

                    //gr.RotateTransform(slope);
                    //gr.DrawString(message, stringFont, myBrush, containerBox, sf);
                    return newImage;
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public int Calculations(decimal w1, decimal h1, int newWidth)
        {
            decimal height = 0;
            decimal ratio = 0;


            if (newWidth < w1)
            {
                ratio = w1 / newWidth;
                height = h1 / ratio;

                return Convert.ToInt32(height);
            }

            if (w1 < newWidth)
            {
                ratio = newWidth / w1;
                height = h1 * ratio;
                return Convert.ToInt32(height);
            }

            return Convert.ToInt32(height);
        }
        private static Bitmap resizeImage(Bitmap imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Bitmap)b;
        }
       

        private void StorePassword(string username, string password)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var salt = new string(
                Enumerable.Repeat(chars, 8)
                       .Select(s => s[random.Next(s.Length)])
                       .ToArray());

            string hash = GetHash(salt + password);
            string saltedHash = salt + ":" + hash;
            string[] credentials = new string[] { username, saltedHash };
            string pathpass = Environment.CurrentDirectory;
            pathpass = pathpass.Remove(pathpass.Length - 9);
            pathpass = pathpass + "pass.txt";
            System.IO.File.WriteAllLines(pathpass, credentials);

        }

        bool ValidatePassword(string username, string password)
        {
            //string fileName = "test.txt";
            //string path = Path.Combine(Environment.CurrentDirectory, @"data\", fileName);
           
            //path='@'+path;
            //label5.Text = path;
            string pathpass = Environment.CurrentDirectory;
            pathpass = pathpass.Remove(pathpass.Length - 9);
            pathpass = pathpass + "pass.txt";
            string[] content = System.IO.File.ReadAllLines(pathpass);
         
            if (username != content[0]) return false; //Wrong username

            string[] saltAndHash = content[1].Split(':'); //The salt will be stored att index 0 and the hash we are testing against will be stored at index 1.

            string hash = GetHash(saltAndHash[0] + password);

            if (hash == saltAndHash[1]) return true;
            else return false;

        }

        string GetHash(string input)
        {
            System.Security.Cryptography.SHA256Managed hasher = new System.Security.Cryptography.SHA256Managed();
            byte[] bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            return BitConverter.ToString(bytes).Replace("-", "");
        }
        private void btnlogin_Click(object sender, System.EventArgs e)
        {
            //string pwd = "ng_324";
            //string user = "admin";
           // StorePassword(user, pwd);
            bool result = ValidatePassword(txtusername.Text, txtpassword.Text);
            if (result == true)
            {
                pnllogin.Visible = false;
                pnlfile.Visible = true;
            }
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            openfile.ShowDialog();
        }

        private void button2_Click_1(object sender, System.EventArgs e)
        {
           // label5.Text= openFileDialog1.FileName;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
           //label5.Text=GetNumberOfPages(label5.Text).ToString();
        }

        static int GetNumberOfPages(String FilePath)
        {
            PdfReader pdfReader = new PdfReader(FilePath);
            return pdfReader.NumberOfPages;
        }

        private void btnopenfile_Click(object sender, System.EventArgs e)
        {
            openfile.ShowDialog();
        }

        private void btnconvert_Click(object sender, System.EventArgs e)
        {
            lblfilepath.Text = openfile.FileName;
            string filepath=lblfilepath.Text;
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;
            string test = Environment.CurrentDirectory;
            // Open the PDF file to be signed
            pdfReader = new PdfReader(lblfilepath.Text);
            string filenameDest = filepath.Remove(filepath.Length - 4);
            filenameDest = filenameDest + "A18.pdf";
            // Output stream to write the stamped PDF to
            using (FileStream outStream = new FileStream(filenameDest, FileMode.Create))
            {
                try
                {
                    // Stamper to stamp the PDF with a signature
                    pdfStamper = new PdfStamper(pdfReader, outStream);

                    // Load signature image
                    iTextSharp.text.Image sigImg = iTextSharp.text.Image.GetInstance(@"E:\v.png");

                    // Scale image to fit
                    sigImg.ScaleToFit(283, 110);

                    // Set signature position on page
                    sigImg.SetAbsolutePosition(100, 300);

                    // Add signatures to desired page
                    PdfContentByte over = pdfStamper.GetOverContent(1);
                    over.AddImage(sigImg);
                }
                finally
                {
                    // Clean up
                    if (pdfStamper != null)
                        pdfStamper.Close();

                    if (pdfReader != null)
                        pdfReader.Close();
                }
            }
        }

        private void button1_Click_2(object sender, System.EventArgs e)
        {
            string firstText = "Hello";
            string secondText = "World";

            PointF firstLocation = new PointF(10f, 10f);
            PointF secondLocation = new PointF(10f, 50f);

            string imageFilePath = @"E:\a.png";
            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file

            using(Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont =  new Font("Arial", 10))
                {
                    graphics.DrawString(firstText, arialFont, Brushes.Blue, firstLocation);
                    graphics.DrawString(secondText, arialFont, Brushes.Red, secondLocation);
                }
            }

            bitmap.Save(@"E:\a2.png");
        }




        //private Bitmap RotateImg(Bitmap bmp, float angle, Color bkColor)
        //{
        //    int w = bmp.Width;
        //    int h = bmp.Height;
        //    bmp.PixelFormat pf = default(bmp.PixelFormat);
        //    if (bkColor == Color.Transparent)
        //    {
        //        pf = bmp.Format32bppArgb;
        //    }
        //    else
        //    {
        //        pf = bmp.PixelFormat;
        //    }

        //    Bitmap tempImg = new Bitmap(w, h, pf);
        //    Graphics g = Graphics.FromImage(tempImg);
        //    g.Clear(bkColor);
        //    g.DrawImageUnscaled(bmp, 1, 1);
        //    g.Dispose();

        //    GraphicsPath path = new GraphicsPath();
        //    path.AddRectangle(new RectangleF(0f, 0f, w, h));
        //    Matrix mtrx = new Matrix();
        //    //Using System.Drawing.Drawing2D.Matrix class 
        //    mtrx.Rotate(angle);
        //    RectangleF rct = path.GetBounds(mtrx);
        //    Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
        //    g = Graphics.FromImage(newImg);
        //    g.Clear(bkColor);
        //    g.TranslateTransform(-rct.X, -rct.Y);
        //    g.RotateTransform(angle);
        //    g.InterpolationMode = InterpolationMode.HighQualityBilinear;
        //    g.DrawImageUnscaled(tempImg, 0, 0);
        //    g.Dispose();
        //    tempImg.Dispose();
        //    return newImg;
        //}
    }
}
