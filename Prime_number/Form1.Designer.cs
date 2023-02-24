
namespace Prime_number
{
    partial class Prime_number
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
            this.Button = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numerePrimeCounter = new System.Windows.Forms.Label();
            this.numereNeprimeCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.LightSalmon;
            this.Button.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.Location = new System.Drawing.Point(210, 184);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(124, 43);
            this.Button.TabIndex = 0;
            this.Button.Text = "Submit";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(210, 158);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(124, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // numerePrimeCounter
            // 
            this.numerePrimeCounter.AutoSize = true;
            this.numerePrimeCounter.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerePrimeCounter.Location = new System.Drawing.Point(12, 39);
            this.numerePrimeCounter.Name = "numerePrimeCounter";
            this.numerePrimeCounter.Size = new System.Drawing.Size(298, 24);
            this.numerePrimeCounter.TabIndex = 2;
            this.numerePrimeCounter.Text = "Numere prime inserate: 0";
            // 
            // numereNeprimeCounter
            // 
            this.numereNeprimeCounter.AutoSize = true;
            this.numereNeprimeCounter.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numereNeprimeCounter.Location = new System.Drawing.Point(12, 63);
            this.numereNeprimeCounter.Name = "numereNeprimeCounter";
            this.numereNeprimeCounter.Size = new System.Drawing.Size(322, 24);
            this.numereNeprimeCounter.TabIndex = 3;
            this.numereNeprimeCounter.Text = "Numere neprime inserate: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Prime_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(516, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numereNeprimeCounter);
            this.Controls.Add(this.numerePrimeCounter);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.Button);
            this.Name = "Prime_number";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label numerePrimeCounter;
        private System.Windows.Forms.Label numereNeprimeCounter;
        private System.Windows.Forms.Label label1;
    }
}

