
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
            this.label1 = new System.Windows.Forms.Label();
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdByMonth = new System.Windows.Forms.RadioButton();
            this.rdByDay = new System.Windows.Forms.RadioButton();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favourite Dishes";
            // 
            // gvResult
            // 
            this.gvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(12, 115);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(600, 376);
            this.gvResult.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdByMonth);
            this.groupBox1.Controls.Add(this.rdByDay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(239, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 70);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // rdByMonth
            // 
            this.rdByMonth.AutoSize = true;
            this.rdByMonth.Location = new System.Drawing.Point(142, 27);
            this.rdByMonth.Name = "rdByMonth";
            this.rdByMonth.Size = new System.Drawing.Size(73, 22);
            this.rdByMonth.TabIndex = 1;
            this.rdByMonth.TabStop = true;
            this.rdByMonth.Text = "Month";
            this.rdByMonth.UseVisualStyleBackColor = true;
            // 
            // rdByDay
            // 
            this.rdByDay.AutoSize = true;
            this.rdByDay.Location = new System.Drawing.Point(6, 27);
            this.rdByDay.Name = "rdByDay";
            this.rdByDay.Size = new System.Drawing.Size(55, 22);
            this.rdByDay.TabIndex = 0;
            this.rdByDay.TabStop = true;
            this.rdByDay.Text = "Day";
            this.rdByDay.UseVisualStyleBackColor = true;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(12, 79);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 20);
            this.dtDate.TabIndex = 16;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShow.Location = new System.Drawing.Point(537, 39);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 496);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvResult);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}