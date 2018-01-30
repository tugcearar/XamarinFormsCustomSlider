using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace XamarinFormsSliderApp.Views
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / 100);
            slider2.Value = newStep * 100;
            lblText.Text = slider2.Value.ToString();
            lblText.TranslateTo(slider2.Value * ((slider2.Width - 40) / slider2.Maximum) , 0, 100);
        }
    }
}
