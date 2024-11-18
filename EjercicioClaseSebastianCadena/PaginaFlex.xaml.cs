namespace EjercicioClaseSebastianCadena;

public partial class PaginaFlex : ContentPage
{
	public PaginaFlex()
	{
		InitializeComponent();
	}

    private void Boton4_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaAbs());

    }

    
}