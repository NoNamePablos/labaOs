using System;

namespace ClassLibraryHotel.Serialization
{
    [Serializable]
    public class SettlementSerializable
    {
        public int RoomId { get; set; }
        public int ClientId { get; set; }
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
