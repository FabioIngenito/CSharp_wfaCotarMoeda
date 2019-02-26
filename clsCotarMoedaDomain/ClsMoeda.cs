/// <summary>
/// How to populate a ComboBox in C# from data structure containing US States?
/// 
/// https://stackoverflow.com/questions/27339800/how-to-populate-a-combobox-in-c-sharp-from-data-structure-containing-us-states
/// </summary>
namespace clsCotarMoedaDomain
{
    public class ClsMoeda
    {
        #region Construtores
        /// <summary>
        /// Use "ctor"
        /// </summary>
        public ClsMoeda(int intCodigo, string strNome)
        {
            _Codigo = intCodigo;
            _Nome = strNome;
        }
        #endregion

        #region Propriedades
        private int _Codigo;
        private string _Nome;
        #endregion

        #region Métodos

        /// <summary>
        /// Código da Moeda no Banco Central do Brasil.
        /// Use "propfull"
        /// </summary>
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        /// <summary>
        /// Nome da Moeda no Banco Central do Brasil.
        /// Use "propfull"
        /// </summary>
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        #endregion
    }
}
