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

        public void grabar_pedido(Pedido Ped)
        {
            if (System.IO.File.Exists("Pedidos.xml") == false)
            { Crear_archivo_pedido(); }

            XDocument xmlPedidos = XDocument.Load("Pedidos.xml");

            int nropedido = (xmlPedidos.Descendants().Count()) + 1;

            xmlPedidos.Element("Pedidos").Add(new XElement("Pedido",

                  new XElement("DNI_Cliente", Ped.DNI_cliente),

                new XElement("Nro_pedido", "nropedido"),
                new XElement("Estado", Ped.Estado)))
               
                ;

            var consulta = xmlPedidos.Elements("PEDIDO").Where(n => n.Element("Nro_pedido").Value == Convert.ToString(Ped.Nro_pedido));
            



            foreach (Panificados P in Ped.retorna_lista_panificados()) {
               
                consulta.Append(new XElement("PRODUCTO",
                new XElement("Nro_lote", P.Nro_lote),
                new XElement("Unidades", P.Unidades),
                new XElement("Peso", P.Peso)))


                ;

            }


           











        }




    }
}