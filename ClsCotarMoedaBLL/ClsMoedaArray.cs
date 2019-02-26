using clsCotarMoedaDomain;
using System.Collections.Generic;

/// <summary>
/// How to populate a ComboBox in C# from data structure containing US States?
/// 
/// https://stackoverflow.com/questions/27339800/how-to-populate-a-combobox-in-c-sharp-from-data-structure-containing-us-states
/// </summary>
namespace ClsCotarMoedaBLL
{
    static class ClsMoedaArray
    {
        static readonly List<ClsMoeda> LstMoeda;

        static ClsMoedaArray()
        {
            LstMoeda = new List<ClsMoeda>(20)
            {
                new ClsMoeda(1, "1 - Dólar(venda)"),
                new ClsMoeda(10813, "10813 - Dólar(compra)"),
                new ClsMoeda(21619, "21619 - Euro(venda)"),
                new ClsMoeda(21620, "21620 - Euro(compra)"),
                new ClsMoeda(21621, "21621 - Iene(venda)"),
                new ClsMoeda(21622, "21622 - Iene(compra)"),
                new ClsMoeda(21623, "21623 - Libra esterlina(venda)"),
                new ClsMoeda(21624, "21624 - Libra esterlina(compra)"),
                new ClsMoeda(21625, "21625 - Franco Suíço(venda)"),
                new ClsMoeda(21626, "21626 - Franco Suíço(compra)"),
                new ClsMoeda(21627, "21627 - Coroa Dinamarquesa(venda)"),
                new ClsMoeda(21628, "21628 - Coroa Dinamarquesa(compra)"),
                new ClsMoeda(21629, "21629 - Coroa Norueguesa(venda)"),
                new ClsMoeda(21630, "21630 - Coroa Norueguesa(compra)"),
                new ClsMoeda(21631, "21631 - Coroa Sueca(venda)"),
                new ClsMoeda(21632, "21632 - Coroa Sueca(compra))"),
                new ClsMoeda(21633, "21633 - Dólar Australiano(venda)"),
                new ClsMoeda(21634, "21634 - Dólar Australiano(compra)"),
                new ClsMoeda(21635, "21635 - Dólar Canadense(venda)"),
                new ClsMoeda(21636, "21636 - Dólar Canadense(compra)")
            };
        }

        public static List<ClsMoeda> Moedas()
        {
            return LstMoeda;
        }
    }
}
