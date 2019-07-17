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
        private bool _isMenuOpen = false;
        private Color _activeColorBtn = Color.FromArgb(46, 139, 87);
        private Color _noActiveColorBtn = Color.FromArgb(29, 115, 153);
        private TypeSearch _typeSearch = TypeSearch.All;

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
            if (this._typeSearch ==TypeSearch.COMPONENTS1)
            {
                showDetailsView("Componente 1",
                    SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.COMPONENTS1), "");
            }

            if (this._typeSearch == TypeSearch.COMPONENTS2)
            {
                showDetailsView("Componente 2",
                    SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.COMPONENTS2), "");
            }
            if (this._typeSearch == TypeSearch.COMPONENTS3)
            {
                showDetailsView("Componente 3",
                    SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.COMPONENTS3), "");
            }
            if (this._typeSearch == TypeSearch.COMPONENTS4)
            {
                showDetailsView("Componente 4",
                    SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.COMPONENTS4), "");
            }
            if (this._typeSearch == TypeSearch.ALLCOMPONENTS)
            {
                showDetailsView("Componentes",
                    SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.ALLCOMPONENTS), "");
            }
            if (this._typeSearch == TypeSearch.All)
            {
                showDetailsView("Resultados de la búsqueda",
                    SearchsTerminals.GetIntance().SearchByKeyAndType(key, TypeSearch.All), "");
            }
        }

        private bool isComponentSelected()
        {
            return _typeSearch != TypeSearch.APP;
            //return this._radioComponent_1.Checked || _radioComponent_2.Checked || _radioComponent_3.Checked ||
            //       _radioComponent_4.Checked || _radioComponents.Checked || _radioAll.Checked;
        }

        private void metroTextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\r"))
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
            showDetailsView("Posters", SearchsTerminals.GetIntance().SearchByKeyAndType("", TypeSearch.POSTERS), "");
        }

        private void showDetailsView(string name, List<Documents> documents, string folder)
        {
            DetailsView fs = new DetailsView(name, documents, folder);
            fs.ShowDialog();
        }

        private void _pilotsSolutionsSideBar_Click(object sender, EventArgs e)
        {
            var sites = new Sites();
            sites.ShowDialog();
        }

        private void _componentsSideBar_Click(object sender, EventArgs e)
        {
            showDetailsView("Componentes",
                SearchsTerminals.GetIntance().SearchByKeyAndType("", TypeSearch.ALLCOMPONENTS), "");
        }

        private void _gallerySideBar_Click(object sender, EventArgs e)
        {
            var gallerys = new Gallerys();
            gallerys.ShowDialog();
        }

        private void _virtualBiblioSideBar_Click(object sender, EventArgs e)
        {
            FormSearchingResult fsr = new FormSearchingResult(this, metroTextBoxSearch.Text, 3, true);
            fsr.Show();
            this.Hide();
        }

        private void componente2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDetailsView("Componente 2",
                SearchsTerminals.GetIntance().SearchByKeyAndType("", TypeSearch.COMPONENTS2), "");
        }

        private void componente1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDetailsView("Componente 1",
                SearchsTerminals.GetIntance().SearchByKeyAndType("", TypeSearch.COMPONENTS1), "");
        }

        private void componente3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDetailsView("Componente 3",
                SearchsTerminals.GetIntance().SearchByKeyAndType("", TypeSearch.COMPONENTS3), "");
        }

        private void componente4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDetailsView("Componente 4",
                SearchsTerminals.GetIntance().SearchByKeyAndType("", TypeSearch.COMPONENTS4), "");
        }

        private void _componentsSideBar_MouseLeave(object sender, EventArgs e)
        {
            ctxMenuComponentes.Hide();
        }

        private void _linkTesting_MouseHover(object sender, EventArgs e)
        {
            ctxMenuComponentes.Show(_componentsSideBar, 197, 0);
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= 0 && e.Location.X <= 197 && e.Location.Y >= 202 && e.Location.Y <= 232)
            {
                ctxMenuComponentes.Show(_componentsSideBar, 197, 0);
            }
        }

        private void ctxMenuComponentes_MouseHover(object sender, EventArgs e)
        {
            _isMenuOpen = true;
        }

        private void ctxMenuComponentes_MouseLeave(object sender, EventArgs e)
        {
            _isMenuOpen = false;
            ctxMenuComponentes.Hide();
        }

        private void FormStart_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= 0 && e.Location.X <= 197 && e.Location.Y >= 202 && e.Location.Y <= 232)
            {
                ctxMenuComponentes.Show(_componentsSideBar, 197, 0);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CheckAndOpenUrlPdf("\\Documentos\\Iniciativa_Biofin\\GOC-2019-O3 RC 6-2018 MINCEX-MFP Reglamento sobre Normas de Origen.pdf");
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            var about= new About_1();
            about.ShowDialog(this);
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

            var names = new List<string>();

                for (int i = 0; i < 30; i++)
            {
                names.Add( "Names " + i);
            }

            var about = new About_2(names);
            about.ShowDialog(this);
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            _typeSearch = TypeSearch.All;
            this.allBtn.Normalcolor = this._activeColorBtn;
            this.allBtn.OnHovercolor = this._activeColorBtn;

            this.componentsBtn.Normalcolor = this._noActiveColorBtn;
            this.componentsBtn.OnHovercolor = this._noActiveColorBtn;

            this.appBtn.Normalcolor = this._noActiveColorBtn;
            this.appBtn.OnHovercolor = this._noActiveColorBtn;

            this.componentABtn.Normalcolor = this._noActiveColorBtn;
            this.componentABtn.OnHovercolor = this._noActiveColorBtn;
            this.componentBBtn.Normalcolor = this._noActiveColorBtn;
            this.componentBBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentCBtn.Normalcolor = this._noActiveColorBtn;
            this.componentCBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentDBtn.Normalcolor = this._noActiveColorBtn;
            this.componentDBtn.OnHovercolor = this._noActiveColorBtn;
            
            
        }

        private void componentsBtn_Click(object sender, EventArgs e)
        {
            _typeSearch = TypeSearch.ALLCOMPONENTS;
            this.allBtn.Normalcolor = this._noActiveColorBtn;
            this.allBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentsBtn.Normalcolor = this._activeColorBtn;
            this.componentsBtn.OnHovercolor = this._activeColorBtn;

            this.appBtn.Normalcolor = this._noActiveColorBtn;
            this.appBtn.OnHovercolor = this._noActiveColorBtn;

            this.componentABtn.Normalcolor = this._noActiveColorBtn;
            this.componentABtn.OnHovercolor = this._noActiveColorBtn;
            this.componentBBtn.Normalcolor = this._noActiveColorBtn;
            this.componentBBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentCBtn.Normalcolor = this._noActiveColorBtn;
            this.componentCBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentDBtn.Normalcolor = this._noActiveColorBtn;
            this.componentDBtn.OnHovercolor = this._noActiveColorBtn;
        }

        private void appBtn_Click(object sender, EventArgs e)
        {
            _typeSearch = TypeSearch.APP;
            this.allBtn.Normalcolor = this._noActiveColorBtn;
            this.allBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentsBtn.Normalcolor = this._noActiveColorBtn;
            this.componentsBtn.OnHovercolor = this._noActiveColorBtn;

            this.appBtn.Normalcolor = this._activeColorBtn;
            this.appBtn.OnHovercolor = this._activeColorBtn;

            this.componentABtn.Normalcolor = this._noActiveColorBtn;
            this.componentABtn.OnHovercolor = this._noActiveColorBtn;
            this.componentBBtn.Normalcolor = this._noActiveColorBtn;
            this.componentBBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentCBtn.Normalcolor = this._noActiveColorBtn;
            this.componentCBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentDBtn.Normalcolor = this._noActiveColorBtn;
            this.componentDBtn.OnHovercolor = this._noActiveColorBtn;
        }

        private void componentABtn_Click(object sender, EventArgs e)
        {
            _typeSearch = TypeSearch.COMPONENTS1;
            this.allBtn.Normalcolor = this._noActiveColorBtn;
            this.allBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentsBtn.Normalcolor = this._noActiveColorBtn;
            this.componentsBtn.OnHovercolor = this._noActiveColorBtn;

            this.appBtn.Normalcolor = this._noActiveColorBtn;
            this.appBtn.OnHovercolor = this._noActiveColorBtn;

            this.componentABtn.Normalcolor = this._activeColorBtn;
            this.componentABtn.OnHovercolor = this._activeColorBtn;
            this.componentBBtn.Normalcolor = this._noActiveColorBtn;
            this.componentBBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentCBtn.Normalcolor = this._noActiveColorBtn;
            this.componentCBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentDBtn.Normalcolor = this._noActiveColorBtn;
            this.componentDBtn.OnHovercolor = this._noActiveColorBtn;
        }

        private void componentBBtn_Click(object sender, EventArgs e)
        {
            _typeSearch = TypeSearch.COMPONENTS2;
            this.allBtn.Normalcolor = this._noActiveColorBtn;
            this.allBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentsBtn.Normalcolor = this._noActiveColorBtn;
            this.componentsBtn.OnHovercolor = this._noActiveColorBtn;

            this.appBtn.Normalcolor = this._noActiveColorBtn;
            this.appBtn.OnHovercolor = this._noActiveColorBtn;

            this.componentABtn.Normalcolor = this._noActiveColorBtn;
            this.componentABtn.OnHovercolor = this._noActiveColorBtn;
            this.componentBBtn.Normalcolor = this._activeColorBtn;
            this.componentBBtn.OnHovercolor = this._activeColorBtn;
            this.componentCBtn.Normalcolor = this._noActiveColorBtn;
            this.componentCBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentDBtn.Normalcolor = this._noActiveColorBtn;
            this.componentDBtn.OnHovercolor = this._noActiveColorBtn;
        }

        private void componentCBtn_Click(object sender, EventArgs e)
        {
            _typeSearch = TypeSearch.COMPONENTS3;
            this.allBtn.Normalcolor = this._noActiveColorBtn;
            this.componentsBtn.Normalcolor = this._noActiveColorBtn;

            this.appBtn.Normalcolor = this._noActiveColorBtn;
            this.appBtn.OnHovercolor = this._noActiveColorBtn;

            this.componentABtn.Normalcolor = _noActiveColorBtn;
            this.componentBBtn.Normalcolor = this._noActiveColorBtn;
            this.componentCBtn.Normalcolor = this._activeColorBtn;
            this.componentCBtn.OnHovercolor = this._activeColorBtn;
            this.componentDBtn.Normalcolor = this._noActiveColorBtn;
            this.componentDBtn.OnHovercolor = this._noActiveColorBtn;
        }

        private void componentDBtn_Click(object sender, EventArgs e)
        {
            _typeSearch = TypeSearch.COMPONENTS4;
            this.allBtn.Normalcolor = this._noActiveColorBtn;
            this.allBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentsBtn.Normalcolor = this._noActiveColorBtn;
            this.componentsBtn.OnHovercolor = this._noActiveColorBtn;

            this.appBtn.Normalcolor = this._noActiveColorBtn;
            this.appBtn.OnHovercolor = this._noActiveColorBtn;

            this.componentABtn.Normalcolor = this._noActiveColorBtn;
            this.componentABtn.OnHovercolor = this._noActiveColorBtn;
            this.componentBBtn.Normalcolor = this._noActiveColorBtn;
            this.componentBBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentCBtn.Normalcolor = this._noActiveColorBtn;
            this.componentCBtn.OnHovercolor = this._noActiveColorBtn;
            this.componentDBtn.Normalcolor = this._activeColorBtn;
            this.componentDBtn.OnHovercolor = this._activeColorBtn;
        }
    }
}