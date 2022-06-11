using System;

namespace lab4
{
 
    public class Works : IValidatable
    {
        //Сотрудник класс
        public Employee Employee { get; set; } 
        // Вид работы класс
        public TypeOfWorks TypeOfWorks { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; } = DateTime.Today;


        public bool IsValid
        {
            get
            {
                if (Employee == null) return false;
                if (TypeOfWorks == null) return false;
                if (EndDate <= StartDate) return false;
                return true;
            }
        }

        public Works()
        {

        }

        public Works(Employee employee, TypeOfWorks typeofworks, DateTime startDate, DateTime endDate)
        {
            Employee = employee;
            TypeOfWorks = typeofworks;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"Сотрудник - {Employee}\r\nТип работы - {TypeOfWorks}\r\nПериод: {StartDate}-{EndDate}\r\n";
        }

    }
}
