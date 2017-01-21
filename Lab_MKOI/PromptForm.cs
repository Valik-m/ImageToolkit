using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_MKOI
{
    
    public partial class PromptForm : Form
    {
        private string result = null;
        public string Result
        {
            get
            {
                return result;
            }
        }
        TypeDialog typeDialog;
        public enum TypeDialog
        {
            Add,
            Mul,
            Log,
            Pow
        }

        public PromptForm(TypeDialog type)
        {
            InitializeComponent();
            typeDialog = type;
            switch (typeDialog)
            {
                case TypeDialog.Add:
                    textLabel.Text = "Введите значение в диапозоне от -255 до 255";
                    break;
                case TypeDialog.Mul:
                    textLabel.Text = "Введите значение в диапозоне от 0 до 10";
                    break;
                case TypeDialog.Log:
                    textLabel.Text = "Введите основание логарифма";
                    break;
                case TypeDialog.Pow:
                    textLabel.Text = "Введите значение степени";
                    break;
                default:
                    break;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool flag = false; 
            switch (typeDialog)
            {
                case TypeDialog.Add:
                    if (Convert.ToInt32(numberTextBox.Text) <= -255 || Convert.ToInt32(numberTextBox.Text) > 255)
                    {
                        MessageBox.Show("Неверное значение", "Ошибка");
                        flag = true;
                    }
                    break;
                case TypeDialog.Mul:
                    if (Convert.ToDouble(numberTextBox.Text) <= 0.0 || Convert.ToDouble(numberTextBox.Text) > 10.0)
                    {
                        MessageBox.Show("Неверное значение", "Ошибка");
                        flag = true;
                    }
                    break;
                case TypeDialog.Log:
                    if (Convert.ToDouble(numberTextBox.Text) <= 0.0 || Convert.ToDouble(numberTextBox.Text) > 255.0)
                    {
                        MessageBox.Show("Неверное значение", "Ошибка");
                        flag = true;
                    }
                    break;
                case TypeDialog.Pow:
                    if (Convert.ToDouble(numberTextBox.Text) <= 0.0 || Convert.ToDouble(numberTextBox.Text) > 255.0)
                    {
                        MessageBox.Show("Неверное значение", "Ошибка");
                        flag = true;
                    }
                    break;
                default:
                    break;
            }
            if (!flag)
            {
                result = numberTextBox.Text;
                this.Close();
            }
        }
    }
}
