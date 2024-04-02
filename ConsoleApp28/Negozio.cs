using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Negozio
    {
        public List <Famiglia> famiglie { get; set; }
        public float CalcoloEtaMedia(Sport sport)
        {
            int SommaEta = 0;
            int NumPersone = 0;
            foreach(Famiglia famiglia in famiglie)
            {
                foreach(Persona persona in famiglia.persone)
                {
                    if (persona.sport == sport)
                    {
                        SommaEta += persona.eta;
                        NumPersone++;
                    }
                }
            }
            float EtaMedia = SommaEta / NumPersone;
            return EtaMedia;
        }


    }
}
