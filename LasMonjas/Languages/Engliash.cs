using UnityEngine;
using System.Linq;
using LasMonjas.Core;
using static LasMonjas.Languages.Language;

namespace LasMonjas.Languages
{
    public class English
    {
        public static void Englishlang()
        {
            colorNames = new string[5] { "Lavender", "Petrol", "Mint", "Olive", "Ice" };
            for (int i = 0; i < colorNames.Count(); i++)
            {
                CustomColors.ColorStrings[i + 50000] = colorNames[i];
            }
            customOptionNames = new string[] {
                        CustomOptionHolder.cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Preset"),
                        CustomOptionHolder.cs(Jailer.color, "Global Settings"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Activate mod roles and gamemodes"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Activate Custom Skeld Map"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Hide Vent Anim on Shadows"),
                        CustomOptionHolder.cs(Detective.color, "Roles Settings"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Find a Role Mode"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Remove Swipe Card Task"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Remove Airship Doors"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Night vision for lights sabotage"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Screen shake for reactor sabotage"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Anonymous players for comms sabotage"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Decrease speed for oxygen sabotage"),
                        CustomOptionHolder.cs(Modifiers.color, "Modifiers"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Lovers"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Lighter"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Blind"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Flash"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Big Chungus"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "The Chosen One"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "The Chosen One") + ": Report Delay",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Performer"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Performer") + ": Alarm Duration",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Pro"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Paintball"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Paintball") + ": Paint Duration",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Electrician"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Electrician") + ": Discharge Duration",
                        CustomOptionHolder.cs(Sheriff.color, "Capture the Flag"),
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Match Duration",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Score Number",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Kill Cooldown",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Revive Wait Time",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Invincibility Time After Revive",
                        CustomOptionHolder.cs(Coward.color, "Police and Thieves"),
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Match Duration",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Jewel Number",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Police Kill Cooldown",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Police Arrest Cooldown",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Time to Arrest",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Police Tase Cooldown",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Police Tase Duration",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Police can see Jewels",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Police vision range",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Police Revive Wait Time",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Who Can Thieves Kill", // 45
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Thieves Kill Cooldown",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Thieves Revive Wait Time",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Invincibility Time After Revive",
                        CustomOptionHolder.cs(Squire.color, "King of the Hill"),
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Match Duration",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Score Number",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Capture Cooldown",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Kill Cooldown",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Kings can Kill",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Revive Wait Time",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Invincibility Time After Revive",
                        CustomOptionHolder.cs(Shy.color, "Hot Potato"),
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Match Duration",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Hot Potato Time Limit for Transfer",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Hot Potato Transfer Cooldown",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Cold Potatoes vision range",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Reset Hot Potato timer after Transfer",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Extra Time when timer doesn't reset",
                        CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory"),
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Match Duration",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Initial Zombies",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Time to Infect",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Infect Cooldown",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Search Box Timer",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Survivors vision range",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Time to use Medkit",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Kill Cooldown",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Revive Wait Time",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Invincibility Time After Revive",
                        CustomOptionHolder.cs(Sleuth.color, "Battle Royale"),
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Match Duration",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Match Type", // 77
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Kill Cooldown",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Fighter Lifes",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Score Number",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Revive Wait Time",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Invincibility Time After Revive",
                        CustomOptionHolder.cs(Mimic.color, "Mimic"),
                        "- " + CustomOptionHolder.cs(Mimic.color, "Mimic") + ": Duration",
                        CustomOptionHolder.cs(Painter.color, "Painter"),
                        "- " + CustomOptionHolder.cs(Painter.color, "Painter") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Painter.color, "Painter") + ": Duration",
                        CustomOptionHolder.cs(Demon.color, "Demon"),
                        "- " + CustomOptionHolder.cs(Demon.color, "Demon") + ": Delay Time",
                        "- " + CustomOptionHolder.cs(Demon.color, "Demon") + ": Can Kill near Nuns",
                        CustomOptionHolder.cs(Janitor.color, "Janitor"),
                        "- " + CustomOptionHolder.cs(Janitor.color, "Janitor") + ": Cooldown",
                        CustomOptionHolder.cs(Illusionist.color, "Illusionist"),
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": Hats Cooldown",
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": Lights Cooldown",
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": Blackout Duration",
                        CustomOptionHolder.cs(Manipulator.color, "Manipulator"),
                        CustomOptionHolder.cs(Bomberman.color, "Bomberman"),
                        "- " + CustomOptionHolder.cs(Bomberman.color, "Bomberman") + ": Cooldown",
                        CustomOptionHolder.cs(Chameleon.color, "Chameleon"),
                        "- " + CustomOptionHolder.cs(Chameleon.color, "Chameleon") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Chameleon.color, "Chameleon") + ": Duration",
                        CustomOptionHolder.cs(Gambler.color, "Gambler"),
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": Shoot Number",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": Can use emergency button",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": Can Shoot multiple times",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": Ignore shields",
                        CustomOptionHolder.cs(Sorcerer.color, "Sorcerer"),
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": Additional Cooldown per Spell",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": Spell Duration",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": Can use emergency button",
                        CustomOptionHolder.cs(Medusa.color, "Medusa"),
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": Petrify Delay",
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": Petrify Duration",
                        CustomOptionHolder.cs(Hypnotist.color, "Hypnotist"),
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": Spiral Number",
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": Spiral Effect Duration",
                        CustomOptionHolder.cs(Archer.color, "Archer"),
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": Arrow Size",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": Arrow Range",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": Notify Range",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": Aim Duration",
                        CustomOptionHolder.cs(Plumber.color, "Plumber"),
                        "- " + CustomOptionHolder.cs(Plumber.color, "Plumber") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Plumber.color, "Plumber") + ": Number of Vents",
                        CustomOptionHolder.cs(Librarian.color, "Librarian"),
                        "- " + CustomOptionHolder.cs(Librarian.color, "Librarian") + ": Cooldown",
                        CustomOptionHolder.cs(Renegade.color, "Renegade"),
                        "- " + CustomOptionHolder.cs(Renegade.color, "Renegade") + ": Can use Vents",
                        "- " + CustomOptionHolder.cs(Renegade.color, "Renegade") + ": Can Recruit a Minion",
                        CustomOptionHolder.cs(BountyHunter.color, "Bounty Hunter"),
                        CustomOptionHolder.cs(Trapper.color, "Trapper"),
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Mine Number",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Mine Duration",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Trap Number",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Trap Duration",
                        CustomOptionHolder.cs(Yinyanger.color, "Yinyanger"),
                        "- " + CustomOptionHolder.cs(Yinyanger.color, "Yinyanger") + ": Cooldown",
                        CustomOptionHolder.cs(Challenger.color, "Challenger"),
                        "- " + CustomOptionHolder.cs(Challenger.color, "Challenger") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Challenger.color, "Challenger") + ": Kills to Win",
                        CustomOptionHolder.cs(Ninja.color, "Ninja"),
                        CustomOptionHolder.cs(Berserker.color, "Berserker"),
                        "- " + CustomOptionHolder.cs(Berserker.color, "Berserker") + ": Kill Time Limit",
                        CustomOptionHolder.cs(Yandere.color, "Yandere"),
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": Stare Cooldown",
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": Stare Times",
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": Stare Duration",
                        CustomOptionHolder.cs(Stranded.color, "Stranded"),
                        CustomOptionHolder.cs(Monja.color, "Monja"),
                        CustomOptionHolder.cs(Joker.color, "Joker"),
                        "- " + CustomOptionHolder.cs(Joker.color, "Joker") + ": Can Sabotage",
                        CustomOptionHolder.cs(RoleThief.color, "Role Thief"),
                        "- " + CustomOptionHolder.cs(RoleThief.color, "Role Thief") + ": Cooldown",
                        CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac"),
                        "- " + CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac") + ": Ignite Duration",
                        CustomOptionHolder.cs(TreasureHunter.color, "Treasure Hunter"),
                        "- " + CustomOptionHolder.cs(TreasureHunter.color, "Treasure Hunter") + ": Treasures to Win",
                        CustomOptionHolder.cs(Devourer.color, "Devourer"),
                        "- " + CustomOptionHolder.cs(Devourer.color, "Devourer") + ": Devours to Win",
                        CustomOptionHolder.cs(Poisoner.color, "Poisoner"),
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": Time to Poison",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": Poison Infect Range",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": Time to fully Poison",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": Can Sabotage",
                        CustomOptionHolder.cs(Puppeteer.color, "Puppeteer"),
                        "- " + CustomOptionHolder.cs(Puppeteer.color, "Puppeteer") + ": Number of Kills",
                        CustomOptionHolder.cs(Exiler.color, "Exiler"),
                        CustomOptionHolder.cs(Amnesiac.color, "Amnesiac"),
                        CustomOptionHolder.cs(Seeker.color, "Seeker"),
                        "- " + CustomOptionHolder.cs(Seeker.color, "Seeker") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Seeker.color, "Seeker") + ": Points to Win",
                        CustomOptionHolder.cs(Captain.color, "Captain"),
                        "- " + CustomOptionHolder.cs(Captain.color, "Captain") + ": Can Special Vote one time",
                        CustomOptionHolder.cs(Mechanic.color, "Mechanic"),
                        "- " + CustomOptionHolder.cs(Mechanic.color, "Mechanic") + ": Repairs Number",
                        "- " + CustomOptionHolder.cs(Mechanic.color, "Mechanic") + ": Expert Repairs",
                        CustomOptionHolder.cs(Sheriff.color, "Sheriff"),
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Sheriff") + ": Can Kill Neutrals",
                        CustomOptionHolder.cs(Detective.color, "Detective"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Show Footprints", // 186
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Show Footprints Duration",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Anonymous Footprints",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Footprints Interval",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Footprints Duration",
                        CustomOptionHolder.cs(Forensic.color, "Forensic"),
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Time to know the name",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Time to know the color type",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Time to know if the killer has hat, outfit, pet or visor",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Question Duration",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": One question per Ghost",
                        CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler"),
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": Shield Duration",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": Rewind Duration",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": Revive player during Rewind",
                        CustomOptionHolder.cs(Squire.color, "Squire"),
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": Show Shielded Player to", // 204
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": Play murder attempt sound if shielded",
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": Can shield again after meeting",
                        CustomOptionHolder.cs(Cheater.color, "Cheater"),
                        "- " + CustomOptionHolder.cs(Cheater.color, "Cheater") + ": Can use emergency button",
                        "- " + CustomOptionHolder.cs(Cheater.color, "Cheater") + ": Can swap himself",
                        CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller"),
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Reveal Time",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Reveal Number",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Revealed Information", // 214
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Show Notification to", // 215
                        CustomOptionHolder.cs(Hacker.color, "Hacker"),
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": Duration",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": Battery Uses",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": Tasks for recharge batteries",
                        CustomOptionHolder.cs(Sleuth.color, "Sleuth"),
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": Track Interval",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": Can Track again after meeting",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": Track Corpses Cooldown",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": Track Corpses Duration",
                        CustomOptionHolder.cs(Fink.color, "Fink"),
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": Tasks remaining for being revealed to Impostors",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": Can reveal Renegade / Minion",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": Hawkeye Duration",
                        CustomOptionHolder.cs(Kid.color, "Kid"),
                        CustomOptionHolder.cs(Welder.color, "Welder"),
                        "- " + CustomOptionHolder.cs(Welder.color, "Welder") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Welder.color, "Welder") + ": Seal Number",
                        CustomOptionHolder.cs(Spiritualist.color, "Spiritualist"),
                        "- " + CustomOptionHolder.cs(Spiritualist.color, "Spiritualist") + ": Revive Player Time",
                        CustomOptionHolder.cs(Vigilant.color, "Vigilant"),
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": Remote Camera Duration",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": Battery Uses",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": Tasks for recharge batteries",
                        CustomOptionHolder.cs(Hunter.color, "Hunter"),
                        "- " + CustomOptionHolder.cs(Hunter.color, "Hunter") + ": Can mark again after meeting",
                        CustomOptionHolder.cs(Jinx.color, "Jinx"),
                        "- " + CustomOptionHolder.cs(Jinx.color, "Jinx") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Jinx.color, "Jinx") + ": Jinx Number",
                        CustomOptionHolder.cs(Coward.color, "Coward"),
                        "- " + CustomOptionHolder.cs(Coward.color, "Coward") + ": Number Of Meetings",
                        CustomOptionHolder.cs(Bat.color, "Bat"),
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": Emit Duration",
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": Emit Range",
                        CustomOptionHolder.cs(Necromancer.color, "Necromancer"),
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": Revive Duration",
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": Room Distance",
                        CustomOptionHolder.cs(Engineer.color, "Engineer"),
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Trap Number",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Trap Duration",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Speed Increase",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Speed Decrease",
                        CustomOptionHolder.cs(Shy.color, "Shy"),
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": Duration",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": Notify Range",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": Arrow color is player color",
                        CustomOptionHolder.cs(TaskMaster.color, "Task Master"),
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Extra Common Tasks",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Extra Long Tasks",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Extra Short Tasks",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Speed Cooldown",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Speed Duration",
                        CustomOptionHolder.cs(Jailer.color, "Jailer"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Jailer") + ": Cooldown",
                        "- " + CustomOptionHolder.cs(Jailer.color, "Jailer") + ": Jail Duration"
                    };
            for (int o = 0; o < customOptionNames.Count(); o++)
            {
                CustomOption.options[o].name = customOptionNames[o];
                switch (o)
                {
                    case 45:
                        CustomOption.options[o].selections = new string[] { "Taser", "All", "Nobody" };
                        break;
                    case 77:
                        CustomOption.options[o].selections = new string[] { "All vs All", "Team Battle", "Score Battle" };
                        break;
                    case 186:
                        CustomOption.options[o].selections = new string[] { "Button Use", "Always" };
                        break;
                    case 204:
                        CustomOption.options[o].selections = new string[] { "Squire", "Both", "All" };
                        break;
                    case 214:
                        CustomOption.options[o].selections = new string[] { "Good / Bad", "Role Name" };
                        break;
                    case 215:
                        CustomOption.options[o].selections = new string[] { "Impostors", "Crewmates", "All", "Nobody" };
                        break;
                }
            }
            roleInfoNames = new string[] {
                        "Steal <color=#0000FFFF>Blue Team</color> flag",
                        "Steal <color=#FF0000FF>Red Team</color> flag",
                        "Kill the player with a flag to switch teams with it",
                        "Kill the player with\na flag to switch teams with it",
                        "Capture all the <color=#D2B48CFF>Thieves</color>",
                        "Tase the <color=#D2B48CFF>Thieves</color>",//5
                        "Tase the <color=#D2B48CFF>Thieves\nwith right click</color>",
                        "Steal all the jewels without getting captured",
                        "Steal all the jewels\nwithout getting captured",
                        "Capture the zones",
                        "Protect your King", //10
                        "Kill a King to become one",
                        "Give the hot potato to other player",
                        "Give the hot potato\nto other player",
                        "Run from the <color=#808080FF>Hot Potato</color>",
                        "You are burnt",//15
                        "Heal survivors and create the cure",
                        "Heal survivors\nand create the cure",
                        "Survive while looking for items to make the cure",
                        "Survive while looking\nfor items to make the cure",
                        "Infect all survivors",//20
                        "Be the last one alive",
                        "Kill <color=#F2BEFFFF>Pink</color> Team",
                        "Kill <color=#39FF14FF>Lime</color> Team",
                        "Mimic other player's look",
                        "Paint players with the same color",//25
                        "Bite players to delay their death",
                        "Remove and move bodies from the crime scene",
                        "Remove and move bodies\nfrom the crime scene",
                        "Create your own vent network and turn off the lights",
                        "Create your own vent\nnetwork and turn off the lights", //30
                        "Manipulate a player to kill his adjacent",
                        "Sabotage by putting bombs",
                        "Make yourself invisible",
                        "Shoot a player choosing their role during the meeting",
                        "Shoot a player choosing\ntheir role during the meeting",//35
                        "Casts spells on players",
                        "Petrify players",
                        "Invert player movement controls",
                        "Make range kills",
                        "Pick bow with F\nand right click to shoot", //40
                        "Create new vents",
                        "Silence a player to prevent him from talking",
                        "Silence a player\nto prevent him from talking",
                        "Recruit a Minion and kill everyone",
                        "Help the Renegade killing everyone",//45
                        "Hunt down your target",
                        "Place landmines and root traps",
                        "Mark two players to die if they collide",
                        "Mark two players\nto die if they collide",
                        "Challenge a player to a rock-paper-scissors duel",//50
                        "Challenge a player to\na rock-paper-scissors duel",
                        "Mark and make double kills",
                        "You can't stop killing",
                        "Stalk and kill your target",
                        "Find ammo and kill 3 players",//55
                        "Recover your items and transform into Monja",
                        "Recover your items\nand transform into Monja",
                        "Get voted out to win",
                        "Get voted out to win\nOpen the map to activate the sabotage button",
                        "Steal other player's role",//60
                        "Ignite all survivors to win",
                        "Find treasures to win",
                        "Devour bodies to win",
                        "Poison all players to win",
                        "Poison all players to win\nOpen the map to activate the sabotage button",//65
                        "Make dummies and get them killed to win",
                        "Make dummies and\nget them killed to win",
                        "Get your target voted out to win",
                        "Remember your role reporting a body",
                        "Gain points playing hide and seek",//70
                        "Your vote counts twice",
                        "Repair sabotages on the ship",
                        "Kill the <color=#FF0000FF>Impostors</color>",
                        "Examine footprints",
                        "Find clues reporting bodies and asking their ghosts",//75
                        "Find clues reporting bodies\nand asking their ghosts",
                        "Rewind the time",
                        "Protect a player with your shield",
                        "Swap the votes of two players",
                        "Reveal who are the <color=#FF0000FF>Impostors</color>",//80
                        "Use Admin and Vitals from anywhere",
                        "Track down a player and corpses",
                        "Finish your tasks to reveal the <color=#FF0000FF>Impostors</color>",
                        "Everyone loses if you die or get voted out",
                        "Seal vents",//85
                        "Sacrifice yourself to revive a player",
                        "Call meetings from anywhere",
                        "Put additional cameras on the map",
                        "Activate remote Doorlog with Q key",
                        "Mark a player to die if you get killed",//90
                        "Jinx players abilities",
                        "Reduce button cooldown and increase impostor ones",
                        "Reduce button cooldown\nand increase impostor ones",
                        "Take a body to its room and revive it",
                        "Place speed and position traps",//95
                        "Place speed and position traps\nSwitch trap type with Q key",
                        "Check close players",
                        "Complete all the tasks and make the extra tasks to win",
                        "Complete all the tasks\nand make the extra tasks to win",
                        "Send killers to prison",//100
                        "Sabotage and kill everyone",
                        "Find and exile the <color=#FF0000FF>Impostors</color>",
                        "You have more vision",
                        "You have less vision",
                        "You're faster",//105
                        "You're bigger and slower",
                        "Your killer will report your body",
                        "Your death will trigger an alarm and reveal where your body is",
                        "Your death will trigger an alarm\nand reveal where your body is",
                        "Your movement controls are inverted",//110
                        "Your killer leaves a paint trail",
                        "Your killer will be paralyzed in place",
                        "♥Survive as a couple with your partner♥",
                        "♥Survive as a couple\nwith your partner♥",
                        "<color=#FF00D1FF>♥Survive as a couple with your partner♥. </color><color=#FF1919FF>Kill the rest</color>",//115
                        "<color=#FF00D1FF>♥Survive as a couple\nwith your partner♥. </color><color=#FF1919FF>Kill the rest</color>",
                    };
            exileControllerTexts = new string[] {
                        " was the ",
                        "You thought I was the Impostor but it was me, Joker!",
                        "That's all folks!"
                    };
            introTexts = new string[] {
                        "♥ Survive as a couple with ",
                        "Time Left: ",
                        "Score: ",
                        "Stolen Jewels: ",
                        "Captured Thieves: ",
                        "Hot Potato: ",
                        "Cold Potatoes: ",
                        "Key Items: ",
                        "Survivors: ",
                        "Infected: ",
                        "Zombies: ",
                        "Battle Royale Fighters: ",
                        "Lime Team: ",
                        "Pink Team: ",
                        "Serial Killer: ",
                        "Goal: ",
                        "Serial Killer Points: ",
                    };
            playerControlTexts = new string[] {
                        "It appears to be a suicide!",
                        "The killer appears to be",
                        "lighter (L) color!",
                        "darker (D) color!",
                        "The killer appears to have a",
                        "The killer appears to wear a hat!",
                        "The killer doesn't wear a hat!",
                        "The killer appears to wear an outfit!",
                        "The killer doesn't wear an outfit!",
                        "The killer appears to have a pet!",
                        "The killer hasn't got a pet!",
                        "The killer appears to wear a visor!",
                        "The killer doesn't wear a visor!",
                        "The body is too old to gain information from!",
                        "Time Elapsed:"
                    };
            usablesTexts = new string[] {
                        "Can't use the emergency button\non custom gamemodes!",
                        "The Cheater can't use the emergency button!",
                        "The Gambler can't use the emergency button!",
                        "The Sorcerer can't use the emergency button!",
                        "There's a Bomb, you can't use the emergency button!",
                        "There's a Blackout, emergency button doesn't work!",
                        "THE MONJA HAS AWAKENED, RUN YOU FOOLS!"
                    };
            buttonsTexts = new string[] {
                        "Ghost of (",
                        "I was the ",
                        "My killer has a ",
                        "Time since death ",
                        "My killer was the "
                    };
            helpersTexts = new string[] {
                        " and recruit a Minion",
                        "Kill everyone"
                    };
            statusRolesTexts = new string[] {
                        "Speed Changed!",
                        "Hypnotized!",
                        "Target Died",
                        "Rampage Mode",
                        "Seeker's current points: ",
                        "The Illusionist turned off the lights: ",
                        "There's a Bomb on the map: ",
                        "Petrified!",
                        "THE MONJA HAS AWAKENED: ",
                        "Amnesiac Body Report: This role can't be remembered",
                        "Fink is using Hawkeye!",
                    };
            statusCaptureTheFlagTexts = new string[] {
                        "You're the new <color=#FF0000FF>Red Team</color> player now!",
                        "You're the new <color=#0000FFFF>Blue Team</color> player now!",
                        "<color=#0000FFFF>Blue Flag</color> stolen by <color=#FF0000FF>",
                        "Your flag has been stolen!",
                        "<color=#FF0000FF>Red Flag</color> stolen by <color=#0000FFFF>",
                        "<color=#FF0000FF>Red Team</color> scored!",
                        "<color=#0000FFFF>Blue Team</color> scored!"
                    };
            statusPoliceAndThiefsTexts = new string[] {
                        "A <color=#928B55FF>Thief</color> has been captured!",
                        "A <color=#928B55FF>Thief</color> has been released!",
                        "A <color=#00F7FFFF>Jewel</color> has been delivered!"
                    };
            statusKingOfTheHillTexts = new string[] {
                        "You're the new <color=#00FF00FF>Green King</color>!",
                        "You're the new <color=#FFFF00FF>Yellow King</color>!",
                        "<color=#00FF00FF>Green King</color> has captured a zone!",
                        "<color=#FFFF00FF>Yellow King</color> has captured a zone!",
                        "Your King has been killed!"
                    };
            statusHotPotatoTexts = new string[] {
                        " is the new Hot Potato!"
                    };
            statusZombieLaboratoryTexts = new string[] {
                        "A <color=#FF00FFFF>Key Item</color> has been delivered!",
                        "A <color=#00CCFFFF>Survivor</color> has been <color=#FFFF00FF>Infected</color>!",
                        "A <color=#00CCFFFF>Survivor</color> turned into a <color=#996633FF>Zombie</color>!"
                    };
            statusBattleRoyaleTexts = new string[] {
                        "One <color=#009F57FF>Fighter</color> down!",
                        "One <color=#39FF14FF>Lime Fighter</color> down!",
                        "One <color=#F2BEFFFF>Pink Fighter</color> down!",
                        "<color=#808080FF>Serial Killer</color> down!",
                        "Points for <color=#39FF14FF>Lime Team</color>!",
                        "Points for <color=#F2BEFFFF>Pink Team</color>!",
                        "Points for <color=#808080FF>Serial Killer</color>!",
                    };
        }
    }
}