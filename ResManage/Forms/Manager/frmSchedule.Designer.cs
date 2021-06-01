﻿
namespace ResManage.Forms
{
    partial class frmSchedule
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
            this.txbTotalEmp = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTotalTime = new System.Windows.Forms.TextBox();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.gvSchedule = new System.Windows.Forms.DataGridView();
            this.btnFullSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Employee";
            // 
            // txbTotalEmp
            // 
            this.txbTotalEmp.Location = new System.Drawing.Point(215, 42);
            this.txbTotalEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotalEmp.Name = "txbTotalEmp";
            this.txbTotalEmp.ReadOnly = true;
            this.txbTotalEmp.Size = new System.Drawing.Size(143, 22);
            this.txbTotalEmp.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.Location = new System.Drawing.Point(379, 42);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 34);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(659, 16);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(265, 22);
            this.dtFrom.TabIndex = 3;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(659, 65);
            this.dtTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(265, 22);
            this.dtTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(577, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(577, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "From:";
            // 
            // txbTotalTime
            // 
            this.txbTotalTime.Location = new System.Drawing.Point(215, 84);
            this.txbTotalTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTotalTime.Name = "txbTotalTime";
            this.txbTotalTime.ReadOnly = true;
            this.txbTotalTime.Size = new System.Drawing.Size(143, 22);
            this.txbTotalTime.TabIndex = 9;
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(781, 111);
            this.txbNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(143, 22);
            this.txbNumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(497, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Emp per Shift";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(444, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Schedule";
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDraw.Location = new System.Drawing.Point(36, 143);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(191, 42);
            this.btnDraw.TabIndex = 12;
            this.btnDraw.Text = "Draw Schedule ";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // gvSchedule
            // 
            this.gvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSchedule.Location = new System.Drawing.Point(36, 271);
            this.gvSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvSchedule.Name = "gvSchedule";
            this.gvSchedule.RowHeadersWidth = 51;
            this.gvSchedule.Size = new System.Drawing.Size(976, 310);
            this.gvSchedule.TabIndex = 13;
            // 
            // btnFullSchedule
            // 
            this.btnFullSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFullSchedule.Location = new System.Drawing.Point(36, 202);
            this.btnFullSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFullSchedule.Name = "btnFullSchedule";
            this.btnFullSchedule.Size = new System.Drawing.Size(191, 42);
            this.btnFullSchedule.TabIndex = 14;
            this.btnFullSchedule.Text = "Full Schedule";
            this.btnFullSchedule.UseVisualStyleBackColor = true;
            this.btnFullSchedule.Click += new System.EventHandler(this.btnFullSchedule_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 655);
            this.Controls.Add(this.btnFullSchedule);
            this.Controls.Add(this.gvSchedule);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTotalTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txbTotalEmp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.gvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotalEmp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTotalTime;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.DataGridView gvSchedule;
        private System.Windows.Forms.Button btnFullSchedule;
    }
}