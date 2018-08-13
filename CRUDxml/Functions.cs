using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CRUDxml
{
    class Functions
    {
        private XmlDocument BoardXml()//error aqui tambien
        {
            
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            try { doc.Load("board.xml"); }
            catch (System.IO.FileNotFoundException)
            {
                doc.LoadXml("<?xml version=\"1.0\"?> \n" +
                "  <!DOCTYPE boardid> \n" + //con SYSTEM "" pero me sale un error extraño
                "    <board> \n" +
                "       <post> \n" +
                "           <id>1</id> \n" +
                "           <username>Ale</username> \n" +
                "           <text>Probando</text> \n" +
                "       </post> \n" +
                "       <post> \n" +
                "           <id>2</id> \n" +
                "           <username>Charles</username> \n" +
                "           <text>Testing</text> \n" +
                "       </post> \n" +
                "   </board>");

                return doc;

            }
        }
    }
}

