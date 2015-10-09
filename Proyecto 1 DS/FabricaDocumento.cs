
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public abstract class FabricaDocumento : IFabricaDocumento
    {

        /**
         * 
         */
        public FabricaDocumento()
        {
        }

        /**
         * @param inDTO 
         * @return
         */
        public abstract Documento fabricarDocumento();

    }
}