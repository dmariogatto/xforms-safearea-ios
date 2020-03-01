using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SafeZone
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender == NoSafeArea)
            {
                Navigation.PushAsync(new NoSafeAreaPage());
            }
            else if (sender == PageSafeArea)
            {
                Navigation.PushAsync(new PageSafeAreaPage());
            }
            else if (sender == EffectSafeArea)
            {
                Navigation.PushAsync(new EffectSafeAreaPage());
            }
        }
    }
}
