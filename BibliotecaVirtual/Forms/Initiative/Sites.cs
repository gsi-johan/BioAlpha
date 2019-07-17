using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BibliotecaVirtual.Properties;
using MetroFramework;
using MetroFramework.Forms;

namespace BibliotecaVirtual.Forms.Initiative
{
    public partial class Sites : MetroForm
    {
        public Sites()
        {
            InitializeComponent();
        }

        private void _pictureBFolder1_Click_1(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\APRM P C.ZAPATA\\Mensajes comunicativos\\";
            loadImagesFromFolder(directory);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\PN P.GUANAHACABIBES\\Mensajes comunicativos\\";
            loadImagesFromFolder(directory);
        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\PN P.GUANAHACABIBES\\Mensajes comunicativos\\";
            loadImagesFromFolder(directory);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\PN P.GUANAHACABIBES\\Justificacion.pdf");
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\PN P.GUANAHACABIBES\\Justificacion.pdf");
        }

        private void _labelFolder1_Click(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\APRM P C.ZAPATA\\Mensajes comunicativos\\";
            loadImagesFromFolder(directory);
        }
        private static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }
        private static void loadImagesFromFolder(string imagePath)
        {
            if (Directory.Exists(imagePath))
            {
                var filters = new String[] { "jpg", "jpeg", "png" };
                var files = GetFilesFrom(imagePath, filters, false);

                var gallery = new Gallery(files);
                gallery.ShowDialog();
            }
        }

        private void pictureBoxJFF1_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\APRM P C.ZAPATA\\Justificacion.pdf");
        }

        private void labelJFF1_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\APRM P C.ZAPATA\\Justificacion.pdf");
        }
        private void CheckAndOpenUrlPdf(string urlPdf)
        {
            try
            {
                string currentDir = Environment.CurrentDirectory;
                string directory = currentDir + urlPdf;

                if (File.Exists(directory))
                {
                    System.Diagnostics.Process.Start(directory);
                }
                else
                {
                    MetroMessageBox.Show(this, Resources.LostFileError, Resources.Information,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning, 120);
                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, Resources.LostFileError, Resources.Information,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, 120);
            }
        }

        private void linkTarifas_Click(object sender, EventArgs e)
        {

        }
    }
}
