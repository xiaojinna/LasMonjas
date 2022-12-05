using static LasMonjas.Languages.English;
using static LasMonjas.Languages.Japanese;
using static LasMonjas.Languages.Spanish;
using static LasMonjas.Languages.Chinese;
using AmongUs.Data.Legacy;

namespace LasMonjas.Languages
{
    public class Language
    {
        public static string[] colorNames;

        public static string[] customOptionNames;

        public static string[] roleInfoNames;

        public static string[] exileControllerTexts;

        public static string[] introTexts;

        public static string[] playerControlTexts;

        public static string[] usablesTexts;

        public static string[] buttonsTexts;

        public static string[] helpersTexts;

        public static string[] statusRolesTexts;

        public static string[] statusCaptureTheFlagTexts;

        public static string[] statusPoliceAndThiefsTexts;

        public static string[] statusKingOfTheHillTexts;

        public static string[] statusHotPotatoTexts;

        public static string[] statusZombieLaboratoryTexts;

        public static string[] statusBattleRoyaleTexts;
        public static string[] Rolesnames;
        public static string nextpage;
        public static bool tolanguagename;
        public static int AmongUslang;
        public static void autolang()
        {
            AmongUslang = (int)LegacySaveManager.LastLanguage;
            LasMonjasPlugin.modLanguage.Value = AmongUslang;
            LoadLanguage();
        }
        public static void LoadLanguage() {
            switch (LasMonjasPlugin.modLanguage.Value)
            {
                // English
                case 0:
                    Englishlang();
                    break;
                // Japanese
                case 11:
                    Japaneselang();
                    break;
                // Spanish
                case 12:
                    Spanishlang();
                    break;
                // Chinese
                case 13:
                    Chineselang();
                    break;
            }
        }
    }
}