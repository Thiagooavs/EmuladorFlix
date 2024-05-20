namespace EmuladorFlix.Categorias;

public partial class Infantil : ContentPage
{
	public Infantil()
	{
		InitializeComponent();
	}

    private void aladin_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.aladdin());
    }

    private void scooby_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.scooby());
    }

    private void incrivelfabrica_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.incrivel());
    }

    private void up_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.up());
    }
}