using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceClassLibrary.Exception;

namespace InsuranceClassLibrary
{
    public class Insurance
    {


        private static Insurance _instance;

        public static Insurance Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Insurance();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private Insurance()
        {

        }

        /// <summary>
        /// Коллекция филиалов
        /// </summary>
        public IEnumerable<Departament> Clients
        {
            get { return _clients.Values.AsEnumerable(); }
        }

        /// <summary>
        /// Коллекция типов страхования
        /// </summary>
        public IEnumerable<InsuranceTypes> Rooms
        {
            get
            {
                return _rooms.Values.AsEnumerable();
            }
        }

        /// <summary>
        /// Коллекция поселений
        /// </summary>
        public IEnumerable<Contract> Settlements
        {
            get
            {
                return _settlements;
            }
        }

        public event EventHandler ClientAdded;
        public event EventHandler RoomAdded;
        public event EventHandler SettlementAdded;
        public event EventHandler ClientRemoved;
        public event EventHandler RoomRemoved;
        public event EventHandler SettlementRemoved;

        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// <param name="Departament">Информация о клиенте</param>
        public void AddClient(Departament client)
        {
            if (!client.IsValid)
            {
                throw new InvalidDepartamentException ("Информация о клиент заполнена некорректно");
            }
            try
            {
                _clients.Add(client.DepId, client);
                //Герерируем событие о том, что клиент добавлен
                ClientAdded?.Invoke(client, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidDepartamentException("При добавлении клиента произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление типа
        /// </summary>
        /// <param name="InsurancyTypes">Информация о номере</param>
        public void AddRoom(InsuranceTypes room)
        {
            if (!room.IsValid)
            {
                throw new InvalidInsuranceTypesException("Информация о номере заполнена некорректно");
            }
            try
            {
                _rooms.Add(room.TypeId, room);
                //Герерируем событие о том, что номер добавлен
                RoomAdded?.Invoke(room, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidInsuranceTypesException("При добавлении номера произошла ошибка", exception);
            }
        }

        /// <summary>
        /// Информация о поселении
        /// </summary>
        /// <param name="settlement"></param>
        public void AddSettlement(Contract settlement)
        {
            if (!settlement.IsValid)
            {
                throw new InvalidContarctException("Информация о заселении заполнена некорректно");
            }
            try
            {
                _settlements.Add(settlement);
                //Герерируем событие о том, что информация о поселении добавлена
                SettlementAdded?.Invoke(settlement, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidContarctException("При поселении произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить клиента по идентификатору
        /// </summary>
        /// <param name="clientKey">Идентификатор клиента</param>
        public void RemoveClient(int clientKey)
        {
            _clients.Remove(clientKey);
            //Генерируем событие о том, что клиент удалён
            ClientRemoved?.Invoke(clientKey, EventArgs.Empty);
            //Получаем список сведений о поселении клиента
            var settlementsForClient = Settlements.Where(s => s.LocalDepartament.DepId == clientKey).ToList();
            for (int i = 0; i < settlementsForClient.Count; i++)
            {
                //Удаляем сведения о поселении клиента
                RemoveSettlement(settlementsForClient[i]);
            }
        }

        /// <summary>
        /// Удалить номер по идентификатору
        /// </summary>
        /// <param name="roomKey"></param>
        public void RemoveRoom(int roomKey)
        {
            _rooms.Remove(roomKey);
            //Генерируем событие о том, что номер удалён
            RoomRemoved?.Invoke(roomKey, EventArgs.Empty);
            //Получаем список сведений о поселении в номер
            var settlementsForRoom = Settlements.Where(s => s.LocalInsuranceTypes.TypeId == roomKey).ToList();
            for (int i = 0; i < settlementsForRoom.Count; i++)
            {
                //Удаляем сведения о поселении в номер
                RemoveSettlement(settlementsForRoom[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о поселении
        /// </summary>
        /// <param name="settlement">Информация о поселении</param>
        public void RemoveSettlement(Contract settlement)
        {
            _settlements.Remove(settlement);
            //Генерируем событие о том, что информация о поселении удалена
            SettlementRemoved?.Invoke(settlement, EventArgs.Empty);
        }



        /// <summary>
        /// Словарь клиентов
        /// </summary>
        private static Dictionary<int, Departament> _clients { get; } = new Dictionary<int, Departament>();
        /// <summary>
        /// Словарь комнат
        /// </summary>
        /// 
        private static Dictionary<int, InsuranceTypes> _rooms { get; } = new Dictionary<int, InsuranceTypes>();
        //public static List<InsuranceTypes> Rooms { get; } = new List<InsuranceTypes>();

        /// <summary>
        /// Спосок поселений
        /// </summary>
        private static List<Contract> _settlements { get; } = new List<Contract>();
    }
}

    
