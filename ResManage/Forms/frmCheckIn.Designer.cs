
namespace ResManage.Forms
{
    partial class frmCheckIn
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
            this.gvDailyWave = new System.Windows.Forms.DataGridView();
            this.btnWaveCalculate = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyWave)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDailyWave
            // 
            this.gvDailyWave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDailyWave.Location = new System.Drawing.Point(420, 140);
            this.gvDailyWave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gvDailyWave.Name = "gvDailyWave";
            this.gvDailyWave.RowHeadersWidth = 62;
            this.gvDailyWave.Size = new System.Drawing.Size(478, 349);
            this.gvDailyWave.TabIndex = 10;
            // 
            // btnWaveCalculate
            // 
            this.btnWaveCalculate.Location = new System.Drawing.Point(481, 39);
            this.btnWaveCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWaveCalculate.Name = "btnWaveCalculate";
            this.btnWaveCalculate.Size = new System.Drawing.Size(112, 60);
            this.btnWaveCalculate.TabIndex = 9;
            this.btnWaveCalculate.Text = "Wave Calculation";
            this.btnWaveCalculate.UseVisualStyleBackColor = true;
            this.btnWaveCalculate.Click += new System.EventHandler(this.btnWaveCalculate_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(23, 15);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "label1";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(179, 39);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(112, 60);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(28, 39);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(112, 60);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 559);
            this.Controls.Add(this.gvDailyWave);
            this.Controls.Add(this.btnWaveCalculate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Name = "frmCheckIn";
            this.Text = "frmCheckIn";
            ((System.ComponentModel.ISupportInitialize)(this.gvDailyWave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDailyWave;
        private System.Windows.Forms.Button btnWaveCalculate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
    }
}