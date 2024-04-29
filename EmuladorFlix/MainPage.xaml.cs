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
    }

}
