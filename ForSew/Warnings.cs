namespace ForSew
{
    /// <summary>
    /// 
    /// </summary>
    public class Warnings
    {
        public const string FileNotExist = "Файл {0} не существует";
        public const string InstrumentsDontParse = "Ошибка определения инструментов в файле: {0}";

        public const string ShortLine = "Строка короче поисковых слов: {0}";
        
        public const string DealDontParsed = "Ошибка парсинга Сделки. Файл: '{0}', строка: '{1}'";
        public const string DealDateTimeDontParsed = "Ошибка парсинга ДатыВремяСделки. Исходный текст: {0}";
        public const string DealTypeDontParsed = "Ошибка парсинга ТипаСделки. Исходный текст: {0}";
        public const string DealAmontDontParsed = "Ошибка парсинга СуммаСделки. Исходный текст: {0}";

    }
}
