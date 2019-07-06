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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxSearch
            // 
            // 
            // 
            // 
            this.metroTextBoxSearch.CustomButton.Image = null;
            this.metroTextBoxSearch.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.metroTextBoxSearch.CustomButton.Name = "";
            this.metroTextBoxSearch.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.metroTextBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSearch.CustomButton.TabIndex = 1;
            this.metroTextBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSearch.CustomButton.UseSelectable = true;
            this.metroTextBoxSearch.CustomButton.Visible = false;
            this.metroTextBoxSearch.Lines = new string[0];
            this.metroTextBoxSearch.Location = new System.Drawing.Point(315, 91);
            this.metroTextBoxSearch.MaxLength = 32767;
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.PasswordChar = '\0';
            this.metroTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearch.SelectedText = "";
            this.metroTextBoxSearch.SelectionLength = 0;
            this.metroTextBoxSearch.SelectionStart = 0;
            this.metroTextBoxSearch.ShortcutsEnabled = true;
            this.metroTextBoxSearch.Size = new System.Drawing.Size(190, 24);
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
            this.pictureBoxTesis.Location = new System.Drawing.Point(28, 142);
            this.pictureBoxTesis.Name = "pictureBoxTesis";
            this.pictureBoxTesis.Size = new System.Drawing.Size(222, 222);
            this.pictureBoxTesis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTesis.TabIndex = 6;
            this.pictureBoxTesis.TabStop = false;
            this.pictureBoxTesis.Click += new System.EventHandler(this.pictureBoxTesis_Click);
            // 
            // pictureBoxLibros
            // 
            this.pictureBoxLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLibros.Image = global::BibliotecaVirtual.Properties.Resources.Libros;
            this.pictureBoxLibros.Location = new System.Drawing.Point(288, 142);
            this.pictureBoxLibros.Name = "pictureBoxLibros";
            this.pictureBoxLibros.Size = new System.Drawing.Size(222, 222);
            this.pictureBoxLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLibros.TabIndex = 5;
            this.pictureBoxLibros.TabStop = false;
            this.pictureBoxLibros.Click += new System.EventHandler(this.pictureBoxLibros_Click);
            // 
            // pictureBoxArticulos
            // 
            this.pictureBoxArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArticulos.Image = global::BibliotecaVirtual.Properties.Resources.Articulo;
            this.pictureBoxArticulos.Location = new System.Drawing.Point(550, 142);
            this.pictureBoxArticulos.Name = "pictureBoxArticulos";
            this.pictureBoxArticulos.Size = new System.Drawing.Size(222, 222);
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
            this.pictureBoxSearch.Location = new System.Drawing.Point(483, 94);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(18, 18);
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
            this.pictureBox1.Location = new System.Drawing.Point(20, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 148);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BibliotecaVirtual.Properties.Resources.FooterFull;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1, 390);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 211);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(320, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Buscar:";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBoxTesis);
            this.Controls.Add(this.pictureBoxLibros);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxArticulos);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.metroTextBoxSearch);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.Resizable = false;
            this.Text = "Economía y Finanzas para la Biodiversidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosed);
            this.Load += new System.EventHandler(this.FormStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

