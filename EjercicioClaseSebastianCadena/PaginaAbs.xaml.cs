namespace EjercicioClaseSebastianCadena;

public partial class PaginaAbs : ContentPage
{
	public PaginaAbs()
	{
		InitializeComponent();
	}

    private void Boton5_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaGrid());


    }
}