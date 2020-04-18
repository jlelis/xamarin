using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppImc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double peso, altura, imc;
        string resultado;

        public MainPage()
        {

            InitializeComponent();
            imc = 0;
            peso = 0;
            altura = 0;
            resultado = "";
        }


        private void btnCalcula_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(this.txtPeso.Text, out peso))

            {

                DisplayAlert("Atenção", "Valor no formato inválido!", "Fechar");

            }

            else if (!double.TryParse(this.txtAltura.Text, out altura))

            {

                DisplayAlert("Atenção", "Valor no formato inválido!", "Fechar");

            }
            else
            {
                altura = double.Parse(this.txtAltura.Text);
                peso = double.Parse(this.txtPeso.Text);

                imc = (peso / (altura * altura));
            }
            if (imc < 18.5)
            {

                resultado = "Abaixo do peso";

            }
            else if (imc >= 18.5 && imc < 24.9)
            {

                resultado = "Peso normal";

            }
            else if (imc >= 25 && imc < 29.9)
            {

                resultado = "Sobrepeso";

            }
            else if (imc >= 30 && imc < 34.9)
            {

                resultado = "Obesidade grau 1";

            }
            else if (imc >= 35 && imc < 39.9)
            {

                resultado = "Obesidade grau 2";

            }
            else if (imc >= 40)
            {

                resultado = "Obesidade grau 3";

            }
            DisplayAlert("Resultado", resultado, "Fechar");

            this.resultAltura.Text = $"Altura digitada: {altura} mt";
            this.resultPeso.Text = $"Peso digitado: {peso} Kg";

            this.resultIMC.Text = imc.ToString("#.##");
            this.resultCalculo.Text = resultado;

        }
    }
}
