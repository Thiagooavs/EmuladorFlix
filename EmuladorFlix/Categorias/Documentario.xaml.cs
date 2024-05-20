namespace EmuladorFlix.Categorias;

public partial class Documentario : ContentPage
{
	public Documentario()
	{
		InitializeComponent();
	}

    private void elena_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.elena());   
    }

    private void einstein_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.bomba());
    }

    private void hitler_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.hitler());
    }

    private void wwi_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.wwi());
    }
}