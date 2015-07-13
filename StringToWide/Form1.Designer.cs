namespace StringToWide {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.cbToWide = new System.Windows.Forms.CheckBox();
            this.cbToSimplified = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbInput.Location = new System.Drawing.Point(15, 16);
            this.tbInput.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(254, 35);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbResult.Location = new System.Drawing.Point(15, 66);
            this.tbResult.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(254, 35);
            this.tbResult.TabIndex = 1;
            // 
            // cbToWide
            // 
            this.cbToWide.AutoSize = true;
            this.cbToWide.Checked = true;
            this.cbToWide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToWide.Location = new System.Drawing.Point(15, 116);
            this.cbToWide.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbToWide.Name = "cbToWide";
            this.cbToWide.Size = new System.Drawing.Size(73, 31);
            this.cbToWide.TabIndex = 2;
            this.cbToWide.Text = "全形";
            this.cbToWide.UseVisualStyleBackColor = true;
            this.cbToWide.CheckedChanged += new System.EventHandler(this.cbToWide_CheckedChanged);
            // 
            // cbToSimplified
            // 
            this.cbToSimplified.AutoSize = true;
            this.cbToSimplified.Location = new System.Drawing.Point(100, 116);
            this.cbToSimplified.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbToSimplified.Name = "cbToSimplified";
            this.cbToSimplified.Size = new System.Drawing.Size(73, 31);
            this.cbToSimplified.TabIndex = 3;
            this.cbToSimplified.Text = "簡體";
            this.cbToSimplified.UseVisualStyleBackColor = true;
            this.cbToSimplified.CheckedChanged += new System.EventHandler(this.cbToSimplified_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.cbToSimplified);
            this.Controls.Add(this.cbToWide);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbInput);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "半形轉全形 / 繁簡互轉";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.CheckBox cbToWide;
        private System.Windows.Forms.CheckBox cbToSimplified;
    }
}

