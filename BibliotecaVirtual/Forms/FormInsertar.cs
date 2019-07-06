using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
using ToastNotifications;

namespace BibliotecaVirtual
{
    public partial class FormInsert : MetroForm
    {
        //Constante utilizada para visualizar la ausencia de palabras claves en un documento
        private const string VACIO = "    _______    ";

        private List<string> _datos;

        private string _tipoDocumento;

        private long _idDocument;

        private DocumentServices _documentServices;

        private TesisServices _tesisServices;

        private BookServices _bookServices;

        private ArticleServices _articleServices;

        private bool _updateForm;

        private List<Par> _documentsParList;

        private string _urlPdfSelected;
        private string _oldUrlPdfSelected;

        private bool addingAutor = true;

        private bool addingKeyWord = true;

        public FormInsert()
        {
            InitializeComponent();
            _documentServices = new DocumentServices();
            metroRadioButtTesis.Checked = true;

            InitializeListViews();
        }

        public FormInsert(List<string> datos, long idDocument, string tipoDocumento, List<Par> documentsParList)
        {
            _datos = datos;
            _idDocument = idDocument;
            _tipoDocumento = tipoDocumento;
            _updateForm = true;
            _urlPdfSelected = _datos[4];
            _oldUrlPdfSelected = _datos[4];
            _documentsParList = documentsParList;
            _documentServices = new DocumentServices();
            _tesisServices = new TesisServices();
            _bookServices = new BookServices();
            _articleServices = new ArticleServices();
            InitializeComponent();
            FillFields();
        }

        #region Privates Methods

        private void FillFields()
        {


            if (_tipoDocumento == "Tesis")
            {
                FillTesisData();
            }
            else if (_tipoDocumento == "Libro")
            {
                FillBooksData();
            }
            else
            {
                FillArticlesData();
            }
            string titulo = _datos[0];
            string year = _datos[1];
            string urlPdf = _datos[4];

            textBoxTittle.Text = titulo;
            numericUpDownYear.Value = Decimal.Parse(year);

            //Solo muestro el nombre del documento
            string urlPdfName = urlPdf.Split('\\').Last();
            urlPdfTextBox.Text = urlPdfName;

            FillListView(metroListViewAutores, _datos[2]);
            FillListView(metroListViewKeyWords, _datos[3]);
        }

