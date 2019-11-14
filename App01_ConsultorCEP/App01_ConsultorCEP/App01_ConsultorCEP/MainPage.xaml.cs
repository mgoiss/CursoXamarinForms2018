using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultorCEP.Servico.Modelo;
using App01_ConsultorCEP.Servico;

namespace App01_ConsultorCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Botao.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string tempCep = Cep.Text.Trim();

            if (isValidCEP(tempCep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(tempCep);

                    if (end != null)
                    {
                        Resultado.Text = string.Format("Resultado do CEP {0}:\n\n" +
                                                        "{1} {2}\n" +
                                                        "{3} {4}\n" +
                                                        "{5} {6}\n" +
                                                        "{7} {8}\n" +
                                                        "{9} {10}\n", tempCep, "Logradouro: ", end.Logradouro, "Bairro: ", end.Bairro, "Localidade: ", end.Localidade, "UF: ", end.Uf, "IBGE: ", end.Ibge);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado: " + tempCep, "OK");
                    }
                }
                catch (Exception ex)
                {
                    DisplayAlert("ERRO CRÍTICO! ", ex.Message, "OK");
                }
            }
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;

            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caractres.", "OK");

                valido = false;
            }

            int novoCep = 0;

            if (!int.TryParse(cep, out novoCep))
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve ser composto apenas por numeros", "OK");

                valido = false;
            }

            return valido;
        }
    }
}
