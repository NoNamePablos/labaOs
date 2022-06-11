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
        public string InsuranceType { get; set; } = "";
        
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
        public int TypeId { get; }
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(InsuranceType)) return false;
                return true;
            }
        }
        public InsuranceTypes() {
            TypeId = NewDepId;
        }
        public InsuranceTypes(string insType) {
            InsuranceType = insType;
            TypeId = NewDepId;
        }
        public override string ToString()
        {
            return $"{InsuranceType}\r\n";
        }
    }
}
    

