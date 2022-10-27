namespace Q3
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTxtBox = new System.Windows.Forms.TextBox();
			this.dateLbl = new System.Windows.Forms.Label();
			this.checkBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTxtBox
			// 
			this.dateTxtBox.Location = new System.Drawing.Point(36, 30);
			this.dateTxtBox.Name = "dateTxtBox";
			this.dateTxtBox.Size = new System.Drawing.Size(100, 22);
			this.dateTxtBox.TabIndex = 0;
			// 
			// dateLbl
			// 
			this.dateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateLbl.Location = new System.Drawing.Point(34, 74);
			this.dateLbl.Name = "dateLbl";
			this.dateLbl.Size = new System.Drawing.Size(102, 48);
			this.dateLbl.TabIndex = 1;
			this.dateLbl.Text = "label1";
			// 
			// checkBtn
			// 
			this.checkBtn.Location = new System.Drawing.Point(36, 144);
			this.checkBtn.Name = "checkBtn";
			this.checkBtn.Size = new System.Drawing.Size(100, 54);
			this.checkBtn.TabIndex = 2;
			this.checkBtn.Text = "檢查";
			this.checkBtn.UseVisualStyleBackColor = true;
			this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(183, 249);
			this.Controls.Add(this.checkBtn);
			this.Controls.Add(this.dateLbl);
			this.Controls.Add(this.dateTxtBox);
			this.Name = "Form1";
			this.Text = "檢查生日";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox dateTxtBox;
		private System.Windows.Forms.Label dateLbl;
		private System.Windows.Forms.Button checkBtn;
	}
}

