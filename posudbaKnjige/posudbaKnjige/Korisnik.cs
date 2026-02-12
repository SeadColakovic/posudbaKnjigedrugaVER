using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posudbaKnjige
{
    internal class Korisnik
    {
        public string txIme { get; set; }
        public string txPrezime { get; set; }
        public string txEmail { get; set; }
        public string txOIB { get; set; }
        public string txBrojTelefona { get; set; }
        public string txAdresa { get; set; }

        public Korisnik(string txIme, string txPrezime, string txEmail, string txOIB, string txBrojTelefona, string txAdresa) { 
        
            this.txIme = txIme;
            this.txPrezime = txPrezime;
            this.txEmail = txEmail;
            this.txOIB = txOIB;
            this.txBrojTelefona = txBrojTelefona;
            this.txAdresa = txAdresa;
        }
       
        }

    }

