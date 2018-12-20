using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFeApiLib.NFe.Tools
{
    /// <summary>
    /// Classe abstrata para serializar objetos em XML.
    /// </summary>
    public abstract class Serializavel
    { 
        /// <summary>
        /// Serializa o objeto que herda dessa classe em XML
        /// </summary>
        /// <returns>
        /// Retorna uma string contendo o XML preenchido de acordo com o objeto
        /// </returns>
        public string SerializeObject()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, this);
                return textWriter.ToString();
            }
        }
    }
}
