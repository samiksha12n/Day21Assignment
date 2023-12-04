using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerialization
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    namespace XMLSerializationEX
    {
        [Serializable]
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        class Program
        {
            static void Main()
            {
                Person person = new Person()
                {
                    Id = 1,
                    Name = "Sam",
                    Age = 25
                };

                //Serialize the object to XML
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                using (TextWriter writer = new StreamWriter("person.xml"))
                {
                    serializer.Serialize(writer, person);
                }

                //Deserialize the object from XML
                using (TextReader reader = new StreamReader("person.xml"))
                {
                    Person deserializedPerson = (Person)serializer.Deserialize(reader);
                    Console.WriteLine($"ID: {deserializedPerson.Id}, Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
                }
                Console.ReadKey();
            }
        }
    }



}
