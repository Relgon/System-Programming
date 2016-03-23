using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class DialogForm : Form
    {
        private Form parent;
        /*Тип делегата для функции обратного вызова.*/
        public delegate void Callback();
        /*Событие,которое мы будем тригерить при нажатии на кнопку.*/
        public event Callback OKButtonClick;

        public DialogForm(Form parent,string message)
        {
            InitializeComponent();
            this.parent = parent;
            this.TextMessage.Text = message;
            /*На передний фон*/
            parent.BringToFront();

        }

        /*Если нажали ОК,то генерим соотв. ивент,и закрываем форму.*/
        private void OKButton_Click(object sender, EventArgs e)
        {
            OKButtonClick();
            Close();
    
        }
        /*Иначе просто закрываем форму*/
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
      
        }
    }
}
