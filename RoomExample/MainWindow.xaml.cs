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
using RoomLibrary;

namespace RoomExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen1_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpen2.IsEnabled = true; // разрешить открыть вторую комнату
            //инициализация полей класса и генерация числа человек
            room1.Roomlehght = rnd.Next(2, 11);
            room1.RoomWidth = rnd.Next(2, 11);
            int numP = rnd.Next(1, 9);

            //вывод сгенерированных данных в метки
            LabelLenght1.Content = room1.Roomlehght;
            LabelWindth1.Content = room1.RoomWidth;
            LabelNumPerson1.Content = numP;

            //вычисление периметра, площади, метража и вывод в метки
            LabelPerimetr1.Content = room1.RoomPerimeter();
            LabelArea1.Content = room1.RoomArea();
            LabelPersonArea1.Content = Math.Round (room1.PersonArea(numP),3);
        }
        /// <summary>
        /// Открытие второй комнаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpen2_Click(object sender, RoutedEventArgs e)
        {
            ButtonAll.IsEnabled = true;//разрешить суммировать площади комнат
            //ввод данных инициализация полей класса
            room2.Roomlehght = Convert.ToDouble(TBLenght2.Text);
            room2.RoomWidth = Convert.ToDouble(TBWidth2.Text);
            int numP = Convert.ToInt32(TBWidth2.Text);

            //вычисление периметра, площади, метража и вывод в метки
            LabelPerimetr2.Content = room2.RoomPerimeter();
            LabelArea2.Content = room2.RoomArea();
            LabelPersonArea2.Content = Math.Round(room2.PersonArea(numP),3);
        }

        private void ButtonAll_Click(object sender, RoutedEventArgs e)
        {
            LabelAllArea.Content = room1.RoomArea() + room2.RoomArea(); 
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
