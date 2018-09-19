using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploLibreria;

namespace implementacionLibreria
{
    public partial class newk : Form
    {
        Form1 fm = new Form1();
        

       //

        public newk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fm.Show();
        }
    }
}
