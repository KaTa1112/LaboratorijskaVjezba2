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
            functionPanel.Function = resultDisplay1.qe.y;
            resultDisplay1.change += ResultDisplay1_change;
        }

        private void ResultDisplay1_change(object sender, EventArgs e)
        {
            functionPanel.Invalidate();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            resultDisplay.FillResults();
        }
    }
}
