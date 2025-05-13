using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dal
{
    internal static class Config
    {
     private static string configName = @"..\xml\data-config.xml";
        private static int nextProductId;
        private static int nextSaleId;
        private static XElement root;
        private static XDocument doc;

        static Config()
        {
            try
            {
              
                 doc = XDocument.Load(configName);
                root = doc.Element("config");
                nextProductId = int.Parse(root.Element("NextProductId").Value);
                nextSaleId = int.Parse(root.Element("NextSaleId").Value);

            }
            catch (Exception ex)
            {
                Console.WriteLine("שגיאה בקריאת הקובץ: " + ex.Message);
            }

        }
        public static int NextProductId
        {

            get
            {
                try
                {
                    root.Element("NextProductId").Value = (nextProductId + 1).ToString();
                    doc.Save(configName);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return nextProductId++;
            }
        }
        
        public static int NextSaleId
        {
            get
            {
                try
                {
                    root.Element("NextSaleId").Value = (nextSaleId + 1).ToString();
                    doc.Save(configName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return nextSaleId++;
            }
        }

    }
}
