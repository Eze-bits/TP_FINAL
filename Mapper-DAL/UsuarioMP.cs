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
    public class UsuarioMP
    {
        //public void Primer_ingreso(Usuario usu)
        //{

        //    { Crear_BD(); }
        //    MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
        //    byte[] bs = System.Text.Encoding.UTF8.GetBytes(usu.Pass);
        //    bs = x.ComputeHash(bs);
        //    System.Text.StringBuilder s = new System.Text.StringBuilder();
        //    foreach (byte b in bs)
        //    {
        //        s.Append(b.ToString("x2"));
        //    }
        //    String hash = s.ToString();

        //    usu.Pass = hash;

        //    XDocument xmlBD = XDocument.Load("IADA_BD.xml");
        //    xmlBD.Element("BD").Add(new XElement("Usuario", new XElement("Rol", usu.Nombre_rol),
        //        new XElement("Clave", usu.Pass)));

        //    xmlBD.Save("IADA_BD.xml");

        //}


        //public void Crear_BD()
        //{

        //    XmlTextWriter Lotestwr = new XmlTextWriter("IADA_BD.xml", System.Text.Encoding.UTF8);
        //    Lotestwr.Formatting = Formatting.Indented;
        //    Lotestwr.Indentation = 2;
        //    Lotestwr.WriteStartDocument(true);
        //    Lotestwr.WriteStartElement("BD");
        //    Lotestwr.WriteEndElement();
        //    Lotestwr.WriteEndDocument();
        //    Lotestwr.Close();

        //}

        public List<Usuario> Mostrar_usuarios()
        {
            var query =

                from Usuario in XElement.Load("IADA_BD.xml").Elements("Usuario")

            select new Usuario
            {
                ID = (Convert.ToInt32(Usuario.Element("ID").Value)),
            Nombre= (Convert.ToString(Usuario.Element("Nombre").Value))

            };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            return usuario_consulta;
        }



        public void Agregar_usuario(Usuario usu)
        {

            XDocument xmlBD = XDocument.Load("IADA_BD.xml");
            xmlBD.Element("BD").Add(new XElement("Usuario", new XElement("ID", usu.ID), new XElement("Nombre", usu.Nombre),
                new XElement("Clave", usu.Obtener_pass())));

            xmlBD.Save("IADA_BD.xml");

        }

        public bool Checkear_usuario(Usuario usu)
        {

            var query =

                   from Usuario in XElement.Load("IADA_BD.xml").Elements("Usuario")

                   select new Usuario
                   {
                       ID = (Convert.ToInt32(Usuario.Element("ID").Value))
                   };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            if (usuario_consulta.Count == 0)
            { return false; }
            foreach (Usuario us in usuario_consulta)
            {
                if (us.ID == usu.ID)

                    return true;
            }
            return false;
        }
        public void Modificar_usuario(Usuario usu)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("IADA_BD.xml");
            XmlNodeList lista_usuario = archivo.SelectNodes("Usuario");

            foreach (XmlNode nodo in lista_usuario)

            {
                if (nodo.SelectSingleNode("ID").InnerText == Convert.ToString(usu.ID))
                {
                    nodo.SelectSingleNode("Nombre").InnerText = usu.Nombre;
                    nodo.SelectSingleNode("Pass").InnerText = usu.Obtener_pass();
                    archivo.Save("IADA_BD.xml");
                    break;
                }
            }
        }


    }
}
