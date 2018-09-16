using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Banco
{
    public class CuentaBancaria
    {
        int Saldo = 0;
        public int getSaldo()
        {
            return Saldo;
        }

        public void Consignacion(int iconsignacón)
        {
            Saldo = iconsignacón;

        }
    }
}
