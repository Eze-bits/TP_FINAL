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

        //public List<Componente> Bajar_roles()
        //{

        //    List<Componente> Lista_roles = new List<Componente>();


        //    {
        //        var query =

        //               from Rol in XElement.Load("IADA_BD.xml").Elements("Rol")

        //               select new Rol(Convert.ToString(Rol.Element("Descripcion").Value))
        //               {
        //                   ID = Convert.ToString(Rol.Element("ID_rol").Value)

        //               };


        //        Lista_roles = query.ToList<Componente>();


        //    }
        //    return Lista_roles;
        //}



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