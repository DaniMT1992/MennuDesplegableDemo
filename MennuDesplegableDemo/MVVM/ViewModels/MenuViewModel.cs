using System.Windows.Input;
using Microsoft.Maui.Controls;


namespace MennuDesplegableDemo.MVVM.ViewModels
{
    public class MenuViewModel
    {        
        public ICommand ExpedientesCommand { get; }
        public ICommand CambiarContrasenaCommand { get; }
        public ICommand AcercaDeCommand { get; }
        public ICommand CerrarSesionCommand { get; }
        public ICommand InicioCommand { get; }

        public MenuViewModel()
        {            
            ExpedientesCommand = new Command(NavegarAExpedientes);
            CambiarContrasenaCommand = new Command(CambiarContrasena);
            AcercaDeCommand = new Command(AbrirAcercaDe);
            CerrarSesionCommand = new Command(CerrarSesion);
            InicioCommand = new Command(NavegarAInicio);
        }

        private void NavegarAExpedientes()
        {
            Application.Current.MainPage.DisplayAlert("Navegación", "Navegando a Expedientes", "OK");
            
        }
        private void CambiarContrasena()
        {
            Application.Current.MainPage.DisplayAlert("Acción", "Cambiando Contraseña", "OK");            
        }
        private void AbrirAcercaDe()
        {
            Application.Current.MainPage.DisplayAlert("Información", "Acerca de esta aplicación", "OK");
        }
        private void CerrarSesion()
        {
            Application.Current.MainPage.DisplayAlert("Sesión", "Cerrando Sesión", "OK");
        }

        
        private void NavegarAInicio()
        {           
            if (Application.Current.MainPage is FlyoutPage flyoutPage)
            {
                flyoutPage.Detail = new NavigationPage(new MainPage()); // Asegúrate de tener la página de inicio
                flyoutPage.IsPresented = false; 
            }
        }
    }
}