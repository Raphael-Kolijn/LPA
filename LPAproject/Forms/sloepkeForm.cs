using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPAproject.Properties;

namespace LPAproject  // Test Textenc
{
    public partial class sloepkeForm : Form
    {
        public sloepkeForm()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e) // Test voor DB connectie
        {
            database.postToBlog("test", "Art", "PC");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void budgetBijkomendeArtikelenCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
