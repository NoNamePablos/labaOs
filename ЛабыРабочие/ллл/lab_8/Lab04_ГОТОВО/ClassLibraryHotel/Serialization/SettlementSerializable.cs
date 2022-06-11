using System;
using lab4;

namespace ClassLibraryHotel.Serialization
{
    [Serializable]
    public class WorksSerializable
    {
        public TypeOfWorksEnum TypeWork { get; set; }
        public int EmployeeId { get; set; }
        /// <summary>
        /// Дата начала проживания
        /// </summary>
        public DateTime StartDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата окончания проживания
        /// </summary>
        public DateTime EndDate { get; set; } = DateTime.Now;
    }
}
