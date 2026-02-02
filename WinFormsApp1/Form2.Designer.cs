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
            label5 = new Label();
            label4 = new Label();
            cbZanr = new ComboBox();
            label3 = new Label();
            godina = new DateTimePicker();
            label2 = new Label();
            txtAutor = new TextBox();
            txtNaslov = new TextBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            dostupnost = new CheckBox();
            brStr = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brStr).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbZanr);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(godina);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAutor);
            groupBox1.Controls.Add(txtNaslov);
            groupBox1.Location = new Point(21, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o knjizi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 115);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 2;
            label5.Text = "Žanr:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 4;
            label4.Text = "Datum izdavanja:";
            // 
            // cbZanr
            // 
            cbZanr.FormattingEnabled = true;
            cbZanr.Items.AddRange(new object[] { "Znanstvena fantastika", "Ljubavni", "Akcijski", "Pustolovni" });
            cbZanr.Location = new Point(183, 112);
            cbZanr.Name = "cbZanr";
            cbZanr.Size = new Size(121, 23);
            cbZanr.TabIndex = 3;
            cbZanr.SelectedIndexChanged += cbZanr_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 54);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Autor:";
            label3.Click += label3_Click;
            // 
            // godina
            // 
            godina.Location = new Point(104, 83);
            godina.Name = "godina";
            godina.Size = new Size(200, 23);
            godina.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 22);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Naslov:";
            label2.Click += label2_Click;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(204, 51);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 1;
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(204, 19);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(100, 23);
            txtNaslov.TabIndex = 0;
            txtNaslov.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dostupnost);
            groupBox2.Controls.Add(brStr);
            groupBox2.Location = new Point(33, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dodatni Podaci";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Broj stranica:";
            // 
            // dostupnost
            // 
            dostupnost.AutoSize = true;
            dostupnost.Location = new Point(86, 51);
            dostupnost.Name = "dostupnost";
            dostupnost.Size = new Size(141, 19);
            dostupnost.TabIndex = 1;
            dostupnost.Text = "Dostupna za posudbu";
            dostupnost.UseVisualStyleBackColor = true;
            dostupnost.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // brStr
            // 
            brStr.Location = new Point(86, 22);
            brStr.Name = "brStr";
            brStr.Size = new Size(105, 23);
            brStr.TabIndex = 0;
            brStr.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(543, 52);
            button1.Name = "button1";
            button1.Size = new Size(200, 100);
            button1.TabIndex = 2;
            button1.Text = "Spremi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(543, 196);
            button2.Name = "button2";
            button2.Size = new Size(200, 100);
            button2.TabIndex = 3;
            button2.Text = "Odustani";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Unos knjiga";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brStr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNaslov;
        private ComboBox cbZanr;
        private DateTimePicker godina;
        private TextBox txtAutor;
        private GroupBox groupBox2;
        private NumericUpDown brStr;
        private CheckBox dostupnost;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}