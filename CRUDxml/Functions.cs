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
                "           <id>24.95</id> \n" +
                "           <username>24.95</username> \n" +
                "           <text>24.95</text> \n" +
                "       </post> \n" +
                "       <post> \n" +
                "           <id>24.95</id> \n" +
                "           <username>24.95</username> \n" +
                "           <text>24.95</text> \n" +
                "       </post> \n" +
                "   </board>");

                return doc;

            }
        }
    }
}

