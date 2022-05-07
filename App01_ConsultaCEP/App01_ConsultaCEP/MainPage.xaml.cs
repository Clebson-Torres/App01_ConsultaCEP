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
            Endereco end = ViaCEPservico.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = string.Format("Endereço: {0},{1} {2}",  end.logradouro, end.bairro, end.uf, end.localidade  );
            //todo - logica do programa
            // todo - validações

        }
    }
}
