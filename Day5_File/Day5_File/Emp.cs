using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Day5_File
{
    public class Emp
    {
        public static void Main()
        {
            Emp emp = new Emp("Sunrit", 24);
            Emp.Serialize(emp, "abc.txt");
            Emp.Deserialize("abc.txt");
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Emp() { }
        public Emp(string name, int age) { Name = name; Age = age; }
        public static void Serialize(Emp emp, string filename)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Emp));
            StreamWriter stream = new StreamWriter(filename);
            Console.WriteLine("Writing Employee Information");
            try
            {
                mySerializer.Serialize(stream, emp);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Exception for Serialization data: " + ex.Message);
                throw;
            }
            finally
            {
                stream.Close();
                Console.WriteLine("Successfully wrote Employye Information ");
            }
        }

        public static void Deserialize(string filename)
        {
            Emp mp = null;
            XmlSerializer mySerializer = new XmlSerializer(typeof(Emp));
            FileStream myFileStream = new FileStream(filename, FileMode.Open);
            Console.WriteLine("Reading Employee Information");
            try
            {
                mp = (Emp)mySerializer.Deserialize(myFileStream);

            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Exception for Deserialize data.." + ex.Message);
                throw;
            }
            finally
            {
                myFileStream.Close();
            }
            if (mp != null)
            {
                Console.WriteLine("Employee Name: {0}", mp.Name);
                Console.WriteLine("Employee Id: {0}", mp.Age.ToString());
            }
            else
            {
                Console.WriteLine("Deserialize employee null Value;");
            }
        }
    }
}
