
namespace ResManage.Forms
{
    partial class dashboard
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
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.btnFoodM = new System.Windows.Forms.Button();
            this.btnFoodMan = new System.Windows.Forms.Button();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.ResBtn = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.closeBtn = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.LightPink;
            this.buttonSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchedule.ForeColor = System.Drawing.Color.White;
            this.buttonSchedule.Image = global::ResManage.Properties.Resources.schedule__1_;
            this.buttonSchedule.Location = new System.Drawing.Point(174, 196);
            this.buttonSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(149, 285);
            this.buttonSchedule.TabIndex = 23;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // btnFoodM
            // 
            this.btnFoodM.BackColor = System.Drawing.Color.Crimson;
            this.btnFoodM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodM.ForeColor = System.Drawing.Color.White;
            this.btnFoodM.Image = global::ResManage.Properties.Resources.rport;
            this.btnFoodM.Location = new System.Drawing.Point(328, 287);
            this.btnFoodM.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoodM.Name = "btnFoodM";
            this.btnFoodM.Size = new System.Drawing.Size(315, 194);
            this.btnFoodM.TabIndex = 4;
            this.btnFoodM.Text = "Report - Statistic";
            this.btnFoodM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFoodM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFoodM.UseVisualStyleBackColor = false;
            this.btnFoodM.Click += new System.EventHandler(this.btnFoodM_Click);
            // 
            // btnFoodMan
            // 
            this.btnFoodMan.BackColor = System.Drawing.Color.Teal;
            this.btnFoodMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodMan.ForeColor = System.Drawing.Color.White;
            this.btnFoodMan.Image = global::ResManage.Properties.Resources.food_removebg_preview__1___1_;
            this.btnFoodMan.Location = new System.Drawing.Point(328, 1);
            this.btnFoodMan.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoodMan.Name = "btnFoodMan";
            this.btnFoodMan.Size = new System.Drawing.Size(155, 281);
            this.btnFoodMan.TabIndex = 5;
            this.btnFoodMan.Text = "Food \nManagement";
            this.btnFoodMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFoodMan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFoodMan.UseVisualStyleBackColor = false;
            this.btnFoodMan.Click += new System.EventHandler(this.btnFoodMan_Click);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.EmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeBtn.Image = global::ResManage.Properties.Resources.hr;
            this.EmployeeBtn.Location = new System.Drawing.Point(2, 196);
            this.EmployeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(167, 285);
            this.EmployeeBtn.TabIndex = 1;
            this.EmployeeBtn.Text = "Employee";
            this.EmployeeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EmployeeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EmployeeBtn.UseVisualStyleBackColor = false;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // ResBtn
            // 
            this.ResBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ResBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResBtn.ForeColor = System.Drawing.Color.White;
            this.ResBtn.Image = global::ResManage.Properties.Resources.table_removebg_preview__1_;
            this.ResBtn.Location = new System.Drawing.Point(2, 1);
            this.ResBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ResBtn.Name = "ResBtn";
            this.ResBtn.Size = new System.Drawing.Size(321, 190);
            this.ResBtn.TabIndex = 0;
            this.ResBtn.Text = "Table \r\nManagement";
            this.ResBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ResBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ResBtn.UseVisualStyleBackColor = false;
            this.ResBtn.Click += new System.EventHandler(this.ResBtn_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.Gold;
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Image = global::ResManage.Properties.Resources.revenue_removebg_preview__1_;
            this.btnRevenue.Location = new System.Drawing.Point(488, 1);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(154, 281);
            this.btnRevenue.TabIndex = 24;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(622, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.closeBtn.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.closeBtn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 22;
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(647, 481);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnFoodM);
            this.Controls.Add(this.btnFoodMan);
            this.Controls.Add(this.EmployeeBtn);
            this.Controls.Add(this.ResBtn);
            this.Controls.Add(this.btnRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ResBtn;
        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Button btnFoodM;
        private System.Windows.Forms.Button btnFoodMan;
        private ePOSOne.btnProduct.Button_WOC closeBtn;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button btnRevenue;
    }
}