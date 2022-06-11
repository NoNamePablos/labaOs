
namespace lab4
{
    public class Employee : IValidatable
    {
        private static int _newEmployeeId;

        private static int NewEmployeeId
        {
            get
            {
                _newEmployeeId++;
                return _newEmployeeId;
            }
        }
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public int EmployeeId { get; }


        /// Имя
        public string FirstName { get; set; } = "";

        /// Отчество
        public string MiddleName { get; set; } = "";


        /// Фамилия
        public string LastName { get; set; } = "";

        public decimal Salary { get; set; } = 0;

        // проверка на заполненость
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (Salary < 0) return false;
                return true;
            }
        }

        public Employee()
        {
            EmployeeId = NewEmployeeId;
        }

        public Employee(string firstName, string lastName, string middleName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Salary = salary;
            EmployeeId = NewEmployeeId;
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName}\r\nИмя: {FirstName}\r\nОтчество: {MiddleName}\r\n";
        }

    }
}


