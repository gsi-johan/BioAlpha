using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using TestGallery;

namespace BibliotecaVirtual.Forms.Initiative
{
    public partial class Gallery : MetroForm
    {
        public Gallery()
        {
            InitializeComponent();
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            //todo read all pictures in the file and add to imageAccordion1 control

            InsertPicturesFromGallery();

            this.imageAccordion1.Add(new Thumbnail("water", Image.FromFile("Documentos\\Iniciativa_Biofin\\Gallery\\img1.jpg")));
            this.imageAccordion1.Add(new Thumbnail("boat", Image.FromFile("Documentos\\Iniciativa_Biofin\\Gallery\\img2.jpg")));
            this.imageAccordion1.Add(new Thumbnail("flower", Image.FromFile("Documentos\\Iniciativa_Biofin\\Gallery\\img3.jpg")));
            this.imageAccordion1.Add(new Thumbnail("House", Image.FromFile("Documentos\\Iniciativa_Biofin\\Gallery\\img4.jpg")));
            this.imageAccordion1.Add(new Thumbnail("Sea", Image.FromFile("Documentos\\Iniciativa_Biofin\\Gallery\\img5.jpg")));
            this.imageAccordion1.Add(new Thumbnail("mountain", Image.FromFile("Documentos\\Iniciativa_Biofin\\Gallery\\img6.jpg")));
            this.imageAccordion1.Add(new Thumbnail("ligtes", Image.FromFile("Documentos\\Iniciativa_Biofin\\Gallery\\img7.jpg")));
            this.imageAccordion1.Add(new Thumbnail("night View", Image.FromFile("Documentos\\Iniciativa_Biofin\\Gallery\\img8.jpg")));
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

        private void InsertPicturesFromGallery()
        {
            return;
        }
    }
}
