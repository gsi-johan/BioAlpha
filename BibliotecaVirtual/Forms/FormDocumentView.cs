using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblio.Business.Service;
using Biblio.Business.Service.Helpers;
using BibliotecaVirtual.Properties;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace BibliotecaVirtual
{
    public partial class FormDocumentView : MetroForm
    {
        private List<string> _datos;
        private string _tipoDocumento;
        private long _idDocument;
        private DocumentServices _documentServices;
        private TesisServices _tesisServices;
        private BookServices _bookServices;
        private ArticleServices _articleServices;

        public FormDocumentView(List<string> datos,long idDocument, string tipoDocumento)
        {
            _idDocument = idDocument;
            _datos = datos;
            _tipoDocumento = tipoDocumento;
            _documentServices = new DocumentServices();
            _tesisServices = new TesisServices();
            _bookServices = new BookServices();
            _articleServices = new ArticleServices();
            InitializeComponent();

            CreateForm();
        }
        private void InitializeListViews()
        {
            metroListViewAutores.View = View.Details;
            metroListViewAutores.Columns.Add("Autores", 230);
            metroListViewAutores.HeaderStyle = ColumnHeaderStyle.None;
        }

        void CreateForm()
        {
            InitializeListViews();
            string titulo=_datos[0];
            string year = _datos[1];

            foreach (var val in _datos[2].Split(';').ToList())
            {
                metroListViewAutores.Items.Add(val);
            }

            KeyWordrichTextBox.Text = _datos[3];

            if (_tipoDocumento == "Tesis")
            {
                string categoria =_tesisServices.CategoryByIdDocument(_idDocument);
                string descripcion =_tesisServices.DescripctionByIdDocument(_idDocument);
                metroLabelCategory.Text = categoria;
                richTextBoxDescription.Text = descripcion;

                //deshabilito los labels relacionados con el campo Literatura
                metroLabel3.Enabled = false;
                metroLabelLiterature.Enabled = false;
                metroLabel3.ForeColor = Color.Silver;
                metroLabelLiterature.ForeColor = Color.Silver;

                //deshabilito los labels relacionados con el campo Localizacion
                LocationMetroLabel.Enabled = false;
                LocationValueMetroLabel.Enabled = false;
                LocationMetroLabel.ForeColor = Color.Silver;
                LocationValueMetroLabel.ForeColor = Color.Silver;

            }
            else if (_tipoDocumento == "Libro")
            {
                string literatura = _bookServices.LiteraturaByIdDocument(_idDocument);
                metroLabelLiterature.Text = literatura;

                //deshabilito los labels relacionados con el campo categoria
                metroLabel2.Enabled = false;
                metroLabelCategory.Enabled = false;
                metroLabel2.ForeColor = Color.Silver;
                metroLabelCategory.ForeColor = Color.Silver;

                //deshabilito los labels relacionados con el campo Descripcion
                metroLabel5.Enabled = false;
                richTextBoxDescription.Enabled = false;
                richTextBoxDescription.BackColor = Color.Silver;
                metroLabel5.ForeColor = Color.Silver;

                //deshabilito los labels relacionados con el campo Localizacion
                LocationMetroLabel.Enabled = false;
                LocationValueMetroLabel.Enabled = false;
                LocationMetroLabel.ForeColor = Color.Silver;
                LocationValueMetroLabel.ForeColor = Color.Silver;
            }
            else
            {
                string literatura = _articleServices.LiteraturaByIdDocument(_idDocument);
                metroLabelLiterature.Text = literatura;

                LocationValueMetroLabel.Text=_articleServices.LocalitationByIdDocument(_idDocument);

                //deshabilito los labels relacionados con el campo categoria
                metroLabel2.Enabled = false;
                metroLabelCategory.Enabled = false;
                metroLabel2.ForeColor = Color.Silver;
                metroLabelCategory.ForeColor = Color.Silver;

                //deshabilito los labels relacionados con el campo Descripcion
                metroLabel5.Enabled = false;
                richTextBoxDescription.Enabled = false;
                richTextBoxDescription.BackColor = Color.Silver;
                metroLabel5.ForeColor = Color.Silver;
            }

            TittleMetroLabel.Text = titulo;
            metroLabelYear.Text = year;
        }

        private void pictureBoxDownload_Click(object sender, EventArgs e)
        {
            string urlPdf = _documentServices.URLById(_idDocument);

            CheckAndOpenUrlPdf(urlPdf);
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
    }
}
