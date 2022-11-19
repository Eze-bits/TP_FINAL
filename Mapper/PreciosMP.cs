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
        public void Crear_lista_precios(Lista_precios Pr)
        {
            XDocument xmlBD = XDocument.Load("IADA_BD.xml");

            xmlBD.Element("BD").Add(new XElement("Precios",
                                       new XElement("Pan_hamburguesa_comun",Pr.PHC ),
                      new XElement("Pan_hamburguesa_maxi",Pr.PHM )));
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


    }
}
