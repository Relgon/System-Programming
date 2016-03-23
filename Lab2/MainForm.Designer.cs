namespace Lab2
{
    partial class MainForm
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
            this.TextEdit = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextEdit
            // 
            this.TextEdit.Location = new System.Drawing.Point(12, 25);
            this.TextEdit.Name = "TextEdit";
            this.TextEdit.Size = new System.Drawing.Size(727, 299);
            this.TextEdit.TabIndex = 0;
            this.TextEdit.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.OptionsMenu,
            this.ExitMenu,
            this.AboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu,
            this.SaveMenu,
            this.CloseMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // OpenMenu
            // 
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.Size = new System.Drawing.Size(152, 22);
            this.OpenMenu.Text = "Открыть";
            this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(152, 22);
            this.SaveMenu.Text = "Сохранить";
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // CloseMenu
            // 
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(152, 22);
            this.CloseMenu.Text = "Закрыть";
            this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteMenu});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(75, 20);
            this.OptionsMenu.Text = "Операции";
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Size = new System.Drawing.Size(152, 22);
            this.DeleteMenu.Text = "Удаление";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(53, 20);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(94, 20);
            this.AboutMenu.Text = "О программе";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 336);
            this.Controls.Add(this.TextEdit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox TextEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
    }
}

