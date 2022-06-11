using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ClassLibraryHotel.Serialization
{
    [Serializable]
    public class HotelSerializable
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<SettlementSerializable> Settlements { get; set; } = new List<SettlementSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            var hotelSerializable = new HotelSerializable();
            var hotel = Hotel.Instance;
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
                hotelSerializable.Settlements.Add(new SettlementSerializable
                {
                    ClientId = settlement.Client.ClientId,
                    RoomId = settlement.Room.Number,
                    StartDate = settlement.StartDate,
                    EndDate = settlement.EndDate
                });
            }
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(HotelSerializable));
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
            HotelSerializable hotelSerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(HotelSerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    hotelSerializable = (HotelSerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    hotelSerializable = (HotelSerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(HotelSerializable));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    hotelSerializable = (HotelSerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var hotel = Hotel.Instance;
            var hotelClients = hotel.Clients.ToList();
            var hotelRooms = hotel.Rooms.ToList();
            var hotelSettlements = hotel.Settlements.ToList();
            foreach (var hotelClient in hotelClients)
            {
                hotel.RemoveClient(hotelClient.ClientId);
            }
            foreach (var hotelRoom in hotelRooms)
            {
                hotel.RemoveRoom(hotelRoom.Number);
            }
            foreach (var hotelSettlement in hotelSettlements)
            {
                hotel.RemoveSettlement(hotelSettlement);
            }
            var clients = new Dictionary<int, Client>();
            var rooms = new Dictionary<int, Room>();
            int maxClientId = 0;
            foreach (var client in hotelSerializable.Clients)
            {
                if (client.ClientId > maxClientId) maxClientId = client.ClientId;
                clients.Add(client.ClientId, client);
                hotel.AddClient(client);
            }
            foreach (var room in hotelSerializable.Rooms)
            {
                rooms.Add(room.Number, room);
                hotel.AddRoom(room);
            }
            foreach (var settlement in hotelSerializable.Settlements)
            {
                hotel.AddSettlement(new Settlement
                {
                    Client = clients[settlement.ClientId],
                    Room = rooms[settlement.RoomId],
                    StartDate = settlement.StartDate,
                    EndDate = settlement.EndDate
                });
            }
            Client.NewClientId = maxClientId;
        }
    }
}