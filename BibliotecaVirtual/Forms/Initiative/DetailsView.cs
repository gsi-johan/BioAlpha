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
    public partial class DetailsView : MetroForm
    {
        public DetailsView(int count)
        {

            int initialY = 10;
            InitializeComponent();
            this.panel1.AutoScroll = true;

            for (int i = 0; i < count; i++)
            {
                TextBox t = new TextBox { Name = "text", Width = 300, Text = "dinamyc text" };

                t.Location = new Point(10, initialY);
              
                this.panel1.Controls.Add(t);
                initialY += 60;

            }
           

          
        }
    }
}
