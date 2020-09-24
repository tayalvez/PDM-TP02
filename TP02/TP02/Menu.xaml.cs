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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void EstiloPadrao(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EstiloPadrao());

        }
        private async void EstiloDinamico(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new EstiloDinamico());

        }

        private async void TriggerView(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new TriggersView());

        }
        private async void Home(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Home());

        }
        private async void ListViewSimples(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ListViewSimples());

        }
        private async void Produto(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ProdutoView());

        }
    }
}