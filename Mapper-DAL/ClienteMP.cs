﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Linq;

namespace Mapper_DAL
{
    public class ClienteMP
    {
        public void Alta_clienteMpp(Cliente C)
        {

            if (System.IO.File.Exists("Clientes.xml") == false)

            {
                XmlTextWriter Clientestwr = new XmlTextWriter("Clientes.xml", System.Text.Encoding.UTF8);
                Clientestwr.Formatting = Formatting.Indented;
                Clientestwr.Indentation = 2;
                Clientestwr.WriteStartDocument(true);
                Clientestwr.WriteStartElement("Clientes");
                Clientestwr.WriteEndElement();
                Clientestwr.WriteEndDocument();
                Clientestwr.Close();
            }

            XDocument xmlClientes = XDocument.Load("Clientes.xml");
     
            xmlClientes.Element("Clientes").Add(new XElement("Cliente",

                  new XElement("DNI", C.DNI),
                  new XElement("Nombre", C.Nombre),
                  new XElement("Apellido", C.Apellido),
                  new XElement("Localidad", C.Localidad),
                  new XElement("Calle", C.Calle),
                  new XElement("Nro_casa", C.Nro_casa),
                  new XElement("Telefono_particular", C.Telefono_particular),
                  new XElement("Email", C.Email)));

            xmlClientes.Save("Clientes.xml");
        }

        public bool BuscarDNI(int D)
        {

            if (System.IO.File.Exists("Clientes.xml") == true)   // si existe el archivo

            {
             //   XDocument xmlClientes = XDocument.Load("Clientes.xml");
                var query =

                  from Cliente in XElement.Load("Clientes.xml").Elements("Cliente")

                  select new Cliente
                  {
                      DNI = Convert.ToInt32(Convert.ToString(Cliente.Element("DNI").Value))
                  };

                List<Cliente> Cliente_consulta = query.ToList<Cliente>();

                foreach (Cliente Cli in Cliente_consulta)
                {
                    if (Cli.DNI == D)

                        return false;     /// existe el dni retorna falso
                }
            }

            ///buscar (si esta creado el xml) si existe el dni proporcionado
            ///si existe el archivo y el dni existe retorna true sino es false
            return false;
        }

        public List<Cliente> Listado_clientes()
        {
            if (System.IO.File.Exists("Clientes.xml") == true)
            {
                var query =

                       from Cliente in XElement.Load("Clientes.xml").Elements("Cliente")

                       select new Cliente
                       {
                           DNI = Convert.ToInt32(Cliente.Element("DNI").Value),
                           Nombre = Convert.ToString(Cliente.Element("Nombre").Value),
                           Apellido = Convert.ToString(Cliente.Element("Apellido").Value),
                           Localidad = Convert.ToString(Cliente.Element("Localidad").Value),
                           Calle = Convert.ToString(Cliente.Element("Calle").Value),
                           Nro_casa = Convert.ToInt32(Cliente.Element("Nro_casa").Value),
                           Telefono_particular = Convert.ToInt32(Cliente.Element("Telefono_particular").Value),
                           Email = Convert.ToString(Cliente.Element("Email").Value)
                       };


                List<Cliente> Lista_clientes = query.ToList<Cliente>();
                return Lista_clientes;
            }
            else
            {
                List<Cliente> Lista_vacia = new List<Cliente>();
                return Lista_vacia;
            }
        }

        public void Borrar_clienteMpp(int D)
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("Clientes.xml");

            XmlElement Clientes = archivo.DocumentElement;
            XmlNodeList Lista_clientes = archivo.SelectNodes("Clientes/Cliente");

            foreach (XmlNode nodo in Lista_clientes)

            {
                if (nodo.SelectSingleNode("DNI").InnerText == Convert.ToString(D))
                {
                    Clientes.RemoveChild(nodo);
                    archivo.Save("Clientes.xml");
                    break;
                }
            }
        }

        public void Modificar_clienteMpp(Cliente C)
        {

            XmlDocument archivo = new XmlDocument();
            archivo.Load("Clientes.xml");

           // XmlElement Clientes = archivo.DocumentElement;
            XmlNodeList lista_cliente = archivo.SelectNodes("Clientes/Cliente");

            foreach (XmlNode nodo in lista_cliente)

            {
                if (nodo.SelectSingleNode("DNI").InnerText == Convert.ToString(C.DNI))
                {
                    nodo.SelectSingleNode("Nombre").InnerText =C.Nombre ;
                    nodo.SelectSingleNode("Apellido").InnerText = C.Apellido;
                    nodo.SelectSingleNode("Localidad").InnerText = C.Localidad;
                    nodo.SelectSingleNode("Calle").InnerText = C.Calle;
                    nodo.SelectSingleNode("Nro_casa").InnerText = Convert.ToString(C.Nro_casa);
                    nodo.SelectSingleNode("Telefono_particular").InnerText = Convert.ToString(C.Telefono_particular);
                    nodo.SelectSingleNode("Email").InnerText = C.Email;


                    archivo.Save("Clientes.xml");
                    break;
                }
            }




        }


    }
}
