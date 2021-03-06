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
using VT_01RaulSalva.Pages;

namespace VT_01RaulSalva
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static Frame myNavigationFrame;
        public UsersHandler usersHandler;
        public ProductHandler productHandler;
        public MainWindow()
        {
            InitializeComponent();
            myNavigationFrame = myFrame;
            usersHandler = new UsersHandler();
            productHandler = new ProductHandler();
            myNavigationFrame.NavigationService.Navigate(new MainPage());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNavigationFrame.NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myNavigationFrame.NavigationService.Navigate(new NewOrModifyUserPage("Nuevo usuario", usersHandler));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            myNavigationFrame.NavigationService.Navigate(new ShowUserPage(usersHandler));

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            myNavigationFrame.NavigationService.Navigate(new NewOrModifyProductPage("Nuevo producto", productHandler));
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            myNavigationFrame.NavigationService.Navigate(new ShowProductPage(productHandler));

        }
    }
}