        private void InitializeListViews()
        {
            metroListViewAutores.View = View.Details;
            metroListViewAutores.Columns.Add("Autores", 196);
            metroListViewAutores.HeaderStyle = ColumnHeaderStyle.None;

            metroListViewKeyWords.View = View.Details;
            metroListViewKeyWords.Columns.Add("Autores", 196);
            metroListViewKeyWords.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void FillListView(MetroListView listView, string datosList)
        {
            listView.View = View.Details;
            listView.Columns.Add("Autores", 196);
            listView.HeaderStyle = ColumnHeaderStyle.None;

            foreach (var val in datosList.Split(';').ToList())
            {
                listView.Items.Add(new ListViewItem(new[] { val, val }));
            }
        }

        private void SelectItemInComboBoxLiterature(string literatura)
        {
            foreach (var item in metroComboBoxLiteratura.Items)
            {
                if (item.ToString().ToLower() == literatura.ToLower())
                {
                    metroComboBoxLiteratura.SelectedItem = item;
                    break;
                }
            }
        }
        private void SelectItemInComboBoxCategory(string categoria)
        {
            foreach (var item in metroComboBCateg.Items)
            {
                if (item.ToString().ToLower() == categoria.ToLower())
                {
                    metroComboBCateg.SelectedItem = item;
                    break;
                }
            }
        }

        private void FillArticlesData()
        {
            //Evito que se dispare el evento CheckedChange
            metroRadioButtArticulos.CheckedChanged -= metroRadioButtArticulos_CheckedChanged;
            metroRadioButtArticulos.Checked = true;

            IniciarComponentesLibrosArticulos(true);

            string literatura = _articleServices.LiteraturaByIdDocument(_idDocument);
            SelectItemInComboBoxLiterature(literatura);

            string localitation = _articleServices.LocalitationByIdDocument(_idDocument);
            localitationMetroTextBox.Text = localitation;

            metroRadioButtArticulos.CheckedChanged += metroRadioButtTesis_CheckedChanged;
        }

        private void FillBooksData()
        {
            //Evito que se dispare el evento CheckedChange
            metroRadioButtLibros.CheckedChanged -= metroRadioButtLibros_CheckedChanged;
            metroRadioButtLibros.Checked = true;

            IniciarComponentesLibrosArticulos(false);

            string literatura = _bookServices.LiteraturaByIdDocument(_idDocument);
            SelectItemInComboBoxLiterature(literatura);

            metroRadioButtLibros.CheckedChanged += metroRadioButtTesis_CheckedChanged;
        }

        private void FillTesisData()
        {
            //Evito que se dispare el evento CheckedChange
            metroRadioButtTesis.CheckedChanged -= metroRadioButtTesis_CheckedChanged;
            metroRadioButtTesis.Checked = true;

            string categoria = _tesisServices.CategoryByIdDocument(_idDocument);
            string descripcion = _tesisServices.DescripctionByIdDocument(_idDocument);

            IniciarComponentesTesis();

            //Lleno la informacion de la categoria de la Tesis
            SelectItemInComboBoxCategory(categoria);

            richTextBDescripcion.Text = descripcion;

            metroRadioButtTesis.CheckedChanged += metroRadioButtTesis_CheckedChanged;
        }

        private void IniciarComponentesTesis()
        {
            //deshabilito los labels relacionados con el campo Literatura
            labelLiteratura.Enabled = false;
            labelLiteratura.ForeColor = Color.Silver;

            metroComboBoxLiteratura.Enabled = false;
            metroComboBoxLiteratura.Items.Clear();

            //deshabilito los labels relacionados con el campo Localizacion
            localitationMetroLabel.Enabled = false;
            localitationMetroLabel.ForeColor = Color.Silver;
            localitationMetroTextBox.Enabled = false;
            localitationMetroTextBox.Text = "";


            //Habilito los controles a utilizar durante la creacion de una nueva Tesis
            metroComboBCateg.Enabled = true;
            metroComboBCateg.Items.Clear();
            metroComboBCateg.FormattingEnabled = true;
            metroComboBCateg.ItemHeight = 23;
            metroComboBCateg.Items.AddRange(new object[]
            {
                "Grado",
                "Maestría",
                "Doctorado"
            });

            metroComboBCateg.SelectedIndex = 2;

            richTextBDescripcion.Enabled = true;
            richTextBDescripcion.IsAccessible = true;
            metroLabelCateg.ResetForeColor();
            labelDescripcion.ResetForeColor();
        }

        private void IniciarComponentesLibrosArticulos(bool isArticulo)
        {
            //deshabilito los labels relacionados con el campo categoria
            metroLabelCateg.Enabled = false;
            metroLabelCateg.ForeColor = Color.Silver;
            metroComboBCateg.Enabled = false;
            metroComboBCateg.Items.Clear();

            //deshabilito los labels relacionados con el campo Descripcion
            labelDescripcion.Enabled = false;
            labelDescripcion.ForeColor = Color.Silver;
            richTextBDescripcion.Enabled = false;
            richTextBDescripcion.IsAccessible = false;

            //Habilito los controles a utilizar durante la creacion de un nuevo libro o Articulo
            metroComboBoxLiteratura.Enabled = true;
            metroComboBoxLiteratura.Items.Clear();
            metroComboBoxLiteratura.FormattingEnabled = true;
            metroComboBoxLiteratura.ItemHeight = 23;
            metroComboBoxLiteratura.Items.AddRange(new object[]
            {
                "Extranjera",
                "Nacional"
            });
            labelLiteratura.ResetForeColor();

            metroComboBoxLiteratura.SelectedIndex = 0;

            if (isArticulo)
            {
                //Habilito los labels relacionados con el campo Localizacion
                localitationMetroLabel.Enabled = true;
                localitationMetroLabel.ForeColor = DefaultForeColor;
                localitationMetroTextBox.Enabled = true;
                localitationMetroTextBox.Text = "";
            }
            else
            {
                //deshabilito los labels relacionados con el campo Localizacion
                localitationMetroLabel.Enabled = false;
                localitationMetroLabel.ForeColor = Color.Silver;
                localitationMetroTextBox.Enabled = false;
                localitationMetroTextBox.Text = "";
            }
        }

        private void RebootTesisControls()
        {
            numericUpDownYear.Value = numericUpDownYear.Minimum;
            textBoxTittle.Text = "";
            metroTextBoxAutores.Text = "";
            metroTextBoxKeyW.Text = "";
            metroListViewAutores.Items.Clear();
            metroListViewKeyWords.Items.Clear();
            metroComboBoxLiteratura.Items.Clear();
            richTextBDescripcion.Text = "";
            urlPdfTextBox.Text = "";
        }

        private void RebootBooks_ArticlesControls()
        {
            numericUpDownYear.Value = numericUpDownYear.Minimum;
            textBoxTittle.Text = "";
            metroTextBoxAutores.Text = "";
            metroTextBoxKeyW.Text = "";
            metroListViewAutores.Items.Clear();
            metroListViewKeyWords.Items.Clear();
            metroComboBCateg.Items.Clear();
            richTextBDescripcion.Text = "";
            urlPdfTextBox.Text = "";
        }

        /// <summary>
        /// Validar la entrada de los autores al ListView
        /// </summary>
        /// <param name="added"></param>
        /// <returns></returns>
        private string ValidateAddedItemListView(string added)
        {
            return ValidateMultiWhiteEspace(added);
        }

        private string ValidateMultiWhiteEspace(string added)
        {
            string result = "";
            bool espacio = false;
            added = added.TrimStart(' ');
            added = added.TrimEnd(' ');
            for (int i = 0; i < added.Length; i++)
            {
                if (added[i] == ' ')
                {
                    if (!espacio)
                        result += added[i];
                    espacio = true;
                }
                else
                {
                    result += added[i];
                    espacio = false;
                }
            }
            return result;
        }

        private bool ValidateDataInput()
        {
            return ValidateCommunInput() && ValidateType();
        }

        private bool ValidateType()
        {
            if (_tipoDocumento.Equals("Tesis"))
            {
                return !string.IsNullOrEmpty(richTextBDescripcion.Text);
            }
            if (_tipoDocumento.Equals("Articulo"))
            {
                return !string.IsNullOrEmpty(localitationMetroTextBox.Text);
            }
            return true;
        }

        private bool ValidateCommunInput()
        {
            if (IsEmptyInputText() || IsEmptyListView())
            {
                return false;
            }
            return true;
        }

        private bool IsEmptyListView()
        {
            return metroListViewAutores.Items.Count == 0 || metroListViewKeyWords.Items.Count == 0;
        }

        private bool IsNotToLargeTextBox()
        {
            if (textBoxTittle.MaxLength < textBoxTittle.Text.Length)
                return false;
            if (localitationMetroTextBox.MaxLength < localitationMetroTextBox.Text.Length &&
                localitationMetroTextBox.Enabled)
                return false;
            return true;
        }

        private bool IsEmptyInputText()
        {
            return string.IsNullOrEmpty(textBoxTittle.Text) || string.IsNullOrEmpty(urlPdfTextBox.Text);
        }

        private void FillDocumentData(out List<string> autores, out List<string> keyWords)
        {
            string titulo = textBoxTittle.Text;
            string year = numericUpDownYear.Value.ToString();
            string urlPdf = _urlPdfSelected;
            string categoria = (string)metroComboBCateg.SelectedItem;
            string literatura = (string)metroComboBoxLiteratura.SelectedItem;
            string descripcion = richTextBDescripcion.Text;
            string localitation = localitationMetroTextBox.Text;

            autores = new List<string>();
            keyWords = new List<string>();

            autores.AddRange(metroListViewAutores.Items.Cast<ListViewItem>().Select(x => x.Text));
            keyWords.AddRange(metroListViewKeyWords.Items.Cast<ListViewItem>().Select(x => x.Text));

            _datos = new List<string>()
            {
                titulo,
                year,
                urlPdf,
                categoria,
                literatura,
                descripcion,
                localitation
            };
        }


        #endregion

        #region Events

        private void metroRadioButtTesis_CheckedChanged(object sender, EventArgs e)
        {
            IniciarComponentesTesis();
            _tipoDocumento = "Tesis";
        }

        private void metroRadioButtLibros_CheckedChanged(object sender, EventArgs e)
        {
            IniciarComponentesLibrosArticulos(false);
            _tipoDocumento = "Libro";
        }

        private void metroRadioButtArticulos_CheckedChanged(object sender, EventArgs e)
        {
            IniciarComponentesLibrosArticulos(true);
            _tipoDocumento = "Articulo";
        }

        private void metroButtClean_Click(object sender, EventArgs e)
        {
            if (metroRadioButtTesis.Checked)
            {
                RebootTesisControls();
                metroRadioButtTesis.Checked = true;
                IniciarComponentesTesis();

            }
            else
            {
                if (metroRadioButtLibros.Checked)
                {
                    RebootBooks_ArticlesControls();
                    metroRadioButtLibros.Checked = true;
                    IniciarComponentesLibrosArticulos(false);
                }
                else if (metroRadioButtArticulos.Checked)
                {
                    RebootBooks_ArticlesControls();
                    metroRadioButtArticulos.Checked = true;
                    IniciarComponentesLibrosArticulos(true);
                }
                else
                {
                    RebootTesisControls();
                    RebootBooks_ArticlesControls();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                //Check whether folder path is exist
                try
                {
                    if (!Directory.Exists(filePath))
                    {
                        string fileName = openFileDialog1.SafeFileName;
                        urlPdfTextBox.Text = fileName;

                        string currentDir = Environment.CurrentDirectory;
                        //DirectoryInfo directory = new DirectoryInfo(
                        //    Path.GetFullPath(Path.Combine(currentDir,
                        //        @"\Documentos\" + _tipoDocumento + @"\" + fileName)));

                        string directory = currentDir + @"\Documentos\" + _tipoDocumento + @"\" + fileName;

                        try
                        {
                            //Save pdf files in installedPath
                            File.Copy(filePath, directory, true);
                            _urlPdfSelected = @"\Documentos\" + _tipoDocumento + @"\" + fileName;
                        }
                        catch (Exception exception)
                        {
                            MetroMessageBox.Show(this, Resources.UpdateFileError, Resources.Information,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, 120);
                            urlPdfTextBox.Text = _urlPdfSelected.Split('\\').Last();
                        }
                    }
                }
                catch (Exception execption)
                {
                    MetroMessageBox.Show(this, Resources.OpenFileError, Resources.Information, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning, 120);
                }
            }
        }

        private void metroButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateDataInput())
            {
                if (IsNotToLargeTextBox())
                {
                    List<string> autores;
                    List<string> keyWords;

                    FillDocumentData(out autores, out keyWords);

                    if (_updateForm)
                    {
                        if (_urlPdfSelected != _oldUrlPdfSelected)
                        {
                            string currentDir = Environment.CurrentDirectory;
                            string directory = currentDir + _oldUrlPdfSelected;
                            if (File.Exists(directory))
                            {
                                try
                                {
                                    System.IO.File.Delete(directory);
                                    _documentServices.Update(_datos, autores, keyWords, _tipoDocumento, _idDocument,
                                        _documentsParList);
                                    ShowNotification("Se ha actualizado correctamente.");
                                }
                                catch (Exception)
                                {
                                    MetroMessageBox.Show(this, Resources.UpdateFileError, Resources.Information,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning, 120);

                                    currentDir = Environment.CurrentDirectory;
                                    directory = currentDir + _urlPdfSelected;
                                    System.IO.File.Delete(directory);
                                }
                            }
                            else
                            {
                                _documentServices.Update(_datos, autores, keyWords, _tipoDocumento, _idDocument,
                                    _documentsParList);
                                ShowNotification("Se ha actualizado correctamente.");
                            }
                        }
                        else
                        {
                            _documentServices.Update(_datos, autores, keyWords, _tipoDocumento, _idDocument,
                                _documentsParList);
                            ShowNotification("Se ha actualizado correctamente.");
                        }
                        this.Close();

                    }
                    else
                    {
                        if (_documentServices.IsUnicDocument(_datos[0], _datos[1], _tipoDocumento))
                        {
                            try
                            {
                                _documentServices.Insert(_datos, autores, keyWords, _tipoDocumento);
                                //limpio los campos luego d ela insercion
                                metroButtClean_Click(sender, e);
                                ShowNotification("Se ha insertado correctamente.");
                            }
                            catch (Exception exception)
                            {
                                MetroMessageBox.Show(this, Resources.IncorrectInsert, Resources.Information,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning, 100);
                                textBoxTittle.Focus();
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, Resources.UnicDocument, Resources.Information,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning, 100);
                            textBoxTittle.Focus();
                        }
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, Resources.ToLargeFields, Resources.Information, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning, 100);
                }
            }
            else
            {
                MetroMessageBox.Show(this, Resources.EmptyFields, Resources.Information, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, 100);
                textBoxTittle.Focus();
            }
        }

