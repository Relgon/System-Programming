using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель : \n Бежан Олег,301 группа", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";
            if(openFile.ShowDialog() == DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                TextEdit.LoadFile(openFile.FileName);
            }

        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.rtf";
            saveFile.Filter = "RTF Files|*.rtf";

            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                TextEdit.SaveFile(saveFile.FileName);
            }


        }

        private void CloseMenu_Click(object sender, EventArgs e)
        {
            TextEdit.Clear();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm(this, TextEdit.SelectionStart);
            delete.Show();
        }
    }
}
