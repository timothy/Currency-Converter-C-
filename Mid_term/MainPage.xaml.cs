using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Mid_term.Resources;

namespace Mid_term
{
    public partial class MainPage : PhoneApplicationPage
    {

        public List<double> USD = new List<double>();
        public List<double> AUD = new List<double>();
        public List<double> CAD = new List<double>();
        public List<double> NZD = new List<double>();
        public List<double> JMD = new List<double>();

        public int to;
        public int from;
        public double amount = 1;

        // Constructor
        public MainPage()
        {

            USD.Add(1.10);//AUD -- 0
            USD.Add(1.12);//CAD -- 1
            USD.Add(109.28);//JMD -- 2
            USD.Add(1.17); //NZD -- 3
            USD.Add(1.00); //USD --4

            CAD.Add(0.89); //AUD -- 0
            CAD.Add(1.00); //CAD -- 1
            CAD.Add(97.49);//JMD -- 2
            CAD.Add(1.5);  //NZD -- 3
            CAD.Add(0.89);  //USD --4

            AUD.Add(1.00);//AUD -- 0
            AUD.Add(1.02);//CAD -- 1
            AUD.Add(99.34);//JMD -- 2
            AUD.Add(1.06);//NZD -- 3
            AUD.Add(0.91);//USD --4

            JMD.Add(0.01);//AUD -- 0
            JMD.Add(0.01);//CAD -- 1
            JMD.Add(1.00);//JMD -- 2
            JMD.Add(0.011);//NZD -- 3
            JMD.Add(0.092);//USD --4

            NZD.Add(0.94);//AUD -- 0
            NZD.Add(0.96);//CAD -- 1
            NZD.Add(93.28);//JMD -- 2
            NZD.Add(1.00);//NZD -- 3
            NZD.Add(0.85);//USD --4

            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void to_USD_radio(object sender, RoutedEventArgs e)
        {
            to = 4;//USD

            amount = Convert.ToDouble(Tbox.Text);
            amount *= USD[from];
            label_one.Text = amount.ToString();

        }

        private void to_AUD_radio(object sender, RoutedEventArgs e)
        {
            to = 0;//AUD

            amount = Convert.ToDouble(Tbox.Text);
            amount *= AUD[from];
            label_one.Text = amount.ToString();

        }

        private void to_JMD_radio(object sender, RoutedEventArgs e)
        {
            to = 2;

            amount = Convert.ToDouble(Tbox.Text);
            amount *= JMD[from];
            label_one.Text = amount.ToString();

        }

        private void to_NZD_radio(object sender, RoutedEventArgs e)
        {
            to = 3;

            amount = Convert.ToDouble(Tbox.Text);
            amount *= NZD[from];
            label_one.Text = amount.ToString();

        }

        private void to_CAD_radio(object sender, RoutedEventArgs e)
        {
            to = 1;

            amount = Convert.ToDouble(Tbox.Text);
            amount *= CAD[from];
            label_one.Text = amount.ToString();

        }

       

        private void from_USD_radio(object sender, RoutedEventArgs e)
        {
            from = 4;

            amount = Convert.ToDouble(Tbox.Text);
            amount *= USD[to];
            label_one.Text = amount.ToString();
        }

        private void from_AUD_radio(object sender, RoutedEventArgs e)
        {
            from = 0;

            amount = Convert.ToDouble(Tbox.Text);
            amount *= AUD[to];
            label_one.Text = amount.ToString();
        }

        private void from_JMD_radio(object sender, RoutedEventArgs e)
        {
            from = 2;

            amount = Convert.ToDouble(Tbox.Text);
            amount *= JMD[to];
            label_one.Text = amount.ToString();
        }

        private void from_NZD_radio(object sender, RoutedEventArgs e)
        {
            from = 3;

            amount = Convert.ToDouble(Tbox.Text);
            amount *= NZD[to];
            label_one.Text = amount.ToString();
        }

        private void from_CAD_radio(object sender, RoutedEventArgs e)
        {
            from = 1;

            amount = Convert.ToDouble(Tbox.Text);
            amount *= CAD[to];
            label_one.Text = amount.ToString();
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}