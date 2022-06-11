using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClassLibrary.Serialization
{
    [Serializable]
   public class ContractSerialization
    {
        public string NumberContract { get; set; }
        /// <summary>
        /// Дата начала проживания
        /// </summary>
        /// 
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
        public int LocalDepartamentId { get; set; }
        /// <summary>
        ///Тип страховнаия
        /// </summary>
        public int LocalInsuranceTypesId { get; set; }

    }
}
