namespace EmuladorFlix.Categorias;

public partial class Nacional : ContentPage
{
	public Nacional()
	{
		InitializeComponent();
	}

    private void cidadededeus_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.cidade());
    }

    private void autodacompadecida_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.compadecida());
    }

    private void morto_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.morto());
    }

    private void tropa_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.tropa());
    }
}