namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            txtNaslov = new TextBox();
            txtAutor = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtAutor);
            groupBox1.Controls.Add(txtNaslov);
            groupBox1.Location = new Point(21, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o knjizi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(3, 19);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(100, 23);
            txtNaslov.TabIndex = 0;
            txtNaslov.TextChanged += textBox1_TextChanged;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(3, 48);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ljubić", "Misterija", "Krimić", "Avantura" });
            comboBox1.Location = new Point(3, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Location = new Point(33, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dodatni Podaci";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(6, 22);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(105, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 60);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Dostupna za posudbu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNaslov;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAutor;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
    }
}