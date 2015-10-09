
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public class FabricaXML : FabricaDocumento
    {

        /**
         * 
         */
        public FabricaXML()
        {
        }

        /**
         * @param inDTO 
         * @return
         */
        public Documento fabricarDocumento()
        {
            return new XML();
        }

    }
}