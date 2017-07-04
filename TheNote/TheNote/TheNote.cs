using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNote
{
    public partial class TheNote : Form
    {
        public TheNote()
        {
            InitializeComponent();
        }

        private void TheNote_Load(object sender, EventArgs e)
        {
            addPage(tabMain, new TabPage("+"));
        }

        public TabPage createTabpage(string name)
        {
            TabPage tabPage; 
            tabPage = new TabPage(name);
            return tabPage; 
        }
        public void addPage(TabControl tabControl, TabPage tabPage)
        {
            tabControl.TabPages.Add(tabPage);
        }
    }
}
