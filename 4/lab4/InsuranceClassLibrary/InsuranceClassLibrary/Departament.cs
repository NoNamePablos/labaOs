using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InsuranceClassLibrary
{
    public class Departament: IValidatable
    {
      

             /// <summary>
            /// Филиал найм
            /// </summary>
            public string depName { get; set; } = "";

        /// <summary>
        /// Адрес
        /// </summary>
        public string address { get; set; } = "";
        /// <summary>
        /// Телефон
        /// </summary>
        public string telephone { get; set; } = "";

        public bool IsValid
            {
                get
                {
                    if (string.IsNullOrWhiteSpace(depName)) return false;
                    if (string.IsNullOrWhiteSpace(address)) return false;
                    if (string.IsNullOrWhiteSpace(telephone)) return false;
                    return true;
                }
            }

            public Departament()
            {

            }
        /// <summary>
        /// конструктор
        /// </summary>
        public Departament(string depName, string address, string telephone )
            {
            this.depName = depName;
            this.address = address;
            this.telephone = telephone;
            }

            public override string ToString()
            {
                return $"Департамент: {depName}\r\nТелефон: {telephone}\r\nАдрес: {address}\r\n";
            }
        }
    }


