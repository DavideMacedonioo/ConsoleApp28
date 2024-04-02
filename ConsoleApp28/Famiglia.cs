using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Famiglia
    {
        
        public string cognome { get; set; }
        public List <Persona> persone { get; set; }
        public float EtaMedia()
        {
            int SommaEta = 0;
            foreach (Persona persona in persone)
            {
                SommaEta += persona.eta;
            }
            float etaMedia = SommaEta / persone.Count;
            return etaMedia;
        }

    }

}

