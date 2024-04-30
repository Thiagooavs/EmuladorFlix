namespace EmuladorFlix
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void aventura_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Aventura());
        }

        private void comedia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Comedia());
        }

        private void drama_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Drama());
        }

        private void terror_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Terror());
        }

        private void ficcao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Ficcao());
        }

        private void suspence_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Suspence());
        }

        private void infantil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Infantil());
        }

        private void animacao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Animacao());
        }

        private void documentario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Documentario());
        }

        private void acao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Acao());
        }

        private void nacional_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Nacional());
        }

        private void romance_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Categorias.Romance());
        }
    }

}
