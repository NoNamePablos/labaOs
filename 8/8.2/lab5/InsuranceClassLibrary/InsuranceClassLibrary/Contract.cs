using System;

namespace InsuranceClassLibrary
{
    [Serializable]
    public class Contract : IValidatable
    {
        /// <summary>
        /// Номер контракта
        /// </summary>
        public string NumberContract { get; set; } = "";
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;
        /// <summary>
        /// Страх колво
        /// </summary>
        public long InsuranceAmount { get; set; } = 0;
        /// <summary>
        /// Тарифная ставка
        /// </summary>
        public long TariffRate { get; set; } = 0;
        /// <summary>
        /// Департамент
        /// </summary>
        public Departament LocalDepartament { get; set; }
        /// <summary>
        ///Тип страховнаия
        /// </summary>
        public InsuranceTypes LocalInsuranceTypes { get; set; }
     
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(NumberContract)) return false;
                if (InsuranceAmount<0) return false;
                if (TariffRate < 0) return false;
                if (LocalDepartament == null) return false;

                return true;
            }
        }


        public Contract()
        {

        }
        /// <summary>
         ///Конструктор
         /// </summary>

        public Contract(string numCntr, DateTime startDate,long insAmount,long trRate,Departament dep, InsuranceTypes type)
        {
            NumberContract = numCntr;

            Date = startDate;
            InsuranceAmount = insAmount;
            TariffRate = trRate;
            LocalDepartament = dep;
            LocalInsuranceTypes = type;
        }

        public override string ToString()
        {
            return $"Номер договора - {NumberContract}\r\nДата заключения сделки - {Date}\r\nСтраховая сумма: {InsuranceAmount}\r\nТарифная ставка - {TariffRate}\r\nФилиал-{LocalDepartament}\r\nТип страхования - {LocalInsuranceTypes}\r\n";
        }
    }


}

