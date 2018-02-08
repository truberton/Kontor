using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class VanemArendaja : Arendaja
    {
        public VanemArendaja()
        {
            PeaUks_Access = true;
            ArendajateRuum_Access = true;
            ÜlemusteRuum_Access = true;
            Köök_Access = true;
            AndmetöötlejateRuum_Access = true;
        }
    }
}
