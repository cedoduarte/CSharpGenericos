using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class Generico<Tipo>
    {
        public void Imprime()
        {
            Console.WriteLine(Valor);
        }

        public Tipo Valor { get; set; }
    }
}
