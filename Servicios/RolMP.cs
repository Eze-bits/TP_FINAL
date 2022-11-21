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
        public void Nuevo_rol(Componente c)
        {

            XDocument xmlrol = XDocument.Load("IADA_BD.xml");

            xmlrol.Element("BD").Add(new XElement("Rol",

                  new XElement("ID_rol", c.ID),

                  new XElement("Descripcion", c.Descripcion)));

            xmlrol.Save("IADA_BD.xml");

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

        public void guardar_permisos_del_rol(Componente c)
        {
            XDocument xmlroles = XDocument.Load("IADA_BD.xml");
            var items = xmlroles.Descendants("Rol")
                              .Where(item => item.Element("ID_rol").Value == c.Descripcion);

            foreach (Componente Co in )
            {
                foreach (var n in items)
                {
                    n.Add(new XElement("PRODUCTO", new XElement("Nro_lote", P.Nro_lote),
                        new XElement("Unidades", P.Unidades), new XElement("Peso", P.Peso)));
                }
            }





        }
            




        
    }
}