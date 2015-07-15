using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsolApp
{
    public class Foo
    {
        private int dummyCont = 0;


        public int GetDummyCont()
        {
            return this.dummyCont;
        }

        public void SetDummyCont(int valor)
        {
            this.dummyCont = valor;
        }

    }
}
