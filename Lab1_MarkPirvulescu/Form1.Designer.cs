namespace InvestmentCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Initial_Investment_Box = new TextBox();
            label2 = new Label();
            Rate_Of_Growth_Box = new TextBox();
            label3 = new Label();
            Years_Of_Growth_Box = new TextBox();
            Calculate_Button = new Button();
            label1 = new Label();
            label4 = new Label();
            Inflation_Adjustment_Box = new TextBox();
            SuspendLayout();
            // 
            // Initial_Investment_Box
            // 
            Initial_Investment_Box.Location = new Point(322, 93);
            Initial_Investment_Box.Name = "Initial_Investment_Box";
            Initial_Investment_Box.Size = new Size(100, 23);
            Initial_Investment_Box.TabIndex = 0;
            Initial_Investment_Box.TabStop = false;
            Initial_Investment_Box.Leave += Initial_Investment_Box_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 138);
            label2.Name = "label2";
            label2.Size = new Size(301, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter the percentage rate at which this index is supposed to grow at";
            // 
            // Rate_Of_Growth_Box
            // 
            Rate_Of_Growth_Box.Location = new Point(322, 156);
            Rate_Of_Growth_Box.Name = "Rate_Of_Growth_Box";
            Rate_Of_Growth_Box.Size = new Size(100, 23);
            Rate_Of_Growth_Box.TabIndex = 3;
            Rate_Of_Growth_Box.TabStop = false;
            Rate_Of_Growth_Box.Leave += Rate_Of_Growth_Box_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 279);
            label3.Name = "label3";
            label3.Size = new Size(198, 15);
            label3.TabIndex = 4;
            label3.Text = "Enter the amount of years of growth";
            // 
            // Years_Of_Growth_Box
            // 
            Years_Of_Growth_Box.Location = new Point(322, 297);
            Years_Of_Growth_Box.Name = "Years_Of_Growth_Box";
            Years_Of_Growth_Box.Size = new Size(100, 23);
            Years_Of_Growth_Box.TabIndex = 5;
            Years_Of_Growth_Box.TabStop = false;
            Years_Of_Growth_Box.Leave += Years_Of_Growth_Box_Leave;
            // 
            // Calculate_Button
            // 
            Calculate_Button.Location = new Point(332, 370);
            Calculate_Button.Name = "Calculate_Button";
            Calculate_Button.Size = new Size(75, 23);
            Calculate_Button.TabIndex = 6;
            Calculate_Button.Text = "Calculate";
            Calculate_Button.UseVisualStyleBackColor = true;
            Calculate_Button.Click += Calculate_Button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(277, 75);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 7;
            label1.Text = "Enter the amount you want to invest";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 212);
            label4.Name = "label4";
            label4.Size = new Size(166, 15);
            label4.TabIndex = 8;
            label4.Text = "Enter a projected inflation rate";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inflation_Adjustment_Box
            // 
            Inflation_Adjustment_Box.Location = new Point(322, 230);
            Inflation_Adjustment_Box.Name = "Inflation_Adjustment_Box";
            Inflation_Adjustment_Box.Size = new Size(100, 23);
            Inflation_Adjustment_Box.TabIndex = 9;
            Inflation_Adjustment_Box.Leave += Inflation_Adjustment_Box_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Inflation_Adjustment_Box);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Calculate_Button);
            Controls.Add(Years_Of_Growth_Box);
            Controls.Add(label3);
            Controls.Add(Rate_Of_Growth_Box);
            Controls.Add(label2);
            Controls.Add(Initial_Investment_Box);
            Name = "Form1";
            Text = "Investment Calculator";
            Activated += Form1_Activate;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox Initial_Investment_Box;
        private Label label2;
        private TextBox Rate_Of_Growth_Box;
        private Label label3;
        private TextBox Years_Of_Growth_Box;
        private Button Calculate_Button;
        private Label label1;
        private Label label4;
        private TextBox Inflation_Adjustment_Box;
    }
}
