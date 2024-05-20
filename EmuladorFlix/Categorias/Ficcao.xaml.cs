namespace EmuladorFlix.Categorias;

public partial class Ficcao : ContentPage
{
	public Ficcao()
	{
		InitializeComponent();
	}

    private void mazerunner_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.mazerunner());
    }

    private void avatar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.avatar());
    }

    private void doctor_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.doctor());
    }

    private void interestelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Filmes.interestelas());
    }
}