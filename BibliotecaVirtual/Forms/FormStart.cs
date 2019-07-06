﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Biblio.Business.Service;
using BibliotecaVirtual.Commun;
using BibliotecaVirtual.Commun.SearchsTerminals;
using BibliotecaVirtual.Forms;
using BibliotecaVirtual.Forms.Initiative;
using BibliotecaVirtual.Properties;
using MetroFramework;
using MetroFramework.Forms;

namespace BibliotecaVirtual
{
    public partial class FormStart : MetroForm
    {
        private DocumentServices _documentServices;

        public FormStart()
        {
            var test= SearchsTerminals.GetIntance();
            _documentServices =new DocumentServices();
            InitializeComponent();

        }



        private void pictureBoxTesis_Click(object sender, EventArgs e)
        {
            FormSearchingResult fsr = new FormSearchingResult(this,metroTextBoxSearch.Text, 0, true);
            fsr.Show();
            this.Hide();
        }

        private void pictureBoxLibros_Click(object sender, EventArgs e)
        {
            FormSearchingResult fsr = new FormSearchingResult(this,metroTextBoxSearch.Text, 1, true);
            fsr.Show();
            this.Hide();
        }

        private void pictureBoxArticulos_Click(object sender, EventArgs e)
        {
            FormSearchingResult fsr = new FormSearchingResult(this,metroTextBoxSearch.Text, 2, true);
            fsr.Show();
            this.Hide();
        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            pictureBoxSearch.Height = 19;
            pictureBoxSearch.Width = 19;
        }

        private void pictureBoxSearch_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSearch.Height = 18;
            pictureBoxSearch.Width = 18;
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            FormSearchingResult fsr = new FormSearchingResult(this,metroTextBoxSearch.Text, 3, true);
            fsr.Show();
            this.Hide();
        }

        private void metroTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\r"))
            {
                FormSearchingResult fsr = new FormSearchingResult(this,metroTextBoxSearch.Text, 3, true);
                fsr.Show();
                this.Hide();
            }
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
           
            if (!Global.isStartFirst)
            {
                var loaded = new Loaded();
                var threadStart = new ThreadStart(() => { DoWork(this, loaded); });
                StartProcessInBackground(threadStart, loaded); 
            }
            ActiveControl = metroTextBoxSearch;
        }

        private void DoWork(FormStart formStart, Loaded loaded)
        {

            _documentServices.GetDocuments();
            Global.isStartFirst = true;
            if (loaded.InvokeRequired)
                loaded.BeginInvoke(new Action(loaded.Close));

        }

        private static void StartProcessInBackground(ThreadStart processBackground, Loaded barModal)
        {
            Thread backgroundThread = new Thread(processBackground);
            backgroundThread.Start();
            barModal.ShowDialog();
        }

        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForms();
        }

        private static void CloseForms()
        {
            List<Form> lista = (from object openForm in Application.OpenForms select openForm as Form).ToList();
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(183, 560);

            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint, endPoint, Color.White, System.Drawing.ColorTranslator.FromHtml("#0c5e6e"));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, 183, 560);

        }

        private void _reportEndSideBar_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\informe_final.pdf");
        }

       

        private void _sumarySideBar_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\resumen_ejecutivo.pdf");
        }


        private void _exitStrategiesSideBar_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\estrategias_de_salidas.pdf");

        }


        private void _lectionsSideBar_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\estrategias_de_salidas.pdf");
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

        private void _postersSideBar_Click(object sender, EventArgs e)
        {
            DetailsView fs = new DetailsView();
            fs.Show();
        }
    }
}
