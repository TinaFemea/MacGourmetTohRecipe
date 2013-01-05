using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MacGourmetReader
{
    class HRecipe
    {
        public class Ingredient
        {
            public string Count;
            public string Units;
            public string Name;

            public string GetHTML()
            {
                return String.Empty;
            }
        }

        public XmlElement BuildElementWithAttr(XmlDocument doc, string baseType, string type, string value)
        {
            XmlElement element = doc.CreateElement(baseType);
            XmlAttribute attr = doc.CreateAttribute(type);
            attr.Value = value;
            element.Attributes.Append(attr);
            return element;
        }
        public string GetHTML()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement bodyElement = doc.CreateElement("body");
            doc.AppendChild(bodyElement);
            XmlElement baseDiv = BuildElementWithAttr(doc, "div", "class", "hrecipe");
            bodyElement.AppendChild(baseDiv);
            
            XmlElement itemSpan = BuildElementWithAttr(doc, "span", "class", "item");
            baseDiv.AppendChild(itemSpan);

            XmlElement nameBlock = BuildElementWithAttr(doc, "h1", "class", "fn");
            nameBlock.AppendChild(doc.CreateTextNode(Name));

            itemSpan.AppendChild(nameBlock);

            return bodyElement.InnerXml;

        }

        public string Name;
        public List<Ingredient> Ingredients = new List<Ingredient>();
        public string Yield;
        public List<string> Instructions = new List<string>();
        public string SmallPhoto;
        public string PhotoLink;
        public string Summary;
        public string Author;
        public string Published;
        public string Nutrition;
        public List<string> Tags;


    }
}
