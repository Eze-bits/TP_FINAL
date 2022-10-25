using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Linq;

namespace Mapper_DAL
{
    public class PedidoMP
    {
        private void Crear_archivo_pedido()
        {

            XmlTextWriter Pedidostwr = new XmlTextWriter("Pedidos.xml", System.Text.Encoding.UTF8);
            Pedidostwr.Formatting = Formatting.Indented;
            Pedidostwr.Indentation = 2;
            Pedidostwr.WriteStartDocument(true);
            Pedidostwr.WriteStartElement("Pedidos");
            Pedidostwr.WriteEndElement();
            Pedidostwr.WriteEndDocument();
            Pedidostwr.Close();
        }

        public void grabar_pedido(Pedido P)
        {
            if (System.IO.File.Exists("Pedidos.xml") == false)
            { Crear_archivo_pedido(); }

            //XDocument xmlClientes = XDocument.Load("Pedidos.xml");

            //xmlClientes.Element("Pedidos").Add(new XElement("Pedido",

            //      new XElement("DNI_Cliente", P.DNI_cliente),

            //      new XElement("Nro_pedido", "1")));
                  

            //xmlClientes.Save("Pedidos.xml");











        }




    }
}