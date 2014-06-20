using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace AppBar
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class gridview : Page
    {
        public class Imag
        {
            public string Source1 { get; set; }
        }

        List<Imag> GridItems = new List<Imag>(){
                new Imag(){Source1 = "Assets/apple.jpg"},
                new Imag(){Source1= "Assets/basketballbaby.jpg"},
                new Imag() {Source1 = "Assets/cat3.jpg"},
                new Imag() {Source1 = "Assets/dog.jpg"},
                new Imag() {Source1 = "Assets/girl1.jpg"},
                new Imag() {Source1 = "Assets/girl2.jpg"},
                new Imag() {Source1 = "Assets/cat1.jpg"},
                new Imag() {Source1 = "Assets/cat2.jpg"},
                new Imag() {Source1 = "Assets/image5.jpg"},
                new Imag() {Source1 = "Assets/images3.png"},
                new Imag() {Source1 = "Assets/images6.jpg"},
                new Imag() {Source1 = "Assets/kill.jpg"},
               // new Imag() {}

            };
        public gridview()
        {
            this.InitializeComponent();
            gridm.ItemsSource = GridItems;
        }
        public void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
        public void List_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(li));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
