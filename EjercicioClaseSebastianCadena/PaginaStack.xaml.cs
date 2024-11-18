namespace EjercicioClaseSebastianCadena;

public partial class PaginaStack : ContentPage
{
	public PaginaStack()
	{
		InitializeComponent();
	}

    private void Boton3_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PaginaFlex());

    }
}