namespace CH.Client.Views
{
    partial class Setting
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
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblYen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(23, 116);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(200, 21);
            this.txtMoney.TabIndex = 31;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(21, 101);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(29, 12);
            this.lblMoney.TabIndex = 30;
            this.lblMoney.Text = "予算";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "期間";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(23, 37);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 21);
            this.dtpFrom.TabIndex = 33;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(229, 43);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 12);
            this.lblFrom.TabIndex = 34;
            this.lblFrom.Text = "から";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(229, 70);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 12);
            this.lblTo.TabIndex = 36;
            this.lblTo.Text = "まで";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(23, 64);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 21);
            this.dtpTo.TabIndex = 35;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(23, 154);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(235, 23);
            this.btnSetting.TabIndex = 37;
            this.btnSetting.Text = "設定する";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // lblYen
            // 
            this.lblYen.AutoSize = true;
            this.lblYen.Location = new System.Drawing.Point(229, 119);
            this.lblYen.Name = "lblYen";
            this.lblYen.Size = new System.Drawing.Size(17, 12);
            this.lblYen.TabIndex = 38;
            this.lblYen.Text = "円";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 198);
            this.Controls.Add(this.lblYen);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblMoney);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblYen;
    }
}