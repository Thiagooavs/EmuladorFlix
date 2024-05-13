namespace EmuladorFlix.Categorias;

public partial class Acao : ContentPage
{
	public Acao()
	{
        InitializeComponent();
    }

    private void doiscaras_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.doiscaras());
    }

    private void pilpfiction_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.pilpfiction());
    }

    private void babydrive_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.babydrive());
    }

    private void madmax_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.madmax());
    }
}