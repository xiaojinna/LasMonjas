using static LasMonjas.Languages.English;
using static LasMonjas.Languages.Japanese;
using static LasMonjas.Languages.Spanish;
using static LasMonjas.Languages.Chinese;

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
        public static int AmongUslang;
        public static void LoadLanguage() {
            AmongUslang = (int)AmongUs.Data.DataManager.settings.language.CurrentLanguage;
            switch (LasMonjasPlugin.modLanguage.Value) {
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