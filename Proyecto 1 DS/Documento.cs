
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS{
    public abstract  class Documento {

        /**
         * 
         */
        public Documento() {
        }

        /**
         * @return
         */
        public abstract void crearDocumento();

        /**
         * @return
         */
        public abstract void abrirDocumento();

    }
}