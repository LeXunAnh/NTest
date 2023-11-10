using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator2
{
    public partial class Caculator : Form
    {
        private int a, b, kq;
        public Caculator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtNum1.Text);
            b = int.Parse(txtNum2.Text);
            Caculation c = new Caculation(a, b);
            kq = c.Exectute("+");
            txtkq.Text = kq.ToString();
        }
    }
}
