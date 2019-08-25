namespace CH.Client.Views
{
    partial class Edit
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
            this.btmDelete = new System.Windows.Forms.Button();
            this.btnAddOrModify = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblMinorCategory = new System.Windows.Forms.Label();
            this.cbxMinorCategory = new System.Windows.Forms.ComboBox();
            this.lblMajorCategory = new System.Windows.Forms.Label();
            this.cbxMajorCategory = new System.Windows.Forms.ComboBox();
            this.lblInOrOut = new System.Windows.Forms.Label();
            this.cbxInOrOut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btmDelete
            // 
            this.btmDelete.Location = new System.Drawing.Point(138, 144);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(113, 36);
            this.btmDelete.TabIndex = 31;
            this.btmDelete.Text = "削除";
            this.btmDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddOrModify
            // 
            this.btnAddOrModify.Location = new System.Drawing.Point(19, 144);
            this.btnAddOrModify.Name = "btnAddOrModify";
            this.btnAddOrModify.Size = new System.Drawing.Size(113, 36);
            this.btnAddOrModify.TabIndex = 30;
            this.btnAddOrModify.Text = "修正";
            this.btnAddOrModify.UseVisualStyleBackColor = true;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(12, 69);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(188, 21);
            this.txtMoney.TabIndex = 29;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(10, 54);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(29, 12);
            this.lblMoney.TabIndex = 28;
            this.lblMoney.Text = "金額";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(220, 69);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(188, 65);
            this.txtReason.TabIndex = 27;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(218, 54);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(29, 12);
            this.lblReason.TabIndex = 26;
            this.lblReason.Text = "備考";
            // 
            // lblMinorCategory
            // 
            this.lblMinorCategory.AutoSize = true;
            this.lblMinorCategory.Location = new System.Drawing.Point(218, 11);
            this.lblMinorCategory.Name = "lblMinorCategory";
            this.lblMinorCategory.Size = new System.Drawing.Size(41, 12);
            this.lblMinorCategory.TabIndex = 25;
            this.lblMinorCategory.Text = "小分類";
            // 
            // cbxMinorCategory
            // 
            this.cbxMinorCategory.FormattingEnabled = true;
            this.cbxMinorCategory.Location = new System.Drawing.Point(220, 26);
            this.cbxMinorCategory.Name = "cbxMinorCategory";
            this.cbxMinorCategory.Size = new System.Drawing.Size(97, 20);
            this.cbxMinorCategory.TabIndex = 24;
            // 
            // lblMajorCategory
            // 
            this.lblMajorCategory.AutoSize = true;
            this.lblMajorCategory.Location = new System.Drawing.Point(115, 11);
            this.lblMajorCategory.Name = "lblMajorCategory";
            this.lblMajorCategory.Size = new System.Drawing.Size(41, 12);
            this.lblMajorCategory.TabIndex = 23;
            this.lblMajorCategory.Text = "大分類";
            // 
            // cbxMajorCategory
            // 
            this.cbxMajorCategory.FormattingEnabled = true;
            this.cbxMajorCategory.Location = new System.Drawing.Point(117, 26);
            this.cbxMajorCategory.Name = "cbxMajorCategory";
            this.cbxMajorCategory.Size = new System.Drawing.Size(97, 20);
            this.cbxMajorCategory.TabIndex = 22;
            // 
            // lblInOrOut
            // 
            this.lblInOrOut.AutoSize = true;
            this.lblInOrOut.Location = new System.Drawing.Point(10, 11);
            this.lblInOrOut.Name = "lblInOrOut";
            this.lblInOrOut.Size = new System.Drawing.Size(67, 12);
            this.lblInOrOut.TabIndex = 21;
            this.lblInOrOut.Text = "収入 / 支出";
            // 
            // cbxInOrOut
            // 
            this.cbxInOrOut.AutoCompleteCustomSource.AddRange(new string[] {
            "収入",
            "支出"});
            this.cbxInOrOut.FormattingEnabled = true;
            this.cbxInOrOut.Location = new System.Drawing.Point(12, 26);
            this.cbxInOrOut.Name = "cbxInOrOut";
            this.cbxInOrOut.Size = new System.Drawing.Size(97, 20);
            this.cbxInOrOut.TabIndex = 20;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 192);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btnAddOrModify);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblMinorCategory);
            this.Controls.Add(this.cbxMinorCategory);
            this.Controls.Add(this.lblMajorCategory);
            this.Controls.Add(this.cbxMajorCategory);
            this.Controls.Add(this.lblInOrOut);
            this.Controls.Add(this.cbxInOrOut);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btnAddOrModify;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblMinorCategory;
        private System.Windows.Forms.ComboBox cbxMinorCategory;
        private System.Windows.Forms.Label lblMajorCategory;
        private System.Windows.Forms.ComboBox cbxMajorCategory;
        private System.Windows.Forms.Label lblInOrOut;
        private System.Windows.Forms.ComboBox cbxInOrOut;
    }
}