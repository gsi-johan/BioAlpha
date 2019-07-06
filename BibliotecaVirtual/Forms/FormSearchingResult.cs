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
using Biblio.Business.Mapper;
using Biblio.Business.Service;
using Biblio.Business.Service.Helpers;
using BibliotecaVirtual.Commun.SearchsTerminals;
using BibliotecaVirtual.Forms;
using BibliotecaVirtual.Properties;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace BibliotecaVirtual
{
    public partial class FormSearchingResult : MetroForm
    {

        private DocumentServices _documentServices;

        private TesisServices _tesisServices;

        private BookServices _bookServices;

        private ArticleServices _articleServices;

        private Form _form ;

        private string _textSearcher;

        private int _selectedTab;

        private bool _isForm;

        public bool isLoged { get; set; }


        public FormSearchingResult()
        {

            InitializeComponent();
            if (isLoged)
            {
                loginPictureBox.Enabled = false;
            }

        }

        public FormSearchingResult(Form parent,string text, int selectedTab, bool isForm = false)
        {
            _documentServices = new DocumentServices();
            _tesisServices = new TesisServices();
            _bookServices = new BookServices();
            _articleServices = new ArticleServices();
            _form = parent;
            isLoged = false;
            _textSearcher = text;
            _selectedTab = selectedTab;
            _isForm = isForm;

            InitializeComponent();
            CreateForm();

           
            metroTabControl2.TabPages.RemoveAt(4);


            if (isLoged)
            {
                loginPictureBox.Enabled = false;
            }

        }

        #region Events

        private void Click_FloatPlus(object sender, EventArgs e)
        {
            FormInsert doc = new FormInsert();
            doc.ShowDialog();
            CreateForm();
        }

        private void StarLink_Click(object sender, EventArgs e)
        {
            
           FormStart fs = new FormStart();
            fs.Show();
            this.Dispose();
        }

        private void SelectedIndexChanged_DataGrid(object sender, EventArgs e)
        {
            switch (metroTabControl2.SelectedIndex)
            {
                case 0:
                    _selectedTab = 0;
                    CreatePictureBox.Visible = false;
                    break;
                case 1:
                    _selectedTab = 1;
                    CreatePictureBox.Visible = false;
                    break;
                case 2:
                    _selectedTab = 2;
                    CreatePictureBox.Visible = false;
                    break;
                case 3:
                    _selectedTab = 3;
                    CreatePictureBox.Visible = false;
                    break;

                default:
                    _selectedTab = 4;
                    CreatePictureBox.Visible = true;
                    RemoveAllButton();
                    AddActionIconToGrid();
                    break;
            }
            if (!_isForm)
            {
                metroTextBoxSearch.Text = "";
                _textSearcher = "";
                CreateForm();
            }
            _isForm = false;

        }

        private void Click_BoxSearch(object sender, EventArgs e)
        {
            if (metroTextBoxSearch.Text == "")
            {

                if (metroTabControl2.SelectedIndex == 0)
                {
                    LoadTesis();
                }
                else if (metroTabControl2.SelectedIndex == 1)
                {
                    LoadBooks();
                }
                else if (metroTabControl2.SelectedIndex == 2)
                {
                    LoadArticles();

                }
                else
                {
                    LoadDocuments();
                }
            }
            else
            {
                if (metroTabControl2.SelectedIndex == 0)
                {
                    LoadTesisSearch(metroTextBoxSearch.Text);
                }
                else if (metroTabControl2.SelectedIndex == 1)
                {
                    LoadBooksSearch(metroTextBoxSearch.Text);
                }
                else if (metroTabControl2.SelectedIndex == 2)
                {
                    LoadArticlesSearch(metroTextBoxSearch.Text);

                }
                else
                {
                    LoadDocumentsSearch(metroTextBoxSearch.Text);
                }
            }
            if (CantResultadoMetroLabel != null)
                CantResultadoMetroLabel.Text = metroGridSearchRes.Rows.Count.ToString();
        }

        private void KeyPress_TextBoxSearch(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\r"))
            {
                _textSearcher = metroTextBoxSearch.Text;
                CreateForm();
            }
        }

        private void CellClick_metroGridSearchResult(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == metroGridSearchRes.NewRowIndex || e.RowIndex < 0)
                return;

            int indexSelected = e.RowIndex;
            long idDocument = 0;
            long id_temp = 0;
            string tipoDocumento = "";
            string urlPdf = "";

            switch (_selectedTab)
            {
                case 0:
                    id_temp = _tesisServices.TesisId[indexSelected];
                    idDocument = _tesisServices.GetTesisById(id_temp).Documentid;
                    tipoDocumento = "Tesis";
                    break;
                case 1:
                    id_temp = _bookServices.BooksId[indexSelected];
                    idDocument = _bookServices.GetBookById(id_temp).Documentid;
                    tipoDocumento = "Libro";
                    break;
                case 2:
                    id_temp = _articleServices.ArticlesId[indexSelected];
                    idDocument = _articleServices.GetArticleById(id_temp).Documentid;
                    tipoDocumento = "Articulo";
                    break;
                default:
                    idDocument = _documentServices.DocumentsId[indexSelected].Id;
                    tipoDocumento = _documentServices.DocumentsId[indexSelected].TipoDocumento;
                    break;
            }

            List<string> datos = new List<string>();
            urlPdf = _documentServices.URLById(idDocument);

            //Me aseguro de no pasar por los iconos en el DataGrid
            for (int i = 0; i < metroGridSearchRes.Columns.Count; i++)
            {
                if (metroGridSearchRes.Rows[e.RowIndex].Cells[i].Value != null)
                    datos.Add(metroGridSearchRes.Rows[e.RowIndex].Cells[i].Value.ToString());
            }

            datos.Add(urlPdf);

            if (_selectedTab != 4)
            {
                if (e.ColumnIndex == metroGridSearchRes.Columns["imageDownloadDocument"].Index)
                {
                    CheckAndOpenUrlPdf(urlPdf);
                }
                else
                {
                    FormDocumentView doc = new FormDocumentView(datos, idDocument, tipoDocumento);
                    doc.ShowDialog();
                }
            }
            else
            {
                if (e.ColumnIndex == metroGridSearchRes.Columns["imageUpdate"].Index)
                {
                    var documentsParList = _documentServices.DocumentsId;
                    FormInsert doc = new FormInsert(datos, idDocument, tipoDocumento,documentsParList);
                    doc.ShowDialog();
                    CreateForm();
                }
                if (e.ColumnIndex == metroGridSearchRes.Columns["imageDelete"].Index)
                {
                    DeleteDocument(idDocument,urlPdf);
                }
            }

            if (_selectedTab != 4)
            {
               
            }

        }

        private void CellFormatting_Datagrid(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (metroGridSearchRes.Columns[e.ColumnIndex].Name == "imageDownloadDocument")
            {
                var ic = new Icon(Properties.Resources.download, new Size(2, 2));

                e.Value = ic;
            }
            if (metroGridSearchRes.Columns[e.ColumnIndex].Name == "imageUpdate")
            {
                var ic = new Icon(Properties.Resources.editar, new Size(2, 2));

                e.Value = ic;
            }
            if (metroGridSearchRes.Columns[e.ColumnIndex].Name == "imageDelete")
            {
                var ic = new Icon(Properties.Resources.trash, new Size(2, 2));

                e.Value = ic;
            }
        }

        private void FormSearchingResult_Load(object sender, EventArgs e)
        {
            ActiveControl = metroTextBoxSearch;
        }

        private void ClosedWindow(object sender, FormClosedEventArgs e)
        {
            CloseForms();
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

        private void loginPictureBox_Click(object sender, EventArgs e)
        {
            var login = new MasterKey(this);
            login.ShowDialog();
            if (isLoged)
            {
                loginPictureBox.Enabled = false;
                TabPage admin= new TabPage();
                // administrator
                // 
                admin.BackColor = System.Drawing.Color.White;
                admin.Location = new System.Drawing.Point(4, 38);
                admin.Name = "administrator";
                admin.Size = new System.Drawing.Size(792, 527);
                admin.TabIndex = 7;
                admin.Text = "Administración";
                // 
                metroTabControl2.TabPages.Add(admin);
            }
        }

        #endregion

        #region methods privates

        private void DeleteDocument(long idDocument,string urlPdf)
        {
            DialogResult dialogResult = MetroMessageBox.Show(this, Resources.Delete, Resources.Information,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, 100);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    string currentDir = Environment.CurrentDirectory;
                    string directory = currentDir + urlPdf;
                    File.Delete(directory);
                    _documentServices.Delete(idDocument);
                }
                catch (Exception e)
                {
                    MetroMessageBox.Show(this, Resources.OpenFileError, Resources.Information, MessageBoxButtons.OK,
                       MessageBoxIcon.Warning, 100);
                }
                
                LoadDocumentsSearch(_textSearcher);
            }
        }

        private void LoadTesis()
        {
            var datasource = _tesisServices.GetTesis();
            metroGridSearchRes.DataSource = datasource.ToList();
            VerifiedNotFoundMessage(datasource);
        }

        private void LoadBooks()
        {
            var datasource = _bookServices.GetBooks();
            metroGridSearchRes.DataSource = datasource.ToList();
            VerifiedNotFoundMessage(datasource);
        }

        private void LoadArticles()
        {
            var datasource = _articleServices.GetArticles();
            metroGridSearchRes.DataSource = datasource.ToList();
            VerifiedNotFoundMessage(datasource);
        }

        private void LoadBooksSearch(string search)
        {
            if (search == "")
                LoadBooks();
            else
            {
                var datasource = _bookServices.SearchBooks(search);
                metroGridSearchRes.DataSource = datasource.ToList();
                VerifiedNotFoundMessage(datasource);
            }
        }

        private void LoadArticlesSearch(string search)
        {
            if (search == "")
                LoadArticles();
            else
            {
                var datasource = _articleServices.SearchArticles(search);
                metroGridSearchRes.DataSource = datasource.ToList();
                VerifiedNotFoundMessage(datasource);
            }
        }

        private void LoadTesisSearch(string search)
        {
            if (search == "")
                LoadTesis();
            else
            {
                var datasource = _tesisServices.SearchTesis(search);
                metroGridSearchRes.DataSource = datasource.ToList();
                VerifiedNotFoundMessage(datasource);
            }
        }

        private void CreateForm()
        {
            metroTabControl2.SelectedIndex = _selectedTab;
            RemoveAllButton();
            if (_selectedTab == 0)
            {
                LoadTesisSearch(_textSearcher);
                AddDownloadIconToGrid();
                _isForm = false;
            }

            else if (_selectedTab == 1)
            {
                LoadBooksSearch(_textSearcher);
                AddDownloadIconToGrid();
            }

            else if (_selectedTab == 2)
            {
                LoadArticlesSearch(_textSearcher);
                AddDownloadIconToGrid();
            }

            else if (_selectedTab == 3)
            {
                LoadDocumentsSearch(_textSearcher);
                AddDownloadIconToGrid();
            }
            else
            {
                LoadDocumentsSearch(_textSearcher);
                AddActionIconToGrid();
            }

            if (CantResultadoMetroLabel != null)
                CantResultadoMetroLabel.Text = metroGridSearchRes.Rows.Count.ToString();
        }

        private void RemoveAllButton()
        {
            if (metroGridSearchRes.Columns["imageDownloadDocument"] != null)
            {
                metroGridSearchRes.Columns.Remove("imageDownloadDocument");
            }
            if (metroGridSearchRes.Columns["imageUpdate"] != null)
            {
                metroGridSearchRes.Columns.Remove("imageUpdate");
            }
            if (metroGridSearchRes.Columns["imageDelete"] != null)
            {
                metroGridSearchRes.Columns.Remove("imageDelete");
            }
        }

        private void AddActionIconToGrid()
        {
            //Icono Update
            var imageimageUpdate = CreateImagenColumn("imageUpdate", "Editar Documento", "Editar");
            metroGridSearchRes.Columns.Add(imageimageUpdate);
            //Icono Delete
            var imageimageDelete = CreateImagenColumn("imageDelete", "Eliminar Documento", "Eliminar");
            metroGridSearchRes.Columns.Add(imageimageDelete);
        }

        private void AddDownloadIconToGrid()
        {
            //Icono Descargar
            var imageDownloadDocument = CreateImagenColumn("imageDownloadDocument", "Descargar documento", "Descargar");

            metroGridSearchRes.Columns.Add(imageDownloadDocument);
        }

        private static DataGridViewImageColumn CreateImagenColumn(string name, string description, string headText)
        {
            var imageDownloadDocument = new DataGridViewImageColumn()
            {
                Name = name,
                Description = description,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                HeaderText = headText
            };

            return imageDownloadDocument;
        }

        private void LoadDocumentsSearch(string search)
        {
            if (search == "")
                LoadDocuments();
            else
            {
                var datasource = _documentServices.SearchDocuments(search);
                metroGridSearchRes.DataSource = datasource.ToList();
                VerifiedNotFoundMessage(datasource);
            }
        }

        private void LoadDocuments()
        {
            var datasource = _documentServices.GetDocuments();
            metroGridSearchRes.DataSource = datasource.ToList();
            VerifiedNotFoundMessage(datasource);
        }

        private void VerifiedNotFoundMessage(object datasource)
        {

            if (datasource.GetType() == typeof (List<TesisDto>))
            {
                var type = datasource as List<TesisDto>;
                if (type.ToList().Count == 0)
                {
                    ShowNotFoundMessage();
                }
                else
                {
                    HideNotFoundMessage();
                }
            }
           else if (datasource.GetType() == typeof(List<ArticleDto>))
            {
                var type = datasource as IEnumerable<ArticleDto>;
                if (type.ToList().Count == 0)
                {
                    ShowNotFoundMessage();
                }
                else
                {
                    HideNotFoundMessage();
                }
            }
            else if (datasource.GetType() == typeof(List<BookDto>))
            {
                var type = datasource as IEnumerable<BookDto>;
                if (type.ToList().Count == 0)
                {
                    ShowNotFoundMessage();
                }
                else
                {
                    HideNotFoundMessage();
                }
            }
            else
            {
                var type = datasource as IEnumerable<DocumentDto>;
                if (type.ToList().Count == 0)
                {
                    ShowNotFoundMessage();
                }
                else
                {
                    HideNotFoundMessage();
                }
            }
        }

        private void ShowNotFoundMessage()
        {
            ErrorMessagePictureBox.Visible = true;
            ErrorMessageMetroLabel.Visible = true;
        }
        private void HideNotFoundMessage()
        {
            ErrorMessagePictureBox.Visible = false;
            ErrorMessageMetroLabel.Visible = false;
        }

        private void CheckAndOpenUrlPdf(string urlPdf)
        {
            try
            {
                string currentDir = Environment.CurrentDirectory;
                string directory = currentDir + urlPdf;

                //Check whether folder path is exist
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
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, Resources.LostFileError, Resources.Information,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning, 120);
            }
        }
        private static void CloseForms()
        {
            List<Form> lista = (from object openForm in Application.OpenForms select openForm as Form).ToList();
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Close();
            }
        }



        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormStart fs = new FormStart();
            fs.Show();
            this.Dispose();
        }
    }
}
