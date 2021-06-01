
namespace ResManage.Forms
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flpnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.comboBoxFoodByCatID = new System.Windows.Forms.ComboBox();
            this.frpnOrder = new System.Windows.Forms.Panel();
            this.OrderBtn = new ePOSOne.btnProduct.Button_WOC();
            this.quantitySelect = new System.Windows.Forms.NumericUpDown();
            this.frpnBill = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.clFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFooDQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSTB = new System.Windows.Forms.Button();
            this.cbSTB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discountNumer = new System.Windows.Forms.NumericUpDown();
            this.payBtn = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.BackBtn = new ePOSOne.btnProduct.Button_WOC();
            this.closeBtn = new ePOSOne.btnProduct.Button_WOC();
            this.label2 = new System.Windows.Forms.Label();
            this.nPeople = new System.Windows.Forms.NumericUpDown();
            this.frpnOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelect)).BeginInit();
            this.frpnBill.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flpnMain
            // 
            this.flpnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpnMain.Location = new System.Drawing.Point(10, 116);
            this.flpnMain.Name = "flpnMain";
            this.flpnMain.Size = new System.Drawing.Size(471, 565);
            this.flpnMain.TabIndex = 9;
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(3, 11);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(165, 25);
            this.comboBoxCat.TabIndex = 12;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // comboBoxFoodByCatID
            // 
            this.comboBoxFoodByCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFoodByCatID.FormattingEnabled = true;
            this.comboBoxFoodByCatID.Location = new System.Drawing.Point(3, 49);
            this.comboBoxFoodByCatID.Name = "comboBoxFoodByCatID";
            this.comboBoxFoodByCatID.Size = new System.Drawing.Size(165, 25);
            this.comboBoxFoodByCatID.TabIndex = 13;
            // 
            // frpnOrder
            // 
            this.frpnOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frpnOrder.Controls.Add(this.OrderBtn);
            this.frpnOrder.Controls.Add(this.quantitySelect);
            this.frpnOrder.Controls.Add(this.comboBoxCat);
            this.frpnOrder.Controls.Add(this.comboBoxFoodByCatID);
            this.frpnOrder.Location = new System.Drawing.Point(486, 116);
            this.frpnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.frpnOrder.Name = "frpnOrder";
            this.frpnOrder.Size = new System.Drawing.Size(344, 84);
            this.frpnOrder.TabIndex = 15;
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OrderBtn.BorderColor = System.Drawing.Color.Transparent;
            this.OrderBtn.ButtonColor = System.Drawing.Color.Tomato;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.Location = new System.Drawing.Point(238, 11);
            this.OrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.OrderBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.OrderBtn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.OrderBtn.Size = new System.Drawing.Size(88, 46);
            this.OrderBtn.TabIndex = 16;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.TextColor = System.Drawing.Color.White;
            this.OrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // quantitySelect
            // 
            this.quantitySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySelect.Location = new System.Drawing.Point(178, 53);
            this.quantitySelect.Margin = new System.Windows.Forms.Padding(2);
            this.quantitySelect.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.quantitySelect.Name = "quantitySelect";
            this.quantitySelect.Size = new System.Drawing.Size(46, 21);
            this.quantitySelect.TabIndex = 15;
            this.quantitySelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frpnBill
            // 
            this.frpnBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frpnBill.Controls.Add(this.lsvBill);
            this.frpnBill.Location = new System.Drawing.Point(486, 205);
            this.frpnBill.Margin = new System.Windows.Forms.Padding(2);
            this.frpnBill.Name = "frpnBill";
            this.frpnBill.Size = new System.Drawing.Size(318, 392);
            this.frpnBill.TabIndex = 16;
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.Ivory;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clFoodName,
            this.clFooDQuan,
            this.clUnitPrice,
            this.clTotal});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.ForeColor = System.Drawing.Color.Black;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 2);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(340, 387);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // clFoodName
            // 
            this.clFoodName.Text = "Food Name";
            this.clFoodName.Width = 100;
            // 
            // clFooDQuan
            // 
            this.clFooDQuan.Text = "Quantity";
            this.clFooDQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clFooDQuan.Width = 65;
            // 
            // clUnitPrice
            // 
            this.clUnitPrice.Text = "Unit Price";
            this.clUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clUnitPrice.Width = 70;
            // 
            // clTotal
            // 
            this.clTotal.Text = "Total";
            this.clTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTotal.Width = 72;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSTB);
            this.panel1.Controls.Add(this.cbSTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.discountNumer);
            this.panel1.Controls.Add(this.payBtn);
            this.panel1.Controls.Add(this.textBoxTotal);
            this.panel1.Location = new System.Drawing.Point(486, 600);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 81);
            this.panel1.TabIndex = 18;
            // 
            // buttonSTB
            // 
            this.buttonSTB.BackColor = System.Drawing.Color.Tomato;
            this.buttonSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSTB.Location = new System.Drawing.Point(3, 2);
            this.buttonSTB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSTB.Name = "buttonSTB";
            this.buttonSTB.Size = new System.Drawing.Size(68, 33);
            this.buttonSTB.TabIndex = 6;
            this.buttonSTB.Text = "Switch";
            this.buttonSTB.UseVisualStyleBackColor = false;
            this.buttonSTB.Click += new System.EventHandler(this.buttonSTB_Click);
            // 
            // cbSTB
            // 
            this.cbSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSTB.FormattingEnabled = true;
            this.cbSTB.Location = new System.Drawing.Point(3, 39);
            this.cbSTB.Margin = new System.Windows.Forms.Padding(2);
            this.cbSTB.Name = "cbSTB";
            this.cbSTB.Size = new System.Drawing.Size(69, 25);
            this.cbSTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Discount";
            // 
            // discountNumer
            // 
            this.discountNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountNumer.Location = new System.Drawing.Point(83, 32);
            this.discountNumer.Margin = new System.Windows.Forms.Padding(2);
            this.discountNumer.Name = "discountNumer";
            this.discountNumer.Size = new System.Drawing.Size(58, 23);
            this.discountNumer.TabIndex = 2;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Tomato;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.Image = global::ResManage.Properties.Resources.pay_removebg_preview__1_;
            this.payBtn.Location = new System.Drawing.Point(238, 13);
            this.payBtn.Margin = new System.Windows.Forms.Padding(2);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(100, 51);
            this.payBtn.TabIndex = 1;
            this.payBtn.Text = "Check Out";
            this.payBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.payBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.Tomato;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.White;
            this.textBoxTotal.Location = new System.Drawing.Point(149, 27);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(85, 28);
            this.textBoxTotal.TabIndex = 0;
            this.textBoxTotal.Text = "0";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::ResManage.Properties.Resources.logoxin;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(274, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(302, 115);
            this.pictureBoxLogo.TabIndex = 19;
            this.pictureBoxLogo.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::ResManage.Properties.Resources.back;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.BorderColor = System.Drawing.Color.Transparent;
            this.BackBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Location = new System.Drawing.Point(0, 0);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.BackBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.BackBtn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BackBtn.Size = new System.Drawing.Size(38, 37);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.TextColor = System.Drawing.Color.White;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = global::ResManage.Properties.Resources.xclose;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.closeBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(800, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.closeBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.closeBtn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.closeBtn.Size = new System.Drawing.Size(31, 37);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Number Of People";
            // 
            // nPeople
            // 
            this.nPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPeople.Location = new System.Drawing.Point(166, 94);
            this.nPeople.Margin = new System.Windows.Forms.Padding(2);
            this.nPeople.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nPeople.Name = "nPeople";
            this.nPeople.Size = new System.Drawing.Size(46, 21);
            this.nPeople.TabIndex = 18;
            this.nPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 688);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nPeople);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.frpnBill);
            this.Controls.Add(this.frpnOrder);
            this.Controls.Add(this.flpnMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.frpnOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelect)).EndInit();
            this.frpnBill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flpnMain;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.ComboBox comboBoxFoodByCatID;
        private System.Windows.Forms.Panel frpnOrder;
        private System.Windows.Forms.NumericUpDown quantitySelect;
        private System.Windows.Forms.Panel frpnBill;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader clFooDQuan;
        private System.Windows.Forms.ColumnHeader clUnitPrice;
        private System.Windows.Forms.ColumnHeader clTotal;
        private System.Windows.Forms.ColumnHeader clFoodName;
        private ePOSOne.btnProduct.Button_WOC BackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private ePOSOne.btnProduct.Button_WOC OrderBtn;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.NumericUpDown discountNumer;
        private System.Windows.Forms.ComboBox cbSTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSTB;
        private ePOSOne.btnProduct.Button_WOC closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nPeople;
    }
}