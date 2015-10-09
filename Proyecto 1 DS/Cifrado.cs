
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Clase abstracta en la  que se declaran las funciones que heredaran las subclases.
 */
namespace Proyecto_1_DS
{
    public abstract class Cifrado
    {

        /**
         * Clase abstracta en la  que se declaran las funciones que heredaran las subclases.
         */
        public Cifrado()
        {
        }

        /**
         * Metodo declarado que permitira cifrar texto.
         * @return
         */
        public abstract Transportador codificar();

        /**
         * Metodo declarado que permitira decifrar texto.
         * @return
         */
        public abstract Transportador decodificar();

    }
}