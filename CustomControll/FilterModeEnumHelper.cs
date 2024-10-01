namespace CustomControll;

public static class FilterModeEnumHelper
{
    // Возвращаем коллекцию отображаемых строк для каждого элемента FilterMode
    public static IEnumerable<string> GetDisplayNames()
    {
        return Enum.GetValues(typeof(FilterMode))
                   .Cast<FilterMode>()
                   .Select(mode => GetDisplayName(mode));
    }

    // Метод для получения отображаемого имени для каждого значения перечисления
    public static string GetDisplayName(FilterMode mode)
    {
        return mode switch
        {
            FilterMode.Equals => "==",
            FilterMode.NotEquals => "!=",
            _ => mode.ToString(), // По умолчанию возвращаем имя элемента Enum
        };
    }
}
