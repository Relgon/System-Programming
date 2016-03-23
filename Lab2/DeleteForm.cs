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
        /*Функция которая возвращает массив наборов ключ-значение
            где в качестве ключа выступает индекс слова,а в качестве
            значение,соответственно само слово.
            */
        private static IEnumerable<KeyValuePair<int, string>> TextEditIterator(RichTextBox TextBox,int start=0)
        {

            string beforeStart = TextBox.Text.Substring(0, start);
            string handlingText = TextBox.Text.Substring(start);
            int beforeStartLength = beforeStart.Length;
            /*Проходимся по всему тексту*/
            for (int i = 0; i < handlingText.Length; i++)
            {
                var builder = new StringBuilder();
                int j = i;
                /*Пока у нас в тексте иду НЕ пробелы*/
                while (handlingText[i] != ' ')
                {
                    /*Докидывает к результату*/
                    builder.Append(handlingText[i]);
                    /*Проверка на конец текста*/
                    if (i + 1 == handlingText.Length)
                    {
                        break;
                    }
                    else
                    {
                        /*Если нет - сдвигаемся дальше*/
                        i++;
                    }
                }
                /*Если у нас в реузьтате что-то есть , то возвращаем слово с его позицией
                с помощью конструкции yield,и переходим к следующей итерации цикла.
                */
                if (builder.Length != 0)
                {
                    yield return new KeyValuePair<int, string>(j+ beforeStartLength, builder.ToString());
                }
            }
        }
        /*Метод,который просто удаляет выделенный текст*/
        private void DeleteSelectionText()
        {
            parent.TextEdit.SelectedText = string.Empty;
        }
        /*Делегат,который будет определять,нужно ли выводить сообщение перед удалением,или нет*/
        private delegate void AskBeforeDeleting();

        /*Метод,который соответствует вышеобъявленному делегату,перед удалением запрашивает поттверждение*/
        private void WithAsking()
        {
            /*Кидаем новую форму с запросом на удаление*/
            var dialog = new DialogForm(parent, "Удалить?");
            dialog.Show();
            parent.BringToFront();
            /*!!! Добавляем listener для события,которое генерится в DialogForm
                Т.е, по сути,когда на форме запроса на удаление нажмут ОК,то сработает метод
                DeleteSelectionText();
            */
            dialog.OKButtonClick += DeleteSelectionText;
        }
        /*Сразу удаляем,без запроса на подтверждение*/
        private void WithoutAsking()
        {
            parent.BringToFront();
            DeleteSelectionText();
        }
        /*Метод для удаления,принимает в качестве параметра метод который соответствует сигнатурой делегату*/
        private bool Delete(AskBeforeDeleting method)
        {
            /*Откуда будем удалять*/
            int curentPosition = FromStartRadio.Checked ? 0 : parent.TextEdit.SelectionStart;
            /*Все слова,начиная с этой позиции*/
            var data = TextEditIterator(parent.TextEdit, curentPosition);
            var pattern = PatternText.Text;
            if (parent.Equals(string.Empty))
            {
                MessageBox.Show("Пожалуйста,введите шаблон!");
            }
            var regExp = new RegExp(PatternText.Text);
            bool flag = false;
            /*Проходимя по всем словам*/
            foreach (var item in data)
            {
                /*Если не соответствует шаблону,идем дальше*/
                if (!regExp.test(item.Value))
                {
                    continue;
                }
                
                flag = true;
                /*Выделяем слово,которое хотим удалять*/
                parent.TextEdit.Select(item.Key, item.Value.Length);
                /*И вызываем метод,который мы передали с помощью делегата*/
                method();
                /*И меняем радиобаттон*/
                this.FromCursorRadio.Checked = true;
                break;
            }
            /*Нашли ли хоть 1 слово?*/
            return flag;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            /*Вызываем делейт,указывая,что нам надо запросить пользователя преед удалением*/
            var isDeleted =Delete(WithAsking);
            if (!isDeleted)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            /*Запрос на удаление*/
            DialogResult result = MessageBox.Show("Удалить все?", "Удаление",
                   MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            /*И все удаляем,без запросов на удаление для каждого слова*/
            while (Delete(WithoutAsking))
            {
                count++;
            }
            if (count == 0)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
        }
        
    }
}
