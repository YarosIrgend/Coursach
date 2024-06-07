using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Coursach
{
    public partial class SlarForm : Form
    {
        private bool resultsReceived;
        private bool canShowGraphics = true;
        private int slar_size = 2;
        private bool sizeChanged;

        public SlarForm()
        {
            InitializeComponent();
        }

        private void Slar_create(int size)
        {
            int textBox_startX = -80;
            int textBox_startY = -20;
            int label_startX = -14;
            int label_startY = -16;

            List<TextBox> textBoxesToRemove = new List<TextBox>();
            List<Label> labelsToRemove = new List<Label>();

            //прибираємо зайве
            foreach (Control control in Controls)
            {
                if (control is TextBox dynamicTextBox &&
                    ((string)control.Tag == "coeffsA" || (string)control.Tag == "coeffsB"))
                {
                    textBoxesToRemove.Add(dynamicTextBox);
                }

                if (control is Label label && (string)control.Tag == "xs_label")
                {
                    labelsToRemove.Add(label);
                }
            }

            foreach (TextBox textBoxToRemove in textBoxesToRemove)
            {
                Controls.Remove(textBoxToRemove);
                textBoxToRemove.Dispose();
            }

            foreach (Label labelToRemove in labelsToRemove)
            {
                Controls.Remove(labelToRemove);
                labelToRemove.Dispose();
            }

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    TextBox textBoxA = new TextBox();
                    textBoxA.Size = new Size(60, 22);
                    textBoxA.Location = new Point(textBox_startX + j * 110, textBox_startY + i * 60);
                    textBoxA.Tag = "coeffsA";
                    Controls.Add(textBoxA);

                    Label label_x = new Label();
                    label_x.Size = new Size(36, 19);
                    label_x.Location = new Point(label_startX + j * 110, label_startY + i * 60);
                    label_x.Tag = "xs_label";
                    label_x.Font = new Font("Segoe UI Semibold", 9);
                    label_x.Text = j == size ? $"x{j} =" : $"x{j} +";
                    Controls.Add(label_x);
                }

                TextBox textBoxB = new TextBox();
                textBoxB.Size = new Size(60, 22);
                textBoxB.Location = new Point(textBox_startX + (size + 1) * 110, textBox_startY + i * 60);
                textBoxB.Tag = "coeffsB";
                Controls.Add(textBoxB);
            }
        }

        private void Clear_control(string tag)
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Control control = Controls[i];
                if ((string)control.Tag == tag)
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        private void Clear_TextBoxes()
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Control control = Controls[i];
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void Size2_CheckedChanged(object sender, EventArgs e)
        {
            //особливість, якщо не змінювати за замовчуванням розмір, то зчитування буде знизу вгору 
            if (slar_size != 2)
            {
                sizeChanged = true;
            }

            slar_size = 2;
            resultsReceived = false;
            canShowGraphics = true;
            Slar_create(slar_size);
        }

        private void Size3_CheckedChanged(object sender, EventArgs e)
        {
            slar_size = 3;
            resultsReceived = false;
            canShowGraphics = false;
            sizeChanged = true;
            Slar_create(slar_size);
        }

        private void Size4_CheckedChanged(object sender, EventArgs e)
        {
            slar_size = 4;
            resultsReceived = false;
            canShowGraphics = false;
            sizeChanged = true;
            Slar_create(slar_size);
        }

        private void Size5_CheckedChanged(object sender, EventArgs e)
        {
            slar_size = 5;
            resultsReceived = false;
            canShowGraphics = false;
            sizeChanged = true;
            Slar_create(slar_size);
        }

        private void Size6_CheckedChanged(object sender, EventArgs e)
        {
            slar_size = 6;
            resultsReceived = false;
            canShowGraphics = false;
            sizeChanged = true;
            Slar_create(slar_size);
        }

        private void Graphics_create(List<List<double>> valuesA, List<double> valuesB, List<double> results)
        {
            try
            {
                Size = new Size(1500, 548);
                // створення графіку
                ZedGraph.ZedGraphControl zedGraphControl = new ZedGraph.ZedGraphControl()
                {
                    Size = new Size(470, 390),
                    Location = new Point(990, 25),
                    Tag = "graphics",
                };
                Controls.Add(zedGraphControl);
                ZedGraph.GraphPane graphics = zedGraphControl.GraphPane;
                graphics.Title.Text = "Графіки функцій";
                graphics.XAxis.Title.Text = "Вісь X";
                graphics.YAxis.Title.Text = "Вісь Y";

                //додавання графіку 1
                ZedGraph.PointPairList points1 = new ZedGraph.PointPairList();
                if (valuesA[0][1] != 0) // Перевірка на 0
                {
                    for (double x = results[0] - 1000; x <= results[0] + 1000; x += 0.1)
                    {
                        double y = (valuesB[0] - valuesA[0][0] * x) / valuesA[0][1];
                        points1.Add(x, y);
                    }
                }
                else
                {
                    for (double y = results[1] - 1000; y <= results[1] + 1000; y += 0.1)
                    {
                        points1.Add(valuesB[0] / valuesA[0][0], y);
                    }
                }

                graphics.AddCurve($"{valuesA[0][0]}x + {valuesA[0][1]}y = {valuesB[0]}", points1, Color.Blue,
                    ZedGraph.SymbolType.None);

                //додавання графіку 2
                ZedGraph.PointPairList points2 = new ZedGraph.PointPairList();
                if (valuesA[1][1] != 0) // Перевірка на 0
                {
                    for (double x = results[0] - 1000; x <= results[0] + 1000; x += 0.1)
                    {
                        double y = (valuesB[1] - valuesA[1][0] * x) / valuesA[1][1];
                        points2.Add(x, y);
                    }
                }
                else
                {
                    for (double y = results[1] - 1000; y <= results[1] + 1000; y += 0.1)
                    {
                        points2.Add(valuesB[1] / valuesA[1][0], y);
                    }
                }

                graphics.AddCurve($"{valuesA[1][0]}x + {valuesA[1][1]}y = {valuesB[1]}", points2, Color.Red,
                    ZedGraph.SymbolType.None);

                zedGraphControl.AxisChange();
                zedGraphControl.Invalidate();
            }
            catch
            {
                Label warning = new Label
                {
                    Size = new Size(360, 40),
                    Location = new Point(280, 390),
                    Text = "Не вдалося завантажити графік. Ймовірно у вас незавантажено\nZedGraph версія 5.1.7.430",
                    ForeColor = Color.Red,
                    Tag = "warn",
                    BackColor = Color.White
                };
                Controls.Add(warning);
                warning.BringToFront();
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Size = new Size(1008, 548);
            resultsReceived = false;
            Calculations.iterationsCount = 0;
            List<List<double>> valuesA = new List<List<double>>();
            List<double> valuesB = new List<double>();
            List<double> results = new List<double>();
            bool canBeCount = true; // прапорець, що рівняння можна обрахувати
            valuesA.Clear();
            valuesB.Clear();
            results.Clear();

            //Прибираємо повідомлення про помилку та результати
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Control control = Controls[i];
                if (control is Label label && ((string)label.Tag == "warn" || (string)label.Tag == "result"))
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
                else if (control is ZedGraph.ZedGraphControl)
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }

            //додавання значень в списки
            int j = 0;
            try
            {
                List<double> valuesA_row = new List<double>(slar_size);
                foreach (Control control in Controls)
                {
                    if (control is TextBox valueA && (string)valueA.Tag == "coeffsA")
                    {
                        j++;
                        //перевірка на 4 знаки після коми
                        if (!Validations.CountOfDecDigitsValid(valueA.Text))
                        {
                            throw new OverflowException();
                        }

                        //перевірка на належність числа діапазону
                        double number = Convert.ToDouble(valueA.Text);
                        if (!Validations.numberInRange(number))
                        {
                            throw new OverflowException();
                        }

                        valuesA_row.Add(number);
                        if (j == slar_size)
                        {
                            if (!sizeChanged)
                            {
                                valuesA_row.Reverse();
                                valuesA.Insert(0, new List<double>(valuesA_row));
                            }
                            else
                            {
                                valuesA.Add(new List<double>(valuesA_row));
                            }

                            valuesA_row.Clear();
                            j = 0;
                        }
                    }
                    else if (control is TextBox valueB && (string)valueB.Tag == "coeffsB")
                    {
                        valuesB.Add(Convert.ToDouble(valueB.Text));
                    }
                }

                if (!sizeChanged)
                {
                    valuesB.Reverse();
                }
            }
            // Помилки при некоректному введенні значень
            catch (FormatException)
            {
                Label warning = new Label
                {
                    Size = new Size(360, 40),
                    Location = new Point(280, 390),
                    Text =
                        "Впишіть всі числа або поправте введення, щоб було тільки число\n      (дробові числа вводьте через кому)",
                    ForeColor = Color.Red,
                    Tag = "warn",
                    BackColor = Color.White
                };
                Controls.Add(warning);
                warning.BringToFront();
                return;
            }
            catch (OverflowException)
            {
                Label warning = new Label
                {
                    Size = new Size(360, 40),
                    Location = new Point(280, 390),
                    Text =
                        "Деякі із введенних чисел занадто малі/великі.\n(Допустимі значення від -1000000 до 1000000, 4 знаки після коми)",
                    ForeColor = Color.Red,
                    Tag = "warn",
                    BackColor = Color.White
                };
                Controls.Add(warning);
                warning.BringToFront();
                return;
            }

            // копії списків для виводу графіку
            List<List<double>> valuesA_copy = valuesA.Select(innerList => new List<double>(innerList)).ToList();
            List<double> valuesB_copy = new List<double>(valuesB);

            //перевірка, щоб не було одних 0 в першому стовпці
            int zeros = 0;
            for (j = 0; j < valuesB.Count; j++)
            {
                if (valuesA[j][0] == 0)
                {
                    zeros++;
                }
            }

            if (zeros == valuesA.Count)
            {
                Label message = new Label
                {
                    Size = new Size(360, 25),
                    Location = new Point(300, 390),
                    Text = "СЛАР має безліч розв'язків або не має взагалі",
                    ForeColor = Color.Red,
                    Tag = "warn",
                    BackColor = Color.White
                };
                Controls.Add(message);
                message.BringToFront();
                return;
            }

            // Обрахунок
            switch (true)
            {
                case true when gausse_method.Checked:
                    results = Calculations.Gausse_method(this, valuesA, valuesB, out canBeCount);
                    break;
                case true when jordan_gausse_method.Checked:
                    results = Calculations.Jordane_Gausse_method(this, valuesA, valuesB, out canBeCount);
                    break;
                case true when matrix_method.Checked:
                    results = Calculations.Matrix_method(this, valuesA, valuesB, out canBeCount);
                    break;
            }

            if (!canBeCount)
            {
                return;
            }

            //вивід результату
            for (int i = 0; i < results.Count; i++)
            {
                Label result = new Label
                {
                    Size = new Size(240, 22),
                    Location = new Point(10, 390 + i * 15),
                    Tag = "result",
                    Font = new Font("Segoe UI Semibold", 10),
                    Text = $"x{i + 1} = {results[i]:F4}",
                    BackColor = Color.White
                };
                Controls.Add(result);
                result.BringToFront();
            }

            //практична складність алгоритму (к-ть ітерацій)
            Label iterations = new Label
            {
                Size = new Size(150, 22),
                Location = new Point(10, 480),
                Tag = "result",
                Font = new Font("Segoe UI Semibold", 10),
                Text = $"Ітерацій: {Calculations.iterationsCount}",
                BackColor = Color.White
            };
            Controls.Add(iterations);
            iterations.BringToFront();
            resultsReceived = true;

            //вивід графіку
            if (canShowGraphics)
            {
                Graphics_create(valuesA_copy, valuesB_copy, results);
            }
        }

        private void WriteInFileButton_Click(object sender, EventArgs e)
        {
            if (resultsReceived)
            {
                //зчитування результатів
                List<string> results = new List<string>();
                foreach (Control control in Controls)
                {
                    if ((string)control.Tag == "result")
                    {
                        results.Add(control.Text);
                    }
                }

                results.Reverse();

                //запис у файл
                string fileName = "..\\..\\Результати.txt";
                File.WriteAllLines(fileName, results);
                Label message = new Label
                {
                    Size = new Size(360, 25),
                    Location = new Point(280, 390),
                    Text = "Записано у текстовий файл",
                    ForeColor = Color.Green,
                    Tag = "warn",
                    BackColor = Color.White
                };
                Controls.Add(message);
                message.BringToFront();
                Process process = new Process();
                process.StartInfo.FileName = fileName;
                try
                {
                    process.Start();
                }
                catch
                {
                    message = new Label
                    {
                        Size = new Size(360, 25),
                        Location = new Point(280, 430),
                        Text = "Не вдалося відкрити файл",
                        ForeColor = Color.Red,
                        Tag = "warn",
                        BackColor = Color.White
                    };
                    Controls.Add(message);
                    message.BringToFront();
                }
            }
            else
            {
                Label warning = new Label
                {
                    Size = new Size(360, 25),
                    Location = new Point(280, 418),
                    Text = "Спочатку отримайте результати, потім записуйте у файл",
                    ForeColor = Color.Red,
                    Tag = "warn",
                    BackColor = Color.White
                };
                Controls.Add(warning);
                warning.BringToFront();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear_control("warn");
            Clear_control("result");
            Clear_control("graphics");
            Clear_TextBoxes();
            Size = new Size(1008, 548);
        }
    }
}