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
    public sealed partial class li : Page
    {
        public class Imag
        {
            public string Source1 { get; set; }
            public string tsource { get; set;}
       
        }

   
        List<Imag> ListItems = new List<Imag>(){
                new Imag(){Source1 = "Assets/apple.jpg" ,tsource = "A big apple"},
                new Imag(){Source1= "Assets/basketballbaby.jpg", tsource = "A beautiful basketball baby"},
                new Imag() {Source1 = "Assets/cat3.jpg", tsource = "A cool Cat"},
                new Imag() {Source1 = "Assets/dog.jpg", tsource = "A Dog sleep"},
                new Imag() {Source1 = "Assets/girl1.jpg", tsource = "A lovely litte girl"},
                new Imag() {Source1 = "Assets/girl2.jpg", tsource = "A pretty girl"},
                new Imag() {Source1 = "Assets/cat1.jpg", tsource = "A lovely cat"},
                new Imag() {Source1 = "Assets/cat2.jpg", tsource = "It's very fat"},
                new Imag() {Source1 = "Assets/image5.jpg", tsource = "A dangrous peak"},
                new Imag() {Source1 = "Assets/images3.png", tsource = "It's very sample"},
                new Imag() {Source1 = "Assets/images6.jpg", tsource = "A nice day"},
                new Imag() {Source1 = "Assets/kill.jpg", tsource = "KILL"}, 
            
             
           
            };
     
        public li()
        {
            this.InitializeComponent();
            
            gridm.ItemsSource = ListItems;
           
        }
        public void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(gridview));
        }
        public void Home_Click(object sender, RoutedEventArgs e)
        {
           Frame.Navigate(typeof(MainPage));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(gridview));
        }
    }
}
