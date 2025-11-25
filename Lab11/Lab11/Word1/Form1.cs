using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Word1
{
    public partial class Form1 : Form
    {
        int correct = 0;
        int wrong = 0;
        string[] words = { "кот", "дом", "сад", "лес", "море", "река", "город", "улица" };
        Random rand = new Random();
        string currentWord;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            NewWord();
            UpdateLabels();
        }
        private void NewWord()
        {
            currentWord = words[rand.Next(words.Length)];
            WordLabel.Text = currentWord;
        }

        private void UpdateLabels()
        {
            CorrectLabel.Text = $"Правильно: {correct}";
            WrongLabel.Text = $"Неправильно: {wrong}";
        }



        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (InputTextBox.Text == currentWord)
                    correct++;
                else
                    wrong++;

                UpdateLabels();
                NewWord();
                InputTextBox.Clear();

                e.SuppressKeyPress = true;
            }
        }
    }
}

