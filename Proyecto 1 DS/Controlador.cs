
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

/**
 * 
 */
namespace Proyecto_1_DS
{
    public class Controlador : IControlador
    {
       
        private IFabricaCifrado miFabricaC;

        private IFabricaDocumento miFabricaD;


        /*
         * Metodo que gestiona la creacion de cifrados
         */
        public Transportador elegirCifrado(Transportador inDTO)
        {
            ObjectHandle ManipularObjeto;

            String operacion = inDTO.getOperacion();

            String CadenaObjeto = "Proyecto_1_DS.Fabrica" + operacion;

            Assembly ensamblar = Assembly.GetExecutingAssembly();
            ManipularObjeto = AppDomain.CurrentDomain.CreateInstance(ensamblar.FullName, CadenaObjeto);
            FabricaCifrado miFabricaC = (FabricaCifrado)ManipularObjeto.Unwrap();

            Cifrado ob = miFabricaC.fabricarCifrado(inDTO);
            Transportador resultado = ob.codificar();
            return resultado;
        }

        /*
         * Metodo que gestiona la creacion de documentos
         */
        public void elegirDocumento(Transportador inDTO)
        {
            ObjectHandle ManipularObjeto;

            String operacion = inDTO.getOperacion();

            String CadenaObjeto = "Proyecto_1_DS.Fabrica" + operacion;

            Assembly ensamblar = Assembly.GetExecutingAssembly();
            ManipularObjeto = AppDomain.CurrentDomain.CreateInstance(ensamblar.FullName, CadenaObjeto);
            FabricaDocumento miFabricaD = (FabricaDocumento)ManipularObjeto.Unwrap();

            Documento ob = miFabricaD.fabricarDocumento();
            ob.crearDocumento();
        }

    }
}