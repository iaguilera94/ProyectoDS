
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public interface IFabricaDocumento
    {

        /**
         * @param inDTO 
         * @return
         */
        public Documento crearDocumento(Transportador inDTO);

    }
}