using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    
    public partial class DeleteForm : Form
    {
        private readonly MainForm parent;
        private int position;
        public DeleteForm(MainForm parent, int position)
        {
            this.parent = parent;
            this.position = position;
            parent.Activate();
            InitializeComponent();
        }
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        private static IEnumerable<KeyValuePair<int, string>> TextEditIterator(RichTextBox TextBox,int start=0)
        {
            string beforeStart = TextBox.Text.Substring(0, start);
            string handlingText = TextBox.Text.Substring(start);
            int beforeStartLength = beforeStart.Length;
            for (int i = 0; i < handlingText.Length; i++)
            {
                var builder = new StringBuilder();
                int j = i;
                while (handlingText[i] != ' ')
                {

                    builder.Append(handlingText[i]);
                    if (i + 1 == handlingText.Length)
                    {
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (builder.Length != 0)
                {
                    yield return new KeyValuePair<int, string>(j+ beforeStartLength, builder.ToString());
                }
            }
        }
        private void DeleteSelectionText()
        {
            parent.TextEdit.SelectedText = string.Empty;
        }

        private delegate void AskBeforeDeleting();

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int curentPosition = FromStartRadio.Checked ? 0 : parent.TextEdit.SelectionStart;
            var data = TextEditIterator(parent.TextEdit, curentPosition);
            var pattern = PatternText.Text;
            if (parent.Equals(string.Empty))
            {
                MessageBox.Show("Пожалуйста,введите шаблон!");
            }
            var regExp = new RegExp(PatternText.Text);
            bool flag = false;
            foreach (var item in data)
            {
                if (!regExp.test(item.Value))
                {
                    continue;
                }
                flag = true;
                parent.TextEdit.Select(item.Key, item.Value.Length);

                var dialog = new DialogForm(parent, "Удалить?");
                dialog.Show();
                parent.BringToFront();
                dialog.OKButtonClick += DeleteSelectionText;
                this.FromCursorRadio.Checked = true;
                break;

            }
            if (!flag)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {

        }
        
    }
}
