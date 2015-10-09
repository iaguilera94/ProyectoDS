
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Clase que permite crear objetos de tipo  CodigoTelefonico
 */
namespace Proyecto_1_DS
{
    public class FabricaCodTeleefonico : FabricaCifrado
    {

        /**
         * Clase que permite crear objetos de tipo  CodigoTelefonico
         */
        public FabricaCodTeleefonico()
        {
        }

        /**
         * @param inDTO 
         * @return
         */
        public Cifrado fabricarCifrado(Transportador inDTO)
        {
            // TODO implement here
            return new CodigoTelefonico();
        }

    }
}