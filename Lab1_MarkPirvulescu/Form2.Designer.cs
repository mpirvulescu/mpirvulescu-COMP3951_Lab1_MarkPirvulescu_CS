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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Reset_Button
            // 
            Reset_Button.Location = new Point(351, 382);
            Reset_Button.Name = "Reset_Button";
            Reset_Button.Size = new Size(75, 23);
            Reset_Button.TabIndex = 0;
            Reset_Button.Text = "Reset";
            Reset_Button.UseVisualStyleBackColor = true;
            Reset_Button.Click += Reset_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(571, 293);
            dataGridView1.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Reset_Button);
            Name = "Form2";
            Text = "Investment Calculator";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Reset_Button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
    }
}