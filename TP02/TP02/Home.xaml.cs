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
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        public async void btnDetalhe(object sender, EventArgs e)
        {
            Contato contato = new Contato
            {
                Nome = nome.Text,
                Idade = int.Parse(idade.Text),
                Profissao = profissao.Text,
                Pais = pais.Text
            };

            var detalhe = new DetalheView();
            detalhe.BindingContext = contato;
            await Navigation.PushAsync(detalhe);

        }
    }
}