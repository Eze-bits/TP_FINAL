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
            if (admin == false)
            {
                xmlrol.Element("BD").Add(new XElement("Rol",

                   new XElement("ID_rol", c.ID),
                   new XElement("Nombre_rol", c.Descripcion)));


            }
            else
            {
                xmlrol.Element("BD").Add(new XElement("Rol",       ///guardo permisos del admin

                   new XElement("ID_rol", "admin"),
                   new XElement("Nombre_rol", c.Descripcion),
                    

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


        public void Actualizar_permisos(Componente c)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("IADA_BD.xml");


            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");
            foreach (XmlNode nodo in lista_roles)
            {
                if (nodo.SelectSingleNode("Nombre_rol").InnerText == Convert.ToString(c.Descripcion))
                {
                    foreach (XmlNode n in nodo.SelectNodes("Permiso_detalle"))
                    {
                        nodo.RemoveChild(n);

                    }
                    foreach (Componente co in c.obtener_lista())
                    {
                        XmlElement permiso = archivo.CreateElement("Permiso_detalle");
                        XmlElement id_permiso = archivo.CreateElement("ID_permiso");
                        //XmlElement desc_permiso = archivo.CreateElement("Descripcion");
                        id_permiso.InnerText = co.Obtener_ID();
                        //  desc_permiso.InnerText = co.Descripcion;
                        permiso.AppendChild(id_permiso);
                        //    permiso.AppendChild(desc_permiso);
                        nodo.AppendChild(permiso);

                    }


                    break;
                }
            }

            archivo.Save("IADA_BD.xml");
        }


        public void Borrar_rol(Componente c)
        {

            XmlDocument archivo = new XmlDocument();
            archivo.Load("IADA_BD.xml");
            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");
            foreach (XmlNode nodo in lista_roles)
            {
                if (nodo.SelectSingleNode("Nombre_rol").InnerText == Convert.ToString(c.Descripcion))
                {
                    archivo.DocumentElement.RemoveChild(nodo);
                    break;
                }

            }
            archivo.Save("IADA_BD.xml");
        }


        public void Agregar_permiso(Componente C)
        {

            XmlDocument archivo = new XmlDocument();
            archivo.Load("IADA_BD.xml");
            XmlNodeList lista_roles = archivo.SelectNodes("BD/Rol");

            foreach (XmlNode nodo in lista_roles)

            {
                if (nodo.SelectSingleNode("Nombre_rol").InnerText == Convert.ToString(C.Descripcion))
                {

                    foreach (Componente Co in C.obtener_lista())
                    {
                        XmlElement permiso = archivo.CreateElement("Permiso_detalle");
                        XmlElement id_permiso = archivo.CreateElement("ID_permiso");
                        XmlElement desc_permiso = archivo.CreateElement("Descripcion");
                        id_permiso.InnerText = Co.Obtener_ID();
                        desc_permiso.InnerText = Co.Descripcion;
                        permiso.AppendChild(id_permiso);
                        permiso.AppendChild(desc_permiso);
                        nodo.AppendChild(permiso);

                    }
                    break;

                }
            }
            archivo.Save("IADA_BD.xml");

        }

        public void Borrar_permiso(Componente C) { }





        public List<Componente> Roles_permisos_descargar()
        {
            List<Componente> lista_todo = new List<Componente>();


            var query =                                        ///roles

                      from Roles in XElement.Load("IADA_BD.xml").Elements("Rol")

                      select new Rol(Convert.ToString(Roles.Element("Nombre_rol").Value))
                      {
                          ID = Roles.Element("ID_rol").Value
                      };


            lista_todo = query.ToList<Componente>();                

            XmlDocument xmlpermisos = new XmlDocument();
            xmlpermisos.Load("IADA_BD.xml");
                                                                                ///permisos
            XmlNodeList lista_permisos = xmlpermisos.SelectNodes("BD/Rol");
            XmlNodeList lista_permisos_detalle = xmlpermisos.SelectNodes("BD/Permiso_detalle");
            foreach (Componente c in lista_todo)
            {

                foreach (XmlNode nod in lista_permisos)
                {
                    if (c.Descripcion == Convert.ToString(nod.SelectSingleNode("Nombre_rol").InnerText))
                    {
                        foreach (XmlNode n in nod.SelectNodes("Permiso_detalle"))
                        {
                            Componente co = new Permiso(null, Convert.ToString(n.SelectSingleNode("ID_permiso").InnerText));

                            c.Agregar(co);

                        }

                    }
                }

            }

            foreach (Componente c in lista_todo)
            {


                foreach (Componente co in c.obtener_lista())
                {
                    foreach (XmlNode n in lista_permisos_detalle)
                    {
                        if (n.SelectSingleNode("ID_permiso").InnerText == co.Obtener_ID())
                        {
                            co.Descripcion = n.SelectSingleNode("Descripcion").InnerText;
                        }
                    }

                }
            }




            return lista_todo;
        }


        public List<Componente> Bajar_roles()
        {

            List<Componente> Lista_roles = new List<Componente>();


            {
                var query =

                       from Rol in XElement.Load("IADA_BD.xml").Elements("Rol")

                       select new Rol(Convert.ToString(Rol.Element("Nombre_rol").Value))
                       {


                       };


                Lista_roles = query.ToList<Componente>();


            }
            return Lista_roles;
        }












    }
}