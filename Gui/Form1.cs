using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    public partial class QuadraticEquation : Form
    {
        public QuadraticEquation()
        {
            InitializeComponent();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            resultDisplay.FillResults();
        }
    }
}
