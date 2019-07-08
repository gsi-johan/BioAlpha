namespace BibliotecaVirtual.Forms
{
    partial class Loaded
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loaded));
            this.footerPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.IniciativaLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.footerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // footerPictureBox
            // 
            this.footerPictureBox.Image = global::BibliotecaVirtual.Properties.Resources.FooterFull;
            this.footerPictureBox.Location = new System.Drawing.Point(-5, 206);
            this.footerPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.footerPictureBox.Name = "footerPictureBox";
            this.footerPictureBox.Size = new System.Drawing.Size(968, 241);
            this.footerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.footerPictureBox.TabIndex = 24;
            this.footerPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(899, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BibliotecaVirtual.Properties.Resources.LogoColor;
            this.pictureBox2.Location = new System.Drawing.Point(534, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // IniciativaLabel
            // 
            this.IniciativaLabel.AutoSize = true;
            this.IniciativaLabel.BackColor = System.Drawing.Color.Transparent;
            this.IniciativaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciativaLabel.ForeColor = System.Drawing.Color.DimGray;
            this.IniciativaLabel.Location = new System.Drawing.Point(543, 195);
            this.IniciativaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IniciativaLabel.Name = "IniciativaLabel";
            this.IniciativaLabel.Size = new System.Drawing.Size(362, 19);
            this.IniciativaLabel.TabIndex = 28;
            this.IniciativaLabel.Text = "Desarrollado como parte de la iniciativa BIOFIN en Cuba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(305, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "Iniciativa Biofin Cuba";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Loaded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IniciativaLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.footerPictureBox);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Loaded";
            this.Padding = new System.Windows.Forms.Padding(27, 37, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Loaded_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox footerPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label IniciativaLabel;
        private System.Windows.Forms.Label label3;
    }
}