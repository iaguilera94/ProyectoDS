
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Clase que permite crear objetos de tipo TraposicionletraAletra
 */
namespace Proyecto_1_DS
{
    public class FabricaLetraALetra : FabricaCifrado
    {

        /**
         * Clase que permite crear objetos de tipo TraposicionletraAletra
         */
        public FabricaLetraALetra()
        {
        }

        /**
         * @param inDTO 
         * @return
         */
        public Cifrado fabricarCifrado(Transportador inDTO)
        {
            // TODO implement here
            return new Transposicion();
        }

    }
}