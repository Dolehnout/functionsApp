using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionsApp.functions
{
    //public: indica que es un alcase de acceso público | static permite utilizar los métodos de esta clase sin necesidad de crear una instancia de la misma 
    public static class miscellaneous
    {
        //cree la función que devuelve una tabla de multiplicar
       /// <summary>
       /// Calcula o devuleve una tabla de multiplicar
       /// </summary>
       /// <param name="tabla"></param>
       /// <returns></returns>
        public static string tablaMultiplicar (int tabla)
        {
            string aux = "";
            for (int k = 0; k<=20; k++)
            {
                aux += $"{tabla} x {k} = {tabla*k}" + Environment.NewLine;

            }
            return aux;
        }
        public static bool validaUsuario(string usuario, string contraseña)
        {
            return ((usuario == "admin" && contraseña == "pucese") ? true : false);
        }
    }
}
