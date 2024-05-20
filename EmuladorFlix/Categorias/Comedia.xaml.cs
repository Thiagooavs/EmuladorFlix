namespace EmuladorFlix.Categorias;

public partial class Comedia : ContentPage
{
	public Comedia()
	{
        InitializeComponent();
    }

    private void gentegrande_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.gentegrande());
    }

    private void umanoite_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.umanoite());
    }

    private void maskara_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.maskara());
    }

    private void juntomisturado_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.juntomisturado());
    }
}