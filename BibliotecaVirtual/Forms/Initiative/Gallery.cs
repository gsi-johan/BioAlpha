using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using TestGallery;

namespace BibliotecaVirtual.Forms.Initiative
{
    public partial class Gallery : MetroForm
    {
        public Gallery(string[] files)
        {
            InitializeComponent();
            InsertPicturesFromGallery(files);
        }
        public Gallery()
        {
            InitializeComponent();
        }
        private void Gallery_Load(object sender, EventArgs e)
        {
            this.imageAccordion1.SelectThumnail(0);
            imageAccordion1.HoverColor = Color.FromArgb(26,98,137);
            imageAccordion1.SelectedColor = Color.FromArgb(20,71,118);
            imageAccordion1.BackColor = Color.WhiteSmoke;
        }

        private void imageAccordion2_ThumbnailChanged(int OldIndex, int NewIndex, Thumbnail thumbnail)
        {
            pictureBox1.BackgroundImage = thumbnail.Image;
//            label1.Text = thumbnail.Text;
//            label1.Left = (panel1.Width - label1.Width) / 2;
        }

        private void InsertPicturesFromGallery(string [] files)
        {
            foreach (var file in files)
            {
                var nameIndex = file.LastIndexOf('\\') + 1;
                string fileName = file.Substring(nameIndex, file.Length - nameIndex);
                this.imageAccordion1.Add(new Thumbnail(fileName, Image.FromFile(file)));
            }
        }
    }
}
