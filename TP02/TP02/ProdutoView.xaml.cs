using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProdutoView : ContentPage
    {
        public ProdutoView()
        {
            InitializeComponent();
        }

        public async void btnDetalhe(object sender, EventArgs e)
        {
            Produto produto = new Produto
            {
                Id = int.Parse(id.Text),
                Descricao = descricao.Text,
                Categoria = categoria.Text,
                Quantidade = int.Parse(quantidade.Text),
                Preco = decimal.Parse(preco.Text)
            };

            var detalhe = new FormProdutoView();
            detalhe.BindingContext = produto;
            await Navigation.PushAsync(detalhe);

        }

    }
}