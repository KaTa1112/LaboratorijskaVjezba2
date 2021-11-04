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
    public partial class resultDisplay : UserControl
    {
        public resultDisplay()
        {
            InitializeComponent();
        }
        public readonly KvadratnaJednadzba qe = new KvadratnaJednadzba();
        public void FillResults()
        {
            qe.A = (double)numericUpDowna.Value;
            qe.B = (double)numericUpDownb.Value;
            qe.C = (double)numericUpDownc.Value;

            double discriminant = qe.Discriminant;
            textBoxDiscriminant.Text = discriminant.ToString();
            textBoxRoot1.Text = qe.Roots[0].ToString();
            textBoxRoot2.Text = qe.Roots[1].ToString();


        }
    }
}
