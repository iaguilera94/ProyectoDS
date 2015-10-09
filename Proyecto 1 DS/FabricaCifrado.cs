
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public abstract class FabricaCifrado : IFabricaCifrado
    {


        public FabricaCifrado(){}

        /**
         * @param inDTO 
         * @return
         */
        public abstract Cifrado fabricarCifrado(Transportador inDTO);

    }
}