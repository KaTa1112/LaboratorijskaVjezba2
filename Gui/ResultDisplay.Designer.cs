
namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    partial class ResultDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDowna = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownb = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownc = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDiscriminant = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRoot1 = new System.Windows.Forms.TextBox();
            this.textBoxRoot2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownc);
            this.groupBox1.Controls.Add(this.numericUpDownb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDowna);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coefficients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&a:";
            // 
            // numericUpDowna
            // 
            this.numericUpDowna.DecimalPlaces = 2;
            this.numericUpDowna.Location = new System.Drawing.Point(65, 25);
            this.numericUpDowna.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDowna.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDowna.Name = "numericUpDowna";
            this.numericUpDowna.Size = new System.Drawing.Size(120, 20);
            this.numericUpDowna.TabIndex = 1;
            this.numericUpDowna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDowna.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "&c:";
            // 
            // numericUpDownb
            // 
            this.numericUpDownb.DecimalPlaces = 2;
            this.numericUpDownb.Location = new System.Drawing.Point(65, 56);
            this.numericUpDownb.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownb.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownb.Name = "numericUpDownb";
            this.numericUpDownb.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownb.TabIndex = 4;
            this.numericUpDownb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownb.ThousandsSeparator = true;
            // 
            // numericUpDownc
            // 
            this.numericUpDownc.DecimalPlaces = 2;
            this.numericUpDownc.Location = new System.Drawing.Point(65, 84);
            this.numericUpDownc.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownc.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownc.Name = "numericUpDownc";
            this.numericUpDownc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownc.TabIndex = 5;
            this.numericUpDownc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownc.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Discriminant";
            // 
            // textBoxDiscriminant
            // 
            this.textBoxDiscriminant.Location = new System.Drawing.Point(128, 167);
            this.textBoxDiscriminant.Name = "textBoxDiscriminant";
            this.textBoxDiscriminant.ReadOnly = true;
            this.textBoxDiscriminant.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiscriminant.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRoot2);
            this.groupBox2.Controls.Add(this.textBoxRoot1);
            this.groupBox2.Location = new System.Drawing.Point(28, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Roots";
            // 
            // textBoxRoot1
            // 
            this.textBoxRoot1.Location = new System.Drawing.Point(40, 29);
            this.textBoxRoot1.Name = "textBoxRoot1";
            this.textBoxRoot1.Size = new System.Drawing.Size(120, 20);
            this.textBoxRoot1.TabIndex = 4;
            // 
            // textBoxRoot2
            // 
            this.textBoxRoot2.Location = new System.Drawing.Point(40, 64);
            this.textBoxRoot2.Name = "textBoxRoot2";
            this.textBoxRoot2.Size = new System.Drawing.Size(120, 20);
            this.textBoxRoot2.TabIndex = 5;
            // 
            // ResultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxDiscriminant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultDisplay";
            this.Size = new System.Drawing.Size(324, 343);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownc;
        private System.Windows.Forms.NumericUpDown numericUpDownb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDowna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDiscriminant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRoot2;
        private System.Windows.Forms.TextBox textBoxRoot1;
    }
}
