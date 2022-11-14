using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Servicios
{
    public class ComponenteMP
    {
        public void Crear_tabla_permisos()
        {
            XDocument xmlBD = XDocument.Load("IADA_BD.xml");

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "C1"),
                     new XElement("Descripcion", "Modificacion de clientes")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "L1"),
                     new XElement("Descripcion", "Crear lote nuevo")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "L2"),
                     new XElement("Descripcion", "Ver y modificar stock de lote")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "P1"),
                     new XElement("Descripcion", "Ver y modificar lista de precios")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "U1"),
                     new XElement("Descripcion", "Ver y modificar usuarios")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "R1"),
                     new XElement("Descripcion", "Reporte de ventas semanal")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                                 new XElement("ID_permiso", "F1"),
                     new XElement("Descripcion", "Facturar pedido")));

            xmlBD.Element("BD").Add(new XElement("Permiso_detalle",
                            new XElement("ID_permiso", "A1"),
                new XElement("Descripcion", "Modificar permisos")));

            xmlBD.Save("IADA_BD.xml");

        }

        public List<Permiso> Cargar_permisos()
        {

            {
                var query =

                       from Permiso_detalle in XElement.Load("IADA_BD.xml").Elements("Permiso_detalle")

                       select new Permiso(Convert.ToString(Permiso_detalle.Element("Descripcion").Value))
                       {
                           ID = Convert.ToString(Permiso_detalle.Element("ID_permiso").Value)
                       };

                List<Permiso> Lista_permisos = query.ToList<Permiso>();
                return Lista_permisos;
            }
        }
        public void Guardar_rol(Componente C) {

            XDocument xmlBD = XDocument.Load("IADA_BD.xml");

            xmlBD.Element("BD").Add(new XElement("Rol",
                                 new XElement("ID_rol", C.ID),
                     new XElement("Descripcion", C.Descripcion)));

            xmlBD.Save("IADA_BD.xml");




        }



    }
}
