using System;
using Xamarin.Forms;

namespace SafeZone
{
    public partial class PageSafeAreaPage : ContentPage
    {
        public PageSafeAreaPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
