using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSnake
{
    class objet
    {
        private int High, Long;
        protected int x,y,ancho;

    
            public objet()
            {
                ancho=10;
            }
        public Boolean interseccion(objet o)
            {
                int difx = Math.Abs(this.x - o.x);
                int dify = Math.Abs(this.y - o.y);
                if (difx>=0&&difx<ancho&&dify>=0&&dify<ancho)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
    }
}
