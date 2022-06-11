using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InsuranceClassLibrary.Serialization
{
    [Serializable]
    public class IncuranceSerialization
    {
        /// <summary>
        /// Словарь клиентов
        /// </summary>
        public List< Departament> Clients { get; } = new List<Departament>();
        /// <summary>
        /// Словарь комнат
        /// </summary>
        /// 
        public List<InsuranceTypes> Rooms { get; } = new List<InsuranceTypes>();
        //public static List<InsuranceTypes> Rooms { get; } = new List<InsuranceTypes>();

        /// <summary>
        /// Спосок поселений
        /// </summary>
        public List<ContractSerialization> Settlements { get; } = new List<ContractSerialization>();
        public static void Save(string fileName, SerializeType type)
        {
            var hotelSerializable = new IncuranceSerialization();
            var hotel = Insurance.Instance;
            foreach (var client in hotel.Clients)
            {
                hotelSerializable.Clients.Add(client);
            }
            foreach (var room in hotel.Rooms)
            {
                hotelSerializable.Rooms.Add(room);
            }
            foreach (var settlement in hotel.Settlements)
            {
                hotelSerializable.Settlements.Add(new ContractSerialization
                {
                    NumberContract = settlement.NumberContract,
                    LocalDepartamentId = settlement.LocalDepartament.DepId,
                    Date = settlement.Date,
                    InsuranceAmount = settlement.InsuranceAmount,
                    TariffRate=settlement.TariffRate,
                    LocalInsuranceTypesId=settlement.LocalInsuranceTypes.TypeId
                });;;
            }
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(IncuranceSerialization));
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
            IncuranceSerialization hotelSerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(IncuranceSerialization));
                    StreamReader streamReader = new StreamReader(fileName);
                    hotelSerializable = (IncuranceSerialization)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    hotelSerializable = (IncuranceSerialization)jsonSerializer.Deserialize(jsonStreamReader, typeof(IncuranceSerialization));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    hotelSerializable = (IncuranceSerialization)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var hotel = Insurance.Instance;
            var hotelClients = hotel.Clients.ToList();
            var hotelRooms = hotel.Rooms.ToList();
            var hotelSettlements = hotel.Settlements.ToList();
            foreach (var hotelClient in hotelClients)
            {
                hotel.RemoveClient(hotelClient.DepId);
            }
            foreach (var hotelRoom in hotelRooms)
            {
                hotel.RemoveRoom(hotelRoom.TypeId);
            }
            foreach (var hotelSettlement in hotelSettlements)
            {
                hotel.RemoveSettlement(hotelSettlement);
            }
            var clients = new Dictionary<int, Departament>();
            var rooms = new Dictionary<int, InsuranceTypes>();
            int maxClientId = 0;
            foreach (var client in hotelSerializable.Clients)
            {
                if (client.DepId > maxClientId) maxClientId = client.DepId;
                clients.Add(client.DepId, client);
                hotel.AddClient(client);
            }
            foreach (var room in hotelSerializable.Rooms)
            {
                rooms.Add(room.TypeId, room);
                hotel.AddRoom(room);
            }
            foreach (var settlement in hotelSerializable.Settlements)
            {
                hotel.AddSettlement(new Contract
                {

                    NumberContract = settlement.NumberContract,
                    Date = settlement.Date,
                    InsuranceAmount = settlement.InsuranceAmount,
                    TariffRate = settlement.TariffRate,

                    LocalDepartament = clients[settlement.LocalDepartamentId],
                    LocalInsuranceTypes = rooms[settlement.LocalInsuranceTypesId],
                   
                   
                  
                });
                Departament.depId = maxClientId;
            }
           
        }

    }
}
