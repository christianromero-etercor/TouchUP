using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace TouchUP
{
    internal class clsImagen
    {
        public clsImagen(byte[] bytes)
        {
        }

        // Convierte una imagen a un arreglo de bytes
        public static MemoryStream BytetoImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream((byte[])array);
            return ms;
        }

        // Convierte un arreglo de bytes a una imagen
        public static byte[] ImagetoByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}

// Compare this snippet from Visores/admin/AgregarArticulo.cs: