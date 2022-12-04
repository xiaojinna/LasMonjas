using UnityEngine;
using LasMonjas.Core;

namespace LasMonjas
{
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "100%"};
        public static string[] presets = new string[]{"Roles", "Capture the Flag", "Police and Thieves", "King of the Hill", "Hot Potato", "Zombie Laboratory", "Battle Royale", "Preset 8", "Preset 9", "Preset 10" };

        // Game Options
        public static CustomOption presetSelection;

        // Global Settings
        public static CustomOption globalSettings;
        public static CustomOption activateRoles;
        public static CustomOption activateSenseiMap;
        public static CustomOption hideVentAnimOnShadows;
        public static CustomOption whoAmIMode;

        // Roles Settings
        public static CustomOption rolesSettings;
        public static CustomOption removeSwipeCard;
        public static CustomOption removeAirshipDoors;
        public static CustomOption nightVisionLightSabotage;
        public static CustomOption screenShakeReactorSabotage;
        public static CustomOption anonymousCommsSabotage;
        public static CustomOption slowSpeedOxigenSabotage;

        // Modifiers
        public static CustomOption activateModifiers;
        public static CustomOption loverPlayer;
        public static CustomOption lighterPlayer;
        public static CustomOption blindPlayer;
        public static CustomOption flashPlayer;
        public static CustomOption bigchungusPlayer;
        public static CustomOption theChosenOnePlayer;
        public static CustomOption theChosenOneReportDelay;
        public static CustomOption performerPlayer;
        public static CustomOption performerDuration;
        public static CustomOption proPlayer;
        public static CustomOption paintballPlayer;
        public static CustomOption paintballDuration;
        public static CustomOption electricianPlayer;
        public static CustomOption electricianDuration;

        // Capture the flag
        public static CustomOption captureTheFlagMode;
        public static CustomOption flagMatchDuration;
        public static CustomOption requiredFlags;
        public static CustomOption flagKillCooldown;
        public static CustomOption flagReviveTime;
        public static CustomOption flagInvincibilityTimeAfterRevive;

        // Police And Thief
        public static CustomOption policeAndThiefMode;
        public static CustomOption thiefModeMatchDuration;
        public static CustomOption thiefModerequiredJewels;
        public static CustomOption thiefModePoliceKillCooldown;
        public static CustomOption thiefModePoliceTaseCooldown;
        public static CustomOption thiefModePoliceTaseDuration;
        public static CustomOption thiefModePoliceCanSeeJewels;
        public static CustomOption thiefModePoliceCatchCooldown;
        public static CustomOption thiefModecaptureThiefTime;
        public static CustomOption thiefModepolicevision;
        public static CustomOption thiefModePoliceReviveTime;
        public static CustomOption thiefModeWhoCanThiefsKill;
        public static CustomOption thiefModeKillCooldown;
        public static CustomOption thiefModeThiefReviveTime;
        public static CustomOption thiefModeInvincibilityTimeAfterRevive;

        // King of the hill
        public static CustomOption kingOfTheHillMode;
        public static CustomOption kingMatchDuration;
        public static CustomOption kingRequiredPoints;
        public static CustomOption kingCaptureCooldown;
        public static CustomOption kingKillCooldown;
        public static CustomOption kingCanKill;
        public static CustomOption kingReviveTime;
        public static CustomOption kingInvincibilityTimeAfterRevive;

        // Hot Potato
        public static CustomOption hotPotatoMode;
        public static CustomOption hotPotatoMatchDuration;
        public static CustomOption hotPotatoTransferLimit;
        public static CustomOption hotPotatoCooldown;
        public static CustomOption hotPotatoNotPotatovision;
        public static CustomOption hotPotatoResetTimeForTransfer;
        public static CustomOption hotPotatoIncreaseTimeIfNoReset;

        // ZombieLaboratory
        public static CustomOption zombieLaboratoryMode;
        public static CustomOption zombieLaboratoryMatchDuration;
        public static CustomOption zombieLaboratoryStartZombies;
        public static CustomOption zombieLaboratoryInfectCooldown;
        public static CustomOption zombieLaboratoryKillCooldown;
        public static CustomOption zombieLaboratoryReviveTime;
        public static CustomOption zombieLaboratoryInvincibilityTimeAfterRevive;
        public static CustomOption zombieLaboratoryInfectTime;
        public static CustomOption zombieLaboratoryMaxTimeForHeal;
        public static CustomOption zombieLaboratorySurvivorsVision;
        public static CustomOption zombieLaboratorySearchBoxTimer;

        // BattleRoyale
        public static CustomOption battleRoyaleMode;
        public static CustomOption battleRoyaleMatchDuration;
        public static CustomOption battleRoyaleMatchType;
        public static CustomOption battleRoyaleKillCooldown;
        public static CustomOption battleRoyaleLifes;
        public static CustomOption battleRoyaleScoreNeeded;
        public static CustomOption battleRoyaleReviveTime;
        public static CustomOption battleRoyaleInvincibilityTimeAfterRevive;

        // Impostors configurable options

        // Mimic
        public static CustomOption mimicSpawnRate;
        public static CustomOption mimicDuration;

        // Painter
        public static CustomOption painterSpawnRate;
        public static CustomOption painterCooldown;
        public static CustomOption painterDuration;

        // Demon
        public static CustomOption demonSpawnRate;
        public static CustomOption demonKillDelay;
        public static CustomOption demonCanKillNearNuns;

        // Janitor
        public static CustomOption janitorSpawnRate;
        public static CustomOption janitorCooldown;

        // Illusionist
        public static CustomOption illusionistSpawnRate;
        public static CustomOption illusionistPlaceHatCooldown;
        public static CustomOption illusionistLightsOutCooldown;
        public static CustomOption illusionistLightsOutDuration;

        // Manipulator
        public static CustomOption manipulatorSpawnRate;

        // Bomberman
        public static CustomOption bombermanSpawnRate;
        public static CustomOption bombermanBombCooldown;

        // Chameleon
        public static CustomOption chameleonSpawnRate;
        public static CustomOption chameleonCooldown;
        public static CustomOption chameleonDuration;

        // Gambler
        public static CustomOption gamblerSpawnRate;
        public static CustomOption gamblerNumberOfShots;
        public static CustomOption gamblerCanCallEmergency;
        public static CustomOption gamblerCanShootMultipleTimes;
        public static CustomOption gamblerCanKillThroughShield;

        // Sorcerer
        public static CustomOption sorcererSpawnRate;
        public static CustomOption sorcererCooldown;
        public static CustomOption sorcererAdditionalCooldown;
        public static CustomOption sorcererSpellDuration;
        public static CustomOption sorcererCanCallEmergency;

        // Medusa
        public static CustomOption medusaSpawnRate;
        public static CustomOption medusaCooldown;
        public static CustomOption medusaDelay;
        public static CustomOption medusaDuration;

        // Hypnotist
        public static CustomOption hypnotistSpawnRate;
        public static CustomOption hypnotistCooldown;
        public static CustomOption hypnotistNumberOfSpirals;
        public static CustomOption hypnotistSpiralsDuration;
        
        // Archer
        public static CustomOption archerSpawnRate;
        public static CustomOption archerShotSize;
        public static CustomOption archerShotRange;
        public static CustomOption archerNoticeRange;
        public static CustomOption archerAimAssistDuration;

        // Plumber
        public static CustomOption plumberSpawnRate;
        public static CustomOption plumberCooldown;
        public static CustomOption plumberVentNumber;

        public static CustomOption librarianSpawnRate;
        public static CustomOption librarianCooldown;
        
        
        // Rebels configurable options

        // Renegade & Minion
        public static CustomOption renegadeSpawnRate;
        public static CustomOption renegadeCanUseVents;
        public static CustomOption renegadeCanRecruitMinion;    

        // Bountyhunter
        public static CustomOption bountyHunterSpawnRate;

        // Trapper
        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMineNumber;
        public static CustomOption trapperMineDuration; 
        public static CustomOption trapperTrapNumber;
        public static CustomOption trapperTrapDuration;

        // Yinyanger
        public static CustomOption yinyangerSpawnRate;
        public static CustomOption yinyangerCooldown;

        // Challenger
        public static CustomOption challengerSpawnRate;
        public static CustomOption challengerCooldown;
        public static CustomOption challengerKillsForWin;

        // Ninja
        public static CustomOption ninjaSpawnRate;

        // Berserker
        public static CustomOption berserkerSpawnRate;
        public static CustomOption berserkerTimeToKill;

        // Yandere
        public static CustomOption yandereSpawnRate;
        public static CustomOption yandereCooldown;
        public static CustomOption yandereStareTimes;
        public static CustomOption yandereStareDuration;

        // Stranded
        public static CustomOption strandedSpawnRate;

        // Monja
        public static CustomOption monjaSpawnRate;


        // Neutral configurable options

        // Joker
        public static CustomOption jokerSpawnRate;
        public static CustomOption jokerCanSabotage;

        // Role Thief
        public static CustomOption rolethiefSpawnRate;
        public static CustomOption rolethiefCooldown;

        // Pyromaniac
        public static CustomOption pyromaniacSpawnRate;
        public static CustomOption pyromaniacCooldown;
        public static CustomOption pyromaniacDuration;

        // Treasure Hunter
        public static CustomOption treasureHunterSpawnRate;
        public static CustomOption treasureHunterTreasureNumber;

        // Devourer
        public static CustomOption devourerSpawnRate;
        public static CustomOption devourerBodiesNumber;

        // Poisoner
        public static CustomOption poisonerSpawnRate;
        public static CustomOption poisonerDuration;
        public static CustomOption poisonerInfectRange;
        public static CustomOption poisonerInfectDuration;
        public static CustomOption poisonerCanSabotage;

        // Puppeteer
        public static CustomOption puppeteerSpawnRate;
        public static CustomOption puppeteerNumberOfKills;

        // Exiler
        public static CustomOption exilerSpawnRate;

        // Amnesiac
        public static CustomOption amnesiacSpawnRate;

        // Seeker
        public static CustomOption seekerSpawnRate;
        public static CustomOption seekerCooldown;
        public static CustomOption seekerPointsNumber;


        // Crewmates configurable options

        // Captain
        public static CustomOption captainSpawnRate;
        public static CustomOption captainCanSpecialVoteOneTime;

        // Mechanic
        public static CustomOption mechanicSpawnRate;
        public static CustomOption mechanicNumberOfRepairs;
        public static CustomOption mechanicExpertRepairs;

        // Sheriff
        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCanKillNeutrals;

        // Detective
        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveShowFootprints;
        public static CustomOption detectiveCooldown;
        public static CustomOption detectiveShowFootPrintDuration;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;

        // Forensic
        public static CustomOption forensicSpawnRate;
        public static CustomOption forensicReportNameDuration;
        public static CustomOption forensicReportColorDuration;
        public static CustomOption forensicReportClueDuration;
        public static CustomOption forensicDuration;
        public static CustomOption forensicOneTimeUse;

        // TimeTraveler
        public static CustomOption timeTravelerSpawnRate;
        public static CustomOption timeTravelerCooldown;
        public static CustomOption timeTravelerRewindTime;
        public static CustomOption timeTravelerShieldDuration;
        public static CustomOption timeTravelerReviveDuringRewind;

        // Squire
        public static CustomOption squireSpawnRate;
        public static CustomOption squireShowShielded;
        public static CustomOption squireShowAttemptToShielded;
        public static CustomOption squireResetShieldAfterMeeting;

        // Cheater
        public static CustomOption cheaterSpawnRate;
        public static CustomOption cheaterCanCallEmergency;
        public static CustomOption cheatercanOnlyCheatOthers;

        // FortuneTeller
        public static CustomOption fortuneTellerSpawnRate;
        public static CustomOption fortuneTellerCooldown;
        public static CustomOption fortuneTellerDuration; 
        public static CustomOption fortuneTellerNumberOfSee;
        public static CustomOption fortuneTellerKindOfInfo;
        public static CustomOption fortuneTellerPlayersWithNotification;

        // Hacker
        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;

        // Sleuth
        public static CustomOption sleuthSpawnRate;
        public static CustomOption sleuthUpdateIntervall;
        public static CustomOption sleuthResetTargetAfterMeeting;
        public static CustomOption sleuthCorpsesPathfindCooldown;
        public static CustomOption sleuthCorpsesPathfindDuration;

        // Fink
        public static CustomOption finkSpawnRate;
        public static CustomOption finkLeftTasksForImpostors;
        public static CustomOption finkIncludeTeamRenegade;
        public static CustomOption finkCooldown;
        public static CustomOption finkDuration;

        // Kid
        public static CustomOption kidSpawnRate;

        // Welder
        public static CustomOption welderSpawnRate;
        public static CustomOption welderCooldown;
        public static CustomOption welderTotalWelds;

        // Spiritualist
        public static CustomOption spiritualistSpawnRate;
        public static CustomOption spiritualistReviveTime;       

        // Vigilant
        public static CustomOption vigilantSpawnRate;
        public static CustomOption vigilantCooldown;
        public static CustomOption vigilantCamDuration;
        public static CustomOption vigilantCamMaxCharges;
        public static CustomOption vigilantCamRechargeTasksNumber;      
        
        // Hunter
        public static CustomOption hunterSpawnRate;
        public static CustomOption hunterResetTargetAfterMeeting;

        // Jinx
        public static CustomOption jinxSpawnRate;
        public static CustomOption jinxCooldown;
        public static CustomOption jinxJinxsNumber;

        // Coward
        public static CustomOption cowardSpawnRate;
        public static CustomOption cowardNumberOfCalls;

        // Bat
        public static CustomOption batSpawnRate;
        public static CustomOption batCooldown;
        public static CustomOption batDuration;
        public static CustomOption batRange;

        // Necromancer
        public static CustomOption necromancerSpawnRate;
        public static CustomOption necromancerReviveCooldown;
        public static CustomOption necromancerReviveTimer;
        public static CustomOption necromancerMaxReviveRoomDistance;

        // Engineer
        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerCooldown;
        public static CustomOption engineerNumberOfTraps;
        public static CustomOption engineerTrapsDuration;
        public static CustomOption engineerAccelTrapIncrease;
        public static CustomOption engineerDecelTrapDecrease;

        // Shy
        public static CustomOption shySpawnRate;
        public static CustomOption shyCooldown;
        public static CustomOption shyDuration;
        public static CustomOption shyArrowRange;
        public static CustomOption shyPlayerColor;

        // TimeMaster
        public static CustomOption taskMasterSpawnRate;
        public static CustomOption taskMasterCooldown;
        public static CustomOption taskMasterDuration; 
        public static CustomOption taskMasterExtraCommonTasks;
        public static CustomOption taskMasterExtraShortTasks;
        public static CustomOption taskMasterExtraLongTasks;

        // Jailer
        public static CustomOption jailerSpawnRate;
        public static CustomOption jailerCooldown;
        public static CustomOption jailerDuration;

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static void Load() {
            
            // Game Options
            presetSelection = CustomOption.Create(0, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Preset"), "setting", presets, null, true);

            // Global Settings
            globalSettings = CustomOption.Create(1, cs(Jailer.color, "Global Settings"), "setting", false, null, true);
            activateRoles = CustomOption.Create(2, cs(Jailer.color, "Activate mod roles and gamemodes"), "setting", true, globalSettings);
            activateSenseiMap = CustomOption.Create(3, cs(Jailer.color, "Activate Custom Skeld Map"), "setting", false, globalSettings);
            hideVentAnimOnShadows = CustomOption.Create(4, cs(Jailer.color, "Hide Vent Anim on Shadows"), "setting", false, globalSettings);

            // Roles Settings
            rolesSettings = CustomOption.Create(6, cs(Detective.color, "Roles Settings"), "setting", false, null, true);
            whoAmIMode = CustomOption.Create(7, cs(Detective.color, "Find a Role Mode"), "setting", false, rolesSettings);
            removeSwipeCard = CustomOption.Create(8, cs(Detective.color, "Remove Swipe Card Task"), "setting", false, rolesSettings);
            removeAirshipDoors = CustomOption.Create(9, cs(Detective.color, "Remove Airship Doors"), "setting", false, rolesSettings);
            nightVisionLightSabotage = CustomOption.Create(10, cs(Detective.color, "Night vision for lights sabotage"), "setting", false, rolesSettings);
            screenShakeReactorSabotage = CustomOption.Create(11, cs(Detective.color, "Screen shake for reactor sabotage"), "setting", false, rolesSettings);
            anonymousCommsSabotage = CustomOption.Create(12, cs(Detective.color, "Anonymous players for comms sabotage"), "setting", false, rolesSettings);
            slowSpeedOxigenSabotage = CustomOption.Create(13, cs(Detective.color, "Decrease speed for oxygen sabotage"), "setting", false, rolesSettings);

            // Modifiers
            activateModifiers = CustomOption.Create(15, cs(Modifiers.color, "Modifiers"), "setting", false, null, true);
            loverPlayer = CustomOption.Create(16, cs(Modifiers.color, "Lovers"), "setting", rates, activateModifiers, false);
            lighterPlayer = CustomOption.Create(17, cs(Modifiers.color, "Lighter"), "setting", rates, activateModifiers, false);
            blindPlayer = CustomOption.Create(18, cs(Modifiers.color, "Blind"), "setting", rates, activateModifiers, false);
            flashPlayer = CustomOption.Create(19, cs(Modifiers.color, "Flash"), "setting", rates, activateModifiers, false);
            bigchungusPlayer = CustomOption.Create(20, cs(Modifiers.color, "Big Chungus"), "setting", rates, activateModifiers, false);
            theChosenOnePlayer = CustomOption.Create(21, cs(Modifiers.color, "The Chosen One"), "setting", rates, activateModifiers, false);
            theChosenOneReportDelay = CustomOption.Create(22, cs(Modifiers.color, "The Chosen One") + ": Report Delay", "setting", 0f, 0f, 5f, 1f, activateModifiers);
            performerPlayer = CustomOption.Create(23, cs(Modifiers.color, "Performer"), "setting", rates, activateModifiers, false);
            performerDuration = CustomOption.Create(24, cs(Modifiers.color, "Performer") + ": Alarm Duration", "setting", 30f, 15f, 30f, 1f, activateModifiers);
            proPlayer = CustomOption.Create(25, cs(Modifiers.color, "Pro"), "setting", rates, activateModifiers, false);
            paintballPlayer = CustomOption.Create(26, cs(Modifiers.color, "Paintball"), "setting", rates, activateModifiers, false);
            paintballDuration = CustomOption.Create(27, cs(Modifiers.color, "Paintball") + ": Paint Duration", "setting", 10f, 5f, 15f, 1f, activateModifiers);
            electricianPlayer = CustomOption.Create(28, cs(Modifiers.color, "Electrician"), "setting", rates, activateModifiers, false);
            electricianDuration = CustomOption.Create(29, cs(Modifiers.color, "Electrician") + ": Discharge Duration", "setting", 5f, 5f, 10f, 1f, activateModifiers);      
            
            // Capture the flag mode
            captureTheFlagMode = CustomOption.Create(30, cs(Sheriff.color, "Capture the Flag"), "gamemode", false, null, true);
            flagMatchDuration = CustomOption.Create(31, cs(Sheriff.color, "Capture the Flag") + ": Match Duration", "gamemode", 180f, 180f, 300f, 30f, captureTheFlagMode);
            requiredFlags = CustomOption.Create(32, cs(Sheriff.color, "Capture the Flag") + ": Score Number", "gamemode", 3f, 3f, 5f, 1f, captureTheFlagMode);
            flagKillCooldown = CustomOption.Create(33, cs(Sheriff.color, "Capture the Flag") + ": Kill Cooldown", "gamemode", 10f, 5f, 15f, 1f, captureTheFlagMode);
            flagReviveTime = CustomOption.Create(34, cs(Sheriff.color, "Capture the Flag") + ": Revive Wait Time", "gamemode", 8f, 7f, 15f, 1f, captureTheFlagMode);
            flagInvincibilityTimeAfterRevive = CustomOption.Create(35, cs(Sheriff.color, "Capture the Flag") + ": Invincibility Time After Revive", "gamemode", 3f, 2f, 5f, 1f, captureTheFlagMode);

            // Police and Thief mode
            policeAndThiefMode = CustomOption.Create(40, cs(Coward.color, "Police and Thieves"), "gamemode", false, null, true);
            thiefModeMatchDuration = CustomOption.Create(41, cs(Coward.color, "Police and Thieves") + ": Match Duration", "gamemode", 300f, 300f, 450f, 30f, policeAndThiefMode);
            thiefModerequiredJewels = CustomOption.Create(42, cs(Coward.color, "Police and Thieves") + ": Jewel Number", "gamemode", 15f, 8f, 15f, 1f, policeAndThiefMode);
            thiefModePoliceKillCooldown = CustomOption.Create(43, cs(Coward.color, "Police and Thieves") + ": Police Kill Cooldown", "gamemode", 15f, 10f, 20f, 1f, policeAndThiefMode);
            thiefModePoliceCatchCooldown = CustomOption.Create(44, cs(Coward.color, "Police and Thieves") + ": Police Arrest Cooldown", "gamemode", 10f, 5f, 15f, 1f, policeAndThiefMode);
            thiefModecaptureThiefTime = CustomOption.Create(45, cs(Coward.color, "Police and Thieves") + ": Time to Arrest", "gamemode", 3f, 2f, 5f, 1f, policeAndThiefMode);
            thiefModePoliceTaseCooldown = CustomOption.Create(46, cs(Coward.color, "Police and Thieves") + ": Police Tase Cooldown", "gamemode", 15f, 10f, 20f, 1f, policeAndThiefMode);
            thiefModePoliceTaseDuration = CustomOption.Create(47, cs(Coward.color, "Police and Thieves") + ": Police Tase Duration", "gamemode", 3f, 3f, 5f, 1f, policeAndThiefMode);
            thiefModePoliceCanSeeJewels = CustomOption.Create(48, cs(Coward.color, "Police and Thieves") + ": Police can see Jewels", "gamemode", false, policeAndThiefMode);
            thiefModepolicevision = CustomOption.Create(49, cs(Coward.color, "Police and Thieves") + ": Police vision range", "gamemode", 0.8f, 0.4f, 1.4f, 0.2f, policeAndThiefMode);
            thiefModePoliceReviveTime = CustomOption.Create(50, cs(Coward.color, "Police and Thieves") + ": Police Revive Wait Time", "gamemode", 8f, 8f, 13f, 1f, policeAndThiefMode);
            thiefModeWhoCanThiefsKill = CustomOption.Create(51, cs(Coward.color, "Police and Thieves") + ": Who Can Thieves Kill", "gamemode", new string[] { "Taser", "All", "Nobody" }, policeAndThiefMode);
            thiefModeKillCooldown = CustomOption.Create(52, cs(Coward.color, "Police and Thieves") + ": Thieves Kill Cooldown", "gamemode", 20f, 15f, 30f, 1f, policeAndThiefMode);
            thiefModeThiefReviveTime = CustomOption.Create(53, cs(Coward.color, "Police and Thieves") + ": Thieves Revive Wait Time", "gamemode", 13f, 13f, 23f, 1f, policeAndThiefMode);
            thiefModeInvincibilityTimeAfterRevive = CustomOption.Create(54, cs(Coward.color, "Police and Thieves") + ": Invincibility Time After Revive", "gamemode", 3f, 2f, 5f, 1f, policeAndThiefMode);

            // King of the hill mode
            kingOfTheHillMode = CustomOption.Create(60, cs(Squire.color, "King of the Hill"), "gamemode", false, null, true);
            kingMatchDuration = CustomOption.Create(61, cs(Squire.color, "King of the Hill") + ": Match Duration", "gamemode", 180f, 180f, 300f, 30f, kingOfTheHillMode);
            kingRequiredPoints = CustomOption.Create(62, cs(Squire.color, "King of the Hill") + ": Score Number", "gamemode", 200f, 100f, 300f, 10f, kingOfTheHillMode);
            kingCaptureCooldown = CustomOption.Create(63, cs(Squire.color, "King of the Hill") + ": Capture Cooldown", "gamemode", 10f, 5f, 15f, 1f, kingOfTheHillMode);
            kingKillCooldown = CustomOption.Create(64, cs(Squire.color, "King of the Hill") + ": Kill Cooldown", "gamemode", 10f, 10f, 20f, 1f, kingOfTheHillMode);
            kingCanKill = CustomOption.Create(65, cs(Squire.color, "King of the Hill") + ": Kings can Kill", "gamemode", false, kingOfTheHillMode);
            kingReviveTime = CustomOption.Create(66, cs(Squire.color, "King of the Hill") + ": Revive Wait Time", "gamemode", 13f, 13f, 18f, 1f, kingOfTheHillMode);
            kingInvincibilityTimeAfterRevive = CustomOption.Create(67, cs(Squire.color, "King of the Hill") + ": Invincibility Time After Revive", "gamemode", 3f, 2f, 5f, 1f, kingOfTheHillMode);

            // Hot Potato
            hotPotatoMode = CustomOption.Create(70, cs(Shy.color, "Hot Potato"), "gamemode", false, null, true);
            hotPotatoMatchDuration = CustomOption.Create(71, cs(Shy.color, "Hot Potato") + ": Match Duration", "gamemode", 300f, 300f, 450f, 30f, hotPotatoMode);
            hotPotatoTransferLimit = CustomOption.Create(72, cs(Shy.color, "Hot Potato") + ": Hot Potato Time Limit for Transfer", "gamemode", 20f, 10f, 30f, 1f, hotPotatoMode);
            hotPotatoCooldown = CustomOption.Create(73, cs(Shy.color, "Hot Potato") + ": Hot Potato Transfer Cooldown", "gamemode", 5f, 5f, 10f, 1f, hotPotatoMode);
            hotPotatoNotPotatovision = CustomOption.Create(74, cs(Shy.color, "Hot Potato") + ": Cold Potatoes vision range", "gamemode", 0.8f, 0.7f, 1f, 0.1f, hotPotatoMode);
            hotPotatoResetTimeForTransfer = CustomOption.Create(75, cs(Shy.color, "Hot Potato") + ": Reset Hot Potato timer after Transfer", "gamemode", true, hotPotatoMode);
            hotPotatoIncreaseTimeIfNoReset = CustomOption.Create(76, cs(Shy.color, "Hot Potato") + ": Extra Time when timer doesn't reset", "gamemode", 5f, 5f, 10f, 1f, hotPotatoMode);

            // ZombieLaboratory
            zombieLaboratoryMode = CustomOption.Create(80, cs(Hunter.color, "Zombie Laboratory"), "gamemode", false, null, true);
            zombieLaboratoryMatchDuration = CustomOption.Create(81, cs(Hunter.color, "Zombie Laboratory") + ": Match Duration", "gamemode", 300f, 300f, 450f, 30f, zombieLaboratoryMode);
            zombieLaboratoryStartZombies = CustomOption.Create(82, cs(Hunter.color, "Zombie Laboratory") + ": Initial Zombies", "gamemode", 1f, 1f, 5f, 1f, zombieLaboratoryMode);
            zombieLaboratoryInfectTime = CustomOption.Create(83, cs(Hunter.color, "Zombie Laboratory") + ": Time to Infect", "gamemode", 3f, 3f, 5f, 1f, zombieLaboratoryMode);
            zombieLaboratoryInfectCooldown = CustomOption.Create(84, cs(Hunter.color, "Zombie Laboratory") + ": Infect Cooldown", "gamemode", 10f, 10f, 20f, 1f, zombieLaboratoryMode);
            zombieLaboratorySearchBoxTimer = CustomOption.Create(85, cs(Hunter.color, "Zombie Laboratory") + ": Search Box Timer", "gamemode", 5f, 3f, 5f, 1f, zombieLaboratoryMode);
            zombieLaboratorySurvivorsVision = CustomOption.Create(86, cs(Hunter.color, "Zombie Laboratory") + ": Survivors vision range", "gamemode", 0.8f, 0.8f, 1f, 0.1f, zombieLaboratoryMode);
            zombieLaboratoryMaxTimeForHeal = CustomOption.Create(87, cs(Hunter.color, "Zombie Laboratory") + ": Time to use Medkit", "gamemode", 45f, 30f, 90f, 5f, zombieLaboratoryMode);
            zombieLaboratoryKillCooldown = CustomOption.Create(88, cs(Hunter.color, "Zombie Laboratory") + ": Kill Cooldown", "gamemode", 10f, 10f, 20f, 1f, zombieLaboratoryMode);
            zombieLaboratoryReviveTime = CustomOption.Create(89, cs(Hunter.color, "Zombie Laboratory") + ": Revive Wait Time", "gamemode", 8f, 8f, 13f, 1f, zombieLaboratoryMode);
            zombieLaboratoryInvincibilityTimeAfterRevive = CustomOption.Create(90, cs(Hunter.color, "Zombie Laboratory") + ": Invincibility Time After Revive", "gamemode", 3f, 2f, 5f, 1f, zombieLaboratoryMode);

            // Battle Royale
            battleRoyaleMode = CustomOption.Create(100, cs(Sleuth.color, "Battle Royale"), "gamemode", false, null, true);
            battleRoyaleMatchDuration = CustomOption.Create(101, cs(Sleuth.color, "Battle Royale") + ": Match Duration", "gamemode", 180f, 180f, 300f, 30f, battleRoyaleMode);
            battleRoyaleMatchType = CustomOption.Create(102, cs(Sleuth.color, "Battle Royale") + ": Match Type", "gamemode", new string[] { "All vs All", "Team Battle", "Score Battle" }, battleRoyaleMode);
            battleRoyaleKillCooldown = CustomOption.Create(103, cs(Sleuth.color, "Battle Royale") + ": Kill Cooldown", "gamemode", 1f, 1f, 3f, 1f, battleRoyaleMode);
            battleRoyaleLifes = CustomOption.Create(104, cs(Sleuth.color, "Battle Royale") + ": Fighter Lifes", "gamemode", 3f, 3f, 10f, 1f, battleRoyaleMode);
            battleRoyaleScoreNeeded = CustomOption.Create(105, cs(Sleuth.color, "Battle Royale") + ": Score Number", "gamemode", 200f, 100f, 300f, 10f, battleRoyaleMode);
            battleRoyaleReviveTime = CustomOption.Create(106, cs(Sleuth.color, "Battle Royale") + ": Revive Wait Time", "gamemode", 5f, 3f, 5f, 1f, battleRoyaleMode);
            battleRoyaleInvincibilityTimeAfterRevive = CustomOption.Create(107, cs(Sleuth.color, "Battle Royale") + ": Invincibility Time After Revive", "gamemode", 3f, 2f, 5f, 1f, battleRoyaleMode);

            // Mimic options
            mimicSpawnRate = CustomOption.Create(150, cs(Mimic.color, "Mimic"), "impostor", rates, null, true);
            mimicDuration = CustomOption.Create(151, cs(Mimic.color, "Mimic") + ": Duration", "impostor", 10f, 10f, 15f, 1f, mimicSpawnRate);

            // Painter options
            painterSpawnRate = CustomOption.Create(160, cs(Painter.color, "Painter"), "impostor", rates, null, true);
            painterCooldown = CustomOption.Create(161, cs(Painter.color, "Painter") + ": Cooldown", "impostor", 30f, 20f, 40f, 2.5f, painterSpawnRate);
            painterDuration = CustomOption.Create(162, cs(Painter.color, "Painter") + ": Duration", "impostor", 10f, 10f, 15f, 1f, painterSpawnRate);

            // Demon options
            demonSpawnRate = CustomOption.Create(170, cs(Demon.color, "Demon"), "impostor", rates, null, true);
            demonKillDelay = CustomOption.Create(171, cs(Demon.color, "Demon") + ": Delay Time", "impostor", 10f, 5f, 15f, 1f, demonSpawnRate);
            demonCanKillNearNuns = CustomOption.Create(172, cs(Demon.color, "Demon") + ": Can Kill near Nuns", "impostor", false, demonSpawnRate);

            // Janitor options
            janitorSpawnRate = CustomOption.Create(180, cs(Janitor.color, "Janitor"), "impostor", rates, null, true);
            janitorCooldown = CustomOption.Create(181, cs(Janitor.color, "Janitor") + ": Cooldown", "impostor", 30f, 20f, 40f, 2.5f, janitorSpawnRate);

            // Illusionist options
            illusionistSpawnRate = CustomOption.Create(190, cs(Illusionist.color, "Illusionist"), "impostor", rates, null, true);
            illusionistPlaceHatCooldown = CustomOption.Create(191, cs(Illusionist.color, "Illusionist") + ": Hats Cooldown", "impostor", 20f, 15f, 30f, 1f, illusionistSpawnRate);
            illusionistLightsOutCooldown = CustomOption.Create(192, cs(Illusionist.color, "Illusionist") + ": Lights Cooldown", "impostor", 30f, 20f, 40f, 1f, illusionistSpawnRate);
            illusionistLightsOutDuration = CustomOption.Create(193, cs(Illusionist.color, "Illusionist") + ": Blackout Duration", "impostor", 10f, 5f, 15f, 1f, illusionistSpawnRate);

            // Manipulator options
            manipulatorSpawnRate = CustomOption.Create(200, cs(Manipulator.color, "Manipulator"), "impostor", rates, null, true);

            // Bomberman options
            bombermanSpawnRate = CustomOption.Create(210, cs(Bomberman.color, "Bomberman"), "impostor", rates, null, true);
            bombermanBombCooldown = CustomOption.Create(211, cs(Bomberman.color, "Bomberman") + ": Cooldown", "impostor", 30f, 30f, 60f, 5f, bombermanSpawnRate);

            // Chameleon options
            chameleonSpawnRate = CustomOption.Create(220, cs(Chameleon.color, "Chameleon"), "impostor", rates, null, true);
            chameleonCooldown = CustomOption.Create(221, cs(Chameleon.color, "Chameleon") + ": Cooldown", "impostor", 30f, 20f, 40f, 2.5f, chameleonSpawnRate);
            chameleonDuration = CustomOption.Create(222, cs(Chameleon.color, "Chameleon") + ": Duration", "impostor", 10f, 10f, 15f, 1f, chameleonSpawnRate);

            // Gambler options
            gamblerSpawnRate = CustomOption.Create(230, cs(Gambler.color, "Gambler"), "impostor", rates, null, true);
            gamblerNumberOfShots = CustomOption.Create(231, cs(Gambler.color, "Gambler") + ": Shoot Number", "impostor", 3f, 1f, 3f, 1f, gamblerSpawnRate);
            gamblerCanCallEmergency = CustomOption.Create(232, cs(Gambler.color, "Gambler") + ": Can use emergency button", "impostor", false, gamblerSpawnRate);
            gamblerCanShootMultipleTimes = CustomOption.Create(233, cs(Gambler.color, "Gambler") + ": Can Shoot multiple times", "impostor", true, gamblerSpawnRate);
            gamblerCanKillThroughShield = CustomOption.Create(234, cs(Gambler.color, "Gambler") + ": Ignore shields", "impostor", false, gamblerSpawnRate);

            // Sorcerer Options
            sorcererSpawnRate = CustomOption.Create(240, cs(Sorcerer.color, "Sorcerer"), "impostor", rates, null, true);
            sorcererCooldown = CustomOption.Create(241, cs(Sorcerer.color, "Sorcerer") + ": Cooldown", "impostor", 20f, 20f, 40f, 2.5f, sorcererSpawnRate);
            sorcererAdditionalCooldown = CustomOption.Create(242, cs(Sorcerer.color, "Sorcerer") + ": Additional Cooldown per Spell", "impostor", 5f, 5f, 10f, 1f, sorcererSpawnRate);
            sorcererSpellDuration = CustomOption.Create(244, cs(Sorcerer.color, "Sorcerer") + ": Spell Duration", "impostor", 3f, 3f, 5f, 1f, sorcererSpawnRate);
            sorcererCanCallEmergency = CustomOption.Create(245, cs(Sorcerer.color, "Sorcerer") + ": Can use emergency button", "impostor", false, sorcererSpawnRate);

            // Medusa options
            medusaSpawnRate = CustomOption.Create(250, cs(Medusa.color, "Medusa"), "impostor", rates, null, true);
            medusaCooldown = CustomOption.Create(251, cs(Medusa.color, "Medusa") + ": Cooldown", "impostor", 20f, 15f, 30f, 2.5f, medusaSpawnRate);
            medusaDelay = CustomOption.Create(252, cs(Medusa.color, "Medusa") + ": Petrify Delay", "impostor", 10f, 5f, 10f, 1f, medusaSpawnRate);
            medusaDuration = CustomOption.Create(253, cs(Medusa.color, "Medusa") + ": Petrify Duration", "impostor", 10f, 5f, 10f, 1f, medusaSpawnRate);

            // Hypnotist options
            hypnotistSpawnRate = CustomOption.Create(260, cs(Hypnotist.color, "Hypnotist"), "impostor", rates, null, true);
            hypnotistCooldown = CustomOption.Create(261, cs(Hypnotist.color, "Hypnotist") + ": Cooldown", "impostor", 20f, 15f, 30f, 1f, hypnotistSpawnRate);
            hypnotistNumberOfSpirals = CustomOption.Create(262, cs(Hypnotist.color, "Hypnotist") + ": Spiral Number", "impostor", 5f, 1f, 5f, 1f, hypnotistSpawnRate);
            hypnotistSpiralsDuration = CustomOption.Create(263, cs(Hypnotist.color, "Hypnotist") + ": Spiral Effect Duration", "impostor", 20f, 10f, 30f, 1f, hypnotistSpawnRate);

            // Archer options
            archerSpawnRate = CustomOption.Create(270, cs(Archer.color, "Archer"), "impostor", rates, null, true);
            archerShotSize = CustomOption.Create(271, cs(Archer.color, "Archer") + ": Arrow Size", "impostor", 2f, 1f, 3f, 1f, archerSpawnRate);
            archerShotRange = CustomOption.Create(272, cs(Archer.color, "Archer") + ": Arrow Range", "impostor", 15f, 5f, 15f, 1f, archerSpawnRate);
            archerNoticeRange = CustomOption.Create(273, cs(Archer.color, "Archer") + ": Notify Range", "impostor", 10f, 10f, 30f, 2.5f, archerSpawnRate);
            archerAimAssistDuration = CustomOption.Create(274, cs(Archer.color, "Archer") + ": Aim Duration", "impostor", 10f, 3f, 10f, 1f, archerSpawnRate);

            // Plumber options
            plumberSpawnRate = CustomOption.Create(280, cs(Plumber.color, "Plumber"), "impostor", rates, null, true);
            plumberCooldown = CustomOption.Create(281, cs(Plumber.color, "Plumber") + ": Cooldown", "impostor", 20f, 15f, 30f, 1f, plumberSpawnRate);
            plumberVentNumber = CustomOption.Create(282, cs(Plumber.color, "Plumber") + ": Number of Vents", "impostor", 5f, 2f, 5f, 1f, plumberSpawnRate);

            // Librarian options
            librarianSpawnRate = CustomOption.Create(290, cs(Librarian.color, "Librarian"), "impostor", rates, null, true);
            librarianCooldown = CustomOption.Create(291, cs(Librarian.color, "Librarian") + ": Cooldown", "impostor", 20f, 20f, 30f, 1f, librarianSpawnRate);

            // Renegade & Minion options
            renegadeSpawnRate = CustomOption.Create(300, cs(Renegade.color, "Renegade"), "rebel", rates, null, true);
            renegadeCanUseVents = CustomOption.Create(301, cs(Renegade.color, "Renegade") + ": Can use Vents", "rebel", true, renegadeSpawnRate);
            renegadeCanRecruitMinion = CustomOption.Create(302, cs(Renegade.color, "Renegade") + ": Can Recruit a Minion", "rebel", true, renegadeSpawnRate);

            // Bountyhunter options
            bountyHunterSpawnRate = CustomOption.Create(310, cs(BountyHunter.color, "Bounty Hunter"), "rebel", rates, null, true);

            // Trapper options
            trapperSpawnRate = CustomOption.Create(320, cs(Trapper.color, "Trapper"), "rebel", rates, null, true);
            trapperCooldown = CustomOption.Create(321, cs(Trapper.color, "Trapper") + ": Cooldown", "rebel", 15f, 15f, 30f, 1f, trapperSpawnRate);
            trapperMineNumber = CustomOption.Create(322, cs(Trapper.color, "Trapper") + ": Mine Number", "rebel", 3f, 1f, 3f, 1f, trapperSpawnRate);
            trapperMineDuration = CustomOption.Create(323, cs(Trapper.color, "Trapper") + ": Mine Duration", "rebel", 45f, 30f, 60f, 5f, trapperSpawnRate);
            trapperTrapNumber = CustomOption.Create(324, cs(Trapper.color, "Trapper") + ": Trap Number", "rebel", 3f, 1f, 5f, 1f, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(325, cs(Trapper.color, "Trapper") + ": Trap Duration", "rebel", 60f, 30f, 120f, 5f, trapperSpawnRate);
            
            // Yinyanger options
            yinyangerSpawnRate = CustomOption.Create(330, cs(Yinyanger.color, "Yinyanger"), "rebel", rates, null, true);
            yinyangerCooldown = CustomOption.Create(331, cs(Yinyanger.color, "Yinyanger") + ": Cooldown", "rebel", 15f, 15f, 30f, 1f, yinyangerSpawnRate);

            // Challenger options
            challengerSpawnRate = CustomOption.Create(340, cs(Challenger.color, "Challenger"), "rebel", rates, null, true);
            challengerCooldown = CustomOption.Create(341, cs(Challenger.color, "Challenger") + ": Cooldown", "rebel", 15f, 15f, 30f, 1f, challengerSpawnRate);
            challengerKillsForWin = CustomOption.Create(342, cs(Challenger.color, "Challenger") + ": Kills to Win", "rebel", 3f, 3f, 5f, 1f, challengerSpawnRate);

            // Ninja options
            ninjaSpawnRate = CustomOption.Create(350, cs(Ninja.color, "Ninja"), "rebel", rates, null, true);

            // Berserker options
            berserkerSpawnRate = CustomOption.Create(360, cs(Berserker.color, "Berserker"), "rebel", rates, null, true);
            berserkerTimeToKill = CustomOption.Create(361, cs(Berserker.color, "Berserker") + ": Kill Time Limit", "rebel", 30f, 20f, 40f, 2.5f, berserkerSpawnRate);

            // Yandere options
            yandereSpawnRate = CustomOption.Create(370, cs(Yandere.color, "Yandere"), "rebel", rates, null, true);
            yandereCooldown = CustomOption.Create(371, cs(Yandere.color, "Yandere") + ": Stare Cooldown", "rebel", 30f, 15f, 30f, 1f, yandereSpawnRate);
            yandereStareTimes = CustomOption.Create(372, cs(Yandere.color, "Yandere") + ": Stare Times", "rebel", 5f, 3f, 5f, 1f, yandereSpawnRate);
            yandereStareDuration = CustomOption.Create(373, cs(Yandere.color, "Yandere") + ": Stare Duration", "rebel", 3f, 2f, 4f, 1f, yandereSpawnRate);

            // Stranded options
            strandedSpawnRate = CustomOption.Create(380, cs(Stranded.color, "Stranded"), "rebel", rates, null, true);

            // Monja options
            monjaSpawnRate = CustomOption.Create(390, cs(Monja.color, "Monja"), "rebel", rates, null, true);
            
            // Joker options
            jokerSpawnRate = CustomOption.Create(400, cs(Joker.color, "Joker"), "neutral", rates, null, true);
            jokerCanSabotage = CustomOption.Create(402, cs(Joker.color, "Joker") + ": Can Sabotage", "neutral", true, jokerSpawnRate);

            // RoleThief options
            rolethiefSpawnRate = CustomOption.Create(410, cs(RoleThief.color, "Role Thief"), "neutral", rates, null, true);
            rolethiefCooldown = CustomOption.Create(411, cs(RoleThief.color, "Role Thief") + ": Cooldown", "neutral", 20f, 10f, 30f, 2.5f, rolethiefSpawnRate);

            // Pyromaniac options
            pyromaniacSpawnRate = CustomOption.Create(420, cs(Pyromaniac.color, "Pyromaniac"), "neutral", rates, null, true);
            pyromaniacCooldown = CustomOption.Create(421, cs(Pyromaniac.color, "Pyromaniac") + ": Cooldown", "neutral", 15f, 10f, 20f, 1f, pyromaniacSpawnRate);
            pyromaniacDuration = CustomOption.Create(422, cs(Pyromaniac.color, "Pyromaniac") + ": Ignite Duration", "neutral", 3f, 1f, 5f, 1f, pyromaniacSpawnRate);

            // Treasure hunter options
            treasureHunterSpawnRate = CustomOption.Create(430, cs(TreasureHunter.color, "Treasure Hunter"), "neutral", rates, null, true);
            treasureHunterTreasureNumber = CustomOption.Create(431, cs(TreasureHunter.color, "Treasure Hunter") + ": Treasures to Win", "neutral", 5f, 5f, 10f, 1f, treasureHunterSpawnRate);

            // Devourer options
            devourerSpawnRate = CustomOption.Create(440, cs(Devourer.color, "Devourer"), "neutral", rates, null, true);
            devourerBodiesNumber = CustomOption.Create(441, cs(Devourer.color, "Devourer") + ": Devours to Win", "neutral", 3f, 2f, 5f, 1f, devourerSpawnRate);

            // Poisoner options
            poisonerSpawnRate = CustomOption.Create(450, cs(Poisoner.color, "Poisoner"), "neutral", rates, null, true);
            poisonerDuration = CustomOption.Create(451, cs(Poisoner.color, "Poisoner") + ": Time to Poison", "neutral", 5f, 3f, 5f, 1f, poisonerSpawnRate);
            poisonerInfectRange = CustomOption.Create(452, cs(Poisoner.color, "Poisoner") + ": Poison Infect Range", "neutral", 2f, 0.5f, 2f, 0.25f, poisonerSpawnRate);
            poisonerInfectDuration = CustomOption.Create(453, cs(Poisoner.color, "Poisoner") + ": Time to fully Poison", "neutral", 20f, 15f, 30f, 1f, poisonerSpawnRate);
            poisonerCanSabotage = CustomOption.Create(454, cs(Poisoner.color, "Poisoner") + ": Can Sabotage", "neutral", true, poisonerSpawnRate);

            // Puppeteer options
            puppeteerSpawnRate = CustomOption.Create(460, cs(Puppeteer.color, "Puppeteer"), "neutral", rates, null, true);
            puppeteerNumberOfKills = CustomOption.Create(461, cs(Puppeteer.color, "Puppeteer") + ": Number of Kills", "neutral", 3f, 2f, 4f, 1f, devourerSpawnRate);

            // Exiler options
            exilerSpawnRate = CustomOption.Create(470, cs(Exiler.color, "Exiler"), "neutral", rates, null, true);

            // Amnesiac options
            amnesiacSpawnRate = CustomOption.Create(480, cs(Amnesiac.color, "Amnesiac"), "neutral", rates, null, true);

            // Seeker options
            seekerSpawnRate = CustomOption.Create(490, cs(Seeker.color, "Seeker"), "neutral", rates, null, true);
            seekerCooldown = CustomOption.Create(491, cs(Seeker.color, "Seeker") + ": Cooldown", "neutral", 5f, 5f, 10f, 1f, seekerSpawnRate);
            seekerPointsNumber = CustomOption.Create(492, cs(Seeker.color, "Seeker") + ": Points to Win", "neutral", 5f, 5f, 10f, 1f, seekerSpawnRate);

            // Captain options
            captainSpawnRate = CustomOption.Create(500, cs(Captain.color, "Captain"), "crewmate", rates, null, true);
            captainCanSpecialVoteOneTime = CustomOption.Create(501, cs(Captain.color, "Captain") + ": Can Special Vote one time", "crewmate", true, captainSpawnRate);

            // Mechanic options
            mechanicSpawnRate = CustomOption.Create(510, cs(Mechanic.color, "Mechanic"), "crewmate", rates, null, true);
            mechanicNumberOfRepairs = CustomOption.Create(511, cs(Mechanic.color, "Mechanic") + ": Repairs Number", "crewmate", 3f, 1f, 3f, 1f, mechanicSpawnRate);
            mechanicExpertRepairs = CustomOption.Create(512, cs(Mechanic.color, "Mechanic") + ": Expert Repairs", "crewmate", true, mechanicSpawnRate);

            // Sheriff options
            sheriffSpawnRate = CustomOption.Create(520, cs(Sheriff.color, "Sheriff"), "crewmate", rates, null, true);
            sheriffCanKillNeutrals = CustomOption.Create(521, cs(Sheriff.color, "Sheriff") + ": Can Kill Neutrals", "crewmate", true, sheriffSpawnRate);

            // Detective options
            detectiveSpawnRate = CustomOption.Create(530, cs(Detective.color, "Detective"), "crewmate", rates, null, true);
            detectiveShowFootprints = CustomOption.Create(531, cs(Detective.color, "Detective") + ": Show Footprints", "crewmate", new string[] { "Button Use", "Always" }, detectiveSpawnRate);
            detectiveCooldown = CustomOption.Create(532, cs(Detective.color, "Detective") + ": Cooldown", "crewmate", 15f, 10f, 20f, 1f, detectiveSpawnRate);
            detectiveShowFootPrintDuration = CustomOption.Create(533, cs(Detective.color, "Detective") + ": Show Footprints Duration", "crewmate", 10f, 10f, 15f, 1f, detectiveSpawnRate); 
            detectiveAnonymousFootprints = CustomOption.Create(534, cs(Detective.color, "Detective") + ": Anonymous Footprints", "crewmate", false, detectiveSpawnRate);
            detectiveFootprintIntervall = CustomOption.Create(535, cs(Detective.color, "Detective") + ": Footprints Interval", "crewmate", 0.5f, 0.25f, 2f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(536, cs(Detective.color, "Detective") + ": Footprints Duration", "crewmate", 15f, 10f, 20f, 1f, detectiveSpawnRate);

            // Forensic options
            forensicSpawnRate = CustomOption.Create(540, cs(Forensic.color, "Forensic"), "crewmate", rates, null, true);
            forensicReportNameDuration = CustomOption.Create(541, cs(Forensic.color, "Forensic") + ": Time to know the name", "crewmate", 10, 2.5f, 10, 2.5f, forensicSpawnRate);
            forensicReportColorDuration = CustomOption.Create(542, cs(Forensic.color, "Forensic") + ": Time to know the color type", "crewmate", 20, 10, 20, 2.5f, forensicSpawnRate);
            forensicReportClueDuration = CustomOption.Create(543, cs(Forensic.color, "Forensic") + ": Time to know if the killer has hat, outfit, pet or visor", "crewmate", 30, 20, 30, 2.5f, forensicSpawnRate);
            forensicDuration = CustomOption.Create(544, cs(Forensic.color, "Forensic") + ": Question Duration", "crewmate", 5f, 5f, 10f, 1f, forensicSpawnRate);
            forensicOneTimeUse = CustomOption.Create(545, cs(Forensic.color, "Forensic") + ": One question per Ghost", "crewmate", true, forensicSpawnRate);

            // TimeTraveler options
            timeTravelerSpawnRate = CustomOption.Create(550, cs(TimeTraveler.color, "Time Traveler"), "crewmate", rates, null, true);
            timeTravelerCooldown = CustomOption.Create(551, cs(TimeTraveler.color, "Time Traveler") + ": Cooldown", "crewmate", 30f, 20f, 40f, 2.5f, timeTravelerSpawnRate);
            timeTravelerShieldDuration = CustomOption.Create(552, cs(TimeTraveler.color, "Time Traveler") + ": Shield Duration", "crewmate", 10f, 5f, 15f, 1f, timeTravelerSpawnRate);
            timeTravelerRewindTime = CustomOption.Create(553, cs(TimeTraveler.color, "Time Traveler") + ": Rewind Duration", "crewmate", 10f, 10f, 15f, 1f, timeTravelerSpawnRate);
            timeTravelerReviveDuringRewind = CustomOption.Create(554, cs(TimeTraveler.color, "Time Traveler") + ": Revive player during Rewind", "crewmate", true, timeTravelerSpawnRate);

            // Squire options
            squireSpawnRate = CustomOption.Create(560, cs(Squire.color, "Squire"), "crewmate", rates, null, true);
            squireShowShielded = CustomOption.Create(561, cs(Squire.color, "Squire") + ": Show Shielded Player to", "crewmate", new string[] { "Squire", "Both", "All" }, squireSpawnRate);
            squireShowAttemptToShielded = CustomOption.Create(562, cs(Squire.color, "Squire") + ": Play murder attempt sound if shielded", "crewmate", true, squireSpawnRate);
            squireResetShieldAfterMeeting = CustomOption.Create(563, cs(Squire.color, "Squire") + ": Can shield again after meeting", "crewmate", true, squireSpawnRate);

            // Cheater options
            cheaterSpawnRate = CustomOption.Create(570, cs(Cheater.color, "Cheater"), "crewmate", rates, null, true);
            cheaterCanCallEmergency = CustomOption.Create(571, cs(Cheater.color, "Cheater") + ": Can use emergency button", "crewmate", false, cheaterSpawnRate);
            cheatercanOnlyCheatOthers = CustomOption.Create(572, cs(Cheater.color, "Cheater") + ": Can swap himself", "crewmate", false, cheaterSpawnRate);

            // FortuneTeller options
            fortuneTellerSpawnRate = CustomOption.Create(580, cs(FortuneTeller.color, "Fortune Teller"), "crewmate", rates, null, true);
            fortuneTellerCooldown = CustomOption.Create(581, cs(FortuneTeller.color, "Fortune Teller") + ": Cooldown", "crewmate", 30f, 30f, 40f, 2.5f, fortuneTellerSpawnRate);
            fortuneTellerDuration = CustomOption.Create(582, cs(FortuneTeller.color, "Fortune Teller") + ": Reveal Time", "crewmate", 3f, 3f, 5f, 1f, fortuneTellerSpawnRate);
            fortuneTellerNumberOfSee = CustomOption.Create(583, cs(FortuneTeller.color, "Fortune Teller") + ": Reveal Number", "crewmate", 3f, 1f, 3f, 1f, fortuneTellerSpawnRate);
            fortuneTellerKindOfInfo = CustomOption.Create(584, cs(FortuneTeller.color, "Fortune Teller") + ": Revealed Information", "crewmate", new string[] { "Good / Bad", "Rol Name" }, fortuneTellerSpawnRate);
            fortuneTellerPlayersWithNotification = CustomOption.Create(585, cs(FortuneTeller.color, "Fortune Teller") + ": Show Notification to", "crewmate", new string[] { "Impostors", "Crewmates", "All", "Nobody" }, fortuneTellerSpawnRate);

            // Hacker options
            hackerSpawnRate = CustomOption.Create(590, cs(Hacker.color, "Hacker"), "crewmate", rates, null, true);
            hackerCooldown = CustomOption.Create(591, cs(Hacker.color, "Hacker") + ": Cooldown", "crewmate", 20f, 20f, 40f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(592, cs(Hacker.color, "Hacker") + ": Duration", "crewmate", 15f, 10f, 15f, 1f, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(593, cs(Hacker.color, "Hacker") + ": Battery Uses", "crewmate", 3f, 1f, 5f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(594, cs(Hacker.color, "Hacker") + ": Tasks for recharge batteries", "crewmate", 2f, 1f, 3f, 1f, hackerSpawnRate);

            // Sleuth options
            sleuthSpawnRate = CustomOption.Create(600, cs(Sleuth.color, "Sleuth"), "crewmate", rates, null, true);
            sleuthUpdateIntervall = CustomOption.Create(601, cs(Sleuth.color, "Sleuth") + ": Track Interval", "crewmate", 0f, 0f, 3f, 1f, sleuthSpawnRate);
            sleuthResetTargetAfterMeeting = CustomOption.Create(602, cs(Sleuth.color, "Sleuth") + ": Can Track again after meeting", "crewmate", true, sleuthSpawnRate);
            sleuthCorpsesPathfindCooldown = CustomOption.Create(604, cs(Sleuth.color, "Sleuth") + ": Track Corpses Cooldown", "crewmate", 30f, 20f, 40f, 2.5f, sleuthSpawnRate);
            sleuthCorpsesPathfindDuration = CustomOption.Create(605, cs(Sleuth.color, "Sleuth") + ": Track Corpses Duration", "crewmate", 10f, 5f, 15f, 2.5f, sleuthSpawnRate);

            // Fink options
            finkSpawnRate = CustomOption.Create(610, cs(Fink.color, "Fink"), "crewmate", rates, null, true);
            finkLeftTasksForImpostors = CustomOption.Create(611, cs(Fink.color, "Fink") + ": Tasks remaining for being revealed to Impostors", "crewmate", 1f, 1f, 3f, 1f, finkSpawnRate);
            finkIncludeTeamRenegade = CustomOption.Create(612, cs(Fink.color, "Fink") + ": Can reveal Renegade / Minion", "crewmate", true, finkSpawnRate);
            finkCooldown = CustomOption.Create(613, cs(Fink.color, "Fink") + ": Cooldown", "crewmate", 20f, 20f, 30f, 1f, finkSpawnRate);
            finkDuration = CustomOption.Create(614, cs(Fink.color, "Fink") + ": Hawkeye Duration", "crewmate", 5f, 3f, 5f, 1f, finkSpawnRate);

            // Kid options
            kidSpawnRate = CustomOption.Create(620, cs(Kid.color, "Kid"), "crewmate", rates, null, true);

            // Welder options
            welderSpawnRate = CustomOption.Create(630, cs(Welder.color, "Welder"), "crewmate", rates, null, true);
            welderCooldown = CustomOption.Create(631, cs(Welder.color, "Welder") + ": Cooldown", "crewmate", 20f, 10f, 40f, 2.5f, welderSpawnRate);
            welderTotalWelds = CustomOption.Create(632, cs(Welder.color, "Welder") + ": Seal Number", "crewmate", 5f, 3f, 5f, 1f, welderSpawnRate);

            // Spiritualist options
            spiritualistSpawnRate = CustomOption.Create(640, cs(Spiritualist.color, "Spiritualist"), "crewmate", rates, null, true);
            spiritualistReviveTime = CustomOption.Create(641, cs(Spiritualist.color, "Spiritualist") + ": Revive Player Time", "crewmate", 10f, 10f, 15f, 1f, spiritualistSpawnRate);          

            // Vigilant options
            vigilantSpawnRate = CustomOption.Create(650, cs(Vigilant.color, "Vigilant"), "crewmate", rates, null, true);
            vigilantCooldown = CustomOption.Create(651, cs(Vigilant.color, "Vigilant") + ": Cooldown", "crewmate", 20f, 10f, 30f, 2.5f, vigilantSpawnRate);
            vigilantCamDuration = CustomOption.Create(653, cs(Vigilant.color, "Vigilant") + ": Remote Camera Duration", "crewmate", 10f, 5f, 15f, 1f, vigilantSpawnRate);
            vigilantCamMaxCharges = CustomOption.Create(654, cs(Vigilant.color, "Vigilant") + ": Battery Uses", "crewmate", 5f, 1f, 5f, 1f, vigilantSpawnRate);
            vigilantCamRechargeTasksNumber = CustomOption.Create(655, cs(Vigilant.color, "Vigilant") + ": Tasks for recharge batteries", "crewmate", 2f, 1f, 3f, 1f, vigilantSpawnRate);
                      
            // Hunter options
            hunterSpawnRate = CustomOption.Create(660, cs(Hunter.color, "Hunter"), "crewmate", rates, null, true);
            hunterResetTargetAfterMeeting = CustomOption.Create(661, cs(Hunter.color, "Hunter") + ": Can mark again after meeting", "crewmate", true, hunterSpawnRate);

            // Jinx
            jinxSpawnRate = CustomOption.Create(670, cs(Jinx.color, "Jinx"), "crewmate", rates, null, true);
            jinxCooldown = CustomOption.Create(671, cs(Jinx.color, "Jinx") + ": Cooldown", "crewmate", 20f, 10f, 30f, 2.5f, jinxSpawnRate);
            jinxJinxsNumber = CustomOption.Create(672, cs(Jinx.color, "Jinx") + ": Jinx Number", "crewmate", 15f, 5f, 15f, 1f, jinxSpawnRate);

            // Coward options
            cowardSpawnRate = CustomOption.Create(680, cs(Coward.color, "Coward"), "crewmate", rates, null, true);
            cowardNumberOfCalls = CustomOption.Create(681, cs(Coward.color, "Coward") + ": Number Of Meetings", "crewmate", 3f, 1f, 3f, 1f, cowardSpawnRate);

            // Bat options
            batSpawnRate = CustomOption.Create(690, cs(Bat.color, "Bat"), "crewmate", rates, null, true);
            batCooldown = CustomOption.Create(691, cs(Bat.color, "Bat") + ": Cooldown", "crewmate", 15f, 10f, 20f, 1f, batSpawnRate);
            batDuration = CustomOption.Create(692, cs(Bat.color, "Bat") + ": Emit Duration", "crewmate", 10f, 5f, 10f, 1f, batSpawnRate);
            batRange = CustomOption.Create(693, cs(Bat.color, "Bat") + ": Emit Range", "crewmate", 2f, 0.5f, 2f, 0.25f, batSpawnRate);

            // Necromancer options
            necromancerSpawnRate = CustomOption.Create(700, cs(Necromancer.color, "Necromancer"), "crewmate", rates, null, true);
            necromancerReviveCooldown = CustomOption.Create(701, cs(Necromancer.color, "Necromancer") + ": Cooldown", "crewmate", 20f, 20f, 40f, 1f, necromancerSpawnRate);
            necromancerReviveTimer = CustomOption.Create(702, cs(Necromancer.color, "Necromancer") + ": Revive Duration", "crewmate", 5f, 5f, 10f, 1f, necromancerSpawnRate);
            necromancerMaxReviveRoomDistance = CustomOption.Create(703, cs(Necromancer.color, "Necromancer") + ": Room Distance", "crewmate", 25f, 25f, 50f, 2.5f, necromancerSpawnRate);

            // Engineer options
            engineerSpawnRate = CustomOption.Create(710, cs(Engineer.color, "Engineer"), "crewmate", rates, null, true);
            engineerCooldown = CustomOption.Create(711, cs(Engineer.color, "Engineer") + ": Cooldown", "crewmate", 10f, 10f, 20f, 1f, engineerSpawnRate);
            engineerNumberOfTraps = CustomOption.Create(712, cs(Engineer.color, "Engineer") + ": Trap Number", "crewmate", 5f, 3f, 5f, 1f, engineerSpawnRate);
            engineerTrapsDuration = CustomOption.Create(713, cs(Engineer.color, "Engineer") + ": Trap Duration", "crewmate", 60f, 30f, 120f, 5f, engineerSpawnRate);
            engineerAccelTrapIncrease = CustomOption.Create(714, cs(Engineer.color, "Engineer") + ": Speed Increase", "crewmate", 1.4f, 1.2f, 1.5f, 0.1f, engineerSpawnRate);
            engineerDecelTrapDecrease = CustomOption.Create(715, cs(Engineer.color, "Engineer") + ": Speed Decrease", "crewmate", 0.5f, 0.5f, 0.8f, 0.1f, engineerSpawnRate);

            // Shy options
            shySpawnRate = CustomOption.Create(720, cs(Shy.color, "Shy"), "crewmate", rates, null, true);
            shyCooldown = CustomOption.Create(721, cs(Shy.color, "Shy") + ": Cooldown", "crewmate", 20f, 10f, 30f, 1f, shySpawnRate);
            shyDuration = CustomOption.Create(722, cs(Shy.color, "Shy") + ": Duration", "crewmate", 10f, 5f, 20f, 1f, shySpawnRate);
            shyArrowRange = CustomOption.Create(723, cs(Shy.color, "Shy") + ": Notify Range", "crewmate", 10f, 5f, 15f, 1f, shySpawnRate);
            shyPlayerColor = CustomOption.Create(724, cs(Shy.color, "Shy") + ": Arrow color is player color", "crewmate", true, shySpawnRate);

            // Task Master
            taskMasterSpawnRate = CustomOption.Create(730, cs(TaskMaster.color, "Task Master"), "crewmate", rates, null, true);
            taskMasterExtraCommonTasks = CustomOption.Create(731, cs(TaskMaster.color, "Task Master") + ": Extra Common Tasks", "crewmate", 1f, 1f, 2f, 1f, taskMasterSpawnRate);
            taskMasterExtraLongTasks = CustomOption.Create(732, cs(TaskMaster.color, "Task Master") + ": Extra Long Tasks", "crewmate", 1f, 1f, 3f, 1f, taskMasterSpawnRate);
            taskMasterExtraShortTasks = CustomOption.Create(733, cs(TaskMaster.color, "Task Master") + ": Extra Short Tasks", "crewmate", 1f, 1f, 5f, 1f, taskMasterSpawnRate);
            taskMasterCooldown = CustomOption.Create(734, cs(TaskMaster.color, "Task Master") + ": Speed Cooldown", "crewmate", 20f, 20f, 30f, 1f, taskMasterSpawnRate);
            taskMasterDuration = CustomOption.Create(735, cs(TaskMaster.color, "Task Master") + ": Speed Duration", "crewmate", 10f, 5f, 10f, 1f, taskMasterSpawnRate);

            // Jailer
            jailerSpawnRate = CustomOption.Create(740, cs(Jailer.color, "Jailer"), "crewmate", rates, null, true);
            jailerCooldown = CustomOption.Create(741, cs(Jailer.color, "Jailer") + ": Cooldown", "crewmate", 20f, 15f, 30f, 1f, jailerSpawnRate);
            jailerDuration = CustomOption.Create(742, cs(Jailer.color, "Jailer") + ": Jail Duration", "crewmate", 10f, 5f, 15f, 1f, jailerSpawnRate);
        }
    }    
}