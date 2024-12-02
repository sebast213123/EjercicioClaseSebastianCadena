using Microsoft.Maui.Controls;

namespace EjercicioClaseSebastianCadena
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Boton1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Recarga", "Recarga de celular realizada", "OK");
        }

        private void MostrarCamposEncriptados(object sender, EventArgs e)
        {
            string telefono = TelefonoEntry.Text;
            string nombre = NombreEntry.Text;

            string telefonoEncriptado = "xxxxx"; 
            string nombreEncriptado = "xxxxx"; 

            
            MensajeEncriptadoLabel.Text = $"Número de teléfono encriptado: {telefonoEncriptado}\nNombre encriptado: {nombreEncriptado}";
            MensajeEncriptadoLabel.IsVisible = true;
        }
    }
}
