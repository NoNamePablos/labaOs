using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClassLibrary
{


    /// <summary>
    /// Типы страхования
    /// </summary>
    //public enum InsyranceTypes {
    //    PersonInsuarance, 
    //    PropertyInsurance
    //}
    public class InsuranceTypes : IValidatable {
        public string insuranceType { get; set; } = "";
        
        private static int _newDepId;

        private static int NewDepId
        {
            get
            {
                _newDepId++;
                return _newDepId;
            }
        }
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public int typeId { get; }
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(insuranceType)) return false;
                return true;
            }
        }
        public InsuranceTypes() {
            typeId = NewDepId;
        }
        public InsuranceTypes(string insType) {
            insuranceType = insType;
            typeId = NewDepId;
        }
        public override string ToString()
        {
            return $"{insuranceType}\r\n";
        }
    }
}
    

