using System;

namespace InsuranceClassLibrary
{
    public class Contract : IValidatable
    {
        /// <summary>
        /// Номер контракта
        /// </summary>
        public string numberContract { get; set; } = "";
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime date { get; set; } = DateTime.Now;
        /// <summary>
        /// Страх колво
        /// </summary>
        public long insuranceAmount { get; set; } = 0;
        /// <summary>
        /// Тарифная ставка
        /// </summary>
        public long tariffRate { get; set; } = 0;
        /// <summary>
        /// Департамент
        /// </summary>
        public Departament localDepartament { get; set; }
        /// <summary>
        ///Тип страховнаия
        /// </summary>
        public InsyranceTypes LocalInsuranceTypes { get; set; }
     
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(numberContract)) return false;
                if (insuranceAmount<0) return false;
                if (tariffRate < 0) return false;
                if (localDepartament == null) return false;

                return true;
            }
        }


        public Contract()
        {

        }
        /// <summary>
         ///Конструктор
         /// </summary>

        public Contract(string numCntr, DateTime startDate,long insAmount,long trRate,Departament dep, InsyranceTypes type)
        {
            numberContract = numCntr;

            date = startDate;
            insuranceAmount = insAmount;
            tariffRate = trRate;
            localDepartament = dep;
            LocalInsuranceTypes = type;
        }

        public override string ToString()
        {
            return $"Номер договора - {numberContract}\r\nДата заключения сделки - {date}\r\nСтраховая сумма: {insuranceAmount}\r\nТарифная ставка - {tariffRate}\r\nФилиал-{localDepartament}\r\nТип страхования - {LocalInsuranceTypes}\r\n";
        }
    }


}

