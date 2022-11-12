using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;

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

        public void Agregar_usuario(Usuario usu)
        {

            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(usu.Obtener_pass());
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            String hash = s.ToString();

            usu.Guardar_pass(hash);

            XDocument xmlBD = XDocument.Load("IADA_BD.xml");
            xmlBD.Element("BD").Add(new XElement("Usuario", new XElement("Rol", usu.Nombre),
                new XElement("Clave", usu.Obtener_pass())));

            xmlBD.Save("IADA_BD.xml");

        }

        public bool Checkear_usuario(Usuario usu)
        {

            var query =

                   from Usuario in XElement.Load("IADA_BD.xml").Elements("Usuario")

                   select new Usuario
                   {
                       Nombre = (Convert.ToString(Usuario.Element("Rol").Value))
                   };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            if(usuario_consulta.Count==0)
            { return true; }
            foreach (Usuario us in usuario_consulta)
            {
                if (us.Nombre == usu.Nombre)

                    return true;
            }
            return false;
        }



    }
}
