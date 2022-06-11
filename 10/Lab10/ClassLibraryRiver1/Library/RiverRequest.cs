using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRiver.Library
{
   public class RiverRequest
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public RiverRequestType Type { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Информация о море
        /// </summary>
        public River River { get; set; }
    }
}
