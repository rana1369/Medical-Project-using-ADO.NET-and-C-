namespace Final_Design
{
    partial class Make_Order
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Total_Price = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Save_Order = new System.Windows.Forms.Button();
            this.serchOrder = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.medicineId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save_Reteve_Order = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_to_card = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_to_card)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(155, 24);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(215, 37);
            this.Search.TabIndex = 1;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by Name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(3, 123);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 30;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(661, 293);
            this.dataGridView2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 35);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity";
            // 
            // Total_Price
            // 
            this.Total_Price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Total_Price.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Total_Price.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.Total_Price.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Total_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price.ForeColor = System.Drawing.Color.Black;
            this.Total_Price.Location = new System.Drawing.Point(1015, 475);
            this.Total_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(82, 46);
            this.Total_Price.TabIndex = 13;
            this.Total_Price.Text = "Total Price";
            this.Total_Price.UseVisualStyleBackColor = true;
            this.Total_Price.Click += new System.EventHandler(this.Total_Price_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1103, 487);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 30);
            this.textBox2.TabIndex = 14;
            // 
            // Save_Order
            // 
            this.Save_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Save_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Order.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save_Order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Save_Order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Save_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Order.ForeColor = System.Drawing.Color.PowderBlue;
            this.Save_Order.Location = new System.Drawing.Point(0, 751);
            this.Save_Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_Order.Name = "Save_Order";
            this.Save_Order.Size = new System.Drawing.Size(1486, 86);
            this.Save_Order.TabIndex = 15;
            this.Save_Order.Text = "Save Order";
            this.Save_Order.UseVisualStyleBackColor = false;
            this.Save_Order.Click += new System.EventHandler(this.Save_Order_Click);
            // 
            // serchOrder
            // 
            this.serchOrder.Location = new System.Drawing.Point(289, 54);
            this.serchOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serchOrder.Multiline = true;
            this.serchOrder.Name = "serchOrder";
            this.serchOrder.Size = new System.Drawing.Size(100, 30);
            this.serchOrder.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(494, 54);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 30);
            this.textBox3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(490, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "New Quantity for retreve";
            // 
            // medicineId
            // 
            this.medicineId.Location = new System.Drawing.Point(111, 54);
            this.medicineId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medicineId.Multiline = true;
            this.medicineId.Name = "medicineId";
            this.medicineId.Size = new System.Drawing.Size(100, 30);
            this.medicineId.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(285, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Order Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(109, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Medicine Id";
            // 
            // Save_Reteve_Order
            // 
            this.Save_Reteve_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Reteve_Order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Save_Reteve_Order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Save_Reteve_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Reteve_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Reteve_Order.ForeColor = System.Drawing.Color.White;
            this.Save_Reteve_Order.Location = new System.Drawing.Point(757, 100);
            this.Save_Reteve_Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_Reteve_Order.Name = "Save_Reteve_Order";
            this.Save_Reteve_Order.Size = new System.Drawing.Size(79, 34);
            this.Save_Reteve_Order.TabIndex = 23;
            this.Save_Reteve_Order.Text = "Save";
            this.Save_Reteve_Order.UseVisualStyleBackColor = true;
            this.Save_Reteve_Order.Click += new System.EventHandler(this.Save_Reteve_Order_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Add_to_card);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 438);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "To";
            // 
            // Add_to_card
            // 
            this.Add_to_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_to_card.Image = global::Final_Design.Properties.Resources.cart;
            this.Add_to_card.Location = new System.Drawing.Point(467, 51);
            this.Add_to_card.Name = "Add_to_card";
            this.Add_to_card.Size = new System.Drawing.Size(66, 52);
            this.Add_to_card.TabIndex = 12;
            this.Add_to_card.TabStop = false;
            this.Add_to_card.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Add_to_card_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.serchOrder);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.Save_Reteve_Order);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.medicineId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1486, 145);
            this.panel2.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(707, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Retreve";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Final_Design.Properties.Resources.money_back;
            this.pictureBox3.Location = new System.Drawing.Point(757, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(791, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 438);
            this.panel3.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(293, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 36);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cart";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.Total_Price);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(0, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1486, 557);
            this.panel4.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Final_Design.Properties.Resources.icons8_back_1001;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Make_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 835);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Save_Order);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Make_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_to_card)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Total_Price;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Save_Order;
        private System.Windows.Forms.TextBox serchOrder;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox medicineId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save_Reteve_Order;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Add_to_card;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}