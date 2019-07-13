namespace BibliotecaVirtual.Forms.Initiative
{
    partial class Gallery
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageAccordion1 = new TestGallery.ImageAccordion();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageAccordion1
            // 
            this.imageAccordion1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imageAccordion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageAccordion1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))));
            this.imageAccordion1.Location = new System.Drawing.Point(0, 543);
            this.imageAccordion1.Name = "imageAccordion1";
            this.imageAccordion1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.imageAccordion1.Size = new System.Drawing.Size(842, 121);
            this.imageAccordion1.TabIndex = 0;
            this.imageAccordion1.ThumbnailChanged += new TestGallery.ImageAccordion.ThumbnailChangedDelegate(this.imageAccordion2_ThumbnailChanged);
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 662);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageAccordion1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gallery";
            this.Resizable = false;
            this.Text = "Gallery";
            this.Load += new System.EventHandler(this.Gallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TestGallery.ImageAccordion imageAccordion1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}