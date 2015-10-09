
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Clase que permite crear objetos de tipo PalabraClave
 */
namespace Proyecto_1_DS
{
    public class FabricaPalabraClave : FabricaCifrado
    {

        /**
         * Clase que permite crear objetos de tipo PalabraClave
         */
        public FabricaPalabraClave()
        {
        }

        /**
         * @param inDTO 
         * @return
         */
        public Cifrado fabricarCifrado(Transportador inDTO)
        {
            // TODO implement here
            return new PalabraClave();
        }

    }
}