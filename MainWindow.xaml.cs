﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISRPO_PR3_Cherednichenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            X.Text = "5,5";
            Y.Text = "4,3";
            Z.Text = "2,8";
            Itog.Text = "Ст. гр. 402 ИСП Чередниченко Е.К.";
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            //Считывание значения X
                double x = double.Parse(X.Text);
            //Вывод значения X в окно
            Itog.Text += Environment.NewLine + "X = " + x.ToString();
            //Считывание значения Y
                double y = double.Parse(Y.Text);
            //Вывод значения Y в окно
            Itog.Text += Environment.NewLine + "Y = " + y.ToString();
            //Считывание знгачения Z
                double z = double.Parse(Z.Text);
            //Вывод значения Z в окно
            Itog.Text += Environment.NewLine + "Z = " + z.ToString();

            //Вычисляем арифмитическое выражение
                    double a = Math.Tan(x + y) * Math.Tan(x + y);
                    double b = Math.Exp(y - z);
                    double c = Math.Sqrt(Math.Cos(x * x) + Math.Sin(z * z));
                    double u = a - b * c;
            //Выводим результат в окно
            Itog.Text += Environment.NewLine + "Результат U = " + u.ToString();

        }
    }
}
