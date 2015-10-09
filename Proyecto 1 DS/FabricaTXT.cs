
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public class FabricaTXT : FabricaDocumento
    {

        /**
         * 
         */
        public FabricaTXT()
        {
        }

        /**
         * @param inDTO 
         * @return
         */
        public Documento fabricarDocumento()
        {
            // TODO implement here
            return new TXT();
        }

    }
}