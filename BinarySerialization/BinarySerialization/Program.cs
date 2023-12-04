using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerialization
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee()
            {
                ID = 1,
                FirstName = "Sam",
                LastName = "Rao",
                Salary=98000.90
            };
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\Samiksha\OneDrive\Desktop\GitAssignment\Day21\\ExampleSerailization.txt",
            FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"C:\Users\Samiksha\OneDrive\Desktop\GitAssignment\Day21\\ExampleSerialization.txt",
                FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.FirstName);
            Console.WriteLine(objnew.LastName);
            Console.WriteLine(objnew.Salary);
            Console.ReadKey();
        }
    }
}
