using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InsuranceClassLibrary
{
    [Serializable]
    public class Departament: IValidatable
    {


        /// <summary>
        /// Филиал найм
        /// </summary>
        /// 
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
        public int DepId { get; }

        public string DepName { get; set; } = "";

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; } = "";
        /// <summary>
        /// Телефон
        /// </summary>
        public string Telephone { get; set; } = "";

        public bool IsValid
            {
                get
                {
                    if (string.IsNullOrWhiteSpace(DepName)) return false;
                    if (string.IsNullOrWhiteSpace(Address)) return false;
                    if (string.IsNullOrWhiteSpace(Telephone)) return false;
                    return true;
                }
            }

        public static int depId { get; internal set; }

        public Departament()
            {
            DepId = NewDepId;
            }
        /// <summary>
        /// конструктор
        /// </summary>
        public Departament(string depName, string address, string telephone )
            {
            this.DepName = depName;
            this.Address = address;
            this.Telephone = telephone;
            DepId = NewDepId;
        }

            public override string ToString()
            {
                return $"Департамент: {DepName}\r\nТелефон: {Telephone}\r\nАдрес: {Address}\r\n";
            }
        }
    }


