using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Web.Mvc;

namespace itb.Models
{
    public class Settings
    {
        string file = "~/Files/Settings/settings.xml";

        protected void CreateXML(object sender, EventArgs e)
        {
                //Создание вложенными конструкторами.
            XDocument doc = new XDocument(
                new XElement("CB",
                    new XElement("Report",
                        new XAttribute("id", "1"),
                        new XAttribute("OpenCloseAccount", "Open/Close_Account")
                    )             
                )
            );

            doc.Save(file);
        }

    }
}