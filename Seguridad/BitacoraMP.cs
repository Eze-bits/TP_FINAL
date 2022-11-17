using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;



namespace Servicios
{
    public class BitacoraMP
    {
        public void Agregar_entrada_bitacora(Bitacora Bt)
        {
            if (System.IO.File.Exists("BITACORA_BD.xml") == false)
            {
                Crear_bitacora();
            }

            XDocument xmlBitacora = XDocument.Load("BITACORA_BD.xml");

            xmlBitacora.Element("Bitacora_BD").Add(new XElement("Bitacora",
                                  new XElement("ID_usuario", Bt.ID_usuario),
                  new XElement("Tipo_de_movimiento", Bt.Tipo_de_movimiento),
                  new XElement("Fecha",Bt.Fecha.ToString()),
                  new XElement("Nombre_de_archivo",Bt.Nombre_de_archivo),
                  new XElement("Ruta",Bt.Obtener_ruta())));
            xmlBitacora.Save("BITACORA_BD.xml");


        }
   
    public void Crear_bitacora()
        {
            XmlTextWriter Lotestwr = new XmlTextWriter("Bitacora_BD.xml", System.Text.Encoding.UTF8);
            Lotestwr.Formatting = Formatting.Indented;
            Lotestwr.Indentation = 2;
            Lotestwr.WriteStartDocument(true);
            Lotestwr.WriteStartElement("Bitacora_BD");
            Lotestwr.WriteEndElement();
            Lotestwr.WriteEndDocument();
            Lotestwr.Close();
        }
    
    
    
    }
}
