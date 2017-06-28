namespace PointOfSales
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recentlyAdded = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTotal = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.shopJoggers = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.shopSocks = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.shopBooks = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.shopGlasses = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.shopShoe = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.exportToXml = new System.Windows.Forms.Button();
            this.Receipt = new System.Windows.Forms.Label();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.dataReset = new System.Windows.Forms.Button();
            this.finalReceipt = new System.Windows.Forms.TextBox();
            this.newItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newItemPrice = new System.Windows.Forms.TextBox();
            this.addToList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.recentlyAdded);
            this.groupBox2.Location = new System.Drawing.Point(447, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(17, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 126);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 210;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 205;
            // 
            // recentlyAdded
            // 
            this.recentlyAdded.AutoSize = true;
            this.recentlyAdded.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentlyAdded.Location = new System.Drawing.Point(178, 9);
            this.recentlyAdded.Name = "recentlyAdded";
            this.recentlyAdded.Size = new System.Drawing.Size(169, 24);
            this.recentlyAdded.TabIndex = 0;
            this.recentlyAdded.Text = "Recently Added";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.addTotal);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(0, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 315);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items";
            // 
            // addTotal
            // 
            this.addTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTotal.Location = new System.Drawing.Point(310, 269);
            this.addTotal.Name = "addTotal";
            this.addTotal.Size = new System.Drawing.Size(105, 23);
            this.addTotal.TabIndex = 3;
            this.addTotal.Text = "Add to Cart";
            this.addTotal.UseVisualStyleBackColor = true;
            this.addTotal.Click += new System.EventHandler(this.addTotal_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numericUpDown5);
            this.groupBox9.Controls.Add(this.shopJoggers);
            this.groupBox9.Location = new System.Drawing.Point(5, 239);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(136, 35);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Location = new System.Drawing.Point(87, 11);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown5.TabIndex = 1;
            // 
            // shopJoggers
            // 
            this.shopJoggers.AutoSize = true;
            this.shopJoggers.Location = new System.Drawing.Point(3, 13);
            this.shopJoggers.Name = "shopJoggers";
            this.shopJoggers.Size = new System.Drawing.Size(63, 17);
            this.shopJoggers.TabIndex = 0;
            this.shopJoggers.Text = "Joggers";
            this.shopJoggers.UseVisualStyleBackColor = true;
            this.shopJoggers.CheckedChanged += new System.EventHandler(this.shopJoggers_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numericUpDown4);
            this.groupBox8.Controls.Add(this.shopSocks);
            this.groupBox8.Location = new System.Drawing.Point(6, 194);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(133, 35);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(87, 11);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown4.TabIndex = 1;
            // 
            // shopSocks
            // 
            this.shopSocks.AutoSize = true;
            this.shopSocks.Location = new System.Drawing.Point(3, 13);
            this.shopSocks.Name = "shopSocks";
            this.shopSocks.Size = new System.Drawing.Size(56, 17);
            this.shopSocks.TabIndex = 0;
            this.shopSocks.Text = "Socks";
            this.shopSocks.UseVisualStyleBackColor = true;
            this.shopSocks.CheckedChanged += new System.EventHandler(this.shopSocks_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDown3);
            this.groupBox7.Controls.Add(this.shopBooks);
            this.groupBox7.Location = new System.Drawing.Point(7, 146);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(133, 35);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(85, 11);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown3.TabIndex = 1;
            // 
            // shopBooks
            // 
            this.shopBooks.AutoSize = true;
            this.shopBooks.Location = new System.Drawing.Point(3, 13);
            this.shopBooks.Name = "shopBooks";
            this.shopBooks.Size = new System.Drawing.Size(56, 17);
            this.shopBooks.TabIndex = 0;
            this.shopBooks.Text = "Books";
            this.shopBooks.UseVisualStyleBackColor = true;
            this.shopBooks.CheckedChanged += new System.EventHandler(this.shopBooks_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDown2);
            this.groupBox6.Controls.Add(this.shopGlasses);
            this.groupBox6.Location = new System.Drawing.Point(6, 99);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 35);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(87, 11);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // shopGlasses
            // 
            this.shopGlasses.AutoSize = true;
            this.shopGlasses.Location = new System.Drawing.Point(7, 13);
            this.shopGlasses.Name = "shopGlasses";
            this.shopGlasses.Size = new System.Drawing.Size(63, 17);
            this.shopGlasses.TabIndex = 0;
            this.shopGlasses.Text = "Glasses";
            this.shopGlasses.UseVisualStyleBackColor = true;
            this.shopGlasses.CheckedChanged += new System.EventHandler(this.shopGlasses_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.shopShoe);
            this.groupBox5.Location = new System.Drawing.Point(8, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 35);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(87, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // shopShoe
            // 
            this.shopShoe.AutoSize = true;
            this.shopShoe.Location = new System.Drawing.Point(3, 13);
            this.shopShoe.Name = "shopShoe";
            this.shopShoe.Size = new System.Drawing.Size(51, 17);
            this.shopShoe.TabIndex = 0;
            this.shopShoe.Text = "Shoe";
            this.shopShoe.UseVisualStyleBackColor = true;
            this.shopShoe.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.exportToXml);
            this.groupBox4.Controls.Add(this.Receipt);
            this.groupBox4.Controls.Add(this.Button_Exit);
            this.groupBox4.Controls.Add(this.dataReset);
            this.groupBox4.Controls.Add(this.finalReceipt);
            this.groupBox4.Location = new System.Drawing.Point(447, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 294);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // exportToXml
            // 
            this.exportToXml.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToXml.Location = new System.Drawing.Point(387, 206);
            this.exportToXml.Name = "exportToXml";
            this.exportToXml.Size = new System.Drawing.Size(75, 23);
            this.exportToXml.TabIndex = 4;
            this.exportToXml.Text = "Export";
            this.exportToXml.UseVisualStyleBackColor = true;
            this.exportToXml.Click += new System.EventHandler(this.exportToXml_Click);
            // 
            // Receipt
            // 
            this.Receipt.AutoSize = true;
            this.Receipt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipt.Location = new System.Drawing.Point(126, 16);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(87, 24);
            this.Receipt.TabIndex = 3;
            this.Receipt.Text = "Receipt";
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(387, 146);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 23);
            this.Button_Exit.TabIndex = 2;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataReset
            // 
            this.dataReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataReset.Location = new System.Drawing.Point(387, 87);
            this.dataReset.Name = "dataReset";
            this.dataReset.Size = new System.Drawing.Size(75, 23);
            this.dataReset.TabIndex = 1;
            this.dataReset.Text = "Reset";
            this.dataReset.UseVisualStyleBackColor = true;
            this.dataReset.Click += new System.EventHandler(this.dataReset_Click);
            // 
            // finalReceipt
            // 
            this.finalReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.finalReceipt.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalReceipt.Location = new System.Drawing.Point(6, 45);
            this.finalReceipt.Multiline = true;
            this.finalReceipt.Name = "finalReceipt";
            this.finalReceipt.Size = new System.Drawing.Size(350, 235);
            this.finalReceipt.TabIndex = 0;
            // 
            // newItemName
            // 
            this.newItemName.Location = new System.Drawing.Point(122, 59);
            this.newItemName.Name = "newItemName";
            this.newItemName.Size = new System.Drawing.Size(100, 20);
            this.newItemName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // newItemPrice
            // 
            this.newItemPrice.Location = new System.Drawing.Point(122, 98);
            this.newItemPrice.Name = "newItemPrice";
            this.newItemPrice.Size = new System.Drawing.Size(100, 20);
            this.newItemPrice.TabIndex = 4;
            // 
            // addToList
            // 
            this.addToList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToList.Location = new System.Drawing.Point(310, 107);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(98, 23);
            this.addToList.TabIndex = 5;
            this.addToList.Text = "Add to List";
            this.addToList.UseVisualStyleBackColor = true;
            this.addToList.Click += new System.EventHandler(this.addToList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addToList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.newItemPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newItemName);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 9);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Add Item";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 466);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox newItemName;
        private System.Windows.Forms.Button addToList;
        private System.Windows.Forms.TextBox newItemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button dataReset;
        private System.Windows.Forms.TextBox finalReceipt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.CheckBox shopJoggers;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.CheckBox shopSocks;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox shopBooks;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox shopGlasses;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox shopShoe;
        private System.Windows.Forms.Button addTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recentlyAdded;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label Receipt;
        private System.Windows.Forms.Button exportToXml;
    }
}

