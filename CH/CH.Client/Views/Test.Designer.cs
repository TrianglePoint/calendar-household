namespace CH.Client.Views
{
	partial class Test
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
			this.label = new System.Windows.Forms.Label();
			this.btnHttp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(207, 59);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(35, 12);
			this.label.TabIndex = 0;
			this.label.Text = "label1";
			// 
			// btnHttp
			// 
			this.btnHttp.Location = new System.Drawing.Point(184, 88);
			this.btnHttp.Name = "btnHttp";
			this.btnHttp.Size = new System.Drawing.Size(75, 23);
			this.btnHttp.TabIndex = 2;
			this.btnHttp.Text = "Http";
			this.btnHttp.UseVisualStyleBackColor = true;
			this.btnHttp.Click += new System.EventHandler(this.BtnHttp_Click);
			// 
			// Test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnHttp);
			this.Controls.Add(this.label);
			this.Name = "Test";
			this.Text = "Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Button btnHttp;
	}
}