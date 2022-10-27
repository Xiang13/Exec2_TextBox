namespace Q4
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.peopleTxtBox = new System.Windows.Forms.TextBox();
			this.carTxtBox = new System.Windows.Forms.TextBox();
			this.resultLbl = new System.Windows.Forms.Label();
			this.calcBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "車數";
			// 
			// peopleTxtBox
			// 
			this.peopleTxtBox.Location = new System.Drawing.Point(115, 39);
			this.peopleTxtBox.Name = "peopleTxtBox";
			this.peopleTxtBox.Size = new System.Drawing.Size(100, 22);
			this.peopleTxtBox.TabIndex = 2;
			// 
			// carTxtBox
			// 
			this.carTxtBox.Location = new System.Drawing.Point(115, 107);
			this.carTxtBox.Name = "carTxtBox";
			this.carTxtBox.Size = new System.Drawing.Size(100, 22);
			this.carTxtBox.TabIndex = 3;
			// 
			// resultLbl
			// 
			this.resultLbl.AutoSize = true;
			this.resultLbl.Location = new System.Drawing.Point(258, 77);
			this.resultLbl.Name = "resultLbl";
			this.resultLbl.Size = new System.Drawing.Size(33, 12);
			this.resultLbl.TabIndex = 4;
			this.resultLbl.Text = "label3";
			// 
			// calcBtn
			// 
			this.calcBtn.Location = new System.Drawing.Point(345, 54);
			this.calcBtn.Name = "calcBtn";
			this.calcBtn.Size = new System.Drawing.Size(91, 58);
			this.calcBtn.TabIndex = 5;
			this.calcBtn.Text = "計算";
			this.calcBtn.UseVisualStyleBackColor = true;
			this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 192);
			this.Controls.Add(this.calcBtn);
			this.Controls.Add(this.resultLbl);
			this.Controls.Add(this.carTxtBox);
			this.Controls.Add(this.peopleTxtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "計算費用";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox peopleTxtBox;
		private System.Windows.Forms.TextBox carTxtBox;
		private System.Windows.Forms.Label resultLbl;
		private System.Windows.Forms.Button calcBtn;
	}
}

