namespace BibliotecaVirtual
{
    partial class FormSearchingResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchingResult));
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelSearch = new MetroFramework.Controls.MetroLabel();
            this.metroGridSearchRes = new MetroFramework.Controls.MetroGrid();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.thesis = new System.Windows.Forms.TabPage();
            this.book = new System.Windows.Forms.TabPage();
            this.article = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.TabPage();
            this.administrator = new System.Windows.Forms.TabPage();
            this.metroPanelNav = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CantResultadoMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.CreatePictureBox = new System.Windows.Forms.PictureBox();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorMessagePictureBox = new System.Windows.Forms.PictureBox();
            this.ErrorMessageMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridSearchRes)).BeginInit();
            this.metroTabControl2.SuspendLayout();
            this.metroPanelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxSearch
            // 
            // 
            // 
            // 
            this.metroTextBoxSearch.CustomButton.Image = null;
            this.metroTextBoxSearch.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.metroTextBoxSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxSearch.CustomButton.Name = "";
            this.metroTextBoxSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSearch.CustomButton.TabIndex = 1;
            this.metroTextBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSearch.CustomButton.UseSelectable = true;
            this.metroTextBoxSearch.CustomButton.Visible = false;
            this.metroTextBoxSearch.Lines = new string[0];
            this.metroTextBoxSearch.Location = new System.Drawing.Point(759, 55);
            this.metroTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxSearch.MaxLength = 32767;
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.PasswordChar = '\0';
            this.metroTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSearch.SelectedText = "";
            this.metroTextBoxSearch.SelectionLength = 0;
            this.metroTextBoxSearch.SelectionStart = 0;
            this.metroTextBoxSearch.ShortcutsEnabled = true;
            this.metroTextBoxSearch.Size = new System.Drawing.Size(253, 30);
            this.metroTextBoxSearch.TabIndex = 17;
            this.metroTextBoxSearch.UseSelectable = true;
            this.metroTextBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_TextBoxSearch);
            // 
            // metroLabelSearch
            // 
            this.metroLabelSearch.AutoSize = true;
            this.metroLabelSearch.Location = new System.Drawing.Point(760, 30);
            this.metroLabelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabelSearch.Name = "metroLabelSearch";
            this.metroLabelSearch.Size = new System.Drawing.Size(50, 20);
            this.metroLabelSearch.TabIndex = 16;
            this.metroLabelSearch.Text = "Buscar";
            // 
            // metroGridSearchRes
            // 
            this.metroGridSearchRes.AllowUserToAddRows = false;
            this.metroGridSearchRes.AllowUserToDeleteRows = false;
            this.metroGridSearchRes.AllowUserToResizeRows = false;
            this.metroGridSearchRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridSearchRes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridSearchRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridSearchRes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridSearchRes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(152)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(175)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridSearchRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridSearchRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(175)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridSearchRes.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridSearchRes.EnableHeadersVisualStyles = false;
            this.metroGridSearchRes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridSearchRes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridSearchRes.Location = new System.Drawing.Point(56, 165);
            this.metroGridSearchRes.Margin = new System.Windows.Forms.Padding(4);
            this.metroGridSearchRes.MultiSelect = false;
            this.metroGridSearchRes.Name = "metroGridSearchRes";
            this.metroGridSearchRes.ReadOnly = true;
            this.metroGridSearchRes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(152)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(175)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridSearchRes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridSearchRes.RowHeadersVisible = false;
            this.metroGridSearchRes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridSearchRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridSearchRes.ShowCellErrors = false;
            this.metroGridSearchRes.ShowRowErrors = false;
            this.metroGridSearchRes.Size = new System.Drawing.Size(960, 384);
            this.metroGridSearchRes.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGridSearchRes.TabIndex = 20;
            this.metroGridSearchRes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick_metroGridSearchResult);
            this.metroGridSearchRes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CellFormatting_Datagrid);
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.thesis);
            this.metroTabControl2.Controls.Add(this.book);
            this.metroTabControl2.Controls.Add(this.article);
            this.metroTabControl2.Controls.Add(this.result);
            this.metroTabControl2.Controls.Add(this.administrator);
            this.metroTabControl2.Location = new System.Drawing.Point(0, 43);
            this.metroTabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 4;
            this.metroTabControl2.Size = new System.Drawing.Size(1067, 700);
            this.metroTabControl2.TabIndex = 23;
            this.metroTabControl2.UseSelectable = true;
            this.metroTabControl2.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_DataGrid);
            // 
            // thesis
            // 
            this.thesis.BackColor = System.Drawing.Color.White;
            this.thesis.Location = new System.Drawing.Point(4, 38);
            this.thesis.Margin = new System.Windows.Forms.Padding(4);
            this.thesis.Name = "thesis";
            this.thesis.Size = new System.Drawing.Size(1059, 658);
            this.thesis.TabIndex = 4;
            this.thesis.Text = "Tesis";
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.White;
            this.book.Location = new System.Drawing.Point(4, 38);
            this.book.Margin = new System.Windows.Forms.Padding(4);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(1059, 658);
            this.book.TabIndex = 5;
            this.book.Text = "Libros";
            // 
            // article
            // 
            this.article.BackColor = System.Drawing.Color.White;
            this.article.Location = new System.Drawing.Point(4, 38);
            this.article.Margin = new System.Windows.Forms.Padding(4);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(1059, 658);
            this.article.TabIndex = 6;
            this.article.Text = "Artículos";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(4, 38);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(1059, 658);
            this.result.TabIndex = 3;
            this.result.Text = "Todos";
            // 
            // administrator
            // 
            this.administrator.BackColor = System.Drawing.Color.White;
            this.administrator.Location = new System.Drawing.Point(4, 38);
            this.administrator.Margin = new System.Windows.Forms.Padding(4);
            this.administrator.Name = "administrator";
            this.administrator.Size = new System.Drawing.Size(1059, 658);
            this.administrator.TabIndex = 7;
            this.administrator.Text = "Administración";
            // 
            // metroPanelNav
            // 
            this.metroPanelNav.Controls.Add(this.metroLabel1);
            this.metroPanelNav.Controls.Add(this.CantResultadoMetroLabel);
            this.metroPanelNav.HorizontalScrollbarBarColor = true;
            this.metroPanelNav.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelNav.HorizontalScrollbarSize = 12;
            this.metroPanelNav.Location = new System.Drawing.Point(-9, 92);
            this.metroPanelNav.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanelNav.Name = "metroPanelNav";
            this.metroPanelNav.Size = new System.Drawing.Size(1091, 46);
            this.metroPanelNav.TabIndex = 19;
            this.metroPanelNav.VerticalScrollbarBarColor = true;
            this.metroPanelNav.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelNav.VerticalScrollbarSize = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(879, 10);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 20);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Resultados :";
            // 
            // CantResultadoMetroLabel
            // 
            this.CantResultadoMetroLabel.AutoSize = true;
            this.CantResultadoMetroLabel.Location = new System.Drawing.Point(987, 10);
            this.CantResultadoMetroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantResultadoMetroLabel.Name = "CantResultadoMetroLabel";
            this.CantResultadoMetroLabel.Size = new System.Drawing.Size(17, 20);
            this.CantResultadoMetroLabel.TabIndex = 36;
            this.CantResultadoMetroLabel.Text = "0";
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackgroundImage = global::BibliotecaVirtual.Properties.Resources.search;
            this.pictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxSearch.Location = new System.Drawing.Point(983, 59);
            this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(24, 22);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 24;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.Click_BoxSearch);
            this.pictureBoxSearch.MouseLeave += new System.EventHandler(this.pictureBoxSearch_MouseLeave);
            this.pictureBoxSearch.MouseHover += new System.EventHandler(this.pictureBoxSearch_MouseHover);
            // 
            // CreatePictureBox
            // 
            this.CreatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CreatePictureBox.BackgroundImage = global::BibliotecaVirtual.Properties.Resources.plusFloat;
            this.CreatePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreatePictureBox.Location = new System.Drawing.Point(967, 537);
            this.CreatePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CreatePictureBox.Name = "CreatePictureBox";
            this.CreatePictureBox.Size = new System.Drawing.Size(85, 76);
            this.CreatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreatePictureBox.TabIndex = 30;
            this.CreatePictureBox.TabStop = false;
            this.CreatePictureBox.Visible = false;
            this.CreatePictureBox.Click += new System.EventHandler(this.Click_FloatPlus);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::BibliotecaVirtual.Properties.Resources.login;
            this.loginPictureBox.Location = new System.Drawing.Point(1017, 49);
            this.loginPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(37, 34);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPictureBox.TabIndex = 32;
            this.loginPictureBox.TabStop = false;
            this.loginPictureBox.Click += new System.EventHandler(this.loginPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BibliotecaVirtual.Properties.Resources.footer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 615);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 123);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorMessagePictureBox
            // 
            this.ErrorMessagePictureBox.Image = global::BibliotecaVirtual.Properties.Resources.emoticon;
            this.ErrorMessagePictureBox.Location = new System.Drawing.Point(455, 222);
            this.ErrorMessagePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorMessagePictureBox.Name = "ErrorMessagePictureBox";
            this.ErrorMessagePictureBox.Size = new System.Drawing.Size(141, 124);
            this.ErrorMessagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorMessagePictureBox.TabIndex = 34;
            this.ErrorMessagePictureBox.TabStop = false;
            this.ErrorMessagePictureBox.Visible = false;
            // 
            // ErrorMessageMetroLabel
            // 
            this.ErrorMessageMetroLabel.AutoSize = true;
            this.ErrorMessageMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ErrorMessageMetroLabel.Location = new System.Drawing.Point(315, 356);
            this.ErrorMessageMetroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorMessageMetroLabel.Name = "ErrorMessageMetroLabel";
            this.ErrorMessageMetroLabel.Size = new System.Drawing.Size(324, 25);
            this.ErrorMessageMetroLabel.TabIndex = 35;
            this.ErrorMessageMetroLabel.Text = "Ups!! No se han encontrado resultados.";
            this.ErrorMessageMetroLabel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::BibliotecaVirtual.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(12, 97);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormSearchingResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CreatePictureBox);
            this.Controls.Add(this.ErrorMessageMetroLabel);
            this.Controls.Add(this.ErrorMessagePictureBox);
            this.Controls.Add(this.metroGridSearchRes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.metroPanelNav);
            this.Controls.Add(this.metroTextBoxSearch);
            this.Controls.Add(this.metroLabelSearch);
            this.Controls.Add(this.metroTabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormSearchingResult";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedWindow);
            this.Load += new System.EventHandler(this.FormSearchingResult_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_TextBoxSearch);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridSearchRes)).EndInit();
            this.metroTabControl2.ResumeLayout(false);
            this.metroPanelNav.ResumeLayout(false);
            this.metroPanelNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMessagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private MetroFramework.Controls.MetroLabel metroLabelSearch;
        private MetroFramework.Controls.MetroGrid metroGridSearchRes;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private System.Windows.Forms.TabPage result;
        private System.Windows.Forms.TabPage thesis;
        private System.Windows.Forms.TabPage book;
        private System.Windows.Forms.TabPage article;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private MetroFramework.Controls.MetroPanel metroPanelNav;
        private System.Windows.Forms.TabPage administrator;
        private System.Windows.Forms.PictureBox CreatePictureBox;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ErrorMessagePictureBox;
        private MetroFramework.Controls.MetroLabel ErrorMessageMetroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel CantResultadoMetroLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}