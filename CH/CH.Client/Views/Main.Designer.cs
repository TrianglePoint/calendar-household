namespace CH.Client.Views
{
    partial class Main
    {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
            this.tlpDate = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWeek = new System.Windows.Forms.TableLayoutPanel();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tlpCalander = new System.Windows.Forms.TableLayoutPanel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbarUsedMoney = new System.Windows.Forms.ProgressBar();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblSettingMoney = new System.Windows.Forms.Label();
            this.lblSettingMoneyValue = new System.Windows.Forms.Label();
            this.lblUsedMoneyValue = new System.Windows.Forms.Label();
            this.lblUsedMoney = new System.Windows.Forms.Label();
            this.lblUsedPercentValue = new System.Windows.Forms.Label();
            this.lblUsedPercent = new System.Windows.Forms.Label();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.tlpWeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tlpCalander.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpDate
            // 
            this.tlpDate.ColumnCount = 7;
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDate.Location = new System.Drawing.Point(3, 76);
            this.tlpDate.Name = "tlpDate";
            this.tlpDate.RowCount = 6;
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tlpDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDate.Size = new System.Drawing.Size(863, 534);
            this.tlpDate.TabIndex = 0;
            // 
            // tlpWeek
            // 
            this.tlpWeek.ColumnCount = 7;
            this.tlpWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpWeek.Controls.Add(this.lblSaturday, 6, 0);
            this.tlpWeek.Controls.Add(this.lblFriday, 5, 0);
            this.tlpWeek.Controls.Add(this.lblMonday, 1, 0);
            this.tlpWeek.Controls.Add(this.lblThursday, 4, 0);
            this.tlpWeek.Controls.Add(this.lblWednesday, 3, 0);
            this.tlpWeek.Controls.Add(this.lblTuesday, 2, 0);
            this.tlpWeek.Controls.Add(this.lblSunday, 0, 0);
            this.tlpWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWeek.Location = new System.Drawing.Point(3, 3);
            this.tlpWeek.Name = "tlpWeek";
            this.tlpWeek.RowCount = 1;
            this.tlpWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpWeek.Size = new System.Drawing.Size(863, 67);
            this.tlpWeek.TabIndex = 0;
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaturday.Font = new System.Drawing.Font("Gungsuh", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSaturday.ForeColor = System.Drawing.Color.Blue;
            this.lblSaturday.Location = new System.Drawing.Point(741, 0);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(119, 67);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "土";
            this.lblSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFriday.Font = new System.Drawing.Font("Gungsuh", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFriday.Location = new System.Drawing.Point(618, 0);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(117, 67);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "金";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonday.Font = new System.Drawing.Font("Gungsuh", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMonday.Location = new System.Drawing.Point(126, 0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(117, 67);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "月";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThursday.Font = new System.Drawing.Font("Gungsuh", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblThursday.Location = new System.Drawing.Point(495, 0);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(117, 67);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "木";
            this.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWednesday.Font = new System.Drawing.Font("Gungsuh", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWednesday.Location = new System.Drawing.Point(372, 0);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(117, 67);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "水";
            this.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTuesday.Font = new System.Drawing.Font("Gungsuh", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTuesday.Location = new System.Drawing.Point(249, 0);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(117, 67);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "火";
            this.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSunday.Font = new System.Drawing.Font("Gungsuh", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSunday.ForeColor = System.Drawing.Color.Red;
            this.lblSunday.Location = new System.Drawing.Point(3, 0);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(117, 67);
            this.lblSunday.TabIndex = 0;
            this.lblSunday.Text = "日";
            this.lblSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(10, 12);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tlpCalander);
            this.splitContainer.Panel1.Margin = new System.Windows.Forms.Padding(26, 30, 26, 30);
            this.splitContainer.Panel1MinSize = 869;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dtp);
            this.splitContainer.Panel2.Controls.Add(this.btnModify);
            this.splitContainer.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer.Panel2.Controls.Add(this.dgvList);
            this.splitContainer.Panel2.Controls.Add(this.lblWelcome);
            this.splitContainer.Panel2MinSize = 367;
            this.splitContainer.Size = new System.Drawing.Size(1240, 613);
            this.splitContainer.SplitterDistance = 869;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 1;
            // 
            // tlpCalander
            // 
            this.tlpCalander.ColumnCount = 1;
            this.tlpCalander.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCalander.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpCalander.Controls.Add(this.tlpWeek, 0, 0);
            this.tlpCalander.Controls.Add(this.tlpDate, 0, 1);
            this.tlpCalander.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCalander.Location = new System.Drawing.Point(0, 0);
            this.tlpCalander.Name = "tlpCalander";
            this.tlpCalander.RowCount = 2;
            this.tlpCalander.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90865F));
            this.tlpCalander.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.09135F));
            this.tlpCalander.Size = new System.Drawing.Size(869, 613);
            this.tlpCalander.TabIndex = 0;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(3, 13);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(160, 19);
            this.dtp.TabIndex = 21;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(211, 580);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(154, 30);
            this.btnModify.TabIndex = 20;
            this.btnModify.Text = "修正・削除";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 580);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colType,
            this.colCategory,
            this.colMoney});
            this.dgvList.Location = new System.Drawing.Point(3, 40);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(362, 534);
            this.dgvList.TabIndex = 18;
            // 
            // colNo
            // 
            this.colNo.FillWeight = 40F;
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            // 
            // colType
            // 
            this.colType.FillWeight = 90F;
            this.colType.HeaderText = "収入・支出";
            this.colType.Name = "colType";
            // 
            // colCategory
            // 
            this.colCategory.FillWeight = 90F;
            this.colCategory.HeaderText = "分類";
            this.colCategory.Name = "colCategory";
            // 
            // colMoney
            // 
            this.colMoney.FillWeight = 120F;
            this.colMoney.HeaderText = "金額";
            this.colMoney.Name = "colMoney";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(205, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(100, 12);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "ようこそ、○○さん！";
            // 
            // pbarUsedMoney
            // 
            this.pbarUsedMoney.Location = new System.Drawing.Point(13, 636);
            this.pbarUsedMoney.Name = "pbarUsedMoney";
            this.pbarUsedMoney.Size = new System.Drawing.Size(1234, 23);
            this.pbarUsedMoney.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(1094, 665);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(153, 23);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "予算設定";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // lblSettingMoney
            // 
            this.lblSettingMoney.AutoSize = true;
            this.lblSettingMoney.Location = new System.Drawing.Point(11, 670);
            this.lblSettingMoney.Name = "lblSettingMoney";
            this.lblSettingMoney.Size = new System.Drawing.Size(59, 12);
            this.lblSettingMoney.TabIndex = 4;
            this.lblSettingMoney.Text = "設定金額：";
            // 
            // lblSettingMoneyValue
            // 
            this.lblSettingMoneyValue.AutoSize = true;
            this.lblSettingMoneyValue.Location = new System.Drawing.Point(67, 670);
            this.lblSettingMoneyValue.Name = "lblSettingMoneyValue";
            this.lblSettingMoneyValue.Size = new System.Drawing.Size(55, 12);
            this.lblSettingMoneyValue.TabIndex = 5;
            this.lblSettingMoneyValue.Text = "000,000円";
            this.lblSettingMoneyValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsedMoneyValue
            // 
            this.lblUsedMoneyValue.AutoSize = true;
            this.lblUsedMoneyValue.Location = new System.Drawing.Point(201, 670);
            this.lblUsedMoneyValue.Name = "lblUsedMoneyValue";
            this.lblUsedMoneyValue.Size = new System.Drawing.Size(55, 12);
            this.lblUsedMoneyValue.TabIndex = 7;
            this.lblUsedMoneyValue.Text = "000,000円";
            this.lblUsedMoneyValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsedMoney
            // 
            this.lblUsedMoney.AutoSize = true;
            this.lblUsedMoney.Location = new System.Drawing.Point(146, 670);
            this.lblUsedMoney.Name = "lblUsedMoney";
            this.lblUsedMoney.Size = new System.Drawing.Size(59, 12);
            this.lblUsedMoney.TabIndex = 6;
            this.lblUsedMoney.Text = "使用金額：";
            // 
            // lblUsedPercentValue
            // 
            this.lblUsedPercentValue.AutoSize = true;
            this.lblUsedPercentValue.Location = new System.Drawing.Point(336, 670);
            this.lblUsedPercentValue.Name = "lblUsedPercentValue";
            this.lblUsedPercentValue.Size = new System.Drawing.Size(29, 12);
            this.lblUsedPercentValue.TabIndex = 9;
            this.lblUsedPercentValue.Text = "100%";
            this.lblUsedPercentValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsedPercent
            // 
            this.lblUsedPercent.AutoSize = true;
            this.lblUsedPercent.Location = new System.Drawing.Point(285, 670);
            this.lblUsedPercent.Name = "lblUsedPercent";
            this.lblUsedPercent.Size = new System.Drawing.Size(47, 12);
            this.lblUsedPercent.TabIndex = 8;
            this.lblUsedPercent.Text = "使用率：";
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.Location = new System.Drawing.Point(723, 670);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(153, 12);
            this.lblWarningMessage.TabIndex = 10;
            this.lblWarningMessage.Text = "やばいー予算もう超えてますよー";
            this.lblWarningMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 700);
            this.Controls.Add(this.lblWarningMessage);
            this.Controls.Add(this.lblUsedPercentValue);
            this.Controls.Add(this.lblUsedPercent);
            this.Controls.Add(this.lblUsedMoneyValue);
            this.Controls.Add(this.lblUsedMoney);
            this.Controls.Add(this.lblSettingMoneyValue);
            this.Controls.Add(this.lblSettingMoney);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.pbarUsedMoney);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CH";
            this.tlpWeek.ResumeLayout(false);
            this.tlpWeek.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tlpCalander.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDate;
        private System.Windows.Forms.TableLayoutPanel tlpWeek;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tlpCalander;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ProgressBar pbarUsedMoney;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblSettingMoney;
        private System.Windows.Forms.Label lblSettingMoneyValue;
        private System.Windows.Forms.Label lblUsedMoneyValue;
        private System.Windows.Forms.Label lblUsedMoney;
        private System.Windows.Forms.Label lblUsedPercentValue;
        private System.Windows.Forms.Label lblUsedPercent;
        private System.Windows.Forms.Label lblWarningMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}