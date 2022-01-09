namespace FileManager.Forms
{
    partial class RenameFileForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.new_name = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новое имя папки файла ";
            // 
            // new_name
            // 
            this.new_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_name.Location = new System.Drawing.Point(12, 57);
            this.new_name.Name = "new_name";
            this.new_name.Size = new System.Drawing.Size(227, 22);
            this.new_name.TabIndex = 1;
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.Location = new System.Drawing.Point(245, 56);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(89, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "Принять";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_text.ForeColor = System.Drawing.Color.Red;
            this.error_text.Location = new System.Drawing.Point(15, 101);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(0, 16);
            this.error_text.TabIndex = 3;
            this.error_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RenameFileForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 126);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.new_name);
            this.Controls.Add(this.label1);
            this.Name = "RenameFileForms";
            this.Text = "RenameFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox new_name;
        private System.Windows.Forms.Button ok_button;
        public System.Windows.Forms.Label error_text;
    }
}