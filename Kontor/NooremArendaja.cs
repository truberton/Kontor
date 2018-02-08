using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class NooremArendaja : Arendaja
    {
        public NooremArendaja()
        {
            PeaUks_Access = true;
            ArendajateRuum_Access = true;
            ÜlemusteRuum_Access = false;
            Köök_Access = true;
            AndmetöötlejateRuum_Access = false;
        }
    }
}
