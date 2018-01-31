namespace Demo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDownload = new System.Windows.Forms.Button();
            this.BtnBatchDownload = new System.Windows.Forms.Button();
            this.DgvTasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDownload
            // 
            this.BtnDownload.AutoSize = true;
            this.BtnDownload.Location = new System.Drawing.Point(12, 12);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(102, 37);
            this.BtnDownload.TabIndex = 1;
            this.BtnDownload.Text = "新建下载";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // BtnBatchDownload
            // 
            this.BtnBatchDownload.AutoSize = true;
            this.BtnBatchDownload.Location = new System.Drawing.Point(120, 12);
            this.BtnBatchDownload.Name = "BtnBatchDownload";
            this.BtnBatchDownload.Size = new System.Drawing.Size(142, 37);
            this.BtnBatchDownload.TabIndex = 2;
            this.BtnBatchDownload.Text = "新建批量下载";
            this.BtnBatchDownload.UseVisualStyleBackColor = true;
            this.BtnBatchDownload.Click += new System.EventHandler(this.BtnBatchDownload_Click);
            // 
            // DgvTasks
            // 
            this.DgvTasks.AllowUserToAddRows = false;
            this.DgvTasks.AllowUserToDeleteRows = false;
            this.DgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTasks.BackgroundColor = System.Drawing.Color.White;
            this.DgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTasks.Location = new System.Drawing.Point(12, 55);
            this.DgvTasks.Name = "DgvTasks";
            this.DgvTasks.ReadOnly = true;
            this.DgvTasks.RowTemplate.Height = 27;
            this.DgvTasks.Size = new System.Drawing.Size(758, 486);
            this.DgvTasks.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.DgvTasks);
            this.Controls.Add(this.BtnBatchDownload);
            this.Controls.Add(this.BtnDownload);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "下载示例";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Button BtnBatchDownload;
        private System.Windows.Forms.DataGridView DgvTasks;
    }
}

