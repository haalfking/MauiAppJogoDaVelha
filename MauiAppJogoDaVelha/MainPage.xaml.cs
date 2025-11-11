namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "x";


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "x") 
            {
                btn.Text = "x";
                vez = "o";
            } else
            {
                btn.Text = "0";
                vez = "x";
            }

            
            // Verifica todas as possibilidades de vitória do "x"
            if (
                // Linhas
                (btn10.Text == "x" && btn11.Text == "x" && btn12.Text == "x") ||
                (btn20.Text == "x" && btn21.Text == "x" && btn22.Text == "x") ||
                (btn30.Text == "x" && btn31.Text == "x" && btn32.Text == "x") ||

                // Colunas
                (btn10.Text == "x" && btn20.Text == "x" && btn30.Text == "x") ||
                (btn11.Text == "x" && btn21.Text == "x" && btn31.Text == "x") ||
                (btn12.Text == "x" && btn22.Text == "x" && btn32.Text == "x") ||

                // Diagonais
                (btn10.Text == "x" && btn21.Text == "x" && btn32.Text == "x") ||
                (btn12.Text == "x" && btn21.Text == "x" && btn30.Text == "x")
            )
            {
                DisplayAlert("Parabéns!", "O jogador X venceu!", "OK");
                zerar();
            }

            // Verifica todas as possibilidades de vitória do "o"
            if (
                (btn10.Text == "0" && btn11.Text == "0" && btn12.Text == "0") ||
                (btn20.Text == "0" && btn21.Text == "0" && btn22.Text == "0") ||
                (btn30.Text == "0" && btn31.Text == "0" && btn32.Text == "0") ||

                (btn10.Text == "0" && btn20.Text == "0" && btn30.Text == "0") ||
                (btn11.Text == "0" && btn21.Text == "0" && btn31.Text == "0") ||
                (btn12.Text == "0" && btn22.Text == "0" && btn32.Text == "0") ||

                (btn10.Text == "0" && btn21.Text == "0" && btn32.Text == "0") ||
                (btn12.Text == "0" && btn21.Text == "0" && btn30.Text == "0")
            )
            {
                DisplayAlert("Parabéns!", "O jogador O venceu!", "OK");
                zerar();
            }



            }// fecha metodo 

            void zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";


            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

        }


    }// fecha classe 

}// fecha namespace
