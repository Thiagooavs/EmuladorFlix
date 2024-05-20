namespace EmuladorFlix.Categorias;

public partial class Suspence : ContentPage
{
	public Suspence()
	{
        InitializeComponent();
	}

    private void corra_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.corra());
    }

    private void luther_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.luther());
    }

    private void semsaida_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.semsaida());
    }

    private void birdbox_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.birdbox());
    }
}