        private void ShowNotification(string message )
        {
            var toastNotification = new Notification("Información", message, 5, FormAnimator.AnimationMethod.Slide,
                                FormAnimator.AnimationDirection.Left, System.Drawing.ColorTranslator.FromHtml("#00979D"),
                                Properties.Resources.info2, true, this.DesktopLocation.X + this.Width, this.DesktopLocation.Y + Height);
            toastNotification.Show();
        }

        private void pictureBoxAutores_Click(object sender, EventArgs e)
        {
            if (addingAutor)
            {
                if (metroTextBoxAutores.MaxLength >= metroTextBoxAutores.Text.Length)
                {
                    bool found = metroListViewAutores.Items.Cast<ListViewItem>()
                        .Any(item => item.Text == metroTextBoxAutores.Text);
                    if (!found)
                    {
                        string added = metroTextBoxAutores.Text;
                        added = ValidateAddedItemListView(added);
                        if (added != "")
                        {
                            metroListViewAutores.Items.Add(added);
                            metroTextBoxAutores.Text = "";
                        }
                    }
                }
            }
            else
            {
                if (metroListViewAutores.Items.Count > 1 && metroListViewAutores.SelectedIndices.Count > 0)
                {
                    metroListViewAutores.Items.RemoveAt(metroListViewAutores.SelectedIndices[0]);
                    metroTextBoxAutores.Text = "";
                }
            }


        }

