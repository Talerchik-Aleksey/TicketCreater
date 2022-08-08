namespace TicketCreater.models
{
    internal static class YearsParser
    {

        public static void ParseYears()
        {
            DateTime dateTime = DateTime.Now;

            if (dateTime.Month < 9)
            {
                StartEndYears.StartYear = dateTime.AddYears(-1).Year;
                StartEndYears.EndYear = dateTime.Year;
            }
        }
    }
}
