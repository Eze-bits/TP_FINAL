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
    public class LoteMP
    {

        public void Crear_lote(Lote L)
        {
            if (System.IO.File.Exists("Lotes.xml") == false)

            {
                XmlTextWriter Lotestwr = new XmlTextWriter("Lotes.xml", System.Text.Encoding.UTF8);
                Lotestwr.Formatting = Formatting.Indented;
                Lotestwr.Indentation = 2;
                Lotestwr.WriteStartDocument(true);
                Lotestwr.WriteStartElement("Lotes");
                Lotestwr.WriteEndElement();
                Lotestwr.WriteEndDocument();
                Lotestwr.Close();
            }

            XDocument xmlLotes = XDocument.Load("Lotes.xml");

            xmlLotes.Element("Lotes").Add(new XElement("Lote",
                                  new XElement("Nro_lote", L.Nro_lote),
                  new XElement("Fecha_de_vencimiento", (L.Fecha_de_vencimiento).ToShortDateString())));
            xmlLotes.Save("Lotes.xml");
            agregar_prod(L);
        }

        public bool Checkear_lotes()                    //checkea si hay lotes en la base
        {                                               //false si no hay lotes o true si existen    
            if (System.IO.File.Exists("Lotes.xml") == false)
            { return false; }

            else                                         //  existe el archivo
            {

                XDocument xmlLotes = XDocument.Load("Lotes.xml");
                var xDoc = XDocument.Load("Lotes.xml");
                int conteo = 0;
                conteo = xDoc.Descendants("Lote").Count();
                if (conteo > 0)
                { return true; }
                else
                { return false; }

            }

        }

        public List<Lote> Listado_de_lotes()          /// retorno una lista con todos los lotes de la BD
        {

            var query =

                        from Lote in XElement.Load("Lotes.xml").Elements("Lote")

                        select new Lote
                        {
                            Nro_lote = Convert.ToInt32((Lote.Element("Nro_lote").Value)),
                            Fecha_de_vencimiento = Convert.ToDateTime(Lote.Element("Fecha_de_vencimiento").Value)
                        };


            List<Lote> Lista_lotes = query.ToList<Lote>();

            return Lista_lotes;
        }


        public void Detalle_de_lote(Lote L)         /// bajo de la BD el detalle al objeto lote 
        {

            var consulta_phc =

            from HAMBURGUESAS in XElement.Load("Stock.xml").Elements("HAMBURGUESAS")

            where Convert.ToInt32(HAMBURGUESAS.Element("Peso").Value) == 200 & Convert.ToInt32(HAMBURGUESAS.Element("Nro_lote").Value) == L.Nro_lote

            select new Pan_hamburguesa_comun
            {
                Nro_lote = Convert.ToInt32((HAMBURGUESAS.Element("Nro_lote").Value)),
                Unidades = Convert.ToInt32((HAMBURGUESAS.Element("Unidades").Value))

            };

            if (consulta_phc.Count() == 1)
            { L.agregar_a_lote(consulta_phc.ElementAt(0)); }

            var consulta_phm =

           from HAMBURGUESAS in XElement.Load("Stock.xml").Elements("HAMBURGUESAS")

           where Convert.ToInt32(HAMBURGUESAS.Element("Peso").Value) == 320 & Convert.ToInt32(HAMBURGUESAS.Element("Nro_lote").Value) == L.Nro_lote

           select new Pan_hamburguesa_maxi
           {
               Nro_lote = Convert.ToInt32((HAMBURGUESAS.Element("Nro_lote").Value)),
               Unidades = Convert.ToInt32((HAMBURGUESAS.Element("Unidades").Value))

           };

            if (consulta_phm.Count() == 1)
            { L.agregar_a_lote(consulta_phm.ElementAt(0)); }

            var consulta_plc =

           from LACTAL in XElement.Load("Stock.xml").Elements("LACTAL")

           where Convert.ToInt32(LACTAL.Element("Peso").Value) == 300 & Convert.ToInt32(LACTAL.Element("Nro_lote").Value) == L.Nro_lote

           select new Pan_lactal_chico
           {
               Nro_lote = Convert.ToInt32((LACTAL.Element("Nro_lote").Value)),
               Unidades = Convert.ToInt32((LACTAL.Element("Unidades").Value))
           };

            if (consulta_plc.Count() == 1)
            { L.agregar_a_lote(consulta_plc.ElementAt(0)); }

            var consulta_plg =

           from LACTAL in XElement.Load("Stock.xml").Elements("LACTAL")

           where Convert.ToInt32(LACTAL.Element("Peso").Value) == 600 & Convert.ToInt32(LACTAL.Element("Nro_lote").Value) == L.Nro_lote

           select new Pan_lactal_grande
           {
               Nro_lote = Convert.ToInt32((LACTAL.Element("Nro_lote").Value)),
               Unidades = Convert.ToInt32((LACTAL.Element("Unidades").Value))
           };

            if (consulta_plg.Count() == 1)
            { L.agregar_a_lote(consulta_plg.ElementAt(0)); }

            var consulta_ppc =

                 from PANCHOS in XElement.Load("Stock.xml").Elements("PANCHOS")

                 where Convert.ToInt32(PANCHOS.Element("Peso").Value) == 230 & Convert.ToInt32(PANCHOS.Element("Nro_lote").Value) == L.Nro_lote

                 select new Pan_pancho_chico
                 {
                     Nro_lote = Convert.ToInt32((PANCHOS.Element("Nro_lote").Value)),
                     Unidades = Convert.ToInt32((PANCHOS.Element("Unidades").Value))
                 };

            if (consulta_ppc.Count() == 1)
            { L.agregar_a_lote(consulta_ppc.ElementAt(0)); }

            var consulta_ppm =

               from PANCHOS in XElement.Load("Stock.xml").Elements("PANCHOS")

               where Convert.ToInt32(PANCHOS.Element("Peso").Value) == 350 & Convert.ToInt32(PANCHOS.Element("Nro_lote").Value) == L.Nro_lote

               select new Pan_pancho_maxi
               {
                   Nro_lote = Convert.ToInt32((PANCHOS.Element("Nro_lote").Value)),
                   Unidades = Convert.ToInt32((PANCHOS.Element("Unidades").Value))
               };

            if (consulta_ppm.Count() == 1)
            { L.agregar_a_lote(consulta_ppm.ElementAt(0)); }

        }

        public void agregar_a_lote_stock(List<Panificados> lista_panificados)
        {                                                            ///agrega productos a la bd de lote que no fueron cargados
            XDocument xmlStock = XDocument.Load("Stock.xml");        ///al crear el lote                                                                                                                 

            foreach (Panificados p in lista_panificados)
            {

                switch (p.Peso)
                {
                    case 200:
                        xmlStock.Element("Stock").Add(new XElement("HAMBURGUESAS",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("Stock.xml");

                        break;

                    case 320:
                        xmlStock.Element("Stock").Add(new XElement("HAMBURGUESAS",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("Stock.xml");
                        break;

                    case 300:
                        xmlStock.Element("Stock").Add(new XElement("LACTAL",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("Stock.xml");
                        break;

                    case 600:
                        xmlStock.Element("Stock").Add(new XElement("LACTAL",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("Stock.xml");
                        break;

                    case 230:
                        xmlStock.Element("Stock").Add(new XElement("PANCHOS",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("Stock.xml");
                        break;

                    case 350:
                        xmlStock.Element("Stock").Add(new XElement("PANCHOS",
                        new XElement("Nro_lote", p.Nro_lote),
                        new XElement("Unidades", p.Unidades),
                        new XElement("Peso", p.Peso)));
                        xmlStock.Save("Stock.xml");
                        break;

                }
            }

        }

        public void Borrar_de_lote(Panificados p)
        {
            XElement x = XElement.Load("Stock.xml");

            switch (p.Peso)
            {

                case 200:
                    var consulta = x.Elements("HAMBURGUESAS").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta.Remove();

                    break;

                case 320:
                    var consulta2 = x.Elements("HAMBURGUESAS").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta2.Remove();
                    break;

                case 300:
                    var consulta3 = x.Elements("LACTAL").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta3.Remove();
                    break;
                case 600:
                    var consulta4 = x.Elements("LACTAL").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta4.Remove();
                    break;
                case 230:
                    var consulta5 = x.Elements("PANCHOS").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta5.Remove();
                    break;

                case 350:
                    var consulta6 = x.Elements("PANCHOS").Where(n => n.Element("Nro_lote").Value == Convert.ToString(p.Nro_lote) & n.Element("Peso").Value == Convert.ToString(p.Peso));
                    consulta6.Remove();
                    break;
            }

            x.Save("Stock.xml");

        }

        public bool Lote_del_dia(Lote L)       //retorna true si ya existe lote del dia sino false
        {

            if (System.IO.File.Exists("Lotes.xml") == false)
            { return false; }
            else
            {
                XElement xmlLote = XElement.Load("Lotes.xml");
                var consulta = xmlLote.Elements("Lote").Where(n => n.Element("Nro_lote").Value == Convert.ToString(L.Nro_lote));
                if (consulta.Count() == 1)
                { return true; }
                else
                { return false; }
            }


        }

        private void Crear_archivo_stock()
        {
            XmlTextWriter stockhtwr = new XmlTextWriter("Stock.xml", System.Text.Encoding.UTF8);
            stockhtwr.Formatting = Formatting.Indented;
            stockhtwr.Indentation = 2;
            stockhtwr.WriteStartDocument(true);
            stockhtwr.WriteStartElement("Stock");
            stockhtwr.WriteEndElement();
            stockhtwr.WriteEndDocument();
            stockhtwr.Close();
        }









        public void agregar_prod(Lote L)
        {
            if (System.IO.File.Exists("Stock.xml") == false)

            {
                Crear_archivo_stock();
            }

            if (L.retorna_Phc() != null)
            {
                XDocument xmlHamburguesas = XDocument.Load("Stock.xml");

                xmlHamburguesas.Element("Stock").Add(new XElement("HAMBURGUESAS",
                                      new XElement("Nro_lote", L.Nro_lote),
                      new XElement("Unidades", L.retorna_Phc().Unidades),
                      new XElement("Peso", L.retorna_Phc().Peso)));
                xmlHamburguesas.Save("Stock.xml");

            }

            if (L.retorna_Pmm() != null)
            {
                XDocument xmlHamburguesas = XDocument.Load("Stock.xml");
                xmlHamburguesas.Element("Stock").Add(new XElement("HAMBURGUESAS",
                      new XElement("Nro_lote", L.Nro_lote),
                new XElement("Unidades", L.retorna_Pmm().Unidades),
                new XElement("Peso", L.retorna_Pmm().Peso)));
                xmlHamburguesas.Save("Stock.xml");

            }

            if (L.retorna_Plc() != null)
            {
                XDocument xmlLactal = XDocument.Load("Stock.xml");
                xmlLactal.Element("Stock").Add(new XElement("LACTAL",
                         new XElement("Nro_lote", L.Nro_lote),
         new XElement("Unidades", L.retorna_Plc().Unidades),
         new XElement("Peso", L.retorna_Plc().Peso)));
                xmlLactal.Save("Stock.xml");
            }

            if (L.retorna_Plg() != null)
            {

                XDocument xmlLactal = XDocument.Load("Stock.xml");
                xmlLactal.Element("Stock").Add(new XElement("LACTAL",
                      new XElement("Nro_lote", L.Nro_lote),
      new XElement("Unidades", L.retorna_Plg().Unidades),
      new XElement("Peso", L.retorna_Plg().Peso)));
                xmlLactal.Save("Stock.xml");

            }

            if (L.retorna_Ppc() != null)
            {
                XDocument xmlPanchos = XDocument.Load("Stock.xml");
                xmlPanchos.Element("Stock").Add(new XElement("PANCHOS",
                      new XElement("Nro_lote", L.Nro_lote),
      new XElement("Unidades", L.retorna_Ppc().Unidades),
      new XElement("Peso", L.retorna_Ppc().Peso)));
                xmlPanchos.Save("Stock.xml");
            }

            if (L.retorna_Ppm() != null)
            {
                XDocument xmlPanchos = XDocument.Load("Stock.xml");
                xmlPanchos.Element("Stock").Add(new XElement("PANCHOS",
                      new XElement("Nro_lote", L.Nro_lote),
      new XElement("Unidades", L.retorna_Ppm().Unidades),
      new XElement("Peso", L.retorna_Ppm().Peso)));
                xmlPanchos.Save("Stock.xml");

            }
        }

        public void modificar_stock(List<Panificados> lista_panificados)
        {


            foreach (Panificados p in lista_panificados)
            {
                XmlDocument archivo = new XmlDocument();
                archivo.Load("Stock.xml");

                XmlElement Stock = archivo.DocumentElement;



                if (p.Peso == 200 | p.Peso == 320)
                {

                    XmlNodeList lista_h = archivo.SelectNodes("Stock/HAMBURGUESAS");
                    foreach (XmlNode nodo in lista_h)
                    {
                        if (nodo.SelectSingleNode("Nro_lote").InnerText == Convert.ToString(p.Nro_lote) & nodo.SelectSingleNode("Peso").InnerText == Convert.ToString(p.Peso))
                        {
                            nodo.SelectSingleNode("Unidades").InnerText = Convert.ToString(p.Unidades);
                            archivo.Save("Stock.xml");
                            break;
                        }
                    }
                }

                else
                {
                    if (p.Peso == 300 | p.Peso == 600)
                    {
                        XmlNodeList lista_l = archivo.SelectNodes("Stock/LACTAL");
                        foreach (XmlNode nodo in lista_l)
                        {
                            if (nodo.SelectSingleNode("Nro_lote").InnerText == Convert.ToString(p.Nro_lote) & nodo.SelectSingleNode("Peso").InnerText == Convert.ToString(p.Peso))
                            {
                                nodo.SelectSingleNode("Unidades").InnerText = Convert.ToString(p.Unidades);
                                archivo.Save("Stock.xml");
                                break;
                            }
                        }
                    }
                    else
                    {
                        XmlNodeList lista_p = archivo.SelectNodes("Stock/PANCHOS");
                        foreach (XmlNode nodo in lista_p)
                        {
                            if (nodo.SelectSingleNode("Nro_lote").InnerText == Convert.ToString(p.Nro_lote) & nodo.SelectSingleNode("Peso").InnerText == Convert.ToString(p.Peso))
                            {
                                nodo.SelectSingleNode("Unidades").InnerText = Convert.ToString(p.Unidades);
                                archivo.Save("Stock.xml");
                                break;
                            }
                        }
                    }
                }
            }

        }






    }
}
