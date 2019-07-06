using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BibliotecaVirtual.Commun.SearchsTerminals;
using MetroFramework.Forms;

namespace BibliotecaVirtual.Forms.Initiative
{
    public partial class DetailsView : MetroForm
    {
        public DetailsView(string name,List<Documents> documents, string urlFolder)
        {
            var initialY = 10;
            InitializeComponent();
            panel1.AutoScroll = true;
            this.Text = name;

            foreach (var document in documents)
            {
                var itemView = new ItemView(document) {Location = Location = new Point(10, initialY)};
                this.panel1.Controls.Add(itemView);
                initialY += 70;

            }
            
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
    }
}