
namespace ResManage.Forms.Foods
{
    partial class frmEditDelete
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.txbFQuantity = new System.Windows.Forms.TextBox();
            this.txbFPrice = new System.Windows.Forms.TextBox();
            this.txbFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.foodName = new System.Windows.Forms.Label();
            this.Dish = new System.Windows.Forms.Label();
            this.gvListFood = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.foodID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(169, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 36);
            this.label8.TabIndex = 27;
            this.label8.Text = "Edit";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pbPic);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cbCate);
            this.panel1.Controls.Add(this.txbFQuantity);
            this.panel1.Controls.Add(this.txbFPrice);
            this.panel1.Controls.Add(this.txbFName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.foodName);
            this.panel1.Location = new System.Drawing.Point(13, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 648);
            this.panel1.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(164, 462);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "Upload";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(20, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Photo";
            // 
            // pbPic
            // 
            this.pbPic.Location = new System.Drawing.Point(164, 329);
            this.pbPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(182, 123);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 10;
            this.pbPic.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(124, 545);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 54);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbCate
            // 
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(164, 140);
            this.cbCate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(180, 28);
            this.cbCate.TabIndex = 8;
            // 
            // txbFQuantity
            // 
            this.txbFQuantity.Location = new System.Drawing.Point(164, 269);
            this.txbFQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFQuantity.Name = "txbFQuantity";
            this.txbFQuantity.Size = new System.Drawing.Size(180, 26);
            this.txbFQuantity.TabIndex = 7;
            // 
            // txbFPrice
            // 
            this.txbFPrice.Location = new System.Drawing.Point(164, 206);
            this.txbFPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFPrice.Name = "txbFPrice";
            this.txbFPrice.Size = new System.Drawing.Size(180, 26);
            this.txbFPrice.TabIndex = 6;
            // 
            // txbFName
            // 
            this.txbFName.Location = new System.Drawing.Point(164, 74);
            this.txbFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFName.Name = "txbFName";
            this.txbFName.Size = new System.Drawing.Size(180, 26);
            this.txbFName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // foodName
            // 
            this.foodName.AutoSize = true;
            this.foodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.foodName.Location = new System.Drawing.Point(20, 78);
            this.foodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodName.Name = "foodName";
            this.foodName.Size = new System.Drawing.Size(68, 25);
            this.foodName.TabIndex = 1;
            this.foodName.Text = "Name";
            // 
            // Dish
            // 
            this.Dish.AutoSize = true;
            this.Dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Dish.Location = new System.Drawing.Point(471, 17);
            this.Dish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dish.Name = "Dish";
            this.Dish.Size = new System.Drawing.Size(88, 36);
            this.Dish.TabIndex = 25;
            this.Dish.Text = "Food";
            // 
            // gvListFood
            // 
            this.gvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListFood.Location = new System.Drawing.Point(525, 133);
            this.gvListFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gvListFood.Name = "gvListFood";
            this.gvListFood.RowHeadersWidth = 62;
            this.gvListFood.RowTemplate.Height = 40;
            this.gvListFood.Size = new System.Drawing.Size(554, 392);
            this.gvListFood.TabIndex = 28;
            this.gvListFood.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListFood_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(744, 542);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txbFoodID);
            this.panel2.Controls.Add(this.foodID);
            this.panel2.Location = new System.Drawing.Point(525, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 168);
            this.panel2.TabIndex = 32;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(170, 92);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 54);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(203, 45);
            this.txbFoodID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.Size = new System.Drawing.Size(114, 26);
            this.txbFoodID.TabIndex = 7;
            // 
            // foodID
            // 
            this.foodID.AutoSize = true;
            this.foodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.foodID.Location = new System.Drawing.Point(87, 46);
            this.foodID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodID.Name = "foodID";
            this.foodID.Size = new System.Drawing.Size(88, 25);
            this.foodID.TabIndex = 6;
            this.foodID.Text = "Food ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(525, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 33;
            this.button1.Text = "View Food";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gvListFood);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dish);
            this.Name = "frmEditDelete";
            this.Text = "frmEditDelete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.TextBox txbFQuantity;
        private System.Windows.Forms.TextBox txbFPrice;
        private System.Windows.Forms.TextBox txbFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label foodName;
        private System.Windows.Forms.Label Dish;
        private System.Windows.Forms.DataGridView gvListFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label foodID;
        private System.Windows.Forms.Button button1;
    }
}