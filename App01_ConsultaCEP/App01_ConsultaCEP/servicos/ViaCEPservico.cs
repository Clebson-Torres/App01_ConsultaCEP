using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultaCEP.servicos.modelo;
using Newtonsoft.Json;



namespace App01_ConsultaCEP.servicos
{
    public class ViaCEPservico
    {
        private static string EnderecoUrl = "https://viacep.com.br/ws/{}/json/";

        public static endereco BuscarENderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoUrl, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            endereco end = JsonConvert.DeserializeObject<endereco>(Conteudo);

            return end;

        } 
    }
}
