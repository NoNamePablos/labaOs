using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;
using lab4;

namespace ClassLibraryHotel.Serialization
{
    [Serializable]
    public class JobSerializable
    {
        public List<Employee> Employee { get; set; } = new List<Employee>();
        public List<TypeOfWorks> TypeOfWorks { get; set; } = new List<TypeOfWorks>();
        public List<WorksSerializable> Works { get; set; } = new List<WorksSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            var hotelSerializable = new JobSerializable();
            var hotel = Job.Instance;
            foreach (var client in hotel.Employees)
            {
                hotelSerializable.Employee.Add(client);
            }
            foreach (var room in hotel.TypeOfWorks)
            {
                hotelSerializable.TypeOfWorks.Add(room);
            }
            foreach (var settlement in hotel.Works)
            {
                hotelSerializable.Works.Add(new WorksSerializable
                {EmployeeId = settlement.Employee.EmployeeId,
                    TypeWork = settlement.TypeOfWorks.TypeWork,
                    StartDate = settlement.StartDate,
                    EndDate = settlement.EndDate
                });
            }
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(JobSerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, hotelSerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, hotelSerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, hotelSerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Load(string fileName, SerializeType type)
        {
            JobSerializable hotelSerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(JobSerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    hotelSerializable = (JobSerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    hotelSerializable = (JobSerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(JobSerializable));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    hotelSerializable = (JobSerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var hotel = Job.Instance;
            var hotelClients = hotel.Employees.ToList();
            var hotelRooms = hotel.TypeOfWorks.ToList();
            var hotelSettlements = hotel.Works.ToList();
            foreach (var hotelClient in hotelClients)
            {
                hotel.RemoveEmployee(hotelClient.EmployeeId);
            }
            foreach (var hotelRoom in hotelRooms)
            {
                hotel.RemoveTOW(hotelRoom.TypeWork);
            }
            foreach (var hotelSettlement in hotelSettlements)
            {
                hotel.RemoveWorks(hotelSettlement);
            }
            var clients = new List<Employee>();
            var rooms = new Dictionary<TypeOfWorksEnum, TypeOfWorks>();
            int maxClientId = 0;
            foreach (var client in hotelSerializable.Employee)
            {
                if (client.EmployeeId > maxClientId) maxClientId = client.EmployeeId;
                clients.Add(client);
                hotel.AddEnployee(client);
            }
            foreach (var room in hotelSerializable.TypeOfWorks)
            {
                rooms.Add(room.TypeWork, room);
                hotel.AddTOW(room);
            }
            int x = 0;
            foreach (var settlement in hotelSerializable.Works)
            {
               
                
                
                hotel.AddWorks(new Works
                {
                    Employee = clients[x],
                    TypeOfWorks = rooms[settlement.TypeWork],
                    StartDate = settlement.StartDate,
                    EndDate = settlement.EndDate
                });
                x++;
            }
           
        }
    }
}