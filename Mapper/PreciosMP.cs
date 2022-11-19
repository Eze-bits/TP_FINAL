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
    public class PreciosMP
    {
        public void Grabar_lista_precios(Lista_precios Pr)
        {
            XDocument xmlBD = XDocument.Load("IADA_BD.xml");


            xmlBD.Element("BD").Add(new XElement("Precios",
                                       new XElement("Fecha_de_actualizacion", Pr.Fecha_de_ultima_actualizacion),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PHC.ID_producto),
                                       new XElement("Precio", Pr.PHC.Leer_precio())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PHM.ID_producto),
                                       new XElement("Precio", Pr.PHM.Leer_precio())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PLC.ID_producto),
                                       new XElement("Precio", Pr.PLC.Leer_precio())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PLG.ID_producto),
                                       new XElement("Precio", Pr.PLG.Leer_precio())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PPC.ID_producto),
                                       new XElement("Precio", Pr.PPC.Leer_precio())),
                                       new XElement("Detalle_producto",
                                       new XElement("ID_producto", Pr.PPM.ID_producto),
                                       new XElement("Precio", Pr.PPM.Leer_precio()))));

            xmlBD.Save("IADA_BD.xml");

        }

        public bool Checkear_existencia_precios()
        {
            {

                XDocument xmlBD = XDocument.Load("IADA_BD.xml");
                var xDoc = XDocument.Load("IADA_BD.xml");
                int conteo = 0;
                conteo = xDoc.Descendants("Precios").Count();
                if (conteo == 1)
                { return true; }
                else
                { return false; }

            }
        }

        public void Modificar_lista_precios(Lista_precios Pr, bool mod)
        {

            if (mod == true)                          //true modifica lista, false nueva lista
            {
                XmlDocument xmlBD = new XmlDocument();
                xmlBD.Load("IADA_BD");

                XmlElement Precios = xmlBD.DocumentElement;
                XmlNodeList Lista_pedidos = xmlBD.SelectNodes("BD/Precios");

                foreach (XmlNode nodo in Lista_pedidos)
                {
                    {
                        Precios.RemoveChild(nodo);
                        xmlBD.Save("IADA_BD.xml");
                        break;
                    }
                }

                Grabar_lista_precios(Pr);


            }
            else { Grabar_lista_precios(Pr); }



        }




    }
}
