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
        private static string EnderecoUrl = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoUrl, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString (NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if(end.cep == null) return null;

            return end;

        } 
    }
}
