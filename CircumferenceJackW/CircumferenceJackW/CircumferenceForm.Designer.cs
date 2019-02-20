namespace CircumferenceJackW
{
    partial class CircumferenceForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblQuestion.Location = new System.Drawing.Point(12, 71);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(389, 29);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Enter the radius of the circle (in cm)";
            this.lblQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(407, 80);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(208, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 35);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblAnswer.Location = new System.Drawing.Point(79, 210);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(25, 29);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "?";
            this.lblAnswer.Visible = false;
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // CircumferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 309);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblQuestion);
            this.Name = "CircumferenceForm";
            this.Text = "Cricumference by Jack W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnswer;
    }
}

