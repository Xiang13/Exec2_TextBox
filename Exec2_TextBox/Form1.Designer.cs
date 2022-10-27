namespace Exec2_TextBox
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
			this.numTxtBox = new System.Windows.Forms.TextBox();
			this.resultLbl = new System.Windows.Forms.Label();
			this.confirmBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// numTxtBox
			// 
			this.numTxtBox.Location = new System.Drawing.Point(24, 25);
			this.numTxtBox.Name = "numTxtBox";
			this.numTxtBox.Size = new System.Drawing.Size(100, 22);
			this.numTxtBox.TabIndex = 0;
			// 
			// resultLbl
			// 
			this.resultLbl.AutoSize = true;
			this.resultLbl.Location = new System.Drawing.Point(22, 73);
			this.resultLbl.Name = "resultLbl";
			this.resultLbl.Size = new System.Drawing.Size(33, 12);
			this.resultLbl.TabIndex = 1;
			this.resultLbl.Text = "label1";
			// 
			// confirmBtn
			// 
			this.confirmBtn.Location = new System.Drawing.Point(24, 111);
			this.confirmBtn.Name = "confirmBtn";
			this.confirmBtn.Size = new System.Drawing.Size(100, 28);
			this.confirmBtn.TabIndex = 2;
			this.confirmBtn.Text = "確定";
			this.confirmBtn.UseVisualStyleBackColor = true;
			this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 159);
			this.Controls.Add(this.confirmBtn);
			this.Controls.Add(this.resultLbl);
			this.Controls.Add(this.numTxtBox);
			this.Name = "Form1";
			this.Text = "檢查數值";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numTxtBox;
		private System.Windows.Forms.Label resultLbl;
		private System.Windows.Forms.Button confirmBtn;
	}
}