        private void pictureBoxKeyW_Click(object sender, EventArgs e)
        {
            if (addingKeyWord)
            {
                if(metroTextBoxKeyW.MaxLength >= metroTextBoxKeyW.Text.Length)
                {
                    bool found = metroListViewKeyWords.Items.Cast<ListViewItem>()
                        .Any(item => item.Text == metroTextBoxKeyW.Text);
                    if (!found)
                    {
                        string added = metroTextBoxKeyW.Text;
                        added = ValidateAddedItemListView(added);
                        if (added != "")
                        {
                            metroListViewKeyWords.Items.Add(added);

                            var nulo = metroListViewKeyWords.Items.Cast<ListViewItem>()
                                .FirstOrDefault(item => item.Text == VACIO);
                            if (nulo != null) metroListViewKeyWords.Items.Remove(nulo);

                            metroTextBoxKeyW.Text = "";
                        }
                    }
                }
            }
            else
            {
                if (metroListViewKeyWords.Items.Count > 1 && metroListViewKeyWords.SelectedIndices.Count > 0)
                {
                    metroListViewKeyWords.Items.RemoveAt(metroListViewKeyWords.SelectedIndices[0]);
                    metroTextBoxKeyW.Text = "";
                }
            }
        }


        private void metroListViewAutores_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            metroTextBoxAutores.Text = e.Item.Text;
            addingAutor = false;
            pictureBoxAutores.Image = Resources.rest;
        }

        private void metroListViewKeyWords_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            metroTextBoxKeyW.Text = e.Item.Text;
            addingKeyWord = false;
            pictureBoxKeyW.Image = Resources.rest;
        }

        private void metroTextBoxAutores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                pictureBoxAutores.Image = Resources.plus;
                addingAutor = true;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void metroTextBoxKeyW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar)
                || Char.IsDigit(e.KeyChar) || e.KeyChar == '-')
            {
                pictureBoxKeyW.Image = Resources.plus;
                addingKeyWord = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBoxKeyW_MouseHover(object sender, EventArgs e)
        {
            pictureBoxKeyW.Height = 29;
            pictureBoxKeyW.Width = 29;
        }

        private void pictureBoxKeyW_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxKeyW.Height = 28;
            pictureBoxKeyW.Width = 28;
        }

        private void pictureBoxAutores_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAutores.Height = 28;
            pictureBoxAutores.Width = 28;
        }

        private void pictureBoxAutores_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxAutores.Height = 29;
            pictureBoxAutores.Width = 29;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Height = 29;
            pictureBox1.Width = 29;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Height = 28;
            pictureBox1.Width = 28;
        }

        #endregion


    }
}
