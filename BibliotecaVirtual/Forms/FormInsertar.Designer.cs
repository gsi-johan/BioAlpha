using System;

namespace BibliotecaVirtual
{
    partial class FormInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsert));
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCateg = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDescriptors = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAuthors = new MetroFramework.Controls.MetroLabel();
            this.metroListViewAutores = new MetroFramework.Controls.MetroListView();
            this.metroListViewKeyWords = new MetroFramework.Controls.MetroListView();
            this.richTextBDescripcion = new System.Windows.Forms.RichTextBox();
            this.metroRadioButtTesis = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtLibros = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtArticulos = new MetroFramework.Controls.MetroRadioButton();
            this.metroComboBCateg = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroButtClean = new MetroFramework.Controls.MetroButton();
            this.labelDescripcion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.localitationMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.localitationMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.urlPdfTextBox = new MetroFramework.Controls.MetroTextBox();
            this.urlPdfLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxKeyW = new System.Windows.Forms.PictureBox();
            this.pictureBoxAutores = new System.Windows.Forms.PictureBox();
            this.metroComboBoxLiteratura = new MetroFramework.Controls.MetroComboBox();
            this.labelLiteratura = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxKeyW = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textBoxTittle = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxAutores = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonCancelar = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownYear.Location = new System.Drawing.Point(439, 15);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(52, 16);
            this.numericUpDownYear.TabIndex = 6;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(394, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Año:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabelCateg
            // 
            this.metroLabelCateg.Location = new System.Drawing.Point(6, 147);
            this.metroLabelCateg.Name = "metroLabelCateg";
            this.metroLabelCateg.Size = new System.Drawing.Size(70, 19);
            this.metroLabelCateg.TabIndex = 6;
            this.metroLabelCateg.Text = "Categoría:";
            this.metroLabelCateg.UseCustomForeColor = true;
            // 
            // metroLabelDescriptors
            // 
            this.metroLabelDescriptors.AutoSize = true;
            this.metroLabelDescriptors.Location = new System.Drawing.Point(334, 51);
            this.metroLabelDescriptors.Name = "metroLabelDescriptors";
            this.metroLabelDescriptors.Size = new System.Drawing.Size(96, 19);
            this.metroLabelDescriptors.TabIndex = 12;
            this.metroLabelDescriptors.Text = "Palabras claves";
            this.metroLabelDescriptors.UseCustomForeColor = true;
            // 
            // metroLabelAuthors
            // 
            this.metroLabelAuthors.AutoSize = true;
            this.metroLabelAuthors.Location = new System.Drawing.Point(11, 51);
            this.metroLabelAuthors.Name = "metroLabelAuthors";
            this.metroLabelAuthors.Size = new System.Drawing.Size(62, 19);
            this.metroLabelAuthors.TabIndex = 11;
            this.metroLabelAuthors.Text = "Autor(es)";
            this.metroLabelAuthors.UseCustomForeColor = true;
            // 
            // metroListViewAutores
            // 
            this.metroListViewAutores.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListViewAutores.FullRowSelect = true;
            this.metroListViewAutores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.metroListViewAutores.Location = new System.Drawing.Point(82, 78);
            this.metroListViewAutores.MultiSelect = false;
            this.metroListViewAutores.Name = "metroListViewAutores";
            this.metroListViewAutores.OwnerDraw = true;
            this.metroListViewAutores.Size = new System.Drawing.Size(204, 61);
            this.metroListViewAutores.TabIndex = 10;
            this.metroListViewAutores.UseCompatibleStateImageBehavior = false;
            this.metroListViewAutores.UseSelectable = true;
            this.metroListViewAutores.View = System.Windows.Forms.View.List;
            this.metroListViewAutores.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.metroListViewAutores_ItemSelectionChanged);
            // 
            // metroListViewKeyWords
            // 
            this.metroListViewKeyWords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListViewKeyWords.FullRowSelect = true;
            this.metroListViewKeyWords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.metroListViewKeyWords.Location = new System.Drawing.Point(436, 77);
            this.metroListViewKeyWords.MultiSelect = false;
            this.metroListViewKeyWords.Name = "metroListViewKeyWords";
            this.metroListViewKeyWords.OwnerDraw = true;
            this.metroListViewKeyWords.Size = new System.Drawing.Size(201, 62);
            this.metroListViewKeyWords.TabIndex = 9;
            this.metroListViewKeyWords.UseCompatibleStateImageBehavior = false;
            this.metroListViewKeyWords.UseSelectable = true;
            this.metroListViewKeyWords.View = System.Windows.Forms.View.List;
            this.metroListViewKeyWords.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.metroListViewKeyWords_ItemSelectionChanged);
            // 
            // richTextBDescripcion
            // 
            this.richTextBDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBDescripcion.Location = new System.Drawing.Point(73, 246);
            this.richTextBDescripcion.Name = "richTextBDescripcion";
            this.richTextBDescripcion.Size = new System.Drawing.Size(581, 112);
            this.richTextBDescripcion.TabIndex = 8;
            this.richTextBDescripcion.Text = "";
            // 
            // metroRadioButtTesis
            // 
            this.metroRadioButtTesis.AutoSize = true;
            this.metroRadioButtTesis.Location = new System.Drawing.Point(328, 29);
            this.metroRadioButtTesis.Name = "metroRadioButtTesis";
            this.metroRadioButtTesis.Size = new System.Drawing.Size(49, 15);
            this.metroRadioButtTesis.TabIndex = 15;
            this.metroRadioButtTesis.Text = "Tesis";
            this.metroRadioButtTesis.UseSelectable = true;
            this.metroRadioButtTesis.CheckedChanged += new System.EventHandler(this.metroRadioButtTesis_CheckedChanged);
            // 
            // metroRadioButtLibros
            // 
            this.metroRadioButtLibros.AutoSize = true;
            this.metroRadioButtLibros.Location = new System.Drawing.Point(385, 29);
            this.metroRadioButtLibros.Name = "metroRadioButtLibros";
            this.metroRadioButtLibros.Size = new System.Drawing.Size(55, 15);
            this.metroRadioButtLibros.TabIndex = 16;
            this.metroRadioButtLibros.Text = "Libros";
            this.metroRadioButtLibros.UseSelectable = true;
            this.metroRadioButtLibros.CheckedChanged += new System.EventHandler(this.metroRadioButtLibros_CheckedChanged);
            // 
            // metroRadioButtArticulos
            // 
            this.metroRadioButtArticulos.AutoSize = true;
            this.metroRadioButtArticulos.Location = new System.Drawing.Point(447, 29);
            this.metroRadioButtArticulos.Name = "metroRadioButtArticulos";
            this.metroRadioButtArticulos.Size = new System.Drawing.Size(70, 15);
            this.metroRadioButtArticulos.TabIndex = 17;
            this.metroRadioButtArticulos.Text = "Articulos";
            this.metroRadioButtArticulos.UseSelectable = true;
            this.metroRadioButtArticulos.CheckedChanged += new System.EventHandler(this.metroRadioButtArticulos_CheckedChanged);
            // 
            // metroComboBCateg
            // 
            this.metroComboBCateg.FormattingEnabled = true;
            this.metroComboBCateg.ItemHeight = 23;
            this.metroComboBCateg.Items.AddRange(new object[] {
            "Grado",
            "Maestría",
            "Doctorado"});
            this.metroComboBCateg.Location = new System.Drawing.Point(82, 147);
            this.metroComboBCateg.Name = "metroComboBCateg";
            this.metroComboBCateg.Size = new System.Drawing.Size(121, 29);
            this.metroComboBCateg.TabIndex = 18;
            this.metroComboBCateg.UseSelectable = true;
            // 
            // metroButtonGuardar
            // 
            this.metroButtonGuardar.Location = new System.Drawing.Point(461, 482);
            this.metroButtonGuardar.Name = "metroButtonGuardar";
            this.metroButtonGuardar.Size = new System.Drawing.Size(90, 39);
            this.metroButtonGuardar.TabIndex = 19;
            this.metroButtonGuardar.Text = "Guardar";
            this.metroButtonGuardar.UseSelectable = true;
            this.metroButtonGuardar.Click += new System.EventHandler(this.metroButtonGuardar_Click);
            // 
            // metroButtClean
            // 
            this.metroButtClean.Location = new System.Drawing.Point(564, 363);
            this.metroButtClean.Name = "metroButtClean";
            this.metroButtClean.Size = new System.Drawing.Size(90, 39);
            this.metroButtClean.TabIndex = 20;
            this.metroButtClean.Text = "Limpiar campos";
            this.metroButtClean.UseSelectable = true;
            this.metroButtClean.Click += new System.EventHandler(this.metroButtClean_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(71, 221);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(83, 19);
            this.labelDescripcion.TabIndex = 21;
            this.labelDescripcion.Text = "Descripción :";
            this.labelDescripcion.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(193, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Tipo de documento:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 48);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Datos Generales";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.localitationMetroTextBox);
            this.metroPanel2.Controls.Add(this.localitationMetroLabel);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.urlPdfTextBox);
            this.metroPanel2.Controls.Add(this.urlPdfLabel);
            this.metroPanel2.Controls.Add(this.pictureBoxKeyW);
            this.metroPanel2.Controls.Add(this.pictureBoxAutores);
            this.metroPanel2.Controls.Add(this.metroComboBoxLiteratura);
            this.metroPanel2.Controls.Add(this.richTextBDescripcion);
            this.metroPanel2.Controls.Add(this.labelLiteratura);
            this.metroPanel2.Controls.Add(this.metroTextBoxKeyW);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.textBoxTittle);
            this.metroPanel2.Controls.Add(this.metroTextBoxAutores);
            this.metroPanel2.Controls.Add(this.numericUpDownYear);
            this.metroPanel2.Controls.Add(this.labelDescripcion);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroComboBCateg);
            this.metroPanel2.Controls.Add(this.metroLabelDescriptors);
            this.metroPanel2.Controls.Add(this.metroButtClean);
            this.metroPanel2.Controls.Add(this.metroLabelAuthors);
            this.metroPanel2.Controls.Add(this.metroLabelCateg);
            this.metroPanel2.Controls.Add(this.metroListViewAutores);
            this.metroPanel2.Controls.Add(this.metroListViewKeyWords);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(9, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(681, 413);
            this.metroPanel2.TabIndex = 24;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // localitationMetroTextBox
            // 
            // 
            // 
            // 
            this.localitationMetroTextBox.CustomButton.Image = null;
            this.localitationMetroTextBox.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.localitationMetroTextBox.CustomButton.Name = "";
            this.localitationMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.localitationMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.localitationMetroTextBox.CustomButton.TabIndex = 1;
            this.localitationMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.localitationMetroTextBox.CustomButton.UseSelectable = true;
            this.localitationMetroTextBox.CustomButton.Visible = false;
            this.localitationMetroTextBox.Lines = new string[0];
            this.localitationMetroTextBox.Location = new System.Drawing.Point(436, 147);
            this.localitationMetroTextBox.MaxLength = 255;
            this.localitationMetroTextBox.Name = "localitationMetroTextBox";
            this.localitationMetroTextBox.PasswordChar = '\0';
            this.localitationMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.localitationMetroTextBox.SelectedText = "";
            this.localitationMetroTextBox.SelectionLength = 0;
            this.localitationMetroTextBox.SelectionStart = 0;
            this.localitationMetroTextBox.ShortcutsEnabled = true;
            this.localitationMetroTextBox.Size = new System.Drawing.Size(201, 23);
            this.localitationMetroTextBox.TabIndex = 34;
            this.localitationMetroTextBox.UseSelectable = true;
            this.localitationMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.localitationMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // localitationMetroLabel
            // 
            this.localitationMetroLabel.Location = new System.Drawing.Point(360, 147);
            this.localitationMetroLabel.Name = "localitationMetroLabel";
            this.localitationMetroLabel.Size = new System.Drawing.Size(66, 19);
            this.localitationMetroLabel.TabIndex = 33;
            this.localitationMetroLabel.Text = "Registro :";
            this.localitationMetroLabel.UseCustomForeColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BibliotecaVirtual.Properties.Resources.src;
            this.pictureBox1.Location = new System.Drawing.Point(289, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // urlPdfTextBox
            // 
            // 
            // 
            // 
            this.urlPdfTextBox.CustomButton.Image = null;
            this.urlPdfTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.urlPdfTextBox.CustomButton.Name = "";
            this.urlPdfTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.urlPdfTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlPdfTextBox.CustomButton.TabIndex = 1;
            this.urlPdfTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlPdfTextBox.CustomButton.UseSelectable = true;
            this.urlPdfTextBox.CustomButton.Visible = false;
            this.urlPdfTextBox.Lines = new string[0];
            this.urlPdfTextBox.Location = new System.Drawing.Point(82, 189);
            this.urlPdfTextBox.MaxLength = 32767;
            this.urlPdfTextBox.Name = "urlPdfTextBox";
            this.urlPdfTextBox.PasswordChar = '\0';
            this.urlPdfTextBox.ReadOnly = true;
            this.urlPdfTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlPdfTextBox.SelectedText = "";
            this.urlPdfTextBox.SelectionLength = 0;
            this.urlPdfTextBox.SelectionStart = 0;
            this.urlPdfTextBox.ShortcutsEnabled = true;
            this.urlPdfTextBox.Size = new System.Drawing.Size(204, 23);
            this.urlPdfTextBox.TabIndex = 31;
            this.urlPdfTextBox.UseSelectable = true;
            this.urlPdfTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urlPdfTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // urlPdfLabel
            // 
            this.urlPdfLabel.Location = new System.Drawing.Point(6, 188);
            this.urlPdfLabel.Name = "urlPdfLabel";
            this.urlPdfLabel.Size = new System.Drawing.Size(70, 19);
            this.urlPdfLabel.TabIndex = 30;
            this.urlPdfLabel.Text = "Url Pdf";
            this.urlPdfLabel.UseCustomForeColor = true;
            // 
            // pictureBoxKeyW
            // 
            this.pictureBoxKeyW.Image = global::BibliotecaVirtual.Properties.Resources.plus;
            this.pictureBoxKeyW.Location = new System.Drawing.Point(643, 41);
            this.pictureBoxKeyW.Name = "pictureBoxKeyW";
            this.pictureBoxKeyW.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxKeyW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKeyW.TabIndex = 29;
            this.pictureBoxKeyW.TabStop = false;
            this.pictureBoxKeyW.Click += new System.EventHandler(this.pictureBoxKeyW_Click);
            this.pictureBoxKeyW.MouseLeave += new System.EventHandler(this.pictureBoxKeyW_MouseLeave);
            this.pictureBoxKeyW.MouseHover += new System.EventHandler(this.pictureBoxKeyW_MouseHover);
            // 
            // pictureBoxAutores
            // 
            this.pictureBoxAutores.Image = global::BibliotecaVirtual.Properties.Resources.plus;
            this.pictureBoxAutores.Location = new System.Drawing.Point(289, 43);
            this.pictureBoxAutores.Name = "pictureBoxAutores";
            this.pictureBoxAutores.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxAutores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAutores.TabIndex = 28;
            this.pictureBoxAutores.TabStop = false;
            this.pictureBoxAutores.Click += new System.EventHandler(this.pictureBoxAutores_Click);
            this.pictureBoxAutores.MouseLeave += new System.EventHandler(this.pictureBoxAutores_MouseLeave);
            this.pictureBoxAutores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAutores_MouseMove);
            // 
            // metroComboBoxLiteratura
            // 
            this.metroComboBoxLiteratura.FormattingEnabled = true;
            this.metroComboBoxLiteratura.ItemHeight = 23;
            this.metroComboBoxLiteratura.Items.AddRange(new object[] {
            "Extranjera",
            "Nacional"});
            this.metroComboBoxLiteratura.Location = new System.Drawing.Point(436, 189);
            this.metroComboBoxLiteratura.Name = "metroComboBoxLiteratura";
            this.metroComboBoxLiteratura.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxLiteratura.TabIndex = 27;
            this.metroComboBoxLiteratura.UseSelectable = true;
            // 
            // labelLiteratura
            // 
            this.labelLiteratura.Location = new System.Drawing.Point(360, 189);
            this.labelLiteratura.Name = "labelLiteratura";
            this.labelLiteratura.Size = new System.Drawing.Size(70, 19);
            this.labelLiteratura.TabIndex = 26;
            this.labelLiteratura.Text = "Literatura:";
            this.labelLiteratura.UseCustomForeColor = true;
            // 
            // metroTextBoxKeyW
            // 
            // 
            // 
            // 
            this.metroTextBoxKeyW.CustomButton.Image = null;
            this.metroTextBoxKeyW.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.metroTextBoxKeyW.CustomButton.Name = "";
            this.metroTextBoxKeyW.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxKeyW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxKeyW.CustomButton.TabIndex = 1;
            this.metroTextBoxKeyW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxKeyW.CustomButton.UseSelectable = true;
            this.metroTextBoxKeyW.CustomButton.Visible = false;
            this.metroTextBoxKeyW.Lines = new string[0];
            this.metroTextBoxKeyW.Location = new System.Drawing.Point(436, 47);
            this.metroTextBoxKeyW.MaxLength = 2000;
            this.metroTextBoxKeyW.Name = "metroTextBoxKeyW";
            this.metroTextBoxKeyW.PasswordChar = '\0';
            this.metroTextBoxKeyW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxKeyW.SelectedText = "";
            this.metroTextBoxKeyW.SelectionLength = 0;
            this.metroTextBoxKeyW.SelectionStart = 0;
            this.metroTextBoxKeyW.ShortcutsEnabled = true;
            this.metroTextBoxKeyW.Size = new System.Drawing.Size(201, 23);
            this.metroTextBoxKeyW.TabIndex = 25;
            this.metroTextBoxKeyW.UseSelectable = true;
            this.metroTextBoxKeyW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxKeyW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxKeyW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxKeyW_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 12);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Título:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // textBoxTittle
            // 
            // 
            // 
            // 
            this.textBoxTittle.CustomButton.Image = null;
            this.textBoxTittle.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.textBoxTittle.CustomButton.Name = "";
            this.textBoxTittle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxTittle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxTittle.CustomButton.TabIndex = 1;
            this.textBoxTittle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxTittle.CustomButton.UseSelectable = true;
            this.textBoxTittle.CustomButton.Visible = false;
            this.textBoxTittle.Lines = new string[0];
            this.textBoxTittle.Location = new System.Drawing.Point(82, 12);
            this.textBoxTittle.MaxLength = 255;
            this.textBoxTittle.Name = "textBoxTittle";
            this.textBoxTittle.PasswordChar = '\0';
            this.textBoxTittle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTittle.SelectedText = "";
            this.textBoxTittle.SelectionLength = 0;
            this.textBoxTittle.SelectionStart = 0;
            this.textBoxTittle.ShortcutsEnabled = true;
            this.textBoxTittle.Size = new System.Drawing.Size(204, 23);
            this.textBoxTittle.TabIndex = 23;
            this.textBoxTittle.UseSelectable = true;
            this.textBoxTittle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxTittle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxAutores
            // 
            // 
            // 
            // 
            this.metroTextBoxAutores.CustomButton.Image = null;
            this.metroTextBoxAutores.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.metroTextBoxAutores.CustomButton.Name = "";
            this.metroTextBoxAutores.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxAutores.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAutores.CustomButton.TabIndex = 1;
            this.metroTextBoxAutores.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxAutores.CustomButton.UseSelectable = true;
            this.metroTextBoxAutores.CustomButton.Visible = false;
            this.metroTextBoxAutores.Lines = new string[0];
            this.metroTextBoxAutores.Location = new System.Drawing.Point(82, 47);
            this.metroTextBoxAutores.MaxLength = 70;
            this.metroTextBoxAutores.Name = "metroTextBoxAutores";
            this.metroTextBoxAutores.PasswordChar = '\0';
            this.metroTextBoxAutores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxAutores.SelectedText = "";
            this.metroTextBoxAutores.SelectionLength = 0;
            this.metroTextBoxAutores.SelectionStart = 0;
            this.metroTextBoxAutores.ShortcutsEnabled = true;
            this.metroTextBoxAutores.Size = new System.Drawing.Size(204, 23);
            this.metroTextBoxAutores.TabIndex = 22;
            this.metroTextBoxAutores.UseSelectable = true;
            this.metroTextBoxAutores.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxAutores.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxAutores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxAutores_KeyPress);
            // 
            // metroButtonCancelar
            // 
            this.metroButtonCancelar.Location = new System.Drawing.Point(587, 482);
            this.metroButtonCancelar.Name = "metroButtonCancelar";
            this.metroButtonCancelar.Size = new System.Drawing.Size(90, 39);
            this.metroButtonCancelar.TabIndex = 25;
            this.metroButtonCancelar.Text = "Cancelar";
            this.metroButtonCancelar.UseSelectable = true;
            this.metroButtonCancelar.Click += new System.EventHandler(this.metroButtonCancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "urlPdfOpenFileDialog";
            this.openFileDialog1.Filter = "Pdf file|*.pdf";
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 530);
            this.Controls.Add(this.metroButtonCancelar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroRadioButtArticulos);
            this.Controls.Add(this.metroRadioButtLibros);
            this.Controls.Add(this.metroButtonGuardar);
            this.Controls.Add(this.metroRadioButtTesis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInsert";
            this.Resizable = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelCateg;
        private MetroFramework.Controls.MetroLabel metroLabelDescriptors;
        private MetroFramework.Controls.MetroLabel metroLabelAuthors;
        private MetroFramework.Controls.MetroListView metroListViewAutores;
        private MetroFramework.Controls.MetroListView metroListViewKeyWords;
        private System.Windows.Forms.RichTextBox richTextBDescripcion;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtTesis;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtLibros;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtArticulos;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private MetroFramework.Controls.MetroComboBox metroComboBCateg;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroButton metroButtClean;
        private MetroFramework.Controls.MetroLabel labelDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButtonCancelar;
        private MetroFramework.Controls.MetroTextBox metroTextBoxKeyW;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textBoxTittle;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAutores;
        private MetroFramework.Controls.MetroComboBox metroComboBoxLiteratura;
        private MetroFramework.Controls.MetroLabel labelLiteratura;
        private System.Windows.Forms.PictureBox pictureBoxKeyW;
        private System.Windows.Forms.PictureBox pictureBoxAutores;
        private MetroFramework.Controls.MetroTextBox urlPdfTextBox;
        private MetroFramework.Controls.MetroLabel urlPdfLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox localitationMetroTextBox;
        private MetroFramework.Controls.MetroLabel localitationMetroLabel;
    }
}