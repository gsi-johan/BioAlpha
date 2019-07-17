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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.galleryCienaga = new System.Windows.Forms.PictureBox();
            this.accordionCienaga = new TestGallery.ImageAccordion();
            this.galleryGC = new System.Windows.Forms.PictureBox();
            this.accordionGC = new TestGallery.ImageAccordion();
            this.linkTarifas = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryCienaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryGC)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(-6, 75);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(851, 592);
            this.metroTabControl1.TabIndex = 11;
            this.metroTabControl1.UseSelectable = true;
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
            // 
            // linkTarifas
            // 
            this.linkTarifas.Location = new System.Drawing.Point(707, 85);
            this.linkTarifas.Name = "linkTarifas";
            this.linkTarifas.Size = new System.Drawing.Size(118, 23);
            this.linkTarifas.TabIndex = 12;
            this.linkTarifas.Text = "Tarifa Financiera";
            this.linkTarifas.UseSelectable = true;
            this.linkTarifas.Click += new System.EventHandler(this.linkTarifas_Click);
            // 
            // Sites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 662);
            this.Controls.Add(this.linkTarifas);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sites";
            this.Resizable = false;
            this.Text = "Sitios";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryCienaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryGC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox galleryCienaga;
        private TestGallery.ImageAccordion accordionCienaga;
        private System.Windows.Forms.PictureBox galleryGC;
        private TestGallery.ImageAccordion accordionGC;
        private MetroFramework.Controls.MetroLink linkTarifas;
    }
}
