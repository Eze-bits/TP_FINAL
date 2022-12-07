using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Entidades;

namespace Mapper
{
    public class PlanillaMP
    {
        public void Guardar_planilla(Planilla_produccion pl)
        {
            XmlDocument xmlplanilla = new XmlDocument();
            xmlplanilla.Load("IADA_BD.xml");

            XmlNodeList xmlista = xmlplanilla.SelectNodes("BD");

            foreach (XmlNode n in xmlista)
            {
                XmlElement planilla = xmlplanilla.CreateElement("Planilla");
                XmlElement fecha = xmlplanilla.CreateElement("Fecha_de_produccion");
                XmlElement nrolote = xmlplanilla.CreateElement("Nro_lote");
                nrolote.InnerText = Convert.ToString(pl.Nro_lote);
                fecha.InnerText = pl.Fecha_de_produccion.ToShortDateString();
                planilla.AppendChild(fecha);
                planilla.AppendChild(nrolote);
                foreach (Panificados p in pl.retorna_panificados())
                {
                    if (p != null)
                    {
                        XmlElement detalle = xmlplanilla.CreateElement("Detalle_producto");
                        XmlElement peso = xmlplanilla.CreateElement("Peso");
                        XmlElement id = xmlplanilla.CreateElement("ID_producto");
                        XmlElement unidades = xmlplanilla.CreateElement("Unidades");
                        XmlElement desc = xmlplanilla.CreateElement("Descripcion");

                        desc.InnerText = p.Descripcion;
                        id.InnerText = p.ID_producto;
                        peso.InnerText = Convert.ToString(p.Peso);
                        unidades.InnerText = Convert.ToString(p.Unidades);
                        detalle.AppendChild(id);
                        detalle.AppendChild(peso);
                        detalle.AppendChild(desc);
                        detalle.AppendChild(unidades);
                        planilla.AppendChild(detalle);
                    }
                }
                n.AppendChild(planilla);
                break;
            }
            xmlplanilla.Save("IADA_BD.xml");
        }

        public bool Checkear_planilla()
        {
            bool check = false;
            XmlDocument xmlplanilla = new XmlDocument();
            xmlplanilla.Load("IADA_BD.xml");
            XmlNodeList xmlista = xmlplanilla.SelectNodes("BD/Planilla");
            foreach (XmlNode n in xmlista)
            {
                if (n.SelectSingleNode("Fecha_de_produccion").InnerText == DateTime.Now.ToShortDateString())
                {
                    check = true;
                    break;
                }
            }

            return check;
        }

        public Planilla_produccion Retorna_planilla()
        {
            Lote L = new Lote();
            Planilla_produccion pr=new Planilla_produccion();
            XmlDocument xmlplanilla = new XmlDocument();
            xmlplanilla.Load("IADA_BD.xml");
            XmlNodeList xmlista = xmlplanilla.SelectNodes("BD/Planilla");

            foreach(XmlNode nod in xmlista)
            {
                if(nod.SelectSingleNode("Fecha_de_produccion").InnerText == DateTime.Now.ToShortDateString())
                {
                    foreach(XmlNode n in nod.SelectNodes("Detalle_producto"))
                    {

                        switch (n.SelectSingleNode("ID_producto").InnerText)
                        {
                            case "PHC":
                                break;

                        }



                    }


                    break;
                }



            }










            return pr;
        }


    }
}
