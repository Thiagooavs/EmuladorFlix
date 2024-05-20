namespace EmuladorFlix.Categorias;

public partial class Drama : ContentPage
{
	public Drama()
	{
		InitializeComponent();
	}

    private void coracaoferro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.coracaoferro());
    }

    private void nadanovo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.nadafront());
    }

    private void intocaveis_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.intocaveis());
    }

    private void clubluta_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.clubluta());
    }
}