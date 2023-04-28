namespace LifelineApp
{
    partial class po_master1
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
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox_trtype = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox_id = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            ft = new Label();
            l7 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(107, 84);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "INVOICE DATE";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(695, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(570, 76);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "SELECT DEALER";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(107, 143);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "BILL-NO";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(542, 135);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 6;
            label4.Text = "TRANSACTION-TYPE";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(232, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox_trtype
            // 
            textBox_trtype.Anchor = AnchorStyles.None;
            textBox_trtype.Location = new Point(695, 132);
            textBox_trtype.Name = "textBox_trtype";
            textBox_trtype.ReadOnly = true;
            textBox_trtype.Size = new Size(121, 23);
            textBox_trtype.TabIndex = 12;
            textBox_trtype.Text = "OFFLINE";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 285);
            dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(445, 529);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.None;
            textBox_id.Location = new Point(822, 68);
            textBox_id.Name = "textBox_id";
            textBox_id.ReadOnly = true;
            textBox_id.Size = new Size(18, 23);
            textBox_id.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(232, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2023, 2, 26, 0, 17, 39, 0);
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(667, 529);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(861, 529);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 17;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(103, 522);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 18;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(103, 594);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 19;
            label6.Text = "0";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(103, 555);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 21;
            label8.Text = "0";
            // 
            // ft
            // 
            ft.Anchor = AnchorStyles.None;
            ft.AutoSize = true;
            ft.Location = new Point(432, 591);
            ft.Name = "ft";
            ft.Size = new Size(13, 15);
            ft.TabIndex = 22;
            ft.Text = "0";
            // 
            // l7
            // 
            l7.AutoSize = true;
            l7.Location = new Point(415, 138);
            l7.Name = "l7";
            l7.Size = new Size(38, 15);
            l7.TabIndex = 23;
            l7.Text = "label7";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(10, 518);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 24;
            label7.Text = "Total price";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(-7, 591);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 25;
            label9.Text = "Total Discount";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(-11, 555);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 26;
            label10.Text = "Total - Discount";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(320, 591);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 27;
            label11.Text = "Net Amount";
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            // 
            // po_master1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 637);
            Controls.Add(button4);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(l7);
            Controls.Add(ft);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox_id);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_trtype);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "po_master1";
            Text = "po_master1";
            WindowState = FormWindowState.Maximized;
            Load += po_master1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox_trtype;
        private Button button1;
        private TextBox textBox_id;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        public DataGridView dataGridView1;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label ft;
        private Label l7;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button4;
    }
}