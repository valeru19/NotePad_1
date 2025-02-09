using System.Windows.Forms;
using System;
using System.IO;


namespace TtxEdr

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|TIN Notepad File (*.tnf)|*.tnf";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)    // Если при открытии нажали кнопку отменить, то возвращает обратно
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text); // Сохраняем именно текст с richTextBox
            MessageBox.Show("File saved"); // Объявление о сохранении файла пользователю
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) // Если при открытии нажали кнопку отменить, то возвращает обратно
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename); // Переменная с прочтенными данными из файла
            richTextBox1.Text = fileText;
            MessageBox.Show("File opened!");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) // Проверка длины напечатанного текста
            {
                richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) // Проверка длины напечатанного текста
            {
                richTextBox1.Copy();
            }
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) // Проверка длины напечатанного текста
            {
                richTextBox1.Paste();
            }
        }

        private void settigsShriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void fontSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void highlightEverythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) // Проверка длины напечатанного текста
            {
                richTextBox1.SelectAll();
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void highlightAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) // Проверка длины напечатанного текста
            {
                richTextBox1.SelectAll();
            }
        }

        private void cutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) // Проверка длины напечатанного текста
            {
                richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) // Проверка длины напечатанного текста
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0) // Проверка длины напечатанного текста
            {
                richTextBox1.Paste();
            }
        }

        private void developerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode1 mode1 = new mode1();
            mode1.Show();
        }
    }
}
