using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_uwp
{
    public class objetoPartidos
    {
        public string Equipo1 { get; set; }
        public string Equipo2 { get; set; }

        public objetoPartidos(string equipo1, string equipo2)
        {
            Equipo1 = equipo1;
            Equipo2 = equipo2;
   

        }

        public override bool Equals(object obj)
        {
            objetoPartidos equip = (objetoPartidos)obj;

            return this.Equipo1 == equip.Equipo1 && this.Equipo2 == equip.Equipo2;

        }
    }

    
}
