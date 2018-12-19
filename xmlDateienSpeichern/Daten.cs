using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlDateienSpeichern
{
    public class Daten
    {
        private string prufnummer,prufautomat,materialnummer,fertigungsauftrag,datum,uhrzeit,status;

        public string PRUFNAME
        {
            get
            {
                return prufnummer;
            }
            set
            {
                prufnummer = value;
            }
        }

        public string PRUFAUTOMAT
        {
            get
            {
                return prufautomat;
            }
            set
            {
                prufautomat = value;
            }
        }



        public string MATARIALNUMMER
        {
            get
            {
                return materialnummer;
            }
            set
            {
                materialnummer = value;
            }

        }

        public string FERTIGUNGSAUFTRAG
        {
            get
            {
                return fertigungsauftrag;
            }
            set
            {
                fertigungsauftrag = value;
            }

        }

        public string DATUM
        {
            get
            {
                return datum;
            }
            set
            {
                datum = value;
            }

        }

        public string UHRZEIT
        {
            get
            {
                return uhrzeit;
            }
            set
            {
                uhrzeit = value;
            }

        }

        public string STATUS
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

    }


}
