namespace ClassLibrarySeas
{
    public class SeaRequest
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public SeaRequestType Type { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Информация о море
        /// </summary>
        public Sea Sea { get; set; }
    }
}
