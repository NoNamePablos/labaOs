using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InsuranceClassLibrary
{
    public class Insurance
    {
        /// <summary>
        /// Словарь клиентов
        /// </summary>
        public static Dictionary<int, Departament> Clients { get; } = new Dictionary<int, Departament>();
        /// <summary>
        /// Словарь комнат
        /// </summary>
        /// 
        public static Dictionary<int, InsuranceTypes> Rooms { get; } = new Dictionary<int, InsuranceTypes>();
        //public static List<InsuranceTypes> Rooms { get; } = new List<InsuranceTypes>();

        /// <summary>
        /// Спосок поселений
        /// </summary>
        public static List<Contract> Settlements { get; } = new List<Contract>();
    }
}

    
