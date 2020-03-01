using System;
using Xamarin.Forms;

namespace SafeZone
{
    public partial class NoSafeAreaPage : ContentPage
    {
        public NoSafeAreaPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
