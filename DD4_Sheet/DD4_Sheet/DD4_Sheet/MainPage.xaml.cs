﻿using DD4_Sheet;
using DD4_Sheet.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DD4_Sheet
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.MAIN;
        }

        void FrameDescription_tapped(object sender, EventArgs e)
        {
            Debug.WriteLine("click !");
            Navigation.PushAsync(new CaracterePage ()); 
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine(App.MAIN.ToXML());

            Application.Current.Properties[App.XMLkey] = App.MAIN.ToXML();
        }
    }
}
