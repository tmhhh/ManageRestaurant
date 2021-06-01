
namespace ResManage.Forms.Statistic
{
    partial class frmStatistic
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
            this.label1 = new System.Windows.Forms.Label();
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdByMonth = new System.Windows.Forms.RadioButton();
            this.rdByDay = new System.Windows.Forms.RadioButton();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.chartFavorite = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favourite Dishes";
            // 
            // gvResult
            // 
            this.gvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(16, 142);
            this.gvResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvResult.Name = "gvResult";
            this.gvResult.RowHeadersWidth = 51;
            this.gvResult.Size = new System.Drawing.Size(514, 463);
            this.gvResult.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdByMonth);
            this.groupBox1.Controls.Add(this.rdByDay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(319, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(339, 86);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // rdByMonth
            // 
            this.rdByMonth.AutoSize = true;
            this.rdByMonth.Location = new System.Drawing.Point(189, 33);
            this.rdByMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdByMonth.Name = "rdByMonth";
            this.rdByMonth.Size = new System.Drawing.Size(89, 28);
            this.rdByMonth.TabIndex = 1;
            this.rdByMonth.TabStop = true;
            this.rdByMonth.Text = "Month";
            this.rdByMonth.UseVisualStyleBackColor = true;
            // 
            // rdByDay
            // 
            this.rdByDay.AutoSize = true;
            this.rdByDay.Location = new System.Drawing.Point(8, 33);
            this.rdByDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdByDay.Name = "rdByDay";
            this.rdByDay.Size = new System.Drawing.Size(66, 28);
            this.rdByDay.TabIndex = 0;
            this.rdByDay.TabStop = true;
            this.rdByDay.Text = "Day";
            this.rdByDay.UseVisualStyleBackColor = true;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(16, 97);
            this.dtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(265, 22);
            this.dtDate.TabIndex = 16;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShow.Location = new System.Drawing.Point(753, 60);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 38);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // chartFavorite
            // 
            this.chartFavorite.BackColor = System.Drawing.Color.SeaShell;
            chartArea1.Name = "ChartArea1";
            this.chartFavorite.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFavorite.Legends.Add(legend1);
            this.chartFavorite.Location = new System.Drawing.Point(537, 142);
            this.chartFavorite.Name = "chartFavorite";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "favorite";
            this.chartFavorite.Series.Add(series1);
            this.chartFavorite.Size = new System.Drawing.Size(435, 456);
            this.chartFavorite.TabIndex = 18;
            this.chartFavorite.Text = "chartFavorite";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "Favorite Food";
            this.chartFavorite.Titles.Add(title1);
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(984, 610);
            this.Controls.Add(this.chartFavorite);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvResult);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFavorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdByMonth;
        private System.Windows.Forms.RadioButton rdByDay;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFavorite;
    }
}