namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;


        public MainPage()
        {
            InitializeComponent();
        }



       

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProdutoPage());

        }

        private void btnProduto2_Clicked(object sender, EventArgs e)
        {

        }

        private void btnProduto_Clicked_1(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Mouse Multilaser";
            produto.Preco = 30;
            produto.Categoria = "Informática";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto});
        }

        private void btnProduto2_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProdutoPage2());
        }

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
