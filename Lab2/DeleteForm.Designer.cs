namespace Lab2
{
    partial class DeleteForm
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
            this.PatternText = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FromStartRadio = new System.Windows.Forms.RadioButton();
            this.FromCursorRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст поиска";
            // 
            // PatternText
            // 
            this.PatternText.Location = new System.Drawing.Point(108, 29);
            this.PatternText.Name = "PatternText";
            this.PatternText.Size = new System.Drawing.Size(151, 20);
            this.PatternText.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(166, 94);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(106, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.Location = new System.Drawing.Point(166, 123);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(106, 23);
            this.DeleteAllButton.TabIndex = 3;
            this.DeleteAllButton.Text = "Удалить все";
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(166, 152);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Закрыть окно";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FromStartRadio
            // 
            this.FromStartRadio.AutoSize = true;
            this.FromStartRadio.Checked = true;
            this.FromStartRadio.Location = new System.Drawing.Point(18, 100);
            this.FromStartRadio.Name = "FromStartRadio";
            this.FromStartRadio.Size = new System.Drawing.Size(76, 17);
            this.FromStartRadio.TabIndex = 5;
            this.FromStartRadio.TabStop = true;
            this.FromStartRadio.Text = "От начала";
            this.FromStartRadio.UseVisualStyleBackColor = true;
            // 
            // FromCursorRadio
            // 
            this.FromCursorRadio.AutoSize = true;
            this.FromCursorRadio.Location = new System.Drawing.Point(16, 129);
            this.FromCursorRadio.Name = "FromCursorRadio";
            this.FromCursorRadio.Size = new System.Drawing.Size(82, 17);
            this.FromCursorRadio.TabIndex = 6;
            this.FromCursorRadio.Text = "От курсора";
            this.FromCursorRadio.UseVisualStyleBackColor = true;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.ControlBox = false;
            this.Controls.Add(this.FromCursorRadio);
            this.Controls.Add(this.FromStartRadio);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteAllButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.PatternText);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 224);
            this.MinimumSize = new System.Drawing.Size(300, 224);
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatternText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DeleteAllButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RadioButton FromStartRadio;
        private System.Windows.Forms.RadioButton FromCursorRadio;
    }
}