namespace Exec2_Star
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
			this.generateLeftButton = new System.Windows.Forms.Button();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.generateRightButton = new System.Windows.Forms.Button();
			this.isoscelesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "列數:";
			// 
			// generateLeftButton
			// 
			this.generateLeftButton.Location = new System.Drawing.Point(211, 36);
			this.generateLeftButton.Name = "generateLeftButton";
			this.generateLeftButton.Size = new System.Drawing.Size(75, 23);
			this.generateLeftButton.TabIndex = 1;
			this.generateLeftButton.Text = "靠左";
			this.generateLeftButton.UseVisualStyleBackColor = true;
			this.generateLeftButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Location = new System.Drawing.Point(91, 36);
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(100, 22);
			this.rowsTextBox.TabIndex = 2;
			// 
			// resultTextBox
			// 
			this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultTextBox.Location = new System.Drawing.Point(16, 94);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.resultTextBox.Size = new System.Drawing.Size(423, 342);
			this.resultTextBox.TabIndex = 2;
			this.resultTextBox.WordWrap = false;
			// 
			// generateRightButton
			// 
			this.generateRightButton.Location = new System.Drawing.Point(292, 36);
			this.generateRightButton.Name = "generateRightButton";
			this.generateRightButton.Size = new System.Drawing.Size(75, 23);
			this.generateRightButton.TabIndex = 3;
			this.generateRightButton.Text = "靠右";
			this.generateRightButton.UseVisualStyleBackColor = true;
			this.generateRightButton.Click += new System.EventHandler(this.generateRightButton_Click);
			// 
			// isoscelesButton
			// 
			this.isoscelesButton.Location = new System.Drawing.Point(373, 36);
			this.isoscelesButton.Name = "isoscelesButton";
			this.isoscelesButton.Size = new System.Drawing.Size(75, 23);
			this.isoscelesButton.TabIndex = 4;
			this.isoscelesButton.Text = "等腰";
			this.isoscelesButton.UseVisualStyleBackColor = true;
			this.isoscelesButton.Click += new System.EventHandler(this.isoscelesButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 448);
			this.Controls.Add(this.isoscelesButton);
			this.Controls.Add(this.generateRightButton);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.rowsTextBox);
			this.Controls.Add(this.generateLeftButton);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button generateLeftButton;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.TextBox resultTextBox;
		private System.Windows.Forms.Button generateRightButton;
		private System.Windows.Forms.Button isoscelesButton;
	}
}

