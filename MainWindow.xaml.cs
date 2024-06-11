using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using uchot.Model;

namespace uchot
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary> 
        /// ссылка на главное окно
        /// </summary>
        public static MainWindow init;
        /// <summary> 
        /// создание нового класса с активным пользователем
        /// </summary>
        public Users ActiveUser = new Users();
        public MainWindow()
        {
            InitializeComponent();
            //открытие страницы авторизации
            OpenPages(new Pages.Authentication());
            //запоминаем главное окно
            init = this;
        }

        /// <summary>
        /// метод открытия страниц
        /// </summary>
        public void OpenPages(Page Page)
        {
            //открытие всех страниц в этот frame
            frame.Navigate(Page);
        }

        /// <summary>
        /// открытие страницы с оборудованием
        /// </summary>
        private void OpenEquipment(object sender, RoutedEventArgs e)
        {
            //переход на страницу оборудования
            MainWindow.init.OpenPages(new Pages.Equipment.Main());
        }

        /// <summary>
        /// открытие страницы с пользователями
        /// </summary>
        private void OpenUsers(object sender, RoutedEventArgs e)
        {
            //переход на страницу пользователей
            MainWindow.init.OpenPages(new Pages.Users.Main());
        }
        /// <summary>
        /// открытие страницы с аудиториями
        /// </summary>
        private void OpenClassrooms(object sender, RoutedEventArgs e)
        {
            //переход на страницу аудиторий
            MainWindow.init.OpenPages(new Pages.Classroom.Main());
        }
        /// <summary>
        /// открытие страницы со статусом оборудования
        /// </summary>
        private void OpenStatus(object sender, RoutedEventArgs e)
        {
            //переход на страницу статусов оборудования
            MainWindow.init.OpenPages(new Pages.Status.Main());
        }
    }
}
