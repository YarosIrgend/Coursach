﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Coursach
{
    public static class Calculations
    {
        public static int iterationsCount;

        private static double Determinant(List<List<double>> valuesA)
        {
            // розраховано, що матриця зведена до східчастого вигляду
            double det = valuesA[0][0];
            for (int i = 1; i < valuesA.Count; i++)
            {
                det *= valuesA[i][i];
                iterationsCount++;
            }

            return det;
        }

        private static void Gausse(ref List<List<double>> valuesA, ref List<double> valuesB)
        {
            //якщо перший елемент першого рядка = 0, то поміняти місцями із рядком, де перший елемент != 0
            int i = 0;
            int size = valuesA.Count;
            if (valuesA[0][0] == 0)
            {
                while (valuesA[i][0] == 0)
                {
                    iterationsCount++;
                    i++;
                    if (valuesA[i][0] != 0)
                    {
                        (valuesA[i], valuesA[0]) = (valuesA[0], valuesA[i]);
                        (valuesB[i], valuesB[0]) = (valuesB[0], valuesB[i]);
                        break;
                    }
                }
            }

            // прямий хід перетворення матриці
            for (int k = 0; k < size - 1; k++)
            {
                // Перевірка, чи valuesA[k][k] дорівнює нулю, якщо так, то треба переставити рядки
                if (valuesA[k][k] == 0)
                {
                    int swapRow = k + 1;
                    while (swapRow < size && valuesA[swapRow][k] == 0)
                    {
                        swapRow++;
                    }

                    // Якщо знайдено ненульовий рядок, переставляємо рядки
                    if (swapRow < size)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            (valuesA[k][j], valuesA[swapRow][j]) = (valuesA[swapRow][j], valuesA[k][j]);
                            iterationsCount++;
                        }

                        (valuesB[k], valuesB[swapRow]) = (valuesB[swapRow], valuesB[k]);
                    }
                    else
                    {
                        return;
                    }
                }

                for (i = k + 1; i < size; i++)
                {
                    double factor = -valuesA[i][k] / valuesA[k][k];
                    for (int j = k; j < size; j++)
                    {
                        valuesA[i][j] += factor * valuesA[k][j];
                        iterationsCount++;
                    }

                    valuesB[i] += factor * valuesB[k];
                }
            }
        }

        private static void Gausse(ref List<List<double>> matrix)
        {
            //якщо перший елемент першого рядка = 0, то поміняти місцями із рядком, де перший елемент != 0
            int i = 0;
            int size = matrix.Count;
            if (matrix[0][0] == 0)
            {
                while (matrix[i][0] == 0)
                {
                    i++;
                    if (matrix[i][0] != 0)
                    {
                        (matrix[i], matrix[0]) = (matrix[0], matrix[i]);
                        break;
                    }

                    iterationsCount++;
                }
            }

            // прямий хід перетворення матриці
            for (int k = 0; k < size - 1; k++)
            {
                for (i = k + 1; i < size; i++)
                {
                    double factor = -matrix[i][k] / matrix[k][k];
                    for (int j = k; j < size; j++)
                    {
                        matrix[i][j] += factor * matrix[k][j];
                        iterationsCount++;
                    }
                }
            }
        }

        private static List<List<double>> Inverse_matrix(List<List<double>> valuesA, double determinant)
        {
            List<List<double>> inverse_matrix = Adjugate_matrix(valuesA);
            foreach (var element in inverse_matrix)
            {
                for (int j = 0; j < inverse_matrix.Count; j++)
                {
                    element[j] /= determinant;
                    iterationsCount++;
                }
            }

            return inverse_matrix;
        }

        private static List<List<double>> Adjugate_matrix(List<List<double>> valuesA)
        {
            List<List<double>> adjugate_matrix = new List<List<double>>();

            for (int i = 0; i < valuesA.Count; i++)
            {
                List<double> adjugate_matrix_row = new List<double>();
                for (int j = 0; j < valuesA.Count; j++)
                {
                    List<List<double>> minor_matrix = new List<List<double>>();
                    //зчитування мінора
                    for (int i1 = 0; i1 < valuesA.Count; i1++)
                    {
                        if (i1 == i) continue;
                        List<double> minor_row = new List<double>();
                        for (int j1 = 0; j1 < valuesA.Count; j1++)
                        {
                            if (j1 != j)
                            {
                                minor_row.Add(valuesA[i1][j1]);
                            }

                            iterationsCount++;
                        }

                        minor_matrix.Add(minor_row);
                    }

                    Gausse(ref minor_matrix);
                    double minor = Determinant(minor_matrix);
                    if ((i + j) % 2 != 0)
                        minor *= -1;
                    adjugate_matrix_row.Add(minor);
                }

                adjugate_matrix.Add(adjugate_matrix_row);
            }

            //транспонування матриці
            for (int i = 0; i < valuesA.Count; i++)
            {
                for (int j = i + 1; j < valuesA.Count; j++)
                {
                    (adjugate_matrix[j][i], adjugate_matrix[i][j]) = (adjugate_matrix[i][j], adjugate_matrix[j][i]);
                }
            }

            return adjugate_matrix;
        }

        private static List<double> Solve_equations(List<List<double>> valuesA, List<double> valuesB)
        {
            // створення та ініціалізація нулями
            List<double> results = new List<double>(valuesA.Count);
            for (int i = 0; i < valuesA.Count; i++)
            {
                results.Add(0.0);
            }

            //обрахнуок
            for (int i = valuesA.Count - 1; i >= 0; i--)
            {
                double right = valuesB[i];
                for (int j = valuesA.Count - 1; j >= i; j--)
                {
                    right -= (results[j] * valuesA[i][j]);
                }

                results[i] = right / valuesA[i][i];
                iterationsCount++;
            }

            return results;
        }

        public static List<double> Gausse_method(Form form, List<List<double>> valuesA, List<double> valuesB,
            out bool canBeCount)
        {
            List<double> results = new List<double>();
            Gausse(ref valuesA, ref valuesB);
            double det = Determinant(valuesA);
            if (det == 0)
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
                form.Controls.Add(message);
                message.BringToFront();
                canBeCount = false;
                return results;
            }

            results = Solve_equations(valuesA, valuesB);
            canBeCount = true;
            return results;
        }

        public static List<double> Jordane_Gausse_method(Form form, List<List<double>> valuesA, List<double> valuesB,
            out bool canBeCount)
        {
            List<double> results = new List<double>();
            Gausse(ref valuesA, ref valuesB);
            int n = valuesA.Count;

            //обрахування визначника
            double det = Determinant(valuesA);
            if (det == 0)
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
                form.Controls.Add(message);
                message.BringToFront();
                canBeCount = false;
                return results;
            }

            //зворотний хід
            for (int k = n - 1; k >= 0; k--)
            {
                for (int i = k - 1; i >= 0; i--)
                {
                    if (valuesA[k][k] == 0)
                    {
                        // Пошук рядка для перестановки
                        int swapRow = k - 1;
                        while (swapRow >= 0 && valuesA[swapRow][k] == 0)
                        {
                            swapRow--;
                        }

                        // Якщо знайдено ненульовий рядок, переставляємо рядки
                        if (swapRow >= 0)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                (valuesA[k][j], valuesA[swapRow][j]) = (valuesA[swapRow][j], valuesA[k][j]);
                            }

                            (valuesB[k], valuesB[swapRow]) = (valuesB[swapRow], valuesB[k]);
                        }
                        else
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
                            form.Controls.Add(message);
                            message.BringToFront();
                            canBeCount = false;
                            return results;
                        }
                    }

                    double factor = -valuesA[i][k] / valuesA[k][k];

                    for (int j = 0; j < n; j++)
                    {
                        valuesA[i][j] += factor * valuesA[k][j];
                        iterationsCount++;
                    }

                    valuesB[i] += factor * valuesB[k];
                }
            }

            //розв'язання рівнянь
            for (int i = 0; i < n; i++)
            {
                results.Add(valuesB[i] / valuesA[i][i]);
                iterationsCount++;
            }

            canBeCount = true;
            return results;
        }

        public static List<double> Matrix_method(Form form, List<List<double>> valuesA, List<double> valuesB,
            out bool canBeCount)
        {
            List<double> results = new List<double>();

            //перевірка на визначник
            List<List<double>> valuesA_copy = valuesA.Select(row => new List<double>(row)).ToList(); //копія матриці
            Gausse(ref valuesA_copy);
            double det = Determinant(valuesA_copy);
            if (det == 0)
            {
                Label message = new Label
                {
                    Size = new Size(360, 45),
                    Location = new Point(300, 390),
                    Text = "Неможливо порахувати СЛАР цим способом.\nВведіть інші числа або поміняйте метод",
                    ForeColor = Color.Red,
                    Tag = "warn",
                    BackColor = Color.White
                };
                form.Controls.Add(message);
                message.BringToFront();
                canBeCount = false;
                return results;
            }

            List<List<double>> inverse_matrix = Inverse_matrix(valuesA, det);
            //множення оберненої матриці на вектор вільних членів
            for (int i = 0; i < valuesA.Count; i++)
            {
                double result = 0;
                for (int j = 0; j < valuesA.Count; j++)
                {
                    result += inverse_matrix[i][j] * valuesB[j];
                    iterationsCount++;
                }

                results.Add(result);
            }

            canBeCount = true;
            return results;
        }
    }
}