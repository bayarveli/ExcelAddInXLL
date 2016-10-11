namespace ExcelAddInXLL
{
    partial class Form1
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
            this.txt_input1 = new System.Windows.Forms.TextBox();
            this.txt_input2 = new System.Windows.Forms.TextBox();
            this.txt_input3 = new System.Windows.Forms.TextBox();
            this.txt_input4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_input1
            // 
            this.txt_input1.Location = new System.Drawing.Point(71, 13);
            this.txt_input1.Name = "txt_input1";
            this.txt_input1.Size = new System.Drawing.Size(100, 20);
            this.txt_input1.TabIndex = 0;
            // 
            // txt_input2
            // 
            this.txt_input2.Location = new System.Drawing.Point(71, 39);
            this.txt_input2.Name = "txt_input2";
            this.txt_input2.Size = new System.Drawing.Size(100, 20);
            this.txt_input2.TabIndex = 1;
            // 
            // txt_input3
            // 
            this.txt_input3.Location = new System.Drawing.Point(71, 65);
            this.txt_input3.Name = "txt_input3";
            this.txt_input3.Size = new System.Drawing.Size(100, 20);
            this.txt_input3.TabIndex = 2;
            // 
            // txt_input4
            // 
            this.txt_input4.Location = new System.Drawing.Point(71, 91);
            this.txt_input4.Name = "txt_input4";
            this.txt_input4.Size = new System.Drawing.Size(100, 20);
            this.txt_input4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input 4:";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_calculate.ForeColor = System.Drawing.Color.Red;
            this.btn_calculate.Location = new System.Drawing.Point(190, 42);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(91, 43);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(298, 54);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(317, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 123);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_input4);
            this.Controls.Add(this.txt_input3);
            this.Controls.Add(this.txt_input2);
            this.Controls.Add(this.txt_input1);
            this.Name = "Form1";
            this.Text = "How to XLL functions in C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input1;
        private System.Windows.Forms.TextBox txt_input2;
        private System.Windows.Forms.TextBox txt_input3;
        private System.Windows.Forms.TextBox txt_input4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label5;
    }
}

