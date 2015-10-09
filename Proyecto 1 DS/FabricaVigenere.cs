
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Clase que permite crear objetos de tipo SustitucionVigenere
 */
namespace Proyecto_1_DS
{
    public class FabricaVigenere : FabricaCifrado
    {

        /**
         * Clase que permite crear objetos de tipo SustitucionVigenere
         */
        public FabricaVigenere()
        {
        }

        /**
         * @param inDTO 
         * @return
         */
        public Cifrado fabricarCifrado(Transportador inDTO)
        {
            // TODO implement here
            return new Vigenere();
        }

    }
}