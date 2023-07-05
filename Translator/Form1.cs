using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = openFileDialog1.FileName;

                // Создаем новый XmlDocument
                XmlDocument xmlDoc = new XmlDocument();

                // Загружаем XML-файл
                xmlDoc.Load(openFileDialog1.FileName);

                // Получаем все узлы с тегом <Name_EN>
                XmlNodeList nameEnNodes = xmlDoc.SelectNodes("//Name_EN");

                // Очищаем textBox2
                textBoxBefore.Clear();

                // Добавляем содержимое тегов <Name_EN> в textBox2 построчно
                foreach (XmlNode node in nameEnNodes)
                {
                    textBoxBefore.AppendText(node.InnerText + Environment.NewLine);
                }
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "" && textBoxAfter.Text != "")
            {
                textBoxAfter.Text.Trim();

                // Создаем новый XmlDocument
                XmlDocument xmlDoc = new XmlDocument();

                // Загружаем XML-файл
                xmlDoc.Load(openFileDialog1.FileName);

                // Клонируем корневой элемент
                XmlNode rootClone = xmlDoc.DocumentElement.CloneNode(true);

                // Заменяем строки в тегах <Name_EN> на значения из textBoxAfter
                XmlNodeList nameEnNodes = rootClone.SelectNodes("//Name_EN");
                int index = 0;
                foreach (XmlNode nameEnNode in nameEnNodes)
                {
                    if (index < textBoxAfter.Lines.Length)
                    {
                        nameEnNode.InnerText = textBoxAfter.Lines[index];
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }

                // Сохраняем измененный XML-файл с префиксом "TRANSLATE_" в имени файла
                string newFileName = Path.Combine(Path.GetDirectoryName(openFileDialog1.FileName),
                                                  "TRANSLATE_" + Path.GetFileName(openFileDialog1.FileName));
                xmlDoc.DocumentElement.RemoveAll();
                xmlDoc.DocumentElement.AppendChild(rootClone);
                xmlDoc.Save(newFileName);

                textBoxPathNew.Text = newFileName;
            }
            else
            {
                // Один или оба поля пусты, выводим сообщение об ошибке
                MessageBox.Show("Выберите файл и введите значения в TextBox3", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool shouldAddEmptyLine = false;

        private void textBoxAfter_TextChanged(object sender, EventArgs e)
        {
            if (shouldAddEmptyLine)
            {
                shouldAddEmptyLine = false;

                // Добавляем пустую строку
                textBoxAfter.AppendText(Environment.NewLine);
            }
        }

        private void textBoxAfter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                shouldAddEmptyLine = true;
            }
        }

    }
}
