using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using commom = Framework.Commom;
using business = Framework.BLL;

namespace AppTeste
{
    class Program
    {
        private static commom.Log logger = new commom.Log(typeof(Program));

        static void Main(string[] args)
        {
            logger.Info("Iniciando venda.");

            var vendaBusiness = new business.Venda();
            vendaBusiness.Vender();

            logger.Info("Finalizando venda.");
        }
    }
}
