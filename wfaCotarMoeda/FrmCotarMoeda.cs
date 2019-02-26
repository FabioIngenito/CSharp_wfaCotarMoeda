using System;
using System.Windows.Forms;

/// <summary>
/// Como usar o Web Service do Banco Central para pegar a cotação do dólar, euro, entre outras moedas
/// Agito 24 Horas
/// Publicado em 18 de out de 2017
/// https://www.youtube.com/watch?v=Df2RmBu_xgk
/// 
/// WebService
/// https://www3.bcb.gov.br/sgspub/JSP/sgsgeral/FachadaWSSGS.wsdl
/// 
/// Que códigos o webservice para cotação de moedas do Banco Central aceita? – web-service
/// http://naweb.info/que-codigos-o-webservice-para-cotacao-de-moedas-do-banco-central-aceita-web-service/
/// </summary>
namespace wfaCotarMoeda
{
    public partial class FrmCotarMoeda : Form
    {
        public FrmCotarMoeda()
        {
            InitializeComponent();
        }

        private void FrmCotarMoeda_Load(object sender, EventArgs e)
        {
            //Coloca a data atual e não permite alterar
            dtpCotarMoeda.Value = DateTime.Now.Date;
            dtpCotarMoeda.MinDate = DateTime.Now.Date;
            dtpCotarMoeda.MaxDate = DateTime.Now.Date;

            //Preencher Combo Moedas
            CmbMoeda.DisplayMember = "Nome";
            CmbMoeda.ValueMember = "Codigo";
            CmbMoeda.DataSource = ClsCotarMoedaBLL.ClsCotarMoeda.PreencherComboMoeda();

            //Posicionar na primeira posição da Combobox
            CmbMoeda.SelectedIndex = 0;
        }

        /// <summary>
        /// Faço a comparação de um "Connected Service" x "Web Reference"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBuscarValor_Click(object sender, EventArgs e)
        {
            string codigoMoeda = "";

            // Pega a posição do caracter ( -) que separa o código da descrição da moeda
            //int posTraco = CmbMoeda.Text.LastIndexOf(" –");
            int posTraco = Convert.ToInt32(CmbMoeda.SelectedValue);

            //Caso a posição for maior que -1, atribui o valor a variável codigoMoeda
            if (posTraco > -1)
            {
                //codigoMoeda = CmbMoeda.Text.Substring(0, posTraco);
                codigoMoeda = posTraco.ToString();

                try
                {
                    /* 
                     * Trecho original do vídeo "Como usar o Web Service do Banco Central para pegar a cotação do dólar, euro, entre outras moedas"
                     * https://www.youtube.com/watch?v=Df2RmBu_xgk
                     * --------------------------------------------
                    //Chama o webService para retornar o valor
                    wsCotacao.FachadaWSSGSClient ws = new wsCotacao.FachadaWSSGSClient();

                    //Através do código da moeda, atribui a variável valorCotação o resultado da busca
                    string valorCotacao = ws.getUltimosValoresSerieVO(Convert.ToInt32(codigoMoeda), 1).valores[0].svalor;

                    // Mostrar no LblValor o resultado
                    LblValor.Text = "R$" + valorCotacao;
                     *--------------------------------------------
                    */

                    if (rdoConnectedServices.Checked)
                    {
                        //Substituindo para uma classe usando o Connected Services.
                        //ATENÇÃO! É PRECISO MANTER O CONNECT SERVICE "wsCotacao" AQUI TAMBÉM!
                        LblValor.Text = ClsCotarMoedaBLL.ClsCotarMoeda.RetornarMoedaCS(Convert.ToInt32(codigoMoeda));
                    }
                    else if(rdoWebReferences.Checked)
                    {
                        //Substituindo para uma classe usando o Web References
                        LblValor.Text = ClsCotarMoedaBLL.ClsCotarMoeda.RetornarMoedaWR(Convert.ToInt32(codigoMoeda));
                    }
                    else
                    {
                        LblValor.Text = "R$ 0,00";
                    }

                }
                catch (Exception ex)
                {
                    //Caso aconteça alguma excessão, mostra o valor zerado
                    LblValor.Text = "R$ 0,00";
                    MessageBox.Show("ERRO: " + ex.Message);
                }
            }
        }
    }
}