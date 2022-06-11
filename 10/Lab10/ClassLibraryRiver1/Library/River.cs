using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRiver.Library
{
    public class River
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Площадь
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Наибольшая глубина
        /// </summary>
        public int MaxDepth { get; set; }
    }
}
