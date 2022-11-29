using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Linq;

namespace Servicios
{
    public class RolMP
    {
        public void Nuevo_rol(Componente c, bool admin)     /// si admin es true se crea el administrador
        {
            XDocument xmlrol = XDocument.Load("IADA_BD.xml");
            if (admin == true)
            {
                xmlrol.Element("BD").Add(new XElement("Rol",

                   new XElement("ID_rol", c.ID),

                   new XElement("Descripcion", c.Descripcion)));


            }
            else
            {
                xmlrol.Element("BD").Add(new XElement("Rol",       ///guardo permisos del admin

                   new XElement("ID_rol", c.ID),

                   new XElement("Descripcion", c.Descripcion),


                   new XElement("Permiso_detalle", new XElement("ID_permiso", "C1"),
                   new XElement("Descripcion", "Modificacion de clientes")),
                    new XElement("Permiso_detalle", new XElement("ID_permiso", "L1"),
                   new XElement("Descripcion", "Crear lote nuevo")),
                    new XElement("Permiso_detalle", new XElement("ID_permiso", "L2"),
                   new XElement("Descripcion", "Ver y modificar stock de lote")),
                 new XElement("Permiso_detalle", new XElement("ID_permiso", "P1"),
                   new XElement("Descripcion", "Ver y modificar lista de precios")),
                  new XElement("Permiso_detalle", new XElement("ID_permiso", "U1"),
                   new XElement("Descripcion", "Ver y modificar usuarios")),
                   new XElement("Permiso_detalle", new XElement("ID_permiso", "R1"),
                   new XElement("Descripcion", "Reporte de ventas semanal")),
                   new XElement("Permiso_detalle", new XElement("ID_permiso", "F1"),
                   new XElement("Descripcion", "Facturar pedido")),
                   new XElement("Permiso_detalle", new XElement("ID_permiso", "A1"),
                   new XElement("Descripcion", "Modificar permisos"))




                   ));



            }

            xmlrol.Save("IADA_BD.xml");

        }








        public List<Componente> Bajar_permiso_por_rol(Componente C)
        {
            List<Componente> Lista_permisos = new List<Componente>();










            return Lista_permisos;
        }


        public List<Componente> Bajar_roles()
        {

            List<Componente> Lista_roles = new List<Componente>();


            {
                var query =

                       from Rol in XElement.Load("IADA_BD.xml").Elements("Rol")

                       select new Rol(Convert.ToString(Rol.Element("Descripcion").Value))
                       {
                           ID = Convert.ToString(Rol.Element("ID_rol").Value)

                       };


                Lista_roles = query.ToList<Componente>();


            }
            return Lista_roles;
        }



        //public List<Componente> Retorna_roles_permisos()
        //{

        //    List<Componente> Lista_roles = new List<Componente>();

        //    {
        //        var query =

        //               from Roles in XElement.Load("IADA_BD.xml").Elements("Rol")

        //               select new Rol(Convert.ToString(Roles.Element("Descripcion").Value))
        //               {
        //                   ID = Convert.ToString(Roles.Element("ID_rol").Value)

        //               };

        //        Lista_roles = query.ToList<Componente>();
        //    }

        //    XmlDocument archivo = new XmlDocument();
        //    archivo.Load("IADA_BD.xml");
        //    XmlElement Rol = archivo.DocumentElement;
        //    XmlNodeList Lista_rol = archivo.SelectNodes("BD/Rol");




        //    foreach (Componente c in Lista_roles)
        //    {
        //        foreach(XmlNode n in Lista_rol)

        //        {
        //            if(n.SelectSingleNode)


        //        }



        //    }






        // //   return Lista_roles;






        //}













    }
}