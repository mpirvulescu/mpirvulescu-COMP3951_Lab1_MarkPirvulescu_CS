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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Initial_Investment_Box
            // 
            Initial_Investment_Box.Location = new Point(322, 71);
            Initial_Investment_Box.Name = "Initial_Investment_Box";
            Initial_Investment_Box.Size = new Size(100, 23);
            Initial_Investment_Box.TabIndex = 0;
            Initial_Investment_Box.TabStop = false;
            Initial_Investment_Box.Leave += Initial_Investment_Box_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 128);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // Rate_Of_Growth_Box
            // 
            Rate_Of_Growth_Box.Location = new Point(322, 146);
            Rate_Of_Growth_Box.Name = "Rate_Of_Growth_Box";
            Rate_Of_Growth_Box.Size = new Size(100, 23);
            Rate_Of_Growth_Box.TabIndex = 3;
            Rate_Of_Growth_Box.TabStop = false;
            Rate_Of_Growth_Box.Leave += Rate_Of_Growth_Box_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 204);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // Years_Of_Growth_Box
            // 
            Years_Of_Growth_Box.Location = new Point(322, 222);
            Years_Of_Growth_Box.Name = "Years_Of_Growth_Box";
            Years_Of_Growth_Box.Size = new Size(100, 23);
            Years_Of_Growth_Box.TabIndex = 5;
            Years_Of_Growth_Box.TabStop = false;
            Years_Of_Growth_Box.Leave += Years_Of_Growth_Box_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(334, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 53);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Years_Of_Growth_Box);
            Controls.Add(label3);
            Controls.Add(Rate_Of_Growth_Box);
            Controls.Add(label2);
            Controls.Add(Initial_Investment_Box);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox Initial_Investment_Box;
        private Label label2;
        private TextBox Rate_Of_Growth_Box;
        private Label label3;
        private TextBox Years_Of_Growth_Box;
        private Button button1;
        private Label label1;
    }
}
