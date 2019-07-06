using System.Drawing;
using System.Drawing.Text;
using BibliotecaVirtual.Commun;

namespace BibliotecaVirtual
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.pictureBoxTesis = new System.Windows.Forms.PictureBox();
            this.pictureBoxLibros = new System.Windows.Forms.PictureBox();
            this.pictureBoxArticulos = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this._gallerySideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._lectionsSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._exitStrategiesSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._postersSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._pilotsSolutionsSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._componentsSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._sumarySideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._reportEndSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._radioComponent_1 = new MetroFramework.Controls.MetroRadioButton();
            this._radioComponent_2 = new MetroFramework.Controls.MetroRadioButton();
            this._radioComponent_3 = new MetroFramework.Controls.MetroRadioButton();
            this._radioComponent_4 = new MetroFramework.Controls.MetroRadioButton();
            this._radioMultimedia = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBoxSearch
            // 
            // 
            // 
            // 
            this.metroTextBoxSearch.CustomButton.Image = null;
            this.metroTextBoxSearch.CustomButton.Location = new System.Drawing.Point(300, 2);
            this.metroTextBoxSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxSearch.CustomButton.Name = "";
            this.metroTextBoxSearch.CustomButton.Size = new System.Drawing.Size(33, 31);
            this.metroTextBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSearch.CustomButton.TabIndex = 1;
            this.metroTextBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSearch.CustomButton.UseSelectable = true;
            this.metroTextBoxSearch.CustomButton.Visible = false;
            this.metroTextBoxSearch.Lines = new string[0];
            this.metroTextBoxSearch.Location = new System.Drawing.Point(653, 127);
            this.metroTextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTextBoxSearch.MaxLength = 32767;
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.PasswordChar = '\0';
            this.metroTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearch.SelectedText = "";
            this.metroTextBoxSearch.SelectionLength = 0;
            this.metroTextBoxSearch.SelectionStart = 0;
            this.metroTextBoxSearch.ShortcutsEnabled = true;
            this.metroTextBoxSearch.Size = new System.Drawing.Size(253, 30);
            this.metroTextBoxSearch.TabIndex = 8;
            this.metroTextBoxSearch.UseSelectable = true;
            this.metroTextBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxSearch_KeyPress);
            // 
            // pictureBoxTesis
            // 
            this.pictureBoxTesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTesis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTesis.Image")));
            this.pictureBoxTesis.Location = new System.Drawing.Point(316, 260);
            this.pictureBoxTesis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxTesis.Name = "pictureBoxTesis";
            this.pictureBoxTesis.Size = new System.Drawing.Size(236, 229);
            this.pictureBoxTesis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTesis.TabIndex = 6;
            this.pictureBoxTesis.TabStop = false;
            this.pictureBoxTesis.Click += new System.EventHandler(this.pictureBoxTesis_Click);
            // 
            // pictureBoxLibros
            // 
            this.pictureBoxLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLibros.Image = global::BibliotecaVirtual.Properties.Resources.Libros;
            this.pictureBoxLibros.Location = new System.Drawing.Point(653, 260);
            this.pictureBoxLibros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLibros.Name = "pictureBoxLibros";
            this.pictureBoxLibros.Size = new System.Drawing.Size(236, 229);
            this.pictureBoxLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLibros.TabIndex = 5;
            this.pictureBoxLibros.TabStop = false;
            this.pictureBoxLibros.Click += new System.EventHandler(this.pictureBoxLibros_Click);
            // 
            // pictureBoxArticulos
            // 
            this.pictureBoxArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArticulos.Image = global::BibliotecaVirtual.Properties.Resources.Articulo;
            this.pictureBoxArticulos.Location = new System.Drawing.Point(967, 260);
            this.pictureBoxArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxArticulos.Name = "pictureBoxArticulos";
            this.pictureBoxArticulos.Size = new System.Drawing.Size(236, 229);
            this.pictureBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulos.TabIndex = 4;
            this.pictureBoxArticulos.TabStop = false;
            this.pictureBoxArticulos.Click += new System.EventHandler(this.pictureBoxArticulos_Click);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackgroundImage = global::BibliotecaVirtual.Properties.Resources.search;
            this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxSearch.Location = new System.Drawing.Point(877, 130);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(24, 22);
            this.pictureBoxSearch.TabIndex = 9;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            this.pictureBoxSearch.MouseLeave += new System.EventHandler(this.pictureBoxSearch_MouseLeave);
            this.pictureBoxSearch.MouseHover += new System.EventHandler(this.pictureBoxSearch_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BibliotecaVirtual.Properties.Resources.LogoColor;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 112);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BibliotecaVirtual.Properties.Resources.FooterFull;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(260, 543);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1067, 197);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(660, 100);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 20);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Buscar:";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this._gallerySideBar);
            this.bunifuGradientPanel1.Controls.Add(this._lectionsSideBar);
            this.bunifuGradientPanel1.Controls.Add(this._exitStrategiesSideBar);
            this.bunifuGradientPanel1.Controls.Add(this._postersSideBar);
            this.bunifuGradientPanel1.Controls.Add(this._pilotsSolutionsSideBar);
            this.bunifuGradientPanel1.Controls.Add(this._componentsSideBar);
            this.bunifuGradientPanel1.Controls.Add(this._sumarySideBar);
            this.bunifuGradientPanel1.Controls.Add(this._reportEndSideBar);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(87)))), ((int)(((byte)(146)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 6);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 100;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(263, 734);
            this.bunifuGradientPanel1.TabIndex = 14;
            // 
            // _gallerySideBar
            // 
            this._gallerySideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._gallerySideBar.BackColor = System.Drawing.Color.Transparent;
            this._gallerySideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._gallerySideBar.BorderRadius = 0;
            this._gallerySideBar.ButtonText = "Galeria de Fotos";
            this._gallerySideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._gallerySideBar.DisabledColor = System.Drawing.Color.Gray;
            this._gallerySideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._gallerySideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_gallerySideBar.Iconimage")));
            this._gallerySideBar.Iconimage_right = null;
            this._gallerySideBar.Iconimage_right_Selected = null;
            this._gallerySideBar.Iconimage_Selected = null;
            this._gallerySideBar.IconMarginLeft = 0;
            this._gallerySideBar.IconMarginRight = 0;
            this._gallerySideBar.IconRightVisible = true;
            this._gallerySideBar.IconRightZoom = 0D;
            this._gallerySideBar.IconVisible = false;
            this._gallerySideBar.IconZoom = 90D;
            this._gallerySideBar.IsTab = false;
            this._gallerySideBar.Location = new System.Drawing.Point(0, 558);
            this._gallerySideBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._gallerySideBar.Name = "_gallerySideBar";
            this._gallerySideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._gallerySideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._gallerySideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._gallerySideBar.selected = false;
            this._gallerySideBar.Size = new System.Drawing.Size(263, 36);
            this._gallerySideBar.TabIndex = 10;
            this._gallerySideBar.Text = "Galeria de Fotos";
            this._gallerySideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._gallerySideBar.Textcolor = System.Drawing.Color.White;
            this._gallerySideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // _lectionsSideBar
            // 
            this._lectionsSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._lectionsSideBar.BackColor = System.Drawing.Color.Transparent;
            this._lectionsSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._lectionsSideBar.BorderRadius = 0;
            this._lectionsSideBar.ButtonText = "Lecciones aprendidas";
            this._lectionsSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._lectionsSideBar.DisabledColor = System.Drawing.Color.Gray;
            this._lectionsSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._lectionsSideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_lectionsSideBar.Iconimage")));
            this._lectionsSideBar.Iconimage_right = null;
            this._lectionsSideBar.Iconimage_right_Selected = null;
            this._lectionsSideBar.Iconimage_Selected = null;
            this._lectionsSideBar.IconMarginLeft = 0;
            this._lectionsSideBar.IconMarginRight = 0;
            this._lectionsSideBar.IconRightVisible = true;
            this._lectionsSideBar.IconRightZoom = 0D;
            this._lectionsSideBar.IconVisible = false;
            this._lectionsSideBar.IconZoom = 90D;
            this._lectionsSideBar.IsTab = false;
            this._lectionsSideBar.Location = new System.Drawing.Point(0, 494);
            this._lectionsSideBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._lectionsSideBar.Name = "_lectionsSideBar";
            this._lectionsSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._lectionsSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._lectionsSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._lectionsSideBar.selected = false;
            this._lectionsSideBar.Size = new System.Drawing.Size(263, 36);
            this._lectionsSideBar.TabIndex = 9;
            this._lectionsSideBar.Text = "Lecciones aprendidas";
            this._lectionsSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lectionsSideBar.Textcolor = System.Drawing.Color.White;
            this._lectionsSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lectionsSideBar.Click += new System.EventHandler(this._lectionsSideBar_Click);
            // 
            // _exitStrategiesSideBar
            // 
            this._exitStrategiesSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._exitStrategiesSideBar.BackColor = System.Drawing.Color.Transparent;
            this._exitStrategiesSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._exitStrategiesSideBar.BorderRadius = 0;
            this._exitStrategiesSideBar.ButtonText = "Estrategías de salidas";
            this._exitStrategiesSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._exitStrategiesSideBar.DisabledColor = System.Drawing.Color.Gray;
            this._exitStrategiesSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._exitStrategiesSideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_exitStrategiesSideBar.Iconimage")));
            this._exitStrategiesSideBar.Iconimage_right = null;
            this._exitStrategiesSideBar.Iconimage_right_Selected = null;
            this._exitStrategiesSideBar.Iconimage_Selected = null;
            this._exitStrategiesSideBar.IconMarginLeft = 0;
            this._exitStrategiesSideBar.IconMarginRight = 0;
            this._exitStrategiesSideBar.IconRightVisible = true;
            this._exitStrategiesSideBar.IconRightZoom = 0D;
            this._exitStrategiesSideBar.IconVisible = false;
            this._exitStrategiesSideBar.IconZoom = 90D;
            this._exitStrategiesSideBar.IsTab = false;
            this._exitStrategiesSideBar.Location = new System.Drawing.Point(0, 433);
            this._exitStrategiesSideBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._exitStrategiesSideBar.Name = "_exitStrategiesSideBar";
            this._exitStrategiesSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._exitStrategiesSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._exitStrategiesSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._exitStrategiesSideBar.selected = false;
            this._exitStrategiesSideBar.Size = new System.Drawing.Size(263, 36);
            this._exitStrategiesSideBar.TabIndex = 8;
            this._exitStrategiesSideBar.Text = "Estrategías de salidas";
            this._exitStrategiesSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._exitStrategiesSideBar.Textcolor = System.Drawing.Color.White;
            this._exitStrategiesSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitStrategiesSideBar.Click += new System.EventHandler(this._exitStrategiesSideBar_Click);
            // 
            // _postersSideBar
            // 
            this._postersSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._postersSideBar.BackColor = System.Drawing.Color.Transparent;
            this._postersSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._postersSideBar.BorderRadius = 0;
            this._postersSideBar.ButtonText = "Porters";
            this._postersSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._postersSideBar.DisabledColor = System.Drawing.Color.Gray;
            this._postersSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._postersSideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_postersSideBar.Iconimage")));
            this._postersSideBar.Iconimage_right = null;
            this._postersSideBar.Iconimage_right_Selected = null;
            this._postersSideBar.Iconimage_Selected = null;
            this._postersSideBar.IconMarginLeft = 0;
            this._postersSideBar.IconMarginRight = 0;
            this._postersSideBar.IconRightVisible = true;
            this._postersSideBar.IconRightZoom = 0D;
            this._postersSideBar.IconVisible = false;
            this._postersSideBar.IconZoom = 90D;
            this._postersSideBar.IsTab = false;
            this._postersSideBar.Location = new System.Drawing.Point(0, 378);
            this._postersSideBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._postersSideBar.Name = "_postersSideBar";
            this._postersSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._postersSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._postersSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._postersSideBar.selected = false;
            this._postersSideBar.Size = new System.Drawing.Size(263, 36);
            this._postersSideBar.TabIndex = 7;
            this._postersSideBar.Text = "Porters";
            this._postersSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._postersSideBar.Textcolor = System.Drawing.Color.White;
            this._postersSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._postersSideBar.Click += new System.EventHandler(this._postersSideBar_Click);
            // 
            // _pilotsSolutionsSideBar
            // 
            this._pilotsSolutionsSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._pilotsSolutionsSideBar.BackColor = System.Drawing.Color.Transparent;
            this._pilotsSolutionsSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pilotsSolutionsSideBar.BorderRadius = 0;
            this._pilotsSolutionsSideBar.ButtonText = "Implementación de soluciones pilotos";
            this._pilotsSolutionsSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._pilotsSolutionsSideBar.DisabledColor = System.Drawing.Color.Gray;
            this._pilotsSolutionsSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._pilotsSolutionsSideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_pilotsSolutionsSideBar.Iconimage")));
            this._pilotsSolutionsSideBar.Iconimage_right = null;
            this._pilotsSolutionsSideBar.Iconimage_right_Selected = null;
            this._pilotsSolutionsSideBar.Iconimage_Selected = null;
            this._pilotsSolutionsSideBar.IconMarginLeft = 0;
            this._pilotsSolutionsSideBar.IconMarginRight = 0;
            this._pilotsSolutionsSideBar.IconRightVisible = true;
            this._pilotsSolutionsSideBar.IconRightZoom = 0D;
            this._pilotsSolutionsSideBar.IconVisible = false;
            this._pilotsSolutionsSideBar.IconZoom = 90D;
            this._pilotsSolutionsSideBar.IsTab = false;
            this._pilotsSolutionsSideBar.Location = new System.Drawing.Point(0, 318);
            this._pilotsSolutionsSideBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._pilotsSolutionsSideBar.Name = "_pilotsSolutionsSideBar";
            this._pilotsSolutionsSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._pilotsSolutionsSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._pilotsSolutionsSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._pilotsSolutionsSideBar.selected = false;
            this._pilotsSolutionsSideBar.Size = new System.Drawing.Size(263, 36);
            this._pilotsSolutionsSideBar.TabIndex = 6;
            this._pilotsSolutionsSideBar.Text = "Implementación de soluciones pilotos";
            this._pilotsSolutionsSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._pilotsSolutionsSideBar.Textcolor = System.Drawing.Color.White;
            this._pilotsSolutionsSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pilotsSolutionsSideBar.Click += new System.EventHandler(this._pilotsSolutionsSideBar_Click);
            // 
            // _componentsSideBar
            // 
            this._componentsSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._componentsSideBar.BackColor = System.Drawing.Color.Transparent;
            this._componentsSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._componentsSideBar.BorderRadius = 0;
            this._componentsSideBar.ButtonText = "Componentes";
            this._componentsSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._componentsSideBar.DisabledColor = System.Drawing.Color.Gray;
            this._componentsSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._componentsSideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_componentsSideBar.Iconimage")));
            this._componentsSideBar.Iconimage_right = null;
            this._componentsSideBar.Iconimage_right_Selected = null;
            this._componentsSideBar.Iconimage_Selected = null;
            this._componentsSideBar.IconMarginLeft = 0;
            this._componentsSideBar.IconMarginRight = 0;
            this._componentsSideBar.IconRightVisible = true;
            this._componentsSideBar.IconRightZoom = 0D;
            this._componentsSideBar.IconVisible = false;
            this._componentsSideBar.IconZoom = 90D;
            this._componentsSideBar.IsTab = false;
            this._componentsSideBar.Location = new System.Drawing.Point(0, 250);
            this._componentsSideBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._componentsSideBar.Name = "_componentsSideBar";
            this._componentsSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._componentsSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._componentsSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._componentsSideBar.selected = false;
            this._componentsSideBar.Size = new System.Drawing.Size(263, 36);
            this._componentsSideBar.TabIndex = 5;
            this._componentsSideBar.Text = "Componentes";
            this._componentsSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._componentsSideBar.Textcolor = System.Drawing.Color.White;
            this._componentsSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._componentsSideBar.Click += new System.EventHandler(this._componentsSideBar_Click);
            // 
            // _sumarySideBar
            // 
            this._sumarySideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._sumarySideBar.BackColor = System.Drawing.Color.Transparent;
            this._sumarySideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._sumarySideBar.BorderRadius = 0;
            this._sumarySideBar.ButtonText = "Resumen Ejecutivo";
            this._sumarySideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._sumarySideBar.DisabledColor = System.Drawing.Color.Gray;
            this._sumarySideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._sumarySideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_sumarySideBar.Iconimage")));
            this._sumarySideBar.Iconimage_right = null;
            this._sumarySideBar.Iconimage_right_Selected = null;
            this._sumarySideBar.Iconimage_Selected = null;
            this._sumarySideBar.IconMarginLeft = 0;
            this._sumarySideBar.IconMarginRight = 0;
            this._sumarySideBar.IconRightVisible = true;
            this._sumarySideBar.IconRightZoom = 0D;
            this._sumarySideBar.IconVisible = false;
            this._sumarySideBar.IconZoom = 90D;
            this._sumarySideBar.IsTab = false;
            this._sumarySideBar.Location = new System.Drawing.Point(0, 204);
            this._sumarySideBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._sumarySideBar.Name = "_sumarySideBar";
            this._sumarySideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._sumarySideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._sumarySideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._sumarySideBar.selected = false;
            this._sumarySideBar.Size = new System.Drawing.Size(263, 36);
            this._sumarySideBar.TabIndex = 4;
            this._sumarySideBar.Text = "Resumen Ejecutivo";
            this._sumarySideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._sumarySideBar.Textcolor = System.Drawing.Color.White;
            this._sumarySideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sumarySideBar.Click += new System.EventHandler(this._sumarySideBar_Click);
            // 
            // _reportEndSideBar
            // 
            this._reportEndSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._reportEndSideBar.BackColor = System.Drawing.Color.Transparent;
            this._reportEndSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._reportEndSideBar.BorderRadius = 0;
            this._reportEndSideBar.ButtonText = "Informe Final";
            this._reportEndSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._reportEndSideBar.DisabledColor = System.Drawing.Color.Gray;
            this._reportEndSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._reportEndSideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_reportEndSideBar.Iconimage")));
            this._reportEndSideBar.Iconimage_right = null;
            this._reportEndSideBar.Iconimage_right_Selected = null;
            this._reportEndSideBar.Iconimage_Selected = null;
            this._reportEndSideBar.IconMarginLeft = 0;
            this._reportEndSideBar.IconMarginRight = 0;
            this._reportEndSideBar.IconRightVisible = true;
            this._reportEndSideBar.IconRightZoom = 0D;
            this._reportEndSideBar.IconVisible = false;
            this._reportEndSideBar.IconZoom = 90D;
            this._reportEndSideBar.IsTab = false;
            this._reportEndSideBar.Location = new System.Drawing.Point(0, 150);
            this._reportEndSideBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._reportEndSideBar.Name = "_reportEndSideBar";
            this._reportEndSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._reportEndSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._reportEndSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._reportEndSideBar.selected = false;
            this._reportEndSideBar.Size = new System.Drawing.Size(263, 36);
            this._reportEndSideBar.TabIndex = 3;
            this._reportEndSideBar.Text = "Informe Final";
            this._reportEndSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._reportEndSideBar.Textcolor = System.Drawing.Color.White;
            this._reportEndSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reportEndSideBar.Click += new System.EventHandler(this._reportEndSideBar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(300, 46);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(347, 25);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Economía y Finanzas para la Biodiversidad";
            // 
            // _radioComponent_1
            // 
            this._radioComponent_1.AutoSize = true;
            this._radioComponent_1.Location = new System.Drawing.Point(653, 183);
            this._radioComponent_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._radioComponent_1.Name = "_radioComponent_1";
            this._radioComponent_1.Size = new System.Drawing.Size(110, 17);
            this._radioComponent_1.TabIndex = 17;
            this._radioComponent_1.Text = "Componente 1";
            this._radioComponent_1.UseSelectable = true;
            // 
            // _radioComponent_2
            // 
            this._radioComponent_2.AutoSize = true;
            this._radioComponent_2.Location = new System.Drawing.Point(653, 209);
            this._radioComponent_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._radioComponent_2.Name = "_radioComponent_2";
            this._radioComponent_2.Size = new System.Drawing.Size(110, 17);
            this._radioComponent_2.TabIndex = 18;
            this._radioComponent_2.Text = "Componente 2";
            this._radioComponent_2.UseSelectable = true;
            // 
            // _radioComponent_3
            // 
            this._radioComponent_3.AutoSize = true;
            this._radioComponent_3.Location = new System.Drawing.Point(817, 183);
            this._radioComponent_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._radioComponent_3.Name = "_radioComponent_3";
            this._radioComponent_3.Size = new System.Drawing.Size(110, 17);
            this._radioComponent_3.TabIndex = 19;
            this._radioComponent_3.Text = "Componente 3";
            this._radioComponent_3.UseSelectable = true;
            // 
            // _radioComponent_4
            // 
            this._radioComponent_4.AutoSize = true;
            this._radioComponent_4.Location = new System.Drawing.Point(817, 209);
            this._radioComponent_4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._radioComponent_4.Name = "_radioComponent_4";
            this._radioComponent_4.Size = new System.Drawing.Size(110, 17);
            this._radioComponent_4.TabIndex = 20;
            this._radioComponent_4.Text = "Componente 4";
            this._radioComponent_4.UseSelectable = true;
            // 
            // _radioMultimedia
            // 
            this._radioMultimedia.AutoSize = true;
            this._radioMultimedia.Checked = true;
            this._radioMultimedia.Location = new System.Drawing.Point(737, 164);
            this._radioMultimedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._radioMultimedia.Name = "_radioMultimedia";
            this._radioMultimedia.Size = new System.Drawing.Size(89, 17);
            this._radioMultimedia.TabIndex = 21;
            this._radioMultimedia.TabStop = true;
            this._radioMultimedia.Text = "Multimedia";
            this._radioMultimedia.UseSelectable = true;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 738);
            this.Controls.Add(this._radioMultimedia);
            this.Controls.Add(this._radioComponent_4);
            this.Controls.Add(this._radioComponent_3);
            this.Controls.Add(this._radioComponent_2);
            this.Controls.Add(this._radioComponent_1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBoxTesis);
            this.Controls.Add(this.pictureBoxLibros);
            this.Controls.Add(this.pictureBoxArticulos);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.metroTextBoxSearch);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.TransparencyKey = System.Drawing.Color.SteelBlue;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosed);
            this.Load += new System.EventHandler(this.FormStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxArticulos;
        private System.Windows.Forms.PictureBox pictureBoxLibros;
        private System.Windows.Forms.PictureBox pictureBoxTesis;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton _reportEndSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton _gallerySideBar;
        private Bunifu.Framework.UI.BunifuFlatButton _lectionsSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton _exitStrategiesSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton _postersSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton _pilotsSolutionsSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton _componentsSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton _sumarySideBar;
        private MetroFramework.Controls.MetroRadioButton _radioComponent_1;
        private MetroFramework.Controls.MetroRadioButton _radioComponent_2;
        private MetroFramework.Controls.MetroRadioButton _radioComponent_3;
        private MetroFramework.Controls.MetroRadioButton _radioComponent_4;
        private MetroFramework.Controls.MetroRadioButton _radioMultimedia;
    }
}

