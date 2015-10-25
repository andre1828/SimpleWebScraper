using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebScraper
{
    public partial class ListOfFiles : Form
    {
        public ListOfFiles()
        {
            InitializeComponent();
        }

        private void ListOfFiles_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("testing");
        }
    }
}
