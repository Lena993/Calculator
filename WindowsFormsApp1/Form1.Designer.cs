
namespace WindowsFormsApp1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 104);
            this.button4.TabIndex = 3;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 104);
            this.button5.TabIndex = 4;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(93, 233);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(174, 233);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 49);
            this.button8.TabIndex = 7;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 178);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 49);
            this.button9.TabIndex = 8;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(93, 178);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 49);
            this.button10.TabIndex = 9;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btn_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(174, 178);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 49);
            this.button11.TabIndex = 10;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 123);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 49);
            this.button12.TabIndex = 11;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btn_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(93, 123);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 49);
            this.button13.TabIndex = 12;
            this.button13.Text = "8";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btn_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(174, 123);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 49);
            this.button14.TabIndex = 13;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btn_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(255, 178);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 49);
            this.button15.TabIndex = 14;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(336, 178);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 49);
            this.button16.TabIndex = 15;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(255, 123);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 49);
            this.button17.TabIndex = 16;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(336, 123);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 49);
            this.button18.TabIndex = 17;
            this.button18.Text = "C";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 40);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(399, 47);
            this.txtDisplay.TabIndex = 18;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 368);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

