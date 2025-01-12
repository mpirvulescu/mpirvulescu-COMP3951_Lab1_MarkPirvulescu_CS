namespace InvestmentCalculator
{
    partial class Form2
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
            Reset_Button = new Button();
            SuspendLayout();
            // 
            // Reset_Button
            // 
            Reset_Button.Location = new Point(379, 189);
            Reset_Button.Name = "Reset_Button";
            Reset_Button.Size = new Size(75, 23);
            Reset_Button.TabIndex = 0;
            Reset_Button.Text = "button1";
            Reset_Button.UseVisualStyleBackColor = true;
            Reset_Button.Click += Reset_Button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reset_Button);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button Reset_Button;
    }
}