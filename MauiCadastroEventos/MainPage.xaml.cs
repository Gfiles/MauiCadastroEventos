using MauiCadastroEventos.Models;
using MauiCadastroEventos.Views;

namespace MauiCadastroEventos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CalcularCusto_Clicked(object sender, EventArgs e)
        {
            Evento evento = new Evento();

            evento.Nome = cmpNomeEvento.Text;
            evento.DataInicio = cmpDataInicio.Date;
            evento.DataFim = cmpDataFim.Date;
            evento.NumParticipantes = int.Parse(cmpNumParticipantes.Text);
            evento.Local = cmpLocal.Text;
            evento.CustoParticipante = float.Parse(cmpCustoParticipante.Text);

            await Navigation.PushAsync(new NewPage1()
            {
                BindingContext = evento
            });
        }
    }

}
