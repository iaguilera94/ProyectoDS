
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS{
    public class Binaria : Cifrado {

        /**
         * 
         */
        public Binaria() {}

        /**
         * @param inTexto 
         * @return
         */
        private string codificar_Binaria(string inTexto) {
            // TODO implement here
            return "";
        }

        /**
         * @param inTexto 
         * @return
         */
        private string decodificar_Binaria(string inTexto) {
            // TODO implement here
            return "";
        }

        /**
         * @param inDTO 
         * @return
         */
        public Transportador codificar(Transportador inDTO) {
            return codificar_Binaria(inDTO.getDatos); //IMPORTATE Arreglar
        }

        /**
         * @param inDTO 
         * @return
         */
        public Transportador decodificar(Transportador inDTO) {
            // TODO implement here
            return null;
        }

    }
}