using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Loginv2.Services;
using Loginv2.Models;


namespace Loginv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            AtualizaLista();
        }

        public void inserirTimes()
        {
            Jogos jogos = new Jogos();
            jogos.nomeTimeOne = "Corinthians";
            jogos.nomeTimeTwo = "Flamengo";
            jogos.Local = "Itaquerão";

            ServicesDB db = new ServicesDB(App.DbPath);
            db.CriarJogos(jogos);
        }
        async void InserirItens()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = entNome.ToString();
            cliente.SobreNome = entSobreNome.ToString();
            cliente.Email = entEmail.ToString();
            cliente.Senha = entSenha.ToString() ;
            cliente.ConfirmarSenha = entConfirmSenha.ToString();

            ServicesDB db = new ServicesDB(App.DbPath);
            db.Inserir(cliente);
            await DisplayAlert("Resultado " , db.StatusMessage, "OK");
            await Navigation.PushModalAsync(new PrincipalPage(), true);
        }

        public void AtualizaLista()
        {
            ServicesDB db = new ServicesDB(App.DbPath);
            ListarClieinte.ItemsSource = db.Listar();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            InserirItens();
        }
    }
}