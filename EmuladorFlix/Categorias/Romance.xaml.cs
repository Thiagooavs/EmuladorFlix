namespace EmuladorFlix.Categorias;

public partial class Romance : ContentPage
{
	public Romance()
	{
		InitializeComponent();
	}

    private void todosmenosvoce_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.todosvc());
    }

    private void redencao_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.redencao());
    }

    private void comoera_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.comoera());
    }

    private void umaparede_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.umaparede());
    }
}