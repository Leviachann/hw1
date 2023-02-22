using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part2ofhw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dontclick.Location = new Point(400, 400);
        }

        private void dontclick_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            dontclick.Location = new Point(r.Next(0, 500), r.Next(0, 400));
        }
    }
}
