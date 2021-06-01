
namespace ResManage.Forms
{
    partial class Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRevenue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowBtn = new ePOSOne.btnProduct.Button_WOC();
            this.BackBtn = new ePOSOne.btnProduct.Button_WOC();
            this.chartRev = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRev)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.AllowUserToAddRows = false;
            this.dgvRevenue.AllowUserToDeleteRows = false;
            this.dgvRevenue.AllowUserToResizeColumns = false;
            this.dgvRevenue.AllowUserToResizeRows = false;
            this.dgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(13, 137);
            this.dgvRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersWidth = 51;
            this.dgvRevenue.RowTemplate.Height = 24;
            this.dgvRevenue.Size = new System.Drawing.Size(722, 515);
            this.dgvRevenue.TabIndex = 0;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(118, 36);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(199, 28);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(458, 36);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(199, 28);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Between";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "And";
            // 
            // textBoxRevenue
            // 
            this.textBoxRevenue.BackColor = System.Drawing.Color.OrangeRed;
            this.textBoxRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRevenue.ForeColor = System.Drawing.Color.White;
            this.textBoxRevenue.Location = new System.Drawing.Point(545, 659);
            this.textBoxRevenue.Name = "textBoxRevenue";
            this.textBoxRevenue.Size = new System.Drawing.Size(190, 30);
            this.textBoxRevenue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 659);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Revenue";
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowBtn.BorderColor = System.Drawing.Color.Transparent;
            this.ShowBtn.ButtonColor = System.Drawing.Color.Tomato;
            this.ShowBtn.FlatAppearance.BorderSize = 0;
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.Location = new System.Drawing.Point(316, 78);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ShowBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.ShowBtn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.ShowBtn.Size = new System.Drawing.Size(116, 52);
            this.ShowBtn.TabIndex = 17;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.TextColor = System.Drawing.Color.White;
            this.ShowBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::ResManage.Properties.Resources.back;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.BorderColor = System.Drawing.Color.Transparent;
            this.BackBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Location = new System.Drawing.Point(1266, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.BackBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.BackBtn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BackBtn.Size = new System.Drawing.Size(61, 61);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.TextColor = System.Drawing.Color.White;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // chartRev
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRev.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRev.Legends.Add(legend1);
            this.chartRev.Location = new System.Drawing.Point(742, 137);
            this.chartRev.Name = "chartRev";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "revenue";
            this.chartRev.Series.Add(series1);
            this.chartRev.Size = new System.Drawing.Size(585, 515);
            this.chartRev.TabIndex = 19;
            this.chartRev.Text = "chartRevenue";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Gold;
            title1.Name = "Title1";
            title1.Text = "Revenue";
            this.chartRev.Titles.Add(title1);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1339, 738);
            this.Controls.Add(this.chartRev);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRevenue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dgvRevenue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Revenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRevenue;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC ShowBtn;
        private ePOSOne.btnProduct.Button_WOC BackBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRev;
    }
}