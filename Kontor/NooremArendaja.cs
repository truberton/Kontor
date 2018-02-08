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
