namespace CalcularDiasVividosMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Ação do botão "Calcular Dias Vividos"
    private async void btncalcular_Clicked(object sender, EventArgs e)
    {
        string nome = entnome.Text;
        string idadeTexto = entidade.Text;

        // Validação: verifica se os campos foram preenchidos
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(idadeTexto))
        {
            await DisplayAlert("Atenção", "Por favor, preencha o nome e a idade.", "OK");
            return;
        }

        // Tenta converter a idade para número
        if (int.TryParse(idadeTexto, out int idade))
        {
            int diasVividos = idade * 365;

            // Exibe o resultado em uma caixa de mensagem na tela
            await DisplayAlert("Resultado", $"Olá, {nome}!\nVocê já viveu aproximadamente {diasVividos} dias.", "OK");
        }
        else
        {
            await DisplayAlert("Erro", "Por favor, digite uma idade válida (somente números).", "OK");
        }
    }

    // Ação do botão "Limpar Campos"
    private void btnlimpar_Clicked(object sender, EventArgs e)
    {
        entnome.Text = string.Empty;
        entidade.Text = string.Empty;
    }
}