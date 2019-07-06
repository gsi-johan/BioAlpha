using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BibliotecaVirtual.Commun
{
    public static class FontCustomizable
    {
        public static PrivateFontCollection AsnEncodedData()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            int fontLength = Properties.Resources.myriadRegular.Length;

            byte[] fontdata = Properties.Resources.myriadRegular;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontdata, 0, data, fontLength);

            pfc.AddMemoryFont(data, fontLength);

            return pfc;
        }

        public static Label SetFont( Label label, int size)
        {
            var pfc = FontCustomizable.AsnEncodedData();
            label.Font = new Font(pfc.Families[0], size);

            return label;
        }
        public static Label SetFont(Label label, int size,Color color)
        {
            var pfc = FontCustomizable.AsnEncodedData();
            label.Font = new Font(pfc.Families[0], size,FontStyle.Bold);
            label.ForeColor = color;

            return label;
        }
        public static Form SetFont(MetroForm form, int size)
        {
            var pfc = FontCustomizable.AsnEncodedData();
            form.Font = new Font(pfc.Families[0], size);

            return form;
        }
    }
}
