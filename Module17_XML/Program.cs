using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Module17_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument doc = new XmlDocument();

            //XmlElement root = doc.CreateElement("User");
            //XmlElement name = doc.CreateElement("Name");
            //name.InnerText = "Alex";
            //XmlAttribute atr = doc.CreateAttribute("IIin");
            //atr.InnerText = "5675657656757";
            ////1
            //name.Attributes.Append(atr);
            //// orr 2
            ////name.SetAttribute("Iin", "5675657656757");
            //root.AppendChild(name);
            //doc.AppendChild(root);
            //doc.Save("UserAlex.xml");

            XmlDocument doc = new XmlDocument();
            doc.Load("https://habrahabr.ru/rss/interesting/");

            var rootElement = doc.DocumentElement;

        }
    }
}
