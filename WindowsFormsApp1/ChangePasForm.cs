﻿using System;
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
    public partial class ChangePasForm : Form
    {
        public ChangePasForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            /* Если пароли НЕ пустые:
             1) Шифрование старого пароля по НОВОМУ ключу.
             2) Если зашифрованный старый пароль = зашифрованному паролю в файле:
               1) Генерация нового ключа.
               2) Шифрование нового пароля.
               3) Запись в файл.
               4) Открытие формы "LabelKeyForm1".
              Если пароли пустые:
              1) Сообщение об ошибке.
            */

            Functions b = new Functions();

            if (txtPasOld.Text != "" || txtPasNew.Text != "")
            {
                string PasOld; // Зашифрованный старый пароль по новому ключу.
                String UserData; // Сохранённый в файле (Зашифрованный) пароль.

                // Для считывания зашифрованного пароля из файла.
                UserData = b.ReadFromFile();

                // (1).
                PasOld = b.Encode(txtPasOld.Text, Functions.Key);

                // (2)
                if (PasOld == UserData)
                {
                    string EncodePas; // Новый пароль.

                    // (1).
                    Functions.Key = b.GenKey(txtPasNew.Text.Length);

                    // (2).
                    EncodePas = b.Encode(txtPasNew.Text, Functions.Key);

                    // (3).
                    b.WriteInFile(EncodePas);

                    // (4).
                    LabelKeyForm1 f = new LabelKeyForm1();

                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Введённый пароль НЕ верен!");
            }

            // (1).
            else if (txtPasOld.Text == "" || txtPasNew.Text == "")
            {
                MessageBox.Show("Одно (или оба) из полей для ввода пароля пустое!");
            }

            txtPasOld.Clear();
            txtPasNew.Clear();
        }
    }
}
