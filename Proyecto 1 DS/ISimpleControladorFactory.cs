
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public interface ISimpleControladorFactory
    {
        static public IControlador CrearControlador();
    }
}