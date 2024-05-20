namespace EmuladorFlix.Categorias;

public partial class Terror : ContentPage
{
	public Terror()
	{
		InitializeComponent();
	}

    private void itcoisa_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.itcoisa());
    }

    private void pesadelo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.pesadelo());
    }

    private void invocacao_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.invoc());
    }

    private void falecomigo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.falecomigo());
    }
}