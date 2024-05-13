namespace EmuladorFlix.Categorias;

public partial class Aventura : ContentPage
{
	public Aventura()
	{
        InitializeComponent();
    }

    private void opequenoprincipe_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.pequenoprincipe());
    }

    private void jumanji_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.jumanji());
    }

    private void kingkong_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.kingkong());
    }

    private void piratas_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.piratas());
    }
}