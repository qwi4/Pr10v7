using System;
using System.Collections.Generic;
using System.Windows;

namespace Pr10v7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. " +
                "\r\nДан массив в диапазоне [-30;100] найти минимальное " +
                "r\nи максимальное значение и обменять их местами.",
                "Разработчик: 10.",
                MessageBoxButton.OK,
                MessageBoxImage.Asterisk);
        }

        private void mItExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        int[] array;
        List<int> mas = new List<int>();

        /// <summary>
        /// Заполнение массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFillArrayOne_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lBArrayOne.Items.Clear();

                bool arrayOneSize = int.TryParse(txtBoxSize.Text, out int arraySize);
                if (arrayOneSize)
                {
                    Random rnd = new Random();
                    array = new int[arraySize];

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = rnd.Next(-30, 100);
                        lBArrayOne.Items.Add(array[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Замена Макс - Мин значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwapMaxMin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lBArrayTwo.Items.Clear();

                int minValue = array[0];
                int minIndex = 0;
                int maxValue = array[0];
                int maxIndex = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (minValue > array[i])
                    {
                        minValue = array[i];
                        minIndex = i;
                    }

                    if (maxValue < array[i])
                    {
                        maxValue = array[i];
                        maxIndex = i;
                    }
                }
                array[minIndex] = maxValue;
                array[maxIndex] = minValue;

                for (int i = 0; i < array.Length; i++)
                {
                    mas.Add(array[i]);
                }

                for (int j = 0; j < mas.Count; j++)
                {
                    lBArrayTwo.Items.Add(mas[j]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
