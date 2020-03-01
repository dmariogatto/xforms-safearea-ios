using System;
using Xamarin.Forms;

namespace SafeZone
{
    public partial class EffectSafeAreaPage : ContentPage
    {
        public EffectSafeAreaPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
