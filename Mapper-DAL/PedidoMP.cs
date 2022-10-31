﻿using System;
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

            int nropedido = (xmlPedidos.Descendants("Pedido").Count()) + 1;


            xmlPedidos.Element("Pedidos").Add(new XElement("Pedido",

                  new XElement("DNI_Cliente", Ped.Obtener_DNI()),

                new XElement("Nro_pedido", nropedido),
                new XElement("Estado", Ped.Estado)));



            var items = xmlPedidos.Descendants("Pedido")
                  .Where(item => item.Element("Nro_pedido").Value == Convert.ToString(nropedido));


            foreach (Panificados P in Ped.retorna_lista_panificados())
            {
                foreach (var n in items)
                {
                    n.Add(new XElement("PRODUCTO", new XElement("Nro_lote", P.Nro_lote),
                        new XElement("Unidades", P.Unidades), new XElement("Peso", P.Peso)));
                }
            }

            xmlPedidos.Save("Pedidos.xml");
        }

        public List<Pedido> Listar_pedidos_por_cliente(Cliente C)
        {
            XmlDocument xmlpedidos = new XmlDocument();
            xmlpedidos.Load("Pedidos.xml");
            List<Pedido> lista_pedidos_cliente = new List<Pedido>();
            XmlNodeList lista_pedidos = xmlpedidos.SelectNodes("Pedidos/Pedido");

            foreach (XmlNode nodo in lista_pedidos)
            {
                if (nodo.SelectSingleNode("DNI_Cliente").InnerText == (Convert.ToString(C.DNI)))
                {
                    Pedido Ped = new Pedido();
                    Ped.Nro_pedido = Convert.ToInt32(nodo.SelectSingleNode("Nro_pedido").InnerText);
                    Ped.Grabar_DNI(Convert.ToInt32(nodo.SelectSingleNode("DNI_Cliente").InnerText));
                    Ped.Estado = nodo.SelectSingleNode("Estado").InnerText;


                    foreach (XmlNode nodoprod in nodo.SelectNodes("PRODUCTO"))
                    {

                        switch (nodoprod.SelectSingleNode("Peso").InnerText)
                        {
                            case "200":
                                Pan_hamburguesa_comun phc = new Pan_hamburguesa_comun();
                                phc.Nro_lote = Convert.ToInt32(nodoprod.SelectSingleNode("Nro_lote").InnerText);
                                phc.Unidades = Convert.ToInt32(nodoprod.SelectSingleNode("Unidades").InnerText);

                                Ped.agregar(phc);
                                break;

                            case "320":
                                Pan_hamburguesa_maxi phm = new Pan_hamburguesa_maxi();
                                phm.Nro_lote = Convert.ToInt32(nodoprod.SelectSingleNode("Nro_lote").InnerText);
                                phm.Unidades = Convert.ToInt32(nodoprod.SelectSingleNode("Unidades").InnerText);
                                Ped.agregar(phm);
                                break;

                            case "300":
                                Pan_lactal_chico plc = new Pan_lactal_chico();
                                plc.Nro_lote = Convert.ToInt32(nodoprod.SelectSingleNode("Nro_lote").InnerText);
                                plc.Unidades = Convert.ToInt32(nodoprod.SelectSingleNode("Unidades").InnerText);
                                Ped.agregar(plc);
                                break;

                            case "600":
                                Pan_lactal_grande plg = new Pan_lactal_grande();
                                plg.Nro_lote = Convert.ToInt32(nodoprod.SelectSingleNode("Nro_lote").InnerText);
                                plg.Unidades = Convert.ToInt32(nodoprod.SelectSingleNode("Unidades").InnerText);
                                Ped.agregar(plg);
                                break;

                            case "230":
                                Pan_pancho_chico ppc = new Pan_pancho_chico();
                                ppc.Nro_lote = Convert.ToInt32(nodoprod.SelectSingleNode("Nro_lote").InnerText);
                                ppc.Unidades = Convert.ToInt32(nodoprod.SelectSingleNode("Unidades").InnerText);
                                Ped.agregar(ppc);
                                break;

                            case "350":
                                Pan_pancho_maxi ppm = new Pan_pancho_maxi();
                                ppm.Nro_lote = Convert.ToInt32(nodoprod.SelectSingleNode("Nro_lote").InnerText);
                                ppm.Unidades = Convert.ToInt32(nodoprod.SelectSingleNode("Unidades").InnerText);
                                Ped.agregar(ppm);
                                break;
                        }
                    }
                    lista_pedidos_cliente.Add(Ped);
                }
            }
            return lista_pedidos_cliente;
         }

        public void Modificar_pedido(Pedido Pe) {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("Pedidos.xml");

            XmlElement Pedidos = archivo.DocumentElement;
            XmlNodeList Lista_pedidos = archivo.SelectNodes("Pedidos/Pedido");

            foreach (XmlNode nodo in Lista_pedidos)

            {
                if (nodo.SelectSingleNode("Nro_pedido").InnerText == Convert.ToString(Pe.Nro_pedido))
                {
                    Pedidos.RemoveChild(nodo);
                    archivo.Save("Pedidos.xml");
                    break;
                }
            }


            this.grabar_pedido(Pe);


        }




    }
}