namespace SeaBattle
{
    partial class BattleForm
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
            lblUser = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            lblTime = new System.Windows.Forms.Label();
            tmTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblUser.ForeColor = System.Drawing.Color.DeepPink;
            lblUser.Location = new System.Drawing.Point(320, 9);
            lblUser.Name = "lblUser";
            lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblUser.Size = new System.Drawing.Size(85, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Ход: Первый";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(320, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblTime.ForeColor = System.Drawing.Color.Red;
            lblTime.Location = new System.Drawing.Point(344, 53);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(18, 18);
            lblTime.TabIndex = 2;
            lblTime.Text = "0";
            // 
            // tmTime
            // 
            tmTime.Enabled = true;
            tmTime.Interval = 1000;
            tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 356);
            this.Controls.Add(lblTime);
            this.Controls.Add(btnClose);
            this.Controls.Add(lblUser);
            this.Name = "BattleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской Бой";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnClose;
        private static System.Windows.Forms.Label lblTime;
        private static System.Windows.Forms.Timer tmTime;
    }
}