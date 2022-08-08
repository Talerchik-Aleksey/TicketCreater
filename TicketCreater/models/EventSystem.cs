namespace TicketCreater.models
{
    static class EventSystem
    {
        private static int type = 0;
        private static string name = "TITLE";
        private static string description = "DESCRIPTION";

        public static int Type { get => type; set => type = value; }
        public static string Name { get => name; set => name = value; }
        public static string Description { get => description; set => description = value; }
    }
}
