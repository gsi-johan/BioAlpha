using System.Drawing;

namespace BibliotecaVirtual
{
    partial class FormDocumentView
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
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.metroListViewAutores = new MetroFramework.Controls.MetroListView();
            this.metroLabelAuthors = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDescriptors = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelYear = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDownload = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxDownload = new System.Windows.Forms.PictureBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCategory = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLiterature = new MetroFramework.Controls.MetroLabel();
            this.LocationValueMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.LocationMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.TittleMetroLabel = new System.Windows.Forms.Label();
            this.KeyWordrichTextBox = new System.Windows.Forms.RichTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(15, 365);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(602, 151);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = "";
            // 
            // metroListViewAutores
            // 
            this.metroListViewAutores.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListViewAutores.FullRowSelect = true;
            this.metroListViewAutores.Location = new System.Drawing.Point(15, 215);
            this.metroListViewAutores.MultiSelect = false;
            this.metroListViewAutores.Name = "metroListViewAutores";
            this.metroListViewAutores.OwnerDraw = true;
            this.metroListViewAutores.Size = new System.Drawing.Size(250, 125);
            this.metroListViewAutores.TabIndex = 2;
            this.metroListViewAutores.UseCompatibleStateImageBehavior = false;
            this.metroListViewAutores.UseSelectable = true;
            // 
            // metroLabelAuthors
            // 
            this.metroLabelAuthors.AutoSize = true;
            this.metroLabelAuthors.Location = new System.Drawing.Point(15, 183);
            this.metroLabelAuthors.Name = "metroLabelAuthors";
            this.metroLabelAuthors.Size = new System.Drawing.Size(57, 19);
            this.metroLabelAuthors.TabIndex = 3;
            this.metroLabelAuthors.Text = "Autores:";
            // 
            // metroLabelDescriptors
            // 
            this.metroLabelDescriptors.AutoSize = true;
            this.metroLabelDescriptors.Location = new System.Drawing.Point(304, 183);
            this.metroLabelDescriptors.Name = "metroLabelDescriptors";
            this.metroLabelDescriptors.Size = new System.Drawing.Size(146, 19);
            this.metroLabelDescriptors.TabIndex = 4;
            this.metroLabelDescriptors.Text = "Contenido relacionado:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Año :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(203, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 8;
            // 
            // metroLabelYear
            // 
            this.metroLabelYear.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelYear.Location = new System.Drawing.Point(61, 101);
            this.metroLabelYear.Name = "metroLabelYear";
            this.metroLabelYear.Size = new System.Drawing.Size(65, 23);
            this.metroLabelYear.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(134, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Categoría :";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 343);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Descripción :";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabelDownload
            // 
            this.metroLabelDownload.AutoSize = true;
            this.metroLabelDownload.Location = new System.Drawing.Point(521, 101);
            this.metroLabelDownload.Name = "metroLabelDownload";
            this.metroLabelDownload.Size = new System.Drawing.Size(68, 19);
            this.metroLabelDownload.TabIndex = 10;
            this.metroLabelDownload.Text = "Descargar";
            // 
            // pictureBoxDownload
            // 
            this.pictureBoxDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDownload.Image = global::BibliotecaVirtual.Properties.Resources.downloadpng;
            this.pictureBoxDownload.Location = new System.Drawing.Point(587, 90);
            this.pictureBoxDownload.Name = "pictureBoxDownload";
            this.pictureBoxDownload.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDownload.TabIndex = 11;
            this.pictureBoxDownload.TabStop = false;
            this.pictureBoxDownload.Click += new System.EventHandler(this.pictureBoxDownload_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(365, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 13;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(344, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Literatura:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabelCategory
            // 
            this.metroLabelCategory.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelCategory.Location = new System.Drawing.Point(207, 101);
            this.metroLabelCategory.Name = "metroLabelCategory";
            this.metroLabelCategory.Size = new System.Drawing.Size(94, 23);
            this.metroLabelCategory.TabIndex = 14;
            this.metroLabelCategory.Text = "-";
            this.metroLabelCategory.UseCustomForeColor = true;
            // 
            // metroLabelLiterature
            // 
            this.metroLabelLiterature.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelLiterature.Location = new System.Drawing.Point(411, 101);
            this.metroLabelLiterature.Name = "metroLabelLiterature";
            this.metroLabelLiterature.Size = new System.Drawing.Size(94, 23);
            this.metroLabelLiterature.TabIndex = 15;
            this.metroLabelLiterature.Text = "-";
            this.metroLabelLiterature.UseCustomForeColor = true;
            // 
            // LocationValueMetroLabel
            // 
            this.LocationValueMetroLabel.AutoSize = true;
            this.LocationValueMetroLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.LocationValueMetroLabel.Location = new System.Drawing.Point(88, 144);
            this.LocationValueMetroLabel.Name = "LocationValueMetroLabel";
            this.LocationValueMetroLabel.Size = new System.Drawing.Size(12, 15);
            this.LocationValueMetroLabel.TabIndex = 16;
            this.LocationValueMetroLabel.Text = "-";
            this.LocationValueMetroLabel.UseCustomForeColor = true;
            this.LocationValueMetroLabel.WrapToLine = true;
            // 
            // LocationMetroLabel
            // 
            this.LocationMetroLabel.Location = new System.Drawing.Point(15, 140);
            this.LocationMetroLabel.Name = "LocationMetroLabel";
            this.LocationMetroLabel.Size = new System.Drawing.Size(69, 19);
            this.LocationMetroLabel.TabIndex = 17;
            this.LocationMetroLabel.Text = "Registro :";
            this.LocationMetroLabel.UseCustomForeColor = true;
            // 
            // TittleMetroLabel
            // 
            this.TittleMetroLabel.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleMetroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TittleMetroLabel.Location = new System.Drawing.Point(11, 22);
            this.TittleMetroLabel.Name = "TittleMetroLabel";
            this.TittleMetroLabel.Size = new System.Drawing.Size(615, 60);
            this.TittleMetroLabel.TabIndex = 19;
            this.TittleMetroLabel.Text = "Titulo del documento";
            this.TittleMetroLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KeyWordrichTextBox
            // 
            this.KeyWordrichTextBox.BackColor = System.Drawing.Color.White;
            this.KeyWordrichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyWordrichTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KeyWordrichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.KeyWordrichTextBox.Location = new System.Drawing.Point(305, 216);
            this.KeyWordrichTextBox.MaxLength = 2000;
            this.KeyWordrichTextBox.Name = "KeyWordrichTextBox";
            this.KeyWordrichTextBox.ReadOnly = true;
            this.KeyWordrichTextBox.Size = new System.Drawing.Size(321, 124);
            this.KeyWordrichTextBox.TabIndex = 21;
            this.KeyWordrichTextBox.Text = "";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(304, 215);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(323, 126);
            this.metroPanel1.TabIndex = 22;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FormDocumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 540);
            this.Controls.Add(this.TittleMetroLabel);
            this.Controls.Add(this.LocationMetroLabel);
            this.Controls.Add(this.LocationValueMetroLabel);
            this.Controls.Add(this.metroLabelLiterature);
            this.Controls.Add(this.metroLabelCategory);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBoxDownload);
            this.Controls.Add(this.metroLabelDownload);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabelYear);
            this.Controls.Add(this.metroLabelDescriptors);
            this.Controls.Add(this.metroLabelAuthors);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroListViewAutores);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.KeyWordrichTextBox);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDocumentView";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private MetroFramework.Controls.MetroListView metroListViewAutores;
        private MetroFramework.Controls.MetroLabel metroLabelAuthors;
        private MetroFramework.Controls.MetroLabel metroLabelDescriptors;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabelYear;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabelDownload;
        private System.Windows.Forms.PictureBox pictureBoxDownload;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabelCategory;
        private MetroFramework.Controls.MetroLabel metroLabelLiterature;
        private MetroFramework.Controls.MetroLabel LocationValueMetroLabel;
        private MetroFramework.Controls.MetroLabel LocationMetroLabel;
        private System.Windows.Forms.Label TittleMetroLabel;
        private System.Windows.Forms.RichTextBox KeyWordrichTextBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}