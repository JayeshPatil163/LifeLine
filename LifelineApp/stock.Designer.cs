namespace LifelineApp
{
    partial class stock
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
 
            dgv_stock = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_stock).BeginInit();
            SuspendLayout();
            // 
            // dgv_stock
            // 
            dgv_stock.AllowUserToAddRows = false;
            dgv_stock.AllowUserToDeleteRows = false;
            dgv_stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_stock.Location = new Point(127, 112);
            dgv_stock.Name = "dgv_stock";
            dgv_stock.ReadOnly = true;
            dgv_stock.RowTemplate.Height = 25;
            dgv_stock.Size = new Size(774, 392);
            dgv_stock.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Search Medicine";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 526);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dgv_stock);
            Name = "stock";
            Text = "stock";
            Load += stock_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_stock).EndInit();
            ResumeLayout(false);
            PerformLayout();
 
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_stock
            // 
            this.dgv_stock.AllowUserToAddRows = false;
            this.dgv_stock.AllowUserToDeleteRows = false;
            this.dgv_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(127, 112);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.ReadOnly = true;
            this.dgv_stock.RowTemplate.Height = 25;
            this.dgv_stock.Size = new System.Drawing.Size(774, 392);
            this.dgv_stock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Medicine";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 526);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_stock);
            this.Name = "stock";
            this.Text = "stock";
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

         }

        #endregion

        private DataGridView dgv_stock;
        private Label label1;
        private TextBox textBox1;
    }
}