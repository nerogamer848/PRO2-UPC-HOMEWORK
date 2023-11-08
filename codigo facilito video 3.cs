using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System. Threading.Tasks;

namespace Codigo Facilito
{
    class Program{
        static void Main(string[] args){
            int i =0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d =0.0D;
            string cadena = "hello world";
            bool bandera =false;
            DateTime fecha = Dateline.MinValue;
            console.Writeline("El valor de i es: {0}", i);
            console.WriteLine("El valor de x es : {0:C}",x);
            console.WriteLine("El valor de f es : {0:F2}",f)
            console.WriteLine("el valor de d es : {0:F2}", d)
            console.WriteLine("El valor de cadena es : "+ cadena);
            console.WriteLine("El valor de bandera es : " + bandera.ToString());
            console.WriteLine("El valor de fecha es : " + fecha.ToShortDateString());
            console.ReadKey();
        }
    }
}