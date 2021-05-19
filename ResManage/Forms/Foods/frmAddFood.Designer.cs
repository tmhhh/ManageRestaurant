
namespace ResManage.Forms.Foods
{
    partial class frmAddFood
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
            this.label13 = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.gvListFood = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.txbFQuantity = new System.Windows.Forms.TextBox();
            this.txbFPrice = new System.Windows.Forms.TextBox();
            this.txbFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.foodName = new System.Windows.Forms.Label();
            this.Dish = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListFood)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(533, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Search food by name, id, ...";
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(537, 92);
            this.txbInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(168, 26);
            this.txbInput.TabIndex = 29;
            // 
            // gvListFood
            // 
            this.gvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListFood.Location = new System.Drawing.Point(537, 132);
            this.gvListFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gvListFood.Name = "gvListFood";
            this.gvListFood.RowHeadersWidth = 62;
            this.gvListFood.RowTemplate.Height = 40;
            this.gvListFood.Size = new System.Drawing.Size(626, 608);
            this.gvListFood.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(157, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 36);
            this.label8.TabIndex = 27;
            this.label8.Text = "Add";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pbPic);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbCate);
            this.panel1.Controls.Add(this.txbFQuantity);
            this.panel1.Controls.Add(this.txbFPrice);
            this.panel1.Controls.Add(this.txbFName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.foodName);
            this.panel1.Location = new System.Drawing.Point(-1, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 648);
            this.panel1.TabIndex = 26;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpload.Location = new System.Drawing.Point(164, 462);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(114, 32);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(124, 545);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 54);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Food";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Dish.Location = new System.Drawing.Point(457, 18);
            this.Dish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dish.Name = "Dish";
            this.Dish.Size = new System.Drawing.Size(88, 36);
            this.Dish.TabIndex = 25;
            this.Dish.Text = "Food";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.BackgroundImage = global::ResManage.Properties.Resources.glass1;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(716, 81);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 49);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // frmAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 769);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.gvListFood);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dish);
            this.Name = "frmAddFood";
            this.Text = "frmAddFood";
            ((System.ComponentModel.ISupportInitialize)(this.gvListFood)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.DataGridView gvListFood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.TextBox txbFQuantity;
        private System.Windows.Forms.TextBox txbFPrice;
        private System.Windows.Forms.TextBox txbFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label foodName;
        private System.Windows.Forms.Label Dish;
    }
}