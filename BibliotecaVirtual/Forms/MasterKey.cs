using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BibliotecaVirtual.Forms
{
    public partial class MasterKey : MetroForm
    {
        
        private FormSearchingResult _form;
        public MasterKey(FormSearchingResult form)
        {
            InitializeComponent();
            _form = form;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (keyMetroTextBox1.Text.Equals("BiofinCuba"))
            {
                _form.isLoged = true;
                Dispose();
            }
            else
            {
                _form.isLoged = false;
                errorMetroLabel.Visible = true;
            }
        }

        private void keyMetroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\r"))
            {
                if (keyMetroTextBox1.Text.Equals("BiofinCuba"))
                {
                    _form.isLoged = true;
                    Dispose();
                }
                else
                {
                    _form.isLoged = false;
                    errorMetroLabel.Visible = true;
                }
            }
        }
    }
}
