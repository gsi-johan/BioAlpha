using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BibliotecaVirtual.Forms.Initiative
{
    public partial class About_2 : MetroForm
    {
        public About_2(List<string> names)
        {
            InitializeComponent();
            var initialY = 10;
            foreach (var name in names)
            {
                var label = new MetroFramework.Controls.MetroLabel
                {
                    Text = name,
                    Location = new Point(10, initialY)
                };

                initialY += 25;

                this.metroPanel1.Controls.Add(label);
            }
        }
    }
}