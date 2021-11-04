
namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    partial class QuadraticEquation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultDisplay1 = new Vsite.CSharp.KvadratnaJednadzba.Gui.resultDisplay();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resultDisplay1.Location = new System.Drawing.Point(39, 27);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.Size = new System.Drawing.Size(324, 343);
            this.resultDisplay1.TabIndex = 0;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Location = new System.Drawing.Point(182, 347);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(75, 23);
            this.buttonEvaluate.TabIndex = 1;
            this.buttonEvaluate.Text = "&Evaluate";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // QuadraticEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.resultDisplay1);
            this.Name = "QuadraticEquation";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private resultDisplay resultDisplay1;
        private System.Windows.Forms.Button buttonEvaluate;
    }
}

