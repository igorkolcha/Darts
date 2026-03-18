using System.Reflection.Emit;

namespace Darts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = string.Format("Счет: {0}", scoreRed);
            labelRedClicks.Text = string.Format("Ходов: {0}", redButtonClicks);

            label2.Text = string.Format("Счет: {0}", scoreGreen);
            labelGreenClicks.Text = string.Format("Ходов: {0}", greenButtonClicks);
        }

        int scoreRed = 501;
        int redButtonClicks = 0;

        int scoreGreen = 501;
        int greenButtonClicks = 0;
        private void buttonRed_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            bool isNum1 = int.TryParse(textBox1Red.Text, out num1);
            bool isNum2 = int.TryParse(textBox2Red.Text, out num2);
            bool isNum3 = int.TryParse(textBox3Red.Text, out num3);

            // Увеличиваем счетчик нажатий
            redButtonClicks++;
            labelRedClicks.Text = string.Format("Ходов: {0}", redButtonClicks);

            if (isNum1 && isNum2 && isNum3)
            {
                int result = num1 + num2 + num3;

                if (scoreRed - result > 0)
                {
                    scoreRed = scoreRed - result;
                    // Обновляем отображение счета и количества ходов
                    label1.Text = string.Format("Счет: {0}", scoreRed);

                }
                else if (scoreRed - result == 0)
                {
                    scoreRed = 0;
                    label1.Text = string.Format("Счет: {0}", scoreRed);
                    MessageBox.Show("Красный игрок победил!");
                    ResetGame();
                }
                else
                {
                    MessageBox.Show("Перебор! Осталось: " + scoreRed);
                    ResetGame();
                }
            }

            textBox1Red.Text = "";
            textBox2Red.Text = "";
            textBox3Red.Text = "";
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            bool isNum1 = int.TryParse(textBox1Green.Text, out num1);
            bool isNum2 = int.TryParse(textBox2Green.Text, out num2);
            bool isNum3 = int.TryParse(textBox3Green.Text, out num3);

            // Увеличиваем счетчик нажатий
            greenButtonClicks++;
            labelGreenClicks.Text = string.Format("Ходов: {0}", greenButtonClicks);

            if (isNum1 && isNum2 && isNum3)
            {
                int result = num1 + num2 + num3;

                if (scoreGreen - result > 0)
                {
                    scoreGreen = scoreGreen - result;
                    // Обновляем отображение счета и количества ходов
                    label2.Text = string.Format("Счет: {0}", scoreGreen);

                }
                else if (scoreGreen - result == 0)
                {
                    scoreGreen = 0;
                    label2.Text = string.Format("Счет: {0}", scoreGreen);
                    MessageBox.Show("Зеленый игрок победил!");
                    ResetGame();
                }
                else
                {
                    MessageBox.Show("Перебор! Осталось: " + scoreGreen);
                    ResetGame();
                }
            }

            textBox1Green.Text = "";
            textBox2Green.Text = "";
            textBox3Green.Text = "";
        }

        private void ResetGame()
        {
            // Сброс счетов
            scoreRed = 501;
            scoreGreen = 501;

            // Сброс счетчиков ходов
            redButtonClicks = 0;
            greenButtonClicks = 0;

            // Обновление отображения
            label1.Text = string.Format("Счет: {0}", scoreRed);
            label2.Text = string.Format("Счет: {0}", scoreGreen);
            labelRedClicks.Text = "Ходов красных: 0";
            labelGreenClicks.Text = "Ходов зеленых: 0";

            // Очистка полей ввода
            textBox1Red.Text = "";
            textBox2Red.Text = "";
            textBox3Red.Text = "";
        }
    }
}
