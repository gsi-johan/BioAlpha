using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
            nameCustomLabel.Text = this._document.Name;

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
