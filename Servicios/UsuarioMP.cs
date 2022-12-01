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
    public class UsuarioMP
    {
        Crear_BD BD = new Crear_BD();

        public List<Usuario> Mostrar_usuarios()
        {

            var query =

                from Usuario in XElement.Load("IADA_BD.xml").Elements("Usuario")

                select new Usuario(Convert.ToString(Usuario.Element("Clave").Value))
                {

                    ID_usuario = (Convert.ToInt32(Usuario.Element("ID_usuario").Value)),
                    Nombre = (Convert.ToString(Usuario.Element("Nombre").Value))

                };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            return usuario_consulta;
        }

        public List<Usuario> Mostrar_usuarios_roles()
        {
            var query =

                from Usuario in XElement.Load("IADA_BD.xml").Elements("Usuario")

                select new Usuario(Convert.ToString(Usuario.Element("Clave").Value))
                {

                    ID_usuario = (Convert.ToInt32(Usuario.Element("ID_usuario").Value)),
                    Nombre = (Convert.ToString(Usuario.Element("Nombre").Value))

                };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();

            foreach (Usuario usu in usuario_consulta)
            {
                XmlDocument archivo = new XmlDocument();
                archivo.Load("IADA_BD.xml");
                XmlNodeList lista_usuario = archivo.SelectNodes("BD/Usuario");
                foreach (XmlNode nodo in lista_usuario)
                {
                    if (Convert.ToInt32(nodo.SelectSingleNode("ID_usuario").InnerText) == usu.ID_usuario)
                    {
                        foreach (XmlNode n in nodo.SelectNodes("Roles_de_usuario"))
                        {
                            Componente c = new Rol(Convert.ToString(n.SelectSingleNode("ID_rol").InnerText));
                            usu.Agregar_roles(c);
                        }
                    }
                }

            }


            return usuario_consulta;
        }



        public void Agregar_usuario(Usuario usu, bool admin)        // si admin=true crea el administrador
        {
            if (System.IO.File.Exists("IADA_BD.xml") == false)

            { this.BD.Crear_nueva_BD("IADA_BD.xml"); }
            XDocument xmlBD = XDocument.Load("IADA_BD.xml");
            if (admin == true)
            {
                xmlBD.Element("BD").Add(new XElement("Usuario", new XElement("ID_usuario", usu.ID_usuario), new XElement("Nombre", usu.Nombre),
                    new XElement("Clave", usu.Obtener_pass()),

                    new XElement("Roles_de_usuario", new XElement("ID_rol", "admin"))

                    ));

            }
            else
            {
                xmlBD.Element("BD").Add(new XElement("Usuario", new XElement("ID_usuario", usu.ID_usuario), new XElement("Nombre", usu.Nombre),
                    new XElement("Clave", usu.Obtener_pass())));
            }
            xmlBD.Save("IADA_BD.xml");

        }
        public bool Checkear_bd()
        {
            if (System.IO.File.Exists("IADA_BD.xml") == false)
            { return false; }   // no existe el archivo
            else
            { return true; }

        }

        public bool Checkear_usuario(Usuario usu)     ///checkea si existe el ID
        {
            if (System.IO.File.Exists("IADA_BD.xml") == false)

            {
                BD.Crear_nueva_BD("IADA_BD.xml");
                return false;
            }


            var query =

                   from Usuario in XElement.Load("IADA_BD.xml").Elements("Usuario")

                   select new Usuario
                   {
                       ID_usuario = (Convert.ToInt32(Usuario.Element("ID_usuario").Value))
                   };

            List<Usuario> usuario_consulta = query.ToList<Usuario>();
            if (usuario_consulta.Count == 0)
            { return false; }
            foreach (Usuario us in usuario_consulta)
            {
                if (us.ID_usuario == usu.ID_usuario)

                    return true;
            }
            return false;
        }
        public void Modificar_usuario(Usuario usu)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("IADA_BD.xml");
            XmlNodeList lista_usuario = archivo.SelectNodes("BD/Usuario");

            foreach (XmlNode nodo in lista_usuario)

            {
                if (nodo.SelectSingleNode("ID").InnerText == Convert.ToString(usu.ID_usuario))
                {
                    nodo.SelectSingleNode("Nombre").InnerText = usu.Nombre;
                    nodo.SelectSingleNode("Pass").InnerText = usu.Obtener_pass();
                    archivo.Save("IADA_BD.xml");
                    break;
                }
            }
        }

        public void actualizar_roles_usuario(Usuario usu)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("IADA_BD.xml");
            XmlNodeList lista_usuario = archivo.SelectNodes("BD/Usuario");
            foreach (XmlNode nodo in lista_usuario)

            {
                if (nodo.SelectSingleNode("ID_usuario").InnerText == Convert.ToString(usu.ID_usuario))
                {
                    foreach (XmlNode n in nodo.SelectNodes("Roles_de_usuario"))
                    {
                        nodo.RemoveChild(n);
                    }
                    foreach(Componente c in usu.Mostrar_lista())
                    {
                        XmlElement rol = archivo.CreateElement("Roles_de_usuario");
                        XmlElement id_rol = archivo.CreateElement("ID_Rol");
                        
                        id_rol.InnerText = c.Obtener_ID();
                       
                        rol.AppendChild(id_rol);
                        nodo.AppendChild(rol);
                        


                    }

                }
            }



        }




    }
}
