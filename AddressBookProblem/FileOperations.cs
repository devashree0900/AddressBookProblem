using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CsvHelper;


namespace AddressBookProblem
{
    public class FileOperations
    {
        public static void BinarySerialization(AddressBook obj)
        {
            string path = @"C:\Users\223089248\source\repos\AddressBookProblem\AddressBookProblem\File.txt";
            FileStream file = File.OpenWrite(path);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, obj.contactList);
            file.Close();
            Console.WriteLine("Data added in file successfully");
        }

        public static void BinaryDeserialization()
        {
            string path = @"C:\Users\223089248\source\repos\AddressBookProblem\AddressBookProblem\File.txt";
            FileStream file = File.OpenRead(path);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<Contact> list  = (List<Contact>)binaryFormatter.Deserialize(file);
            foreach (Contact person in list)
            {
                person.display(person);
            }
        }

        
        //Doubt
        public static void JSONSerialization(AddressBook obj)
        {
            string path = @"C:\Users\223089248\source\repos\AddressBookProblem\AddressBookProblem\JsonFile.json";
            foreach(Contact c in obj.contactList)
            {
                c.display(c);
            }
            String result = JsonConvert.SerializeObject(obj.contactList);
            File.WriteAllText(path, result);
            Console.WriteLine("Data Added Successfully");
        }

        public static void JSONDeserialization()
        {
            string path = @"C:\Users\223089248\source\repos\AddressBookProblem\AddressBookProblem\JSONFile.json";
            string result = File.ReadAllText(path);
            List<Contact> personList = JsonConvert.DeserializeObject<List<Contact>>(result);
            foreach (Contact person in personList)
            {
                person.display(person);
            }
        }

        //doubt
        public static void WriteInToCSVFile(AddressBook obj)
        {
            string csvFile = @"C:\Users\223089248\source\repos\AddressBookProblem\AddressBookProblem\CSVFile.csv";
            List <Contact> list = new List<Contact>();
            foreach(Contact c in obj.contactList)
                list.Add(c);
            using (StreamWriter writer = new StreamWriter(csvFile))
            {
                if (writer != null)
                {
                    using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csvWriter.WriteHeader<Contact>();
                        csvWriter.NextRecord();
                        csvWriter.WriteRecords(list);
                    }
                }

            }
            ReadFromCsvFile(obj.contactList,csvFile);
        }

        public static void ReadFromCsvFile(List<Contact> record,string csvFile)
        {

            using (StreamReader reader = new StreamReader(csvFile))

            {
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    record = csvReader.GetRecords<Contact>().ToList();
                }
            }
            foreach (Contact l in record)
            {
                l.display(l);
            }
        }
    }
}
