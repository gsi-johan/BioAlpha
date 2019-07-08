using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BibliotecaVirtual.Forms.Initiative
{
    public partial class Gallerys : MetroForm
    {
        public Gallerys()
        {
            InitializeComponent();
        }

        private void _pictureBFolder1_Click(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Gallery\\Taller Santa Clara 2018";
            loadImagesFromFolder(directory);
        }

        private void _labelFolder1_Click(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Gallery\\Taller Santa Clara 2018";
            loadImagesFromFolder(directory);
        }

        private void _pictureBFolder2_Click(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Gallery\\La Habana";
            loadImagesFromFolder(directory);
        }

        private void _labelFolder2_Click(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Gallery\\La Habana";
            loadImagesFromFolder(directory);
        }

        private void _pictureBFolder3_Click(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Gallery\\Camaguey Polígono AMEBA";
            loadImagesFromFolder(directory);
        }

        private void _labelFolder3_Click(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = currentDir + "\\Documentos\\Iniciativa_Biofin\\Gallery\\Camaguey Polígono AMEBA";
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
    }
}
