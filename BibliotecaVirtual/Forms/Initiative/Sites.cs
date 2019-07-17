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
using TestGallery;

namespace BibliotecaVirtual.Forms.Initiative
{
    public partial class Sites : MetroForm
    {
        public Sites()
        {
            InitializeComponent();
            OpenGallery();
        }

        private void OpenGallery()
        {
            string currentDir = Environment.CurrentDirectory;
            string directory = "";
            if (TabSites.SelectedIndex == 0)
            {
                directory = currentDir +
                            "\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\APRM P C.ZAPATA\\Mensajes comunicativos\\";
                LoadImagesFromFolder(directory);
                SetGalleryReady(accordionCienaga);
            }

              
            else
            {
                directory = currentDir +
                            "\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\PN P.GUANAHACABIBES\\Mensajes comunicativos\\";
                LoadImagesFromFolder(directory);
                SetGalleryReady(accordionGC);
            }
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

        private void LoadImagesFromFolder(string imagePath)
        {
            if (Directory.Exists(imagePath))
            {
                var filters = new String[] {"jpg", "jpeg", "png"};
                var files = GetFilesFrom(imagePath, filters, false);

                InsertPicturesFromGallery(files);
            }
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

        private void TabSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenGallery();
        }

        #region Gallery

        private void SetGalleryReady(ImageAccordion imageAccordion)
        {
            imageAccordion.SelectThumnail(0);
            imageAccordion.HoverColor = Color.FromArgb(26, 98, 137);
            imageAccordion.SelectedColor = Color.FromArgb(20, 71, 118);
            imageAccordion.BackColor = Color.WhiteSmoke;
        }

        private void InsertPicturesFromGallery(string[] files)
        {
            ImageAccordion imageAccordion = TabSites.SelectedIndex == 0 ? accordionCienaga : accordionGC;
            foreach (var file in files)
            {
                var nameIndex = file.LastIndexOf('\\') + 1;
                string fileName = file.Substring(nameIndex, file.Length - nameIndex);
                imageAccordion.Add(new Thumbnail(fileName, Image.FromFile(file)));
            }
        }


        #endregion

        private void accordionCienaga_ThumbnailChanged(int OldIndex, int NewIndex, Thumbnail thumbnail)
        {
            galleryCienaga.BackgroundImage = thumbnail.Image;
        }

        private void accordionGC_ThumbnailChanged(int OldIndex, int NewIndex, Thumbnail thumbnail)
        {
            galleryGC.BackgroundImage = thumbnail.Image;
        }

        private void Sites_Load(object sender, EventArgs e)
        {
            if (TabSites.SelectedIndex == 0)
                SetGalleryReady(accordionCienaga);
            else
            {
                SetGalleryReady(accordionGC);
            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            if (TabSites.SelectedIndex == 0)
                CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\APRM P C.ZAPATA\\Justificacion.pdf");
            else
            {
                CheckAndOpenUrlPdf(
                    "\\Documentos\\Iniciativa_Biofin\\Pilots_Sites\\PN P.GUANAHACABIBES\\Justificacion.pdf");
            }
        }
    }
}