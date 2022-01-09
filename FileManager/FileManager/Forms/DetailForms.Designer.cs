namespace FileManager.Forms
{
    partial class DetailForms
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
            this.extension_label = new System.Windows.Forms.Label();
            this.extension_text = new System.Windows.Forms.Label();
            this.number_of_lines_label = new System.Windows.Forms.Label();
            this.number_of_lines_text = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.number_of_words_label = new System.Windows.Forms.Label();
            this.number_of_words_text = new System.Windows.Forms.Label();
            this.number_of_paragraphs_label = new System.Windows.Forms.Label();
            this.number_of_paragraphs_text = new System.Windows.Forms.Label();
            this.number_of_characters_label = new System.Windows.Forms.Label();
            this.number_of_characters_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // extension_label
            // 
            this.extension_label.AutoSize = true;
            this.extension_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extension_label.Location = new System.Drawing.Point(60, 65);
            this.extension_label.Name = "extension_label";
            this.extension_label.Size = new System.Drawing.Size(98, 16);
            this.extension_label.TabIndex = 0;
            this.extension_label.Text = "Расширение";
            // 
            // extension_text
            // 
            this.extension_text.AutoSize = true;
            this.extension_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extension_text.Location = new System.Drawing.Point(210, 65);
            this.extension_text.Name = "extension_text";
            this.extension_text.Size = new System.Drawing.Size(50, 16);
            this.extension_text.TabIndex = 1;
            this.extension_text.Text = "label1";
            // 
            // number_of_lines_label
            // 
            this.number_of_lines_label.AutoSize = true;
            this.number_of_lines_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_lines_label.Location = new System.Drawing.Point(60, 96);
            this.number_of_lines_label.Name = "number_of_lines_label";
            this.number_of_lines_label.Size = new System.Drawing.Size(103, 16);
            this.number_of_lines_label.TabIndex = 2;
            this.number_of_lines_label.Text = "Кол-во строк";
            // 
            // number_of_lines_text
            // 
            this.number_of_lines_text.AutoSize = true;
            this.number_of_lines_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_lines_text.Location = new System.Drawing.Point(210, 96);
            this.number_of_lines_text.Name = "number_of_lines_text";
            this.number_of_lines_text.Size = new System.Drawing.Size(50, 16);
            this.number_of_lines_text.TabIndex = 3;
            this.number_of_lines_text.Text = "label2";
            // 
            // ok_button
            // 
            this.ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.Location = new System.Drawing.Point(160, 386);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 4;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // number_of_words_label
            // 
            this.number_of_words_label.AutoSize = true;
            this.number_of_words_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_words_label.Location = new System.Drawing.Point(60, 125);
            this.number_of_words_label.Name = "number_of_words_label";
            this.number_of_words_label.Size = new System.Drawing.Size(96, 16);
            this.number_of_words_label.TabIndex = 5;
            this.number_of_words_label.Text = "Кол-во слов";
            // 
            // number_of_words_text
            // 
            this.number_of_words_text.AutoSize = true;
            this.number_of_words_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_words_text.Location = new System.Drawing.Point(210, 125);
            this.number_of_words_text.Name = "number_of_words_text";
            this.number_of_words_text.Size = new System.Drawing.Size(50, 16);
            this.number_of_words_text.TabIndex = 6;
            this.number_of_words_text.Text = "label2";
            // 
            // number_of_paragraphs_label
            // 
            this.number_of_paragraphs_label.AutoSize = true;
            this.number_of_paragraphs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_paragraphs_label.Location = new System.Drawing.Point(60, 154);
            this.number_of_paragraphs_label.Name = "number_of_paragraphs_label";
            this.number_of_paragraphs_label.Size = new System.Drawing.Size(124, 16);
            this.number_of_paragraphs_label.TabIndex = 7;
            this.number_of_paragraphs_label.Text = "Кол-во абзацев";
            // 
            // number_of_paragraphs_text
            // 
            this.number_of_paragraphs_text.AutoSize = true;
            this.number_of_paragraphs_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_paragraphs_text.Location = new System.Drawing.Point(210, 154);
            this.number_of_paragraphs_text.Name = "number_of_paragraphs_text";
            this.number_of_paragraphs_text.Size = new System.Drawing.Size(50, 16);
            this.number_of_paragraphs_text.TabIndex = 8;
            this.number_of_paragraphs_text.Text = "label2";
            // 
            // number_of_characters_label
            // 
            this.number_of_characters_label.AutoSize = true;
            this.number_of_characters_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_characters_label.Location = new System.Drawing.Point(60, 184);
            this.number_of_characters_label.Name = "number_of_characters_label";
            this.number_of_characters_label.Size = new System.Drawing.Size(133, 16);
            this.number_of_characters_label.TabIndex = 9;
            this.number_of_characters_label.Text = "Кол-во символов";
            // 
            // number_of_characters_text
            // 
            this.number_of_characters_text.AutoSize = true;
            this.number_of_characters_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_characters_text.Location = new System.Drawing.Point(210, 184);
            this.number_of_characters_text.Name = "number_of_characters_text";
            this.number_of_characters_text.Size = new System.Drawing.Size(50, 16);
            this.number_of_characters_text.TabIndex = 10;
            this.number_of_characters_text.Text = "label2";
            // 
            // DetailForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 449);
            this.Controls.Add(this.number_of_characters_text);
            this.Controls.Add(this.number_of_characters_label);
            this.Controls.Add(this.number_of_paragraphs_text);
            this.Controls.Add(this.number_of_paragraphs_label);
            this.Controls.Add(this.number_of_words_text);
            this.Controls.Add(this.number_of_words_label);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.number_of_lines_text);
            this.Controls.Add(this.number_of_lines_label);
            this.Controls.Add(this.extension_text);
            this.Controls.Add(this.extension_label);
            this.Name = "DetailForms";
            this.Text = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label extension_label;
        public System.Windows.Forms.Label extension_text;
        private System.Windows.Forms.Label number_of_lines_label;
        public System.Windows.Forms.Label number_of_lines_text;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label number_of_words_label;
        public System.Windows.Forms.Label number_of_words_text;
        private System.Windows.Forms.Label number_of_paragraphs_label;
        public System.Windows.Forms.Label number_of_paragraphs_text;
        private System.Windows.Forms.Label number_of_characters_label;
        public System.Windows.Forms.Label number_of_characters_text;
    }
}