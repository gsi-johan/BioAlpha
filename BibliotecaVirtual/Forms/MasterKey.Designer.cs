namespace BibliotecaVirtual.Forms
{
    partial class MasterKey
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
            this.keyMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.keyMetroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.errorMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // keyMetroLabel
            // 
            this.keyMetroLabel.AutoSize = true;
            this.keyMetroLabel.Location = new System.Drawing.Point(24, 64);
            this.keyMetroLabel.Name = "keyMetroLabel";
            this.keyMetroLabel.Size = new System.Drawing.Size(82, 19);
            this.keyMetroLabel.TabIndex = 0;
            this.keyMetroLabel.Text = "Contraseña :";
            // 
            // keyMetroTextBox1
            // 
            // 
            // 
            // 
            this.keyMetroTextBox1.CustomButton.Image = null;
            this.keyMetroTextBox1.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.keyMetroTextBox1.CustomButton.Name = "";
            this.keyMetroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keyMetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyMetroTextBox1.CustomButton.TabIndex = 1;
            this.keyMetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyMetroTextBox1.CustomButton.UseSelectable = true;
            this.keyMetroTextBox1.CustomButton.Visible = false;
            this.keyMetroTextBox1.Lines = new string[0];
            this.keyMetroTextBox1.Location = new System.Drawing.Point(113, 64);
            this.keyMetroTextBox1.MaxLength = 32767;
            this.keyMetroTextBox1.Name = "keyMetroTextBox1";
            this.keyMetroTextBox1.PasswordChar = '●';
            this.keyMetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyMetroTextBox1.SelectedText = "";
            this.keyMetroTextBox1.SelectionLength = 0;
            this.keyMetroTextBox1.SelectionStart = 0;
            this.keyMetroTextBox1.ShortcutsEnabled = true;
            this.keyMetroTextBox1.Size = new System.Drawing.Size(185, 23);
            this.keyMetroTextBox1.TabIndex = 1;
            this.keyMetroTextBox1.UseSelectable = true;
            this.keyMetroTextBox1.UseSystemPasswordChar = true;
            this.keyMetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyMetroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.keyMetroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyMetroTextBox1_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(223, 123);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Aceptar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // errorMetroLabel
            // 
            this.errorMetroLabel.AutoSize = true;
            this.errorMetroLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMetroLabel.Location = new System.Drawing.Point(113, 92);
            this.errorMetroLabel.Name = "errorMetroLabel";
            this.errorMetroLabel.Size = new System.Drawing.Size(137, 19);
            this.errorMetroLabel.TabIndex = 3;
            this.errorMetroLabel.Text = "Contraseña incorrecta";
            this.errorMetroLabel.UseCustomForeColor = true;
            this.errorMetroLabel.Visible = false;
            // 
            // MasterKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 157);
            this.Controls.Add(this.errorMetroLabel);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.keyMetroTextBox1);
            this.Controls.Add(this.keyMetroLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterKey";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Introducir  clave maestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel keyMetroLabel;
        private MetroFramework.Controls.MetroTextBox keyMetroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel errorMetroLabel;
    }
}