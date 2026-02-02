namespace WinFormsApp1
{
    partial class Form4
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
            button1 = new Button();
            lstStats = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 21);
            button1.Name = "button1";
            button1.Size = new Size(226, 99);
            button1.TabIndex = 0;
            button1.Text = "Broj knjiga po zanrovima";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstStats
            // 
            lstStats.FormattingEnabled = true;
            lstStats.ItemHeight = 15;
            lstStats.Location = new Point(37, 148);
            lstStats.Name = "lstStats";
            lstStats.Size = new Size(226, 184);
            lstStats.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(372, 167);
            button2.Name = "button2";
            button2.Size = new Size(128, 82);
            button2.TabIndex = 2;
            button2.Text = "Zatvori";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(lstStats);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Statistika Žanrova";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox lstStats;
        private Button button2;
    }
}