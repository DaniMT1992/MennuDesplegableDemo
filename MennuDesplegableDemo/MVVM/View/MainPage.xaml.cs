using Microsoft.Maui.Controls;

namespace MennuDesplegableDemo
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
           
            this.Detail = new NavigationPage(new MainPage());

            this.IsPresented = false; 
        }
    }
}