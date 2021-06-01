using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_uwp
{
   public class objetoEquipo: IComparable<objetoEquipo>
    {
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public int PJ { get; set; }
        public int PG { get; set; }
        public int PP { get; set; }
        public int GF { get; set; }
        public int GC { get; set; }
        public int PTS { get; set; }
        

        public objetoEquipo(string nombre, string provincia)
        {
            Nombre = nombre;
            Provincia = provincia;
            PJ = 0;
            PG = 0;
            PP = 0;
            GF = 0;
            GC = 0;
            PTS = 0;

        }

        public override string ToString()
        {
            return $"{Nombre}, {Provincia}";
        }

        public override bool Equals(object obj)
        {
            objetoEquipo equip = (objetoEquipo)obj;
            
                return this.Nombre == equip.Nombre;
            
        }
        public int CompareTo(objetoEquipo other)
        {
            if(this.PTS != other.PTS)
            {
                return this.PTS.CompareTo(other.PTS);
            }
            else
            {
                int item = this.GF - this.GF;
                int item2 = other.GF - other.GC;

                return item.CompareTo(item2);

            }
        }
    }
}
