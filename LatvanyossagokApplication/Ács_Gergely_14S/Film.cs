using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLApp
{
    class Film
    {
        int id;
        string cim;
        DateTime kiadas;
        int hossz;
        string rendezo_id;

        public Film(int id, string cim, DateTime kiadas, int hossz, string rendezo_id)
        {
            this.id = id;
            this.cim = cim;
            this.kiadas = kiadas;
            this.hossz = hossz;
            this.rendezo_id = rendezo_id;
        }

        public int Id { get => id; }
        public string Cim { get => cim; set => cim = value; }
        public DateTime Kiadas { get => kiadas; set => kiadas = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public string Rendezo_id { get => rendezo_id; set => rendezo_id = value; }
    }
}
