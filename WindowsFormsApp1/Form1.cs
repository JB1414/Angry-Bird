using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int velocity, int angle)
        {
            InitializeComponent();
            textBoxVelocity.Text = velocity.ToString();
            textBoxAngle.Text = angle.ToString();
        }

        private void GetDataFromFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    string fileContents = File.ReadAllText(filePath);

                    if (CheckInputFileContent(fileContents))
                    {
                        var splitted = fileContents.Split('\n');
                        textBoxVelocity.Text = splitted[0];
                        textBoxAngle.Text = splitted[1];
                    }
                    else
                    {
                        MessageBox.Show("Введенные вами данные некорректны\n" +
                            "Скорость должна быть целым числом от 1 до 1000\n" +
                            "Угол должен быть целым числом от 0 до 90\n" +
                            "Числа в файле должны быть записаны на 2 разных строках без лишних пробелов или переносов строк");
                    }
                }
            }
        }

        private bool CheckInputFileContent(string fileContents)
        {
            var stringsCount = fileContents.Count(x => x ==  '\n') + 1;
            if (stringsCount != 2) 
                return false;
            
            var splitted = fileContents.Split('\n');
            return CheckParameters(splitted[0], splitted[1]);
        }

        private bool CheckParameters(string velocity, string angle)
        {
            if (int.TryParse(velocity, out var parsedVelocity) && int.TryParse(angle, out var parsedAngle))
            {
                var isVelocityCorrect = parsedVelocity > 0 && parsedVelocity <= 300;
                var isAngleCorrect = parsedAngle >= 0 && parsedAngle <= 90;
                return isVelocityCorrect && isAngleCorrect;
            }
            return false;
        }

        private void VisualizteButton_Click(object sender, EventArgs e)
        {
            var velocityMs = textBoxVelocity.Text;
            var angleMs = textBoxAngle.Text;

            if (CheckParameters(velocityMs, angleMs))
            {
                var form2 = new Form2(int.Parse(velocityMs), int.Parse(angleMs));
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введенные вами данные некорректны\n" +
                            "Скорость должна быть целым числом от 1 до 300\n" +
                            "Угол должен быть целым числом от 0 до 90\n");
            }
        }
    }
}
