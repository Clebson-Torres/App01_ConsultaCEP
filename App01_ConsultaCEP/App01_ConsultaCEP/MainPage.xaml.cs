using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultaCEP.servicos.modelo;
using App01_ConsultaCEP.servicos;

namespace App01_ConsultaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;

        }
        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();

            if (isVALIDCEP(cep))
            {
                Endereco end = ViaCEPservico.BuscarEnderecoViaCEP(cep);

                RESULTADO.Text = string.Format("Endereço: {0},{1} {2}", end.logradouro, end.bairro, end.uf, end.localidade);
                        
             }


        }
        private bool isVALIDCEP(string cep)
        {
            bool valido = true;

            if(cep.Length !=8)
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres.", "OK");
                
                valido = false;
            }
            int NovoCEP = 0;

                if(!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve ser composto apenas por números.", "OK");
                
                valido = false;
            }
            return valido;
        }

    }
}
