
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public class FabricaPDF : FabricaDocumento
    {

        /**
         * 
         */
        public FabricaPDF(){}

        /**
         * @param inDTO 
         * @return
         */
        public Documento fabricarDocumento()
        {
            return new PDF();
        }

    }
}