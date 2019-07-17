using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BibliotecaVirtual.Commun.SearchsTerminals;
using BibliotecaVirtual.Properties;
using MetroFramework;

namespace BibliotecaVirtual.Forms.Initiative
{
    public partial class ItemView : UserControl
    {
        private readonly Documents _document
            ;

        public ItemView(Documents documents)
        {
            this._document = documents;
            InitializeComponent();
            SetName();
        }

        private void SetName()
        {
            nameCustomLabel.Text = _document.Name;
            if (nameCustomLabel.Width < TextRenderer.MeasureText(nameCustomLabel.Text,
                        new Font(nameCustomLabel.Font.FontFamily, nameCustomLabel.Font.Size,
                            nameCustomLabel.Font.Style))
                    .Width)
            {
                nameCustomLabel.Text = _document.Name.Substring(0, 42) + "..";
            }
        }

        private void CheckAndOpenUrlPdf(string urlPdf)
        {
            try
            {
                string currentDir = Environment.CurrentDirectory;
                string directory = currentDir + urlPdf;

                if (File.Exists(directory))
                {
                    System.Diagnostics.Process.Start(directory);
                }
                else
                {
                    MetroMessageBox.Show(this, Resources.LostFileError, Resources.Information,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning, 120);
                }
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, Resources.LostFileError, Resources.Information,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, 120);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.CheckAndOpenUrlPdf(this._document.Url);
        }

        private void nameCustomLabel_MouseHover(object sender, EventArgs e)
        {
            toolTName.SetToolTip(nameCustomLabel, _document.Name);
        }
    }
}