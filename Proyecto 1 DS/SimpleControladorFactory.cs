
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public class SimpleControladorFactory : ISimpleControladorFactory
    {

        static public IControlador CrearControlador()
        {

            return new Controlador();
        }

    }
}