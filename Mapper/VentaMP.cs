using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Linq;


namespace Mapper
{
    public class VentaMP
    {
        public void Agregar_venta(Venta Ve)
        {


            XDocument xmlventas = XDocument.Load("IADA_BD.xml");

            xmlventas.Element("BD").Add(new XElement("Venta",

                  new XElement("Fecha", Ve.Fecha_venta.ToShortDateString()),
                  new XElement("Nro_pedido", Ve.pr.Nro_pedido),
                  new XElement("DNI", Ve.pr.Obtener_DNI()),
                  new XElement("Importe_total", Ve.Importe_total.ToString())));

            var items = xmlventas.Descendants("Venta")
                  .Where(item => item.Element("Nro_pedido").Value == Convert.ToString(Ve.pr.Nro_pedido));


            foreach (Panificados P in Ve.pr.retorna_lista_panificados())
            {
                foreach (var n in items)
                {
                    n.Add(new XElement("Detalle_producto", new XElement("Nro_lote", P.Nro_lote),
                        new XElement("Unidades", P.Unidades), new XElement("Peso", P.Peso),
                        new XElement("Precio", P.Leer_precio().ToString())
                        ));
                }
            }



            xmlventas.Save("IADA_BD.xml");
        }

        public void graficar_x_dia()
        {
           // decimal[] lista=new ;
            XmlDocument xmlventas = new XmlDocument();
            xmlventas.Load("IADA_BD.xml");
            XmlNodeList lista_pedidos = xmlventas.SelectNodes("BD/Venta");



        }


    }
}
