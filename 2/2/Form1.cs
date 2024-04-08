using System;
using System.IO;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = "1.txt";
            try
            {
                string text = File.ReadAllText(filepath);
                string[] words = text.Split(' ');

                foreach (string word in words)
                {
                    listBox1.Items.Add(word); // Добавляем каждое слово в список
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
        }
    }
}
