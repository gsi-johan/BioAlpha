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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this._virtualBiblioSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._gallerySideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._lectionsSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._exitStrategiesSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._postersSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._pilotsSolutionsSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._componentsSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._sumarySideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this._reportEndSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ctxMenuComponentes = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.componente1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componente2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componente3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componente4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.allBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.componentsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.appBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.componentABtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.componentBBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.componentCBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.componentDBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.ctxMenuComponentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBoxSearch
            // 
            // 
            // 
            // 
            this.metroTextBoxSearch.CustomButton.Image = null;
            this.metroTextBoxSearch.CustomButton.Location = new System.Drawing.Point(647, 2);
            this.metroTextBoxSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxSearch.CustomButton.Name = "";
            this.metroTextBoxSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSearch.CustomButton.TabIndex = 1;
            this.metroTextBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSearch.CustomButton.UseSelectable = true;
            this.metroTextBoxSearch.CustomButton.Visible = false;
            this.metroTextBoxSearch.Lines = new string[0];
            this.metroTextBoxSearch.Location = new System.Drawing.Point(463, 166);
            this.metroTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxSearch.MaxLength = 32767;
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.PasswordChar = '\0';
            this.metroTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearch.SelectedText = "";
            this.metroTextBoxSearch.SelectionLength = 0;
            this.metroTextBoxSearch.SelectionStart = 0;
            this.metroTextBoxSearch.ShortcutsEnabled = true;
            this.metroTextBoxSearch.Size = new System.Drawing.Size(675, 30);
            this.metroTextBoxSearch.TabIndex = 8;
            this.metroTextBoxSearch.UseSelectable = true;
            this.metroTextBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxSearch_KeyPress);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackgroundImage = global::BibliotecaVirtual.Properties.Resources.search;
            this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxSearch.Location = new System.Drawing.Point(1108, 169);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(4);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1067, 197);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(469, 139);
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
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Controls.Add(this._virtualBiblioSideBar);
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
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 100;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(263, 734);
            this.bunifuGradientPanel1.TabIndex = 14;
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Resoluciones";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(5, 124);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(263, 36);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "Resoluciones";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // _virtualBiblioSideBar
            // 
            this._virtualBiblioSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
            this._virtualBiblioSideBar.BackColor = System.Drawing.Color.Transparent;
            this._virtualBiblioSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._virtualBiblioSideBar.BorderRadius = 0;
            this._virtualBiblioSideBar.ButtonText = "Biblioteca Virtual";
            this._virtualBiblioSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._virtualBiblioSideBar.DisabledColor = System.Drawing.Color.Gray;
            this._virtualBiblioSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this._virtualBiblioSideBar.Iconimage = ((System.Drawing.Image)(resources.GetObject("_virtualBiblioSideBar.Iconimage")));
            this._virtualBiblioSideBar.Iconimage_right = null;
            this._virtualBiblioSideBar.Iconimage_right_Selected = null;
            this._virtualBiblioSideBar.Iconimage_Selected = null;
            this._virtualBiblioSideBar.IconMarginLeft = 0;
            this._virtualBiblioSideBar.IconMarginRight = 0;
            this._virtualBiblioSideBar.IconRightVisible = true;
            this._virtualBiblioSideBar.IconRightZoom = 0D;
            this._virtualBiblioSideBar.IconVisible = false;
            this._virtualBiblioSideBar.IconZoom = 90D;
            this._virtualBiblioSideBar.IsTab = false;
            this._virtualBiblioSideBar.Location = new System.Drawing.Point(-5, 631);
            this._virtualBiblioSideBar.Margin = new System.Windows.Forms.Padding(5);
            this._virtualBiblioSideBar.Name = "_virtualBiblioSideBar";
            this._virtualBiblioSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._virtualBiblioSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._virtualBiblioSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._virtualBiblioSideBar.selected = false;
            this._virtualBiblioSideBar.Size = new System.Drawing.Size(263, 36);
            this._virtualBiblioSideBar.TabIndex = 11;
            this._virtualBiblioSideBar.Text = "Biblioteca Virtual";
            this._virtualBiblioSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._virtualBiblioSideBar.Textcolor = System.Drawing.Color.White;
            this._virtualBiblioSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._virtualBiblioSideBar.Click += new System.EventHandler(this._virtualBiblioSideBar_Click);
            // 
            // _gallerySideBar
            // 
            this._gallerySideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
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
            this._gallerySideBar.Location = new System.Drawing.Point(0, 574);
            this._gallerySideBar.Margin = new System.Windows.Forms.Padding(5);
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
            this._gallerySideBar.Click += new System.EventHandler(this._gallerySideBar_Click);
            // 
            // _lectionsSideBar
            // 
            this._lectionsSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
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
            this._lectionsSideBar.Location = new System.Drawing.Point(0, 516);
            this._lectionsSideBar.Margin = new System.Windows.Forms.Padding(5);
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
            this._exitStrategiesSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
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
            this._exitStrategiesSideBar.Location = new System.Drawing.Point(0, 453);
            this._exitStrategiesSideBar.Margin = new System.Windows.Forms.Padding(5);
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
            this._postersSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
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
            this._postersSideBar.Location = new System.Drawing.Point(0, 398);
            this._postersSideBar.Margin = new System.Windows.Forms.Padding(5);
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
            this._pilotsSolutionsSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
            this._pilotsSolutionsSideBar.BackColor = System.Drawing.Color.Transparent;
            this._pilotsSolutionsSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._pilotsSolutionsSideBar.BorderRadius = 0;
            this._pilotsSolutionsSideBar.ButtonText = "Implementación de sitios pilotos";
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
            this._pilotsSolutionsSideBar.Location = new System.Drawing.Point(0, 337);
            this._pilotsSolutionsSideBar.Margin = new System.Windows.Forms.Padding(5);
            this._pilotsSolutionsSideBar.Name = "_pilotsSolutionsSideBar";
            this._pilotsSolutionsSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._pilotsSolutionsSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._pilotsSolutionsSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._pilotsSolutionsSideBar.selected = false;
            this._pilotsSolutionsSideBar.Size = new System.Drawing.Size(263, 36);
            this._pilotsSolutionsSideBar.TabIndex = 6;
            this._pilotsSolutionsSideBar.Text = "Implementación de sitios pilotos";
            this._pilotsSolutionsSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._pilotsSolutionsSideBar.Textcolor = System.Drawing.Color.White;
            this._pilotsSolutionsSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pilotsSolutionsSideBar.Click += new System.EventHandler(this._pilotsSolutionsSideBar_Click);
            // 
            // _componentsSideBar
            // 
            this._componentsSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
            this._componentsSideBar.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this._componentsSideBar.BackColor = System.Drawing.Color.Transparent;
            this._componentsSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._componentsSideBar.BorderRadius = 0;
            this._componentsSideBar.ButtonText = "Informes por Componentes";
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
            this._componentsSideBar.Location = new System.Drawing.Point(0, 270);
            this._componentsSideBar.Margin = new System.Windows.Forms.Padding(5);
            this._componentsSideBar.Name = "_componentsSideBar";
            this._componentsSideBar.Normalcolor = System.Drawing.Color.Transparent;
            this._componentsSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this._componentsSideBar.OnHoverTextColor = System.Drawing.Color.White;
            this._componentsSideBar.selected = false;
            this._componentsSideBar.Size = new System.Drawing.Size(263, 36);
            this._componentsSideBar.TabIndex = 5;
            this._componentsSideBar.Text = "Informes por Componentes";
            this._componentsSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._componentsSideBar.Textcolor = System.Drawing.Color.White;
            this._componentsSideBar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._componentsSideBar.Click += new System.EventHandler(this._componentsSideBar_Click);
            this._componentsSideBar.MouseLeave += new System.EventHandler(this._componentsSideBar_MouseLeave);
            // 
            // _sumarySideBar
            // 
            this._sumarySideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
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
            this._sumarySideBar.Location = new System.Drawing.Point(0, 224);
            this._sumarySideBar.Margin = new System.Windows.Forms.Padding(5);
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
            this._reportEndSideBar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(10)))));
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
            this._reportEndSideBar.Location = new System.Drawing.Point(0, 171);
            this._reportEndSideBar.Margin = new System.Windows.Forms.Padding(5);
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
            // ctxMenuComponentes
            // 
            this.ctxMenuComponentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(106)))), ((int)(((byte)(132)))));
            this.ctxMenuComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ctxMenuComponentes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuComponentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componente1ToolStripMenuItem,
            this.componente2ToolStripMenuItem,
            this.componente3ToolStripMenuItem,
            this.componente4ToolStripMenuItem});
            this.ctxMenuComponentes.Name = "ctxMenuComponentes";
            this.ctxMenuComponentes.ShowImageMargin = false;
            this.ctxMenuComponentes.Size = new System.Drawing.Size(144, 92);
            this.ctxMenuComponentes.MouseLeave += new System.EventHandler(this.ctxMenuComponentes_MouseLeave);
            this.ctxMenuComponentes.MouseHover += new System.EventHandler(this.ctxMenuComponentes_MouseHover);
            // 
            // componente1ToolStripMenuItem
            // 
            this.componente1ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.componente1ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.componente1ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.componente1ToolStripMenuItem.Name = "componente1ToolStripMenuItem";
            this.componente1ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.componente1ToolStripMenuItem.Text = "Componente 1";
            this.componente1ToolStripMenuItem.Click += new System.EventHandler(this.componente1ToolStripMenuItem_Click);
            // 
            // componente2ToolStripMenuItem
            // 
            this.componente2ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.componente2ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.componente2ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.componente2ToolStripMenuItem.Name = "componente2ToolStripMenuItem";
            this.componente2ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.componente2ToolStripMenuItem.Text = "Componente 2";
            this.componente2ToolStripMenuItem.Click += new System.EventHandler(this.componente2ToolStripMenuItem_Click);
            // 
            // componente3ToolStripMenuItem
            // 
            this.componente3ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.componente3ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.componente3ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.componente3ToolStripMenuItem.Name = "componente3ToolStripMenuItem";
            this.componente3ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.componente3ToolStripMenuItem.Text = "Componente 3";
            this.componente3ToolStripMenuItem.Click += new System.EventHandler(this.componente3ToolStripMenuItem_Click);
            // 
            // componente4ToolStripMenuItem
            // 
            this.componente4ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.componente4ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.componente4ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.componente4ToolStripMenuItem.Name = "componente4ToolStripMenuItem";
            this.componente4ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.componente4ToolStripMenuItem.Text = "Componente 4";
            this.componente4ToolStripMenuItem.Click += new System.EventHandler(this.componente4ToolStripMenuItem_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.metroLabel3.Location = new System.Drawing.Point(1239, 30);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 20);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "About 1";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.metroLabel4.Location = new System.Drawing.Point(1156, 30);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 20);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "About 2";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // allBtn
            // 
            this.allBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.allBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.allBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allBtn.BorderRadius = 0;
            this.allBtn.ButtonText = "Todo";
            this.allBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allBtn.DisabledColor = System.Drawing.Color.Gray;
            this.allBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.allBtn.Iconimage = null;
            this.allBtn.Iconimage_right = null;
            this.allBtn.Iconimage_right_Selected = null;
            this.allBtn.Iconimage_Selected = null;
            this.allBtn.IconMarginLeft = 0;
            this.allBtn.IconMarginRight = 0;
            this.allBtn.IconRightVisible = true;
            this.allBtn.IconRightZoom = 0D;
            this.allBtn.IconVisible = true;
            this.allBtn.IconZoom = 90D;
            this.allBtn.IsTab = false;
            this.allBtn.Location = new System.Drawing.Point(307, 254);
            this.allBtn.Margin = new System.Windows.Forms.Padding(5);
            this.allBtn.Name = "allBtn";
            this.allBtn.Normalcolor = System.Drawing.Color.SeaGreen;
            this.allBtn.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.allBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.allBtn.selected = false;
            this.allBtn.Size = new System.Drawing.Size(289, 89);
            this.allBtn.TabIndex = 26;
            this.allBtn.Text = "Todo";
            this.allBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allBtn.Textcolor = System.Drawing.Color.White;
            this.allBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // componentsBtn
            // 
            this.componentsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.componentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.componentsBtn.BorderRadius = 0;
            this.componentsBtn.ButtonText = "Componentes";
            this.componentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.componentsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.componentsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.componentsBtn.Iconimage = null;
            this.componentsBtn.Iconimage_right = null;
            this.componentsBtn.Iconimage_right_Selected = null;
            this.componentsBtn.Iconimage_Selected = null;
            this.componentsBtn.IconMarginLeft = 0;
            this.componentsBtn.IconMarginRight = 0;
            this.componentsBtn.IconRightVisible = true;
            this.componentsBtn.IconRightZoom = 0D;
            this.componentsBtn.IconVisible = true;
            this.componentsBtn.IconZoom = 90D;
            this.componentsBtn.IsTab = false;
            this.componentsBtn.Location = new System.Drawing.Point(667, 254);
            this.componentsBtn.Margin = new System.Windows.Forms.Padding(5);
            this.componentsBtn.Name = "componentsBtn";
            this.componentsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.componentsBtn.selected = false;
            this.componentsBtn.Size = new System.Drawing.Size(289, 89);
            this.componentsBtn.TabIndex = 27;
            this.componentsBtn.Text = "Componentes";
            this.componentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.componentsBtn.Textcolor = System.Drawing.Color.White;
            this.componentsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsBtn.Click += new System.EventHandler(this.componentsBtn_Click);
            // 
            // appBtn
            // 
            this.appBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.appBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.appBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.appBtn.BorderRadius = 0;
            this.appBtn.ButtonText = "Multimedia";
            this.appBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appBtn.DisabledColor = System.Drawing.Color.Gray;
            this.appBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.appBtn.Iconimage = null;
            this.appBtn.Iconimage_right = null;
            this.appBtn.Iconimage_right_Selected = null;
            this.appBtn.Iconimage_Selected = null;
            this.appBtn.IconMarginLeft = 0;
            this.appBtn.IconMarginRight = 0;
            this.appBtn.IconRightVisible = true;
            this.appBtn.IconRightZoom = 0D;
            this.appBtn.IconVisible = true;
            this.appBtn.IconZoom = 90D;
            this.appBtn.IsTab = false;
            this.appBtn.Location = new System.Drawing.Point(1013, 254);
            this.appBtn.Margin = new System.Windows.Forms.Padding(5);
            this.appBtn.Name = "appBtn";
            this.appBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.appBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.appBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.appBtn.selected = false;
            this.appBtn.Size = new System.Drawing.Size(289, 89);
            this.appBtn.TabIndex = 28;
            this.appBtn.Text = "Multimedia";
            this.appBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appBtn.Textcolor = System.Drawing.Color.White;
            this.appBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appBtn.Click += new System.EventHandler(this.appBtn_Click);
            // 
            // componentABtn
            // 
            this.componentABtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.componentABtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentABtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.componentABtn.BorderRadius = 0;
            this.componentABtn.ButtonText = "Componente 1";
            this.componentABtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.componentABtn.DisabledColor = System.Drawing.Color.Gray;
            this.componentABtn.Iconcolor = System.Drawing.Color.Transparent;
            this.componentABtn.Iconimage = null;
            this.componentABtn.Iconimage_right = null;
            this.componentABtn.Iconimage_right_Selected = null;
            this.componentABtn.Iconimage_Selected = null;
            this.componentABtn.IconMarginLeft = 0;
            this.componentABtn.IconMarginRight = 0;
            this.componentABtn.IconRightVisible = true;
            this.componentABtn.IconRightZoom = 0D;
            this.componentABtn.IconVisible = true;
            this.componentABtn.IconZoom = 90D;
            this.componentABtn.IsTab = false;
            this.componentABtn.Location = new System.Drawing.Point(328, 401);
            this.componentABtn.Margin = new System.Windows.Forms.Padding(5);
            this.componentABtn.Name = "componentABtn";
            this.componentABtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentABtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentABtn.OnHoverTextColor = System.Drawing.Color.White;
            this.componentABtn.selected = false;
            this.componentABtn.Size = new System.Drawing.Size(175, 89);
            this.componentABtn.TabIndex = 29;
            this.componentABtn.Text = "Componente 1";
            this.componentABtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.componentABtn.Textcolor = System.Drawing.Color.White;
            this.componentABtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentABtn.Click += new System.EventHandler(this.componentABtn_Click);
            // 
            // componentBBtn
            // 
            this.componentBBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.componentBBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentBBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.componentBBtn.BorderRadius = 0;
            this.componentBBtn.ButtonText = "Componente 2";
            this.componentBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.componentBBtn.DisabledColor = System.Drawing.Color.Gray;
            this.componentBBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.componentBBtn.Iconimage = null;
            this.componentBBtn.Iconimage_right = null;
            this.componentBBtn.Iconimage_right_Selected = null;
            this.componentBBtn.Iconimage_Selected = null;
            this.componentBBtn.IconMarginLeft = 0;
            this.componentBBtn.IconMarginRight = 0;
            this.componentBBtn.IconRightVisible = true;
            this.componentBBtn.IconRightZoom = 0D;
            this.componentBBtn.IconVisible = true;
            this.componentBBtn.IconZoom = 90D;
            this.componentBBtn.IsTab = false;
            this.componentBBtn.Location = new System.Drawing.Point(576, 401);
            this.componentBBtn.Margin = new System.Windows.Forms.Padding(5);
            this.componentBBtn.Name = "componentBBtn";
            this.componentBBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentBBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentBBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.componentBBtn.selected = false;
            this.componentBBtn.Size = new System.Drawing.Size(175, 89);
            this.componentBBtn.TabIndex = 30;
            this.componentBBtn.Text = "Componente 2";
            this.componentBBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.componentBBtn.Textcolor = System.Drawing.Color.White;
            this.componentBBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentBBtn.Click += new System.EventHandler(this.componentBBtn_Click);
            // 
            // componentCBtn
            // 
            this.componentCBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.componentCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentCBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.componentCBtn.BorderRadius = 0;
            this.componentCBtn.ButtonText = "Componente 3";
            this.componentCBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.componentCBtn.DisabledColor = System.Drawing.Color.Gray;
            this.componentCBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.componentCBtn.Iconimage = null;
            this.componentCBtn.Iconimage_right = null;
            this.componentCBtn.Iconimage_right_Selected = null;
            this.componentCBtn.Iconimage_Selected = null;
            this.componentCBtn.IconMarginLeft = 0;
            this.componentCBtn.IconMarginRight = 0;
            this.componentCBtn.IconRightVisible = true;
            this.componentCBtn.IconRightZoom = 0D;
            this.componentCBtn.IconVisible = true;
            this.componentCBtn.IconZoom = 90D;
            this.componentCBtn.IsTab = false;
            this.componentCBtn.Location = new System.Drawing.Point(824, 401);
            this.componentCBtn.Margin = new System.Windows.Forms.Padding(5);
            this.componentCBtn.Name = "componentCBtn";
            this.componentCBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentCBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentCBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.componentCBtn.selected = false;
            this.componentCBtn.Size = new System.Drawing.Size(175, 89);
            this.componentCBtn.TabIndex = 31;
            this.componentCBtn.Text = "Componente 3";
            this.componentCBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.componentCBtn.Textcolor = System.Drawing.Color.White;
            this.componentCBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentCBtn.Click += new System.EventHandler(this.componentCBtn_Click);
            // 
            // componentDBtn
            // 
            this.componentDBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.componentDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.componentDBtn.BorderRadius = 0;
            this.componentDBtn.ButtonText = "Componente 4";
            this.componentDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.componentDBtn.DisabledColor = System.Drawing.Color.Gray;
            this.componentDBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.componentDBtn.Iconimage = null;
            this.componentDBtn.Iconimage_right = null;
            this.componentDBtn.Iconimage_right_Selected = null;
            this.componentDBtn.Iconimage_Selected = null;
            this.componentDBtn.IconMarginLeft = 0;
            this.componentDBtn.IconMarginRight = 0;
            this.componentDBtn.IconRightVisible = true;
            this.componentDBtn.IconRightZoom = 0D;
            this.componentDBtn.IconVisible = true;
            this.componentDBtn.IconZoom = 90D;
            this.componentDBtn.IsTab = false;
            this.componentDBtn.Location = new System.Drawing.Point(1063, 401);
            this.componentDBtn.Margin = new System.Windows.Forms.Padding(5);
            this.componentDBtn.Name = "componentDBtn";
            this.componentDBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentDBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.componentDBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.componentDBtn.selected = false;
            this.componentDBtn.Size = new System.Drawing.Size(175, 89);
            this.componentDBtn.TabIndex = 32;
            this.componentDBtn.Text = "Componente 4";
            this.componentDBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.componentDBtn.Textcolor = System.Drawing.Color.White;
            this.componentDBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentDBtn.Click += new System.EventHandler(this.componentDBtn_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(307, 213);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(32, 20);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "En :";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 738);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.componentDBtn);
            this.Controls.Add(this.componentCBtn);
            this.Controls.Add(this.componentBBtn);
            this.Controls.Add(this.componentABtn);
            this.Controls.Add(this.appBtn);
            this.Controls.Add(this.componentsBtn);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.metroTextBoxSearch);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.TransparencyKey = System.Drawing.Color.SteelBlue;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosed);
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormStart_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ctxMenuComponentes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Bunifu.Framework.UI.BunifuFlatButton _virtualBiblioSideBar;
        private MetroFramework.Controls.MetroContextMenu ctxMenuComponentes;
        private System.Windows.Forms.ToolStripMenuItem componente1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componente2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componente3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componente4ToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton allBtn;
        private Bunifu.Framework.UI.BunifuFlatButton componentsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton appBtn;
        private Bunifu.Framework.UI.BunifuFlatButton componentABtn;
        private Bunifu.Framework.UI.BunifuFlatButton componentBBtn;
        private Bunifu.Framework.UI.BunifuFlatButton componentCBtn;
        private Bunifu.Framework.UI.BunifuFlatButton componentDBtn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

