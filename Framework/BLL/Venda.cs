using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using commom = Framework.Commom;

namespace Framework.BLL
{
    public class Venda
    {
        public void Vender()
        {
            var logger = new commom.Log(typeof(Venda));
            logger.Info("Fiz uma venda.");
        }
    }
}
