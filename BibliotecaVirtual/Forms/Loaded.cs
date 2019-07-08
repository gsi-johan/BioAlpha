using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Biblio.Business.Service;
using BibliotecaVirtual.Commun;
using MetroFramework.Forms;

namespace BibliotecaVirtual.Forms
{
    public partial class Loaded : MetroForm
    {
        private DocumentServices _documentServices;
        private bool start = false;

        public Loaded()
        {
            InitializeComponent();
//            FontCustomizable.SetFont(label1, 20);
            Color logoBioFin = Color.FromArgb(255, 86, 133, 196);
            IniciativaLabel.ForeColor = logoBioFin;
            //FontCustomizable.SetFont(IniciativaLabel, 11,logoBioFin);
            //IniciativaLabel.Font.Bold = true;
        }

        private void Loaded_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
