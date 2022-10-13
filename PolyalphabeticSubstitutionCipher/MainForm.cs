using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyalphabeticSubstitutionCipher
{
    public partial class MainForm : Form
    {
        char[] alphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З',
        'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х',
        'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'};
        static int size;
        static int count = 0;
        public MainForm()
        {
            InitializeComponent();
            size = alphabet.Length;
            CreateGrid();
        }
        // Создание разметки таблицы
        void CreateRowsAndColumns()
        {
            AlphabetGrid.RowCount = size + 1;
            AlphabetGrid.ColumnCount = size + 1;
        }
        // Установка размера колонок
        void ResizeColumns()
        {
            for (int i = 0; i < size + 1; i++)
                AlphabetGrid.Columns[i].Width = 25;
        }
        // Заполнение заголовков по горизонтали
        void FillGridHorizontalHeader()
        {
            for (int i = 0; i < size; i++)
            {
                AlphabetGrid.Rows[0].Cells[i + 1].Value = alphabet[i];
                AlphabetGrid.Rows[0].Cells[i + 1].Style.BackColor = Color.Green;
            }
        }
        // Заполнение заголовков по вертикали
        void FillGridVerticalHeader()
        {
            for (int i = 0; i < size; i++)
            {
                AlphabetGrid.Rows[i + 1].Cells[0].Value = alphabet[i];
                AlphabetGrid.Rows[i + 1].Cells[0].Style.BackColor = Color.Orange;
            }
        }
        // Заполнение таблицы
        void FillGridField()
        {
            char[] currentAlphabet = alphabet;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    AlphabetGrid.Rows[i + 1].Cells[j + 1].Value = currentAlphabet[j];
                }
                currentAlphabet = AppendToStart(currentAlphabet);
            }
        }
        // Создание таблицы
        void CreateGrid()
        {
            CreateRowsAndColumns();
            ResizeColumns();
            FillGridHorizontalHeader();
            FillGridVerticalHeader();
            FillGridField();
        }
        // Добавление последнего элемента в начало
        char[] AppendToStart(char[] array)
        {
            char[] result = new char[size];
            result[0] = array[size - 1];
            for (int i = 0; i < array.Length - 1; i++)
                result[i + 1] = array[i];

            return result;
        }
        // Установка первоначальных цветов таблицы
        void GridColorReset()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    AlphabetGrid.Rows[i + 1].Cells[j + 1].Style.BackColor = Color.White;
                }
            }
        }
        // Валидация ключа
        bool ValidateKey(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (Array.IndexOf(alphabet, Char.ToUpper(key[i])) == -1)
                {
                    return false;
                }
            }
            return true;
        }
        // Валидация текста
        bool ValidateText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Array.IndexOf(alphabet, Char.ToUpper(text[i])) == -1)
                {
                    return false;
                }
            }
            return true;
        }
        // Визуальное отображение результата кодирования
        void DisplayCipherResult(string text, string key)
        {
            char letter = TextInput.Text[TextInput.Text.Length - 1];
            int x = Array.IndexOf(alphabet, Char.ToUpper(key[count])) + 1;
            int y = Array.IndexOf(alphabet, Char.ToUpper(letter)) + 1;
            for (int i = 0; i < x; i++)
            {
                AlphabetGrid.Rows[i + 1].Cells[y].Style.BackColor = Color.Gray;
            }

            for (int i = 0; i < y; i++)
            {
                AlphabetGrid.Rows[x].Cells[i + 1].Style.BackColor = Color.Gray;
            }
            AlphabetGrid.Rows[x].Cells[y].Style.BackColor = Color.Yellow;
            CipherInput.Text += AlphabetGrid.Rows[x].Cells[y].Value.ToString().ToLower();
        }
        private void TextInput_TextChanged(object sender, EventArgs e)
        {   
            if (!ValidateText(TextInput.Text))
            {
                MessageBox.Show("Должны быть только русские буквы!");
                ResetButton_Click(sender, e);
            }
            else if(TextInput.Text != "")
            {
                if (CipherInput.Text.Length % KeyInput.Text.Length == 0)
                {
                    count = 0;
                }
                KeyInput.Enabled = false;
                GridColorReset();
                DisplayCipherResult(TextInput.Text, KeyInput.Text);
                count++;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TextInput.Text = "";
            KeyInput.Text = "";
            CipherInput.Text = "";
            KeyInput.Enabled = true;
            TextInput.Enabled = false;
            count = 0;
            GridColorReset();
        }

        private void KeyInput_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateKey(KeyInput.Text))
            {
                MessageBox.Show("Должны быть только русские буквы!");
                KeyInput.Text = "";
            }
            else if (KeyInput.Text != "")
            {
                TextInput.Enabled = true;
            }
            else
            {
                TextInput.Enabled = false;
            }
        }
    }
}
