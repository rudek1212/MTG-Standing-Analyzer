using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();
            // Read a purchase order.
            t.DeserializeObject("standingi.xml");
        }

        private void DeserializeObject(string filename)
        {
            Console.WriteLine("Reading with XmlReader");

            // Create an instance of the XmlSerializer specifying type and namespace.
            XmlSerializer serializer = new XmlSerializer(typeof(Standings));
            StreamReader reader = new StreamReader("C:\\Users\\Rudni\\Desktop\\standingi.xml");
            var x = serializer.Deserialize(reader);
            // Write out the properties of the object.
            Console.ReadLine();
        }
    }

}
