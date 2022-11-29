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



                   new XElement("Nombre_rol", c.Descripcion)));


            }
            else
            {
                xmlrol.Element("BD").Add(new XElement("Rol",       ///guardo permisos del admin



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
                        id_permiso.InnerText = Co.ID;
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






        public List<Componente> Roles_permisos_descargar()
        {
            List<Componente> lista_todo = new List<Componente>();


            var query =

                      from Roles in XElement.Load("IADA_BD.xml").Elements("Rol")

                      select new Rol (Convert.ToString(Roles.Element("Nombre_rol").Value))
                      {
                         
                      };


            lista_todo = query.ToList<Componente>();                ///roles

            XmlDocument xmlpermisos = new XmlDocument();
            xmlpermisos.Load("IADA_BD.xml");
            
            XmlNodeList lista_permisos = xmlpermisos.SelectNodes("BD/Rol");

            foreach (Componente c in lista_todo)
            {

                foreach(XmlNode nod in lista_permisos)
                {
                    if (c.Descripcion==nod.SelectSingleNode("Nombre_rol").Value&nod.HasChildNodes==true)
                    {
                        foreach(XmlNode n in nod.ChildNodes)
                        {
                            Componente co = new Permiso(n.SelectSingleNode("Descripcion").Value);
                            co.ID = n.SelectSingleNode("ID_permiso").Value;
                            c.Agregar(co);

                        }


                    }

                }





            }






            return lista_todo;
        }




        //public List<Componente> Bajar_permiso_por_rol(Componente C)
        //{
        //    List<Componente> Lista_permisos = new List<Componente>();



        //    return Lista_permisos;
        //}


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