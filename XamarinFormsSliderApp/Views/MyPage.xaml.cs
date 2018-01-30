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
            mySlider.Value = newStep * 100;
            lblText.Text = mySlider.Value.ToString();
            lblText.TranslateTo(mySlider.Value * ((mySlider.Width - 40) / mySlider.Maximum) , 0, 100);
        }
    }
}
