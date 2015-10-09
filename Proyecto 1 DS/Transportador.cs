
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS{

    public class Transportador {

        private List<string> datos;

        private string operacion;

        public Transportador(List<string> inDatos, string inOperacion) 
        {
            datos = inDatos;
            operacion = inOperacion;
        }


        public Transportador(List<string> inDatos) :this(inDatos,"")
        {}

        public List<string> getDatos() 
        {
            return datos;
        }

        public string getOperacion()
        {
            return operacion;
        }
    }
}