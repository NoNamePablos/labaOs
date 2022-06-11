using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{

    /// <summary>
    /// job
    /// </summary>
   
    public class Job
    {
        private static Job _instance;
        /// <summary>
        /// Единственный экземпляр класса Отель
        /// </summary>
        public static Job Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Job();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private Job()
        {

        }
        /// <summary>
        /// Словарь клиентов
        /// </summary>
        private Dictionary<int, Employee> _employee = new Dictionary<int, Employee>();
        /// <summary>
        /// Словарь номеров
        /// </summary>
        private Dictionary<TypeOfWorksEnum, TypeOfWorks> _typeOfWorks = new Dictionary<TypeOfWorksEnum, TypeOfWorks>();
        /// <summary>
        /// Спосок поселений
        /// </summary>
        private List<Works> _works = new List<Works>();

        /// <summary>
        /// Коллекция клиентов
        /// </summary>
        public IEnumerable<Employee> Employees
        {
            get { return _employee.Values.AsEnumerable(); }
        }
        /// <summary>
        /// Коллекция номеров
        /// </summary>
        public IEnumerable<TypeOfWorks> TypeOfWorks
        {
            get
            {
                return _typeOfWorks.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция поселений
        /// </summary>
        public IEnumerable<Works> Works
        {
            get
            {
                return _works;
            }
        }

        public event EventHandler EmployeeAdded;
        public event EventHandler TypeOfWorksAdded;
        public event EventHandler WorksAdded;
        public event EventHandler EmployeeRemoved;
        public event EventHandler TypeOfWorksRemoved;
        public event EventHandler WorksRemoved;
        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// 
        public void AddEnployee(Employee employee)
        {
            if (!employee.IsValid)
            {
                throw new InvalidEmployeeException("Информация о клиент заполнена некорректно");
            }
            try
            {
                _employee.Add(employee.EmployeeId, employee);
                //Герерируем событие о том, что клиент добавлен
                EmployeeAdded?.Invoke(employee, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidEmployeeException("При добавлении клиента произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление номера
        /// </summary>
        /// 
        public void AddTOW(TypeOfWorks typeOfWorks)
        {
            if (!typeOfWorks.IsValid)
            {
                throw new InvalidTOWException("Информация о номере заполнена некорректно");
            }
            try
            {
                _typeOfWorks.Add(typeOfWorks.TypeWork, typeOfWorks);
                //Герерируем событие о том, что номер добавлен
                TypeOfWorksAdded?.Invoke(typeOfWorks, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidTOWException("При добавлении номера произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Информация о поселении
        /// </summary>
        ///
        public void AddWorks(Works works)
        {
            if (!works.IsValid)
            {
                throw new InvalidWorksException("Информация о заселении заполнена некорректно");
            }
            try
            {
                _works.Add(works);
                //Герерируем событие о том, что информация о поселении добавлена
                WorksAdded?.Invoke(works, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidWorksException("При поселении произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить клиента по идентификатору
        /// </summary>
        /// <param name="clientKey">Идентификатор клиента</param>
        public void RemoveEmployee(int clientKey)
        {
            _employee.Remove(clientKey);
            //Генерируем событие о том, что клиент удалён
            EmployeeRemoved?.Invoke(clientKey, EventArgs.Empty);
            //Получаем список сведений о поселении клиента
            var worksForEmployee = Works.Where(s => s.Employee.EmployeeId == clientKey).ToList();
            for (int i = 0; i < worksForEmployee.Count; i++)
            {
                //Удаляем сведения о поселении клиента
                RemoveWorks(worksForEmployee[i]);
            }
        }

        /// <summary>
        /// Удалить номер по идентификатору
        /// </summary>
        /// <param name="roomKey"></param>
        public void RemoveTOW(TypeOfWorksEnum typeWork)
        {
            _typeOfWorks.Remove(typeWork);
            //Генерируем событие о том, что номер удалён
            TypeOfWorksRemoved?.Invoke(typeWork, EventArgs.Empty);
            //Получаем список сведений о поселении в номер
            var worksForTOW = Works.Where(s => s.TypeOfWorks.TypeWork == typeWork).ToList();
            for (int i = 0; i < worksForTOW.Count; i++)
            {
                //Удаляем сведения о поселении в номер
                RemoveWorks(worksForTOW[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о поселении
        /// </summary>
        /// <param name="settlement">Информация о поселении</param>
        public void RemoveWorks(Works works)
        {
            _works.Remove(works);
            //Генерируем событие о том, что информация о поселении удалена
            WorksRemoved?.Invoke(works, EventArgs.Empty);
        }
    }


}

