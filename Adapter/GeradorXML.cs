using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Adapter
{
    class GeradorXML
    {
        public string Gerar(object obj)
        {
            var serializer = new XmlSerializer(obj.GetType());
            var writer =  new StringWriter();

            serializer.Serialize(writer, obj);
            return writer.ToString();
        }
    }
}
