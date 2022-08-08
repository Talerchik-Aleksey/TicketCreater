using MyProg;

namespace TicketCreater.models
{
    internal static class Settings
    {
        public const string IniPath = "../../../settings.ini";

        public static string? Subject { get; set; }
        public static string? Group { get; set; }
        public static bool TicketDesign { get; set; }
        public static string? EducateInstitution { get; set; }
        public static string? EducationRegion { get; set; }


        internal static void ReadSettingsFromIniFile()
        {
            try
            {
                var iniFile = new IniFile(IniPath);
                EducateInstitution = iniFile.KeyExists("EducateInstitution") ?
                                        iniFile.Read("EducateInstitution") : "";

                EducationRegion = iniFile.KeyExists("EducationRegion") ?
                         iniFile.Read("EducationRegion") : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
