namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainWindow = new System.Windows.Forms.ListBox();
            this.fileAddress = new System.Windows.Forms.TextBox();
            this.goOver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainWindow
            // 
            this.mainWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainWindow.FormattingEnabled = true;
            this.mainWindow.ItemHeight = 20;
            this.mainWindow.Location = new System.Drawing.Point(23, 84);
            this.mainWindow.Name = "mainWindow";
            this.mainWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainWindow.Size = new System.Drawing.Size(758, 404);
            this.mainWindow.TabIndex = 0;
            // 
            // fileAddress
            // 
            this.fileAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileAddress.Location = new System.Drawing.Point(23, 34);
            this.fileAddress.Name = "fileAddress";
            this.fileAddress.Size = new System.Drawing.Size(758, 22);
            this.fileAddress.TabIndex = 1;
            // 
            // goOver
            // 
            this.goOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goOver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goOver.Location = new System.Drawing.Point(803, 32);
            this.goOver.Name = "goOver";
            this.goOver.Size = new System.Drawing.Size(120, 23);
            this.goOver.TabIndex = 2;
            this.goOver.Text = "Перейти";
            this.goOver.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.goOver);
            this.Controls.Add(this.fileAddress);
            this.Controls.Add(this.mainWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mainWindow;
        private System.Windows.Forms.TextBox fileAddress;
        private System.Windows.Forms.Button goOver;
    }
}

