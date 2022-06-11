namespace ClassLibrarySeas
{
    /// <summary>
    /// Ответ от справочника морей
    /// </summary>
    public class SeaResponse
    {
        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Признак успешного выполнения запроса
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Информация о городе
        /// </summary>
        public Sea Sea { get; set; }
    }
}
