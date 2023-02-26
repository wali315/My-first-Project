namespace my_first_project
{
    partial class Shop
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idcombo = new System.Windows.Forms.TextBox();
            this.coffeecombo = new System.Windows.Forms.ComboBox();
            this.typecombo = new System.Windows.Forms.ComboBox();
            this.quantitycombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoffeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.paytext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coffee Shop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Coffee Name:";
            // 
            // idcombo
            // 
            this.idcombo.Location = new System.Drawing.Point(155, 98);
            this.idcombo.Name = "idcombo";
            this.idcombo.Size = new System.Drawing.Size(144, 20);
            this.idcombo.TabIndex = 6;
            this.idcombo.Text = "Enter Id";
            this.idcombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idcombo_KeyPress);
            // 
            // coffeecombo
            // 
            this.coffeecombo.FormattingEnabled = true;
            this.coffeecombo.Items.AddRange(new object[] {
            "Latte",
            "Cappuchino",
            "Chocolate"});
            this.coffeecombo.Location = new System.Drawing.Point(155, 153);
            this.coffeecombo.Name = "coffeecombo";
            this.coffeecombo.Size = new System.Drawing.Size(144, 21);
            this.coffeecombo.TabIndex = 7;
            this.coffeecombo.Text = "Select Coffee Name";
            // 
            // typecombo
            // 
            this.typecombo.FormattingEnabled = true;
            this.typecombo.Items.AddRange(new object[] {
            "Frapp",
            "Ice",
            "Hot"});
            this.typecombo.Location = new System.Drawing.Point(155, 208);
            this.typecombo.Name = "typecombo";
            this.typecombo.Size = new System.Drawing.Size(144, 21);
            this.typecombo.TabIndex = 8;
            this.typecombo.Text = "Select Coffee Type";
            // 
            // quantitycombo
            // 
            this.quantitycombo.FormattingEnabled = true;
            this.quantitycombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantitycombo.Location = new System.Drawing.Point(155, 263);
            this.quantitycombo.Name = "quantitycombo";
            this.quantitycombo.Size = new System.Drawing.Size(144, 21);
            this.quantitycombo.TabIndex = 9;
            this.quantitycombo.Text = "Select Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CoffeeName,
            this.Type,
            this.Quantity,
            this.Payment});
            this.dataGridView1.Location = new System.Drawing.Point(347, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 186);
            this.dataGridView1.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // CoffeeName
            // 
            this.CoffeeName.HeaderText = "CoffeeNamee";
            this.CoffeeName.Name = "CoffeeName";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total:";
            // 
            // paytext
            // 
            this.paytext.Location = new System.Drawing.Point(155, 310);
            this.paytext.Name = "paytext";
            this.paytext.Size = new System.Drawing.Size(144, 20);
            this.paytext.TabIndex = 15;
            this.paytext.Text = "Total Payment";
            // 
            // Shop
            // 
            this.ClientSize = new System.Drawing.Size(949, 538);
            this.Controls.Add(this.paytext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quantitycombo);
            this.Controls.Add(this.typecombo);
            this.Controls.Add(this.coffeecombo);
            this.Controls.Add(this.idcombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Shop";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idcombo;
        private System.Windows.Forms.ComboBox coffeecombo;
        private System.Windows.Forms.ComboBox typecombo;
        private System.Windows.Forms.ComboBox quantitycombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoffeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paytext;
    }
}

