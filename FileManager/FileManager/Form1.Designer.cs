namespace FileManager
{
    public partial class Form1
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
            this.goOver_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.rename_button = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.transferal_button = new System.Windows.Forms.Button();
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
            this.mainWindow.Size = new System.Drawing.Size(742, 444);
            this.mainWindow.TabIndex = 0;
            this.mainWindow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainWindow_doudleClick);
            // 
            // fileAddress
            // 
            this.fileAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileAddress.Location = new System.Drawing.Point(7, 33);
            this.fileAddress.Name = "fileAddress";
            this.fileAddress.Size = new System.Drawing.Size(758, 22);
            this.fileAddress.TabIndex = 1;
            // 
            // goOver_button
            // 
            this.goOver_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goOver_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goOver_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goOver_button.Location = new System.Drawing.Point(771, 33);
            this.goOver_button.Name = "goOver_button";
            this.goOver_button.Size = new System.Drawing.Size(152, 23);
            this.goOver_button.TabIndex = 2;
            this.goOver_button.Text = "Перейти";
            this.goOver_button.UseVisualStyleBackColor = true;
            this.goOver_button.Click += new System.EventHandler(this.goOver_button_Click);
            // 
            // create_button
            // 
            this.create_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.create_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_button.Location = new System.Drawing.Point(771, 107);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(153, 23);
            this.create_button.TabIndex = 3;
            this.create_button.Text = "Создать";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(771, 136);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(153, 23);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // rename_button
            // 
            this.rename_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rename_button.Location = new System.Drawing.Point(771, 165);
            this.rename_button.Name = "rename_button";
            this.rename_button.Size = new System.Drawing.Size(153, 23);
            this.rename_button.TabIndex = 5;
            this.rename_button.Text = "Переименовывать";
            this.rename_button.UseVisualStyleBackColor = true;
            this.rename_button.Click += new System.EventHandler(this.rename_button_Click);
            // 
            // copy_button
            // 
            this.copy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copy_button.Location = new System.Drawing.Point(772, 195);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(152, 23);
            this.copy_button.TabIndex = 6;
            this.copy_button.Text = "Копировать";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // transferal_button
            // 
            this.transferal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transferal_button.Location = new System.Drawing.Point(772, 225);
            this.transferal_button.Name = "transferal_button";
            this.transferal_button.Size = new System.Drawing.Size(152, 23);
            this.transferal_button.TabIndex = 7;
            this.transferal_button.Text = "Переместить";
            this.transferal_button.UseVisualStyleBackColor = true;
            this.transferal_button.Click += new System.EventHandler(this.transferal_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.transferal_button);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.rename_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.goOver_button);
            this.Controls.Add(this.fileAddress);
            this.Controls.Add(this.mainWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox mainWindow;
        public System.Windows.Forms.TextBox fileAddress;
        public System.Windows.Forms.Button goOver_button;
        public System.Windows.Forms.Button create_button;
        public System.Windows.Forms.Button delete_button;
        public System.Windows.Forms.Button rename_button;
        public System.Windows.Forms.Button copy_button;
        public System.Windows.Forms.Button transferal_button;
    }
}

