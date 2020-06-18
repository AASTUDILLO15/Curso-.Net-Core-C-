using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class UploadImage
    {
        private OpenFileDialog FileDialog = new OpenFileDialog();
        public void Upload(PictureBox pictureBoxStudents)
        {
            pictureBoxStudents.WaitOnLoad=true;//se establece en true para que la imagen se cargue de forma sincrona
            FileDialog.Filter = "Imagenes|*.jpg;*.jpeg;*.gif;*.png;*.bmp;";
            FileDialog.ShowDialog();
            if (FileDialog.FileName != string.Empty)
            {
                pictureBoxStudents.ImageLocation = FileDialog.FileName;
            }
        }

        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public Image byteArrayToImage(byte[] image)
        {
            return Image.FromStream(new MemoryStream(image));
        }
    }
}
