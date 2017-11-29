using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Библиотека для работы с файлами.

namespace WindowsFormsApp1
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
           
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Functions b = new Functions();
            // Файл НЕ существует...
            if (!(File.Exists("E:\\3курс(5сем)\\ТОКБ\\WindowsFormsApp1\\test.txt")))
            {
                /*  
                    1) Генерация ключа.
                    2) Шифрование пароля.
                    3) Запись в файл.
                    4) Открытие формы "LabelKeyForm1".
                */
                string EncodePas;

                // (1).
                Functions.Key = b.GenKey(txtPas.Text.Length);

                // (2).
                EncodePas = b.Encode(txtPas.Text, Functions.Key);

                // (3).
                b.WriteInFile(EncodePas);

                // (4).
                LabelKeyForm1 f = new LabelKeyForm1();

                this.Hide();
                f.ShowDialog();
                this.Close();

            }
            // Файл существует.
            else
            {
                /*  
                    1) Передача пароля в конструктор формы "KeyForm".
                    2) Открытие формы "KeyForm" для ввода ключа.
                */

                // (1).
                KeyForm f = new KeyForm(this.txtPas.Text);

                // (2).
                this.Hide();
                f.ShowDialog();
                this.Close();
            }

        }
    }
}
