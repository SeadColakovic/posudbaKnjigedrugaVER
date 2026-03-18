using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posudbaKnjige
{
    internal class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string OIB { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }

        public Korisnik(string Ime, string txPrezime, string txEmail, string txOIB, string txBrojTelefona, string txAdresa) { 
        
            this.Ime = Ime;
            this.Prezime = txPrezime;
            this.Email = txEmail;
            this.OIB = txOIB;
            this.BrojTelefona = txBrojTelefona;
            this.Adresa = txAdresa;
        }
       
        }

    }

