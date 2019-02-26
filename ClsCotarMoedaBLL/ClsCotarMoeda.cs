using System.Collections.Generic;
using clsCotarMoedaDomain;

/* MOEDAS
1 – Dólar(venda)
10813 – Dólar(compra)
21619 – Euro(venda)
21620 – Euro(compra)
21621 – Iene(venda)
21622 – Iene(compra)
21623 – Libra esterlina(venda)
21624 – Libra esterlina(compra)
21625 – Franco Suíço(venda)
21626 – Franco Suíço(compra)
21627 – Coroa Dinamarquesa(venda)
21628 – Coroa Dinamarquesa(compra)
21629 – Coroa Norueguesa(venda)
21630 – Coroa Norueguesa(compra)
21631 – Coroa Sueca(venda)
21632 – Coroa Sueca(compra)
21633 – Dólar Australiano(venda)
21634 – Dólar Australiano(compra)
21635 – Dólar Canadense(venda)
21636 – Dólar Canadense(compra)
*/

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
namespace ClsCotarMoedaBLL
{
    public class ClsCotarMoeda
    {
        /// <summary>
        /// Preenche a Combo Moeda
        /// </summary>
        /// <returns>Retorna uma Lista de Moedas</returns>
        public static List<ClsMoeda> PreencherComboMoeda()
        {
            List<ClsMoeda> LstMoeda = new List<ClsMoeda>();

            LstMoeda = ClsMoedaArray.Moedas();

            return LstMoeda;
        }

        /// <summary>
        ///  Chama o CONNECTED SERVICES para retornar o valor
        /// </summary>
        /// <param name="Moeda">Código da Moeda</param>
        /// <returns>Retorna String de Valor Atualizado</returns>
        public static string RetornarMoedaCS(int Moeda)
        {
            //Chama o webService para retornar o valor
            wsCotacao.FachadaWSSGSClient ws = new wsCotacao.FachadaWSSGSClient();

            //Através do código da moeda, atribui a variável valorCotação o resultado da busca
            string valorCotacao = ws.getUltimosValoresSerieVO(Moeda, 1).valores[0].svalor;

            // Retorna o resultado
            return "R$ " + valorCotacao;
        }

        /// <summary>
        /// Chama o WEB REFERENCES para retornar o valor
        /// </summary>
        /// <param name="Moeda">Código da Moeda</param>
        /// <returns>Retorna String de Valor Atualizado</returns>
        public static string RetornarMoedaWR(int Moeda)
        {
            br.gov.bcb.www3.FachadaWSSGSService ws = new br.gov.bcb.www3.FachadaWSSGSService();

            //Através do código da moeda, atribui a variável valorCotação o resultado da busca
            string valorCotacao = ws.getUltimosValoresSerieVO(Moeda, 1).valores[0].svalor;

            // Retorna o resultado
            return "R$ " + valorCotacao;
        }
    }
}
