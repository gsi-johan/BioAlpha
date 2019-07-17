namespace BibliotecaVirtual.Forms.Initiative
{
    partial class Sites
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabSites = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.galleryCienaga = new System.Windows.Forms.PictureBox();
            this.accordionCienaga = new TestGallery.ImageAccordion();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.galleryGC = new System.Windows.Forms.PictureBox();
            this.accordionGC = new TestGallery.ImageAccordion();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TabSites.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryCienaga)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryGC)).BeginInit();
            this.SuspendLayout();
            // 
            // TabSites
            // 
            this.TabSites.Controls.Add(this.tabPage1);
            this.TabSites.Controls.Add(this.tabPage2);
            this.TabSites.Location = new System.Drawing.Point(-6, 75);
            this.TabSites.Name = "TabSites";
            this.TabSites.SelectedIndex = 0;
            this.TabSites.Size = new System.Drawing.Size(851, 592);
            this.TabSites.TabIndex = 11;
            this.TabSites.UseSelectable = true;
            this.TabSites.SelectedIndexChanged += new System.EventHandler(this.TabSites_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.galleryCienaga);
            this.tabPage1.Controls.Add(this.accordionCienaga);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(843, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "APRM P C.Zapata";
            // 
            // galleryCienaga
            // 
            this.galleryCienaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.galleryCienaga.Location = new System.Drawing.Point(7, 3);
            this.galleryCienaga.Name = "galleryCienaga";
            this.galleryCienaga.Size = new System.Drawing.Size(830, 436);
            this.galleryCienaga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.galleryCienaga.TabIndex = 3;
            this.galleryCienaga.TabStop = false;
            // 
            // accordionCienaga
            // 
            this.accordionCienaga.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accordionCienaga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accordionCienaga.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.accordionCienaga.Location = new System.Drawing.Point(0, 445);
            this.accordionCienaga.Name = "accordionCienaga";
            this.accordionCienaga.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.accordionCienaga.Size = new System.Drawing.Size(847, 109);
            this.accordionCienaga.TabIndex = 2;
            this.accordionCienaga.ThumbnailChanged += new TestGallery.ImageAccordion.ThumbnailChangedDelegate(this.accordionCienaga_ThumbnailChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.galleryGC);
            this.tabPage2.Controls.Add(this.accordionGC);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(843, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PN P.Guanahacabibes";
            // 
            // galleryGC
            // 
            this.galleryGC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.galleryGC.Location = new System.Drawing.Point(5, 0);
            this.galleryGC.Name = "galleryGC";
            this.galleryGC.Size = new System.Drawing.Size(830, 436);
            this.galleryGC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.galleryGC.TabIndex = 5;
            this.galleryGC.TabStop = false;
            // 
            // accordionGC
            // 
            this.accordionGC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accordionGC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accordionGC.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.accordionGC.Location = new System.Drawing.Point(-2, 442);
            this.accordionGC.Name = "accordionGC";
            this.accordionGC.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.accordionGC.Size = new System.Drawing.Size(847, 109);
            this.accordionGC.TabIndex = 4;
            this.accordionGC.ThumbnailChanged += new TestGallery.ImageAccordion.ThumbnailChangedDelegate(this.accordionGC_ThumbnailChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(153)))));
            this.metroLabel4.Location = new System.Drawing.Point(694, 84);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 20);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Tarifa Financiera";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // Sites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 662);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TabSites);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sites";
            this.Resizable = false;
            this.Text = "Sitios";
            this.Load += new System.EventHandler(this.Sites_Load);
            this.TabSites.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryCienaga)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryGC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl TabSites;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox galleryCienaga;
        private TestGallery.ImageAccordion accordionCienaga;
        private System.Windows.Forms.PictureBox galleryGC;
        private TestGallery.ImageAccordion accordionGC;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
