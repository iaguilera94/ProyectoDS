
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Clase que permite crear objetos de tipo CodificacionBinaria
 */
namespace Proyecto_1_DS
{
    public class FabricaBinaria : FabricaCifrado
    {

        /**
         * Clase que permite crear objetos de tipo CodificacionBinaria
         */
        public FabricaBinaria()
        {
        }

        /**
         * @param inDTO 
         * @return
         */
        public Cifrado fabricarCifrado(Transportador inDTO)
        {
            // TODO implement here
            return new Binaria();
        }

    }
}