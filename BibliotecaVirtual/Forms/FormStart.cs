using System;
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
            var test = SearchsTerminals.GetIntance();
            _documentServices = new DocumentServices();
            InitializeComponent();
        }


        private void pictureBoxTesis_Click(object sender, EventArgs e)
        {
            FormSearchingResult fsr = new FormSearchingResult(this, metroTextBoxSearch.Text, 0, true);
            fsr.Show();
            this.Hide();
        }

        private void pictureBoxLibros_Click(object sender, EventArgs e)
        {
            FormSearchingResult fsr = new FormSearchingResult(this, metroTextBoxSearch.Text, 1, true);
            fsr.Show();
            this.Hide();
        }

        private void pictureBoxArticulos_Click(object sender, EventArgs e)
        {
            FormSearchingResult fsr = new FormSearchingResult(this, metroTextBoxSearch.Text, 2, true);
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
            if (isComponentSelected())
            {
                _showComponents(metroTextBoxSearch.Text);
            }
            else
            {
                FormSearchingResult fsr = new FormSearchingResult(this, metroTextBoxSearch.Text, 3, true);
                fsr.Show();
                this.Hide();
            }
        }

        private void _showComponents(string key)
        {
            if (this._radioComponent_1.Checked)
            {
                showDetailsView("Componente 1", SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.COMPONENTS1),"");
            }

            if (this._radioComponent_2.Checked)
            {
                showDetailsView("Componente 2", SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.COMPONENTS2), "");
            }
            if (this._radioComponent_3.Checked)
            {
                showDetailsView("Componente 3", SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.COMPONENTS3), "");
            }
            if (this._radioComponent_4.Checked)
            {
                showDetailsView("Componente 4", SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.COMPONENTS4), "");
            }
        }

        private bool isComponentSelected()
        {
            return this._radioComponent_1.Checked || _radioComponent_2.Checked || _radioComponent_3.Checked ||
                   _radioComponent_4.Checked;
        }

        private void metroTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\r"))
            {
                FormSearchingResult fsr = new FormSearchingResult(this, metroTextBoxSearch.Text, 3, true);
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
                new LinearGradientBrush(startPoint, endPoint, Color.White,
                    System.Drawing.ColorTranslator.FromHtml("#0c5e6e"));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, 183, 560);
        }

        private void _reportEndSideBar_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Informe Final Componentes.pdf");
        }


        private void _sumarySideBar_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Resumen Ejecutivo.pdf");
        }


        private void _exitStrategiesSideBar_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Estrategia de Salida.pdf");
        }


        private void _lectionsSideBar_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\Lecciones Aprendidas.pdf");
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
            showDetailsView("Posters", SearchsTerminals.GetIntance().SearchByKeyAndType("",TypeSearch.POSTERS), "");
        }

        private void showDetailsView(string name, List<Documents> documents, string folder)
        {
            DetailsView fs = new DetailsView(name, documents, folder);
            fs.ShowDialog();
        }

        private void _pilotsSolutionsSideBar_Click(object sender, EventArgs e)
        {
            showDetailsView("Implementación de soluciones pilotos", SearchsTerminals.GetIntance().SearchByKeyAndType("", TypeSearch.PILOTSSOLUTIONS), "");
        }

        private void _componentsSideBar_Click(object sender, EventArgs e)
        {
            showDetailsView("Componentes", SearchsTerminals.GetIntance().SearchByKeyAndType("", TypeSearch.ALLCOMPONENTS), "");
        }

        private void _gallerySideBar_Click(object sender, EventArgs e)
        {
            var gallery =new Gallery();
            gallery.ShowDialog();
        }
    }
}