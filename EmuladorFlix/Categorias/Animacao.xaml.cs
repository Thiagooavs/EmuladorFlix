namespace EmuladorFlix.Categorias;

public partial class Animacao : ContentPage
{
	public Animacao()
	{
        InitializeComponent();
    }

    private void shrekdois_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.shrekdois());
    }

    private void gatodebotas_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.gato());
    }

    private void aranhaverso_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.spiderman());
    }

    private void injustice_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.injustice());
    }
}