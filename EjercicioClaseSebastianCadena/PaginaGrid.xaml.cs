namespace EjercicioClaseSebastianCadena;

public partial class PaginaGrid : ContentPage
{
	public PaginaGrid()
	{
		InitializeComponent();
	}

    private void Boton2_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new PaginaStack());

    }


   
}