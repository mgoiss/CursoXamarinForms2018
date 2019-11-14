using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultorCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultorCEP.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/"; //URL com o parametro {0}

        //Função para retornar os dados
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string novoEnderecoURL = string.Format(EnderecoURL, cep); //Passando a URL completa para a variável

            WebClient wc = new WebClient(); //Criando um objeto para pegar os dados na internet

            string conteudo = wc.DownloadString(novoEnderecoURL); //Pegando os dados

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo); //Convertendo os dados

            if (end.Cep == null)
            {
                return null;
            }

            end.OrganizaDadosExibidos();

            return end; //Retornando
        }

    }
}
