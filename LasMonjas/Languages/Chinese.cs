using UnityEngine;
using System.Linq;
using LasMonjas.Core;
using static LasMonjas.Languages.Language;

namespace LasMonjas.Languages
{
    public class Chinese
    {
        public static void Chineselang()
        {
            colorNames = new string[5] { "薰衣紫", "深绿色", "薄荷色", "橄榄绿", "冰蓝色" };
            for (int i = 0; i < colorNames.Count(); i++)
            {
                CustomColors.ColorStrings[i + 50000] = colorNames[i];
            }
            customOptionNames = new string[] {
                        CustomOptionHolder.cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "预设"),
                        CustomOptionHolder.cs(Jailer.color, "全局设置"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "激活修道院模组专属职业和模式"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "激活千年隼地图"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "隐藏关灯时使用管道动画"),
                        CustomOptionHolder.cs(Detective.color, "职业设置"),
                        "- " + CustomOptionHolder.cs(Detective.color, "启用模组职业"),
                        "- " + CustomOptionHolder.cs(Detective.color, "移除刷卡任务"),
                        "- " + CustomOptionHolder.cs(Detective.color, "移除飞艇地图的门"),
                        "- " + CustomOptionHolder.cs(Detective.color, "破坏灯光时监控不显示"),
                        "- " + CustomOptionHolder.cs(Detective.color, "破坏反应堆时屏幕晃动"),
                        "- " + CustomOptionHolder.cs(Detective.color, "破坏通讯进入隐蔽状态"),
                        "- " + CustomOptionHolder.cs(Detective.color, "破坏氧气时降低速度"),
                        CustomOptionHolder.cs(Modifiers.color, "Modifiers"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Lovers"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Lighter"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Blind"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Flash"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Big Chungus"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "The Chosen One"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "The Chosen One") + ": 报告延迟",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Performer"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Performer") + ": 警报持续时间",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Pro"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Paintball"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Paintball") + ": 隐蔽持续时间",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Electrician"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Electrician") + ": 释放持续时间",
                        CustomOptionHolder.cs(Sheriff.color, "Capture the Flag"),
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": 比赛时长",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": 分数",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": 击杀冷却时间",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": 复活等待时间",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": 复活无敌时间",
                        CustomOptionHolder.cs(Coward.color, "Police and Thieves"),
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 比赛时长",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 宝石数量",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察击杀冷却时间",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察抓捕冷却时间",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 抓捕所需时间",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察电击枪冷却时间",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察电击效果持续时间",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察可以看见宝石",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察视野范围",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察复活等待时间",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 小偷可以击杀", // 45
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 小偷击杀冷却时间",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 小偷复活等待时间",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 复活无敌时间",
                        CustomOptionHolder.cs(Squire.color, "King of the Hill"),
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 比赛时长",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 分数",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 偷取冷却时间",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 击杀冷却时间",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 国王可以击杀",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 复活等待时间",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 复活无敌时间",
                        CustomOptionHolder.cs(Shy.color, "Hot Potato"),
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": 比赛时长",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": 烫山芋爆炸倒计时",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": 传递烫山芋冷却时间",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": 冷山芋视野范围",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": 传递烫山芋重置爆炸时间",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": 不重置倒计时时追加时间",
                        CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory"),
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 比赛时长",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 初始丧尸",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 丧尸感染所需时间",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 丧尸感染冷却时间",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 幸存者打开箱子所需时间",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 幸存者视野",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 护士治愈所需时间",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 击杀冷却时间",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 复活等待时间",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 复活无敌时间",
                        CustomOptionHolder.cs(Sleuth.color, "Battle Royale"),
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 比赛时长",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 游戏类型", // 77
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 击杀冷却时间",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 战士的生命",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 分数",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 复活等待时间",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 复活无敌时间",
                        CustomOptionHolder.cs(Mimic.color, "Mimic"),
                        "- " + CustomOptionHolder.cs(Mimic.color, "Mimic") + ": 持续时间",
                        CustomOptionHolder.cs(Painter.color, "Painter"),
                        "- " + CustomOptionHolder.cs(Painter.color, "Painter") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Painter.color, "Painter") + ": 持续时间",
                        CustomOptionHolder.cs(Demon.color, "Demon"),
                        "- " + CustomOptionHolder.cs(Demon.color, "Demon") + ": 延迟时间",
                        "- " + CustomOptionHolder.cs(Demon.color, "Demon") + ": 可以在修女附近击杀",
                        CustomOptionHolder.cs(Janitor.color, "Janitor"),
                        "- " + CustomOptionHolder.cs(Janitor.color, "Janitor") + ": 冷却时间",
                        CustomOptionHolder.cs(Illusionist.color, "Illusionist"),
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": 帽子冷却时间",
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": 关灯冷却时间",
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": 关灯持续时间",
                        CustomOptionHolder.cs(Manipulator.color, "Manipulator"),
                        CustomOptionHolder.cs(Bomberman.color, "Bomberman"),
                        "- " + CustomOptionHolder.cs(Bomberman.color, "Bomberman") + ": 冷却时间",
                        CustomOptionHolder.cs(Chameleon.color, "Chameleon"),
                        "- " + CustomOptionHolder.cs(Chameleon.color, "Chameleon") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Chameleon.color, "Chameleon") + ": 持续时间",
                        CustomOptionHolder.cs(Gambler.color, "Gambler"),
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": 猜测次数",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": 可以使用紧急会议",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": 可以多次猜测",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": 无视护盾",
                        CustomOptionHolder.cs(Sorcerer.color, "Sorcerer"),
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": 每次诅咒追加冷却时间",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": 诅咒所需时间",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": 可以使用紧急会议",
                        CustomOptionHolder.cs(Medusa.color, "Medusa"),
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": 石化延迟",
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": 石化持续时间",
                        CustomOptionHolder.cs(Hypnotist.color, "Hypnotist"),
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": 技能次数",
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": 技能持续时间",
                        CustomOptionHolder.cs(Archer.color, "Archer"),
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": 箭矢大小",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": 攻击范围",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": 攻击警报范围",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": 目标时限",
                        CustomOptionHolder.cs(Plumber.color, "Plumber"),
                        "- " + CustomOptionHolder.cs(Plumber.color, "Plumber") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Plumber.color, "Plumber") + ": 管道数量",
                        CustomOptionHolder.cs(Librarian.color, "Librarian"),
                        "- " + CustomOptionHolder.cs(Librarian.color, "Librarian") + ": 冷却时间",
                        CustomOptionHolder.cs(Renegade.color, "Renegade"),
                        "- " + CustomOptionHolder.cs(Renegade.color, "Renegade") + ": 可以使用管道",
                        "- " + CustomOptionHolder.cs(Renegade.color, "Renegade") + ": 可以招募小弟",
                        CustomOptionHolder.cs(BountyHunter.color, "Bounty Hunter"),
                        CustomOptionHolder.cs(Trapper.color, "Trapper"),
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": 地雷放置数量",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": 地雷持续时间",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": 陷阱数量",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": 陷阱持续时间",
                        CustomOptionHolder.cs(Yinyanger.color, "Yinyanger"),
                        "- " + CustomOptionHolder.cs(Yinyanger.color, "Yinyanger") + ": 冷却时间",
                        CustomOptionHolder.cs(Challenger.color, "Challenger"),
                        "- " + CustomOptionHolder.cs(Challenger.color, "Challenger") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Challenger.color, "Challenger") + ": 殺來贏",
                        CustomOptionHolder.cs(Ninja.color, "Ninja"),
                        CustomOptionHolder.cs(Berserker.color, "Berserker"),
                        "- " + CustomOptionHolder.cs(Berserker.color, "Berserker") + ": 击杀时限",
                        CustomOptionHolder.cs(Yandere.color, "Yandere"),
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": 追踪冷却时间",
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": 追踪时间",
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": 追踪持续时间",
                        CustomOptionHolder.cs(Stranded.color, "Stranded"),
                        CustomOptionHolder.cs(Monja.color, "Monja"),
                        CustomOptionHolder.cs(Joker.color, "Joker"),
                        "- " + CustomOptionHolder.cs(Joker.color, "Joker") + ": 可以破坏",
                        CustomOptionHolder.cs(RoleThief.color, "Role Thief"),
                        "- " + CustomOptionHolder.cs(RoleThief.color, "Role Thief") + ": 冷却时间",
                        CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac"),
                        "- " + CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac") + ": 无视持续时间",
                        CustomOptionHolder.cs(TreasureHunter.color, "Treasure Hunter"),
                        "- " + CustomOptionHolder.cs(TreasureHunter.color, "Treasure Hunter") + ": 寻宝成功",
                        CustomOptionHolder.cs(Devourer.color, "Devourer"),
                        "- " + CustomOptionHolder.cs(Devourer.color, "Devourer") + ": 吞噬尸体获得胜利",
                        CustomOptionHolder.cs(Poisoner.color, "Poisoner"),
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": 下毒所需时间",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": 病毒感染范围",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": 病毒感染时间",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": 可以破坏",
                        CustomOptionHolder.cs(Puppeteer.color, "Puppeteer"),
                        "- " + CustomOptionHolder.cs(Puppeteer.color, "Puppeteer") + ": 击杀次数",
                        CustomOptionHolder.cs(Exiler.color, "Exiler"),
                        CustomOptionHolder.cs(Amnesiac.color, "Amnesiac"),
                        CustomOptionHolder.cs(Seeker.color, "Seeker"),
                        "- " + CustomOptionHolder.cs(Seeker.color, "Seeker") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Seeker.color, "Seeker") + ": 分数达标",
                        CustomOptionHolder.cs(Captain.color, "Captain"),
                        "- " + CustomOptionHolder.cs(Captain.color, "Captain") + ": 可以投出特别的一票",
                        CustomOptionHolder.cs(Mechanic.color, "Mechanic"),
                        "- " + CustomOptionHolder.cs(Mechanic.color, "Mechanic") + ": 维修次数",
                        "- " + CustomOptionHolder.cs(Mechanic.color, "Mechanic") + ": 专业维修",
                        CustomOptionHolder.cs(Sheriff.color, "Sheriff"),
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Sheriff") + ": 可以击杀中立阵营",
                        CustomOptionHolder.cs(Detective.color, "Detective"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": 显示脚印", // 184
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": 脚印显示时间",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": 匿名脚印",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": 脚印生成间隔",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": 脚印持续时间",
                        CustomOptionHolder.cs(Forensic.color, "Forensic"),
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 显示凶手名字报告时间",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 显示凶手颜色类型报告时间",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 显示凶手是否有帽子、衣服、宠物或面罩报告时间",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 询问持续时间",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 每个灵魂只能询问一次",
                        CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler"),
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": 时之盾持续时间",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": 回溯持续时间",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": 回溯过程中复活玩家",
                        CustomOptionHolder.cs(Squire.color, "Squire"),
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": 展示被庇护的玩家", // 204
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": 被庇护玩家被尝试击杀时播放音效",
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": 会议结束后重置护盾",
                        CustomOptionHolder.cs(Cheater.color, "Cheater"),
                        "- " + CustomOptionHolder.cs(Cheater.color, "Cheater") + ": 可以使用紧急会议",
                        "- " + CustomOptionHolder.cs(Cheater.color, "Cheater") + ": 可以交换自己",
                        CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller"),
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 预言所需时间",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 预言次数",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 预言信息", // 214
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 显示通知给", // 215
                        CustomOptionHolder.cs(Hacker.color, "Hacker"),
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": 持续时间",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": 电池用途",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": 充能需要完成的任务数",
                        CustomOptionHolder.cs(Sleuth.color, "Sleuth"),
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": 追踪箭头更新时间",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": 会议后可重置追踪目标",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": 追踪尸体冷却时间",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": 追踪尸体持续时间",
                        CustomOptionHolder.cs(Fink.color, "Fink"),
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": 揭发内鬼的剩余任务",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": 与叛乱者阵营相互发现 Renegade / Minion",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": 鹰眼持续时间",
                        CustomOptionHolder.cs(Kid.color, "Kid"),
                        CustomOptionHolder.cs(Welder.color, "Welder"),
                        "- " + CustomOptionHolder.cs(Welder.color, "Welder") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Welder.color, "Welder") + ": 密封管道次数",
                        CustomOptionHolder.cs(Spiritualist.color, "Spiritualist"),
                        "- " + CustomOptionHolder.cs(Spiritualist.color, "Spiritualist") + ": 复活玩家所需时间",
                        CustomOptionHolder.cs(Vigilant.color, "Vigilant"),
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": 远程查看监控持续时间",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": 电池用途",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": 充能需要完成的任务数",
                        CustomOptionHolder.cs(Hunter.color, "Hunter"),
                        "- " + CustomOptionHolder.cs(Hunter.color, "Hunter") + ": 会议后重置标记",
                        CustomOptionHolder.cs(Jinx.color, "Jinx"),
                        "- " + CustomOptionHolder.cs(Jinx.color, "Jinx") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Jinx.color, "Jinx") + ": 把霉运分给其他人",
                        CustomOptionHolder.cs(Coward.color, "Coward"),
                        "- " + CustomOptionHolder.cs(Coward.color, "Coward") + ": 会议次数",
                        CustomOptionHolder.cs(Bat.color, "Bat"),
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": 技能冷却时间",
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": 发出范围",
                        CustomOptionHolder.cs(Necromancer.color, "Necromancer"),
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": 复活时间",
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": 房间距离",
                        CustomOptionHolder.cs(Engineer.color, "Engineer"),
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": 陷阱数量",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": 陷阱持续时间",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": 速度加快",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": 速度减慢",
                        CustomOptionHolder.cs(Shy.color, "Shy"),
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": 持续时间",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": 攻击警报范围",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": 箭头颜色是玩家颜色",
                        CustomOptionHolder.cs(TaskMaster.color, "Task Master"),
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 额外的普通任务",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 额外的长任务",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 额外的短任务",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 速度冷却时间",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 速度持续时间",
                        CustomOptionHolder.cs(Jailer.color, "Jailer"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Jailer") + ": 冷却时间",
                        "- " + CustomOptionHolder.cs(Jailer.color, "Jailer") + ": 监禁时间"
                    };
            for (int o = 0; o < customOptionNames.Count(); o++)
            {
                CustomOption.options[o].name = customOptionNames[o];
                switch (o)
                {
                    case 45:
                        CustomOption.options[o].selections = new string[] { "Taser", "所有", "无" };
                        break;
                    case 77:
                        CustomOption.options[o].selections = new string[] { "所有 VS 所有", "团队", "分数" };
                        break;
                    case 186:
                        CustomOption.options[o].selections = new string[] { "技能按钮", "始终" };
                        break;
                    case 204:
                        CustomOption.options[o].selections = new string[] { "Squire", "两者", "所有" };
                        break;
                    case 214:
                        CustomOption.options[o].selections = new string[] { "好的 / 坏的", "角色名称" };
                        break;
                    case 215:
                        CustomOption.options[o].selections = new string[] { "内鬼", "船员", "所有", "无" };
                        break;
                }
            }
            roleInfoNames = new string[] {
                        "窃取<color=#0000FFFF>蓝队</color>旗帜",
                        "窃取<color=#FF0000FF>红队</color>旗帜",
                        "杀死拿着旗子的玩家，与它交换队伍",
                        "杀死拿着旗子的玩家, 与它交换队伍",
                        "捕获所有的<color=#D2B48CFF>盗贼</color>",
                        "用右键击打<color=#D2B48CFF>盗贼</color>",//5
                        "用右键击打<color=#D2B48CFF>盗贼</color>",
                        "偷取所有珠宝而不被抓获",
                        "偷取所有珠宝而不被抓获",
                        "占领区域",
                        "保护你的国王", //10
                        "杀死一个国王并替代他成为国王",
                        "把热的山芋送给其他玩家",
                        "把热的山芋送给其他玩家",
                        "远离<color=#808080FF>热山芋</color>",
                        "你被烫伤了",//15
                        "寻找解药并治疗正在被感染的幸存者",
                        "寻找解药并治疗正在被感染的幸存者",
                        "生存下去，同时寻找物品来获得",
                        "生存下去，同时寻找物品来获得",
                        "感染所有幸存者",//20
                        "成为最后一个活着的人",
                        "杀死<color=#F2BEFFFF>粉队</color>",
                        "杀死<color=#39FF14FF>灰队</color>",
                        "模仿其他玩家的造型",
                        "将玩家变成相同颜色和外形",//25
                        "咬住玩家以延迟他们的死亡",
                        "从犯罪现场移走尸体",
                        "从犯罪现场移走尸体",
                        "创建你自己的通风网络并关上灯",
                        "创建你自己的通风网络并关上灯", //30
                        "操纵玩家杀死他附近的玩家",
                        "放置炸弹破坏",
                        "让自己隐身",
                        "会议期间猜测玩家的职业",
                        "会议期间猜测玩家的职业",//35
                        "对玩家施放长矛",
                        "到处巡逻",
                        "反转玩家的移动方向",
                        "用F键选取弓箭，然后点击右键进行射击",
                        "用F键选取弓箭，然后点击右键进行射击", //40
                        "建造新的通风口",
                        "嘘，不要说话~",
                        "嘘，不要说话~",
                        "招募一个小弟，杀光所有人",
                        "帮助叛徒杀死所有人",//45
                        "猎取你的目标",
                        "埋设地雷和尖刺陷阱",
                        "你们只是阴阳之人罢了",
                        "你们只是阴阳之人罢了",
                        "猜拳来决一胜负吧",//50
                        "猜拳来决一胜负吧",
                        "标记并进行双杀",
                        "你越杀越兴奋，根本停不下来！！",
                        "追踪并杀死你的目标",
                        "寻找弹药并杀死3名玩家",//55
                        "找回你的物品，变身为 Monja",
                        "找回你的物品，变身为 Monja",
                        "想办法被放逐",
                        "想办法被放逐，打开地图，激活破坏按钮",
                        "窃取其他玩家的职业",//60
                        "燃烧吧，多么美妙的火焰！",
                        "宝藏！",
                        "吃尸体，吃更多尸体",
                        "带给船员们瘟疫吧",
                        "带给船员们瘟疫吧，打开地图，激活破坏的按钮",//65
                        "制作傀儡，让傀儡被杀以获得胜利",
                        "制作傀儡，让傀儡被杀以获得胜利",
                        "驱逐你的目标",
                        "记住你职业的作用报告尸体",
                        "捉迷藏获得积分",//70
                        "你的票数是其他人的两倍",
                        "快速修理船上的破坏",
                        "执法<color=#FF0000FF>内鬼</color>！",
                        "通过脚印痕迹找出内鬼",
                        "通过报告尸体和询问灵魂得到线索",//75
                        "通过报告尸体和询问灵魂得到线索",
                        "时光倒流",
                        "用你的护盾保护一名玩家",
                        "互换两名玩家的票",
                        "找出谁是真正的<color=#FF0000FF>内鬼</color>",//80
                        "从任何地方使用管理面板和生命检测仪",
                        "追踪玩家和寻找尸体",
                        "完成你的任务，找出<color=#FF0000FF>内鬼</color>",
                        "你是个孩子，没人会伤害你",
                        "把通风口堵死",//85
                        "牺牲自己来复活玩家",
                        "从任何地方发起会议",
                        "安装更多的监控在地图上",
                        "用Q键激活遥控门锁",
                        "如果你被杀，标记一位玩家同归于尽",//90
                        "把霉运分给其他人",
                        "减少技能的冷却时间，并增加内鬼技能的冷却时间。",
                        "减少技能的冷却时间，并增加内鬼技能的冷却时间。",
                        "将尸体拖到指定位置并等待",
                        "设置速度和位置机关",//95
                        "设置速度和位置机关，用Q键切换陷阱类型",
                        "察觉附近的玩家",
                        "完成所有的任务，并完成额外的任务来赢得胜利。",
                        "完成所有的任务，并完成额外的任务来赢得胜利。",
                        "把凶手送进监狱",//100
                        "破坏设备并杀光所有人",
                        "找出并驱逐<color=#FF0000FF>内鬼</color>",
                        "你有更广阔的视野",
                        "你的视野变窄了",
                        "你的速度更快了",//105
                        "你更大了，但也更慢了",
                        "杀害你的人会报告你的尸体",
                        "你的死亡会触发警报，并显示你的尸体在哪里。",
                        "你的死亡会触发警报，并显示你的尸体在哪里。",
                        "你移动的方向颠倒了",//110
                        "杀害你的凶手留下血液痕迹",
                        "杀害你的凶手会短暂的无法移动",
                        "♥与你的恋人一起活到最后♥",
                        "♥与你的恋人一起活到最后♥",
                        "<color=#FF00D1FF>♥与你的恋人一起活到最后♥. </color><color=#FF1919FF>并杀掉其他人</color>",//115
                        "<color=#FF00D1FF>♥与你的恋人一起活到最后♥. </color><color=#FF1919FF>并杀掉其他人</color>",
                    };
            exileControllerTexts = new string[] {
                        " 是 ",
                        "没想到吧, Joker!",
                        "这就是所有的人!"
                    };
            introTexts = new string[] {
                        "♥ 一起活到最后 ",
                        "剩余时间: ",
                        "分数: ",
                        "被盗的珠宝: ",
                        "被盗的珠宝: ",
                        "烫手山芋: ",
                        "冷山芋: ",
                        "关键线索: ",
                        "幸存者: ",
                        "你被感染了: ",
                        "丧尸: ",
                        "丛林大逃杀: ",
                        "灰色阵营: ",
                        "粉色阵营: ",
                        "连环杀手: ",
                        "目标: ",
                        "连环杀手分数: ",
                    };
            playerControlTexts = new string[] {
                        "疑似自杀！",
                        "凶手疑似是",
                        "浅 (L)!",
                        "深 色 (D)!",
                        "凶手的颜色似乎是 ",
                        "凶手似乎戴着帽子!",
                        "凶手似乎不戴着帽子!",
                        "凶手似乎戴着衣服!",
                        "凶手似乎不戴着衣服!",
                        "凶手似乎戴着宠物!",
                        "凶手似乎不戴着宠物!",
                        "凶手似乎戴着面罩!",
                        "凶手似乎不戴着面罩!",
                        "尸体报告时间过久，没有信息！",
                        "时间流逝:"
                    };
            usablesTexts = new string[] {
                        "在自定义游戏模式中不能发起会议！",
                        "Cheater 不能发起会议！",
                        "Gambler 不能发起会议！",
                        "Sorcerer 不能发起会议！",
                        "有炸弹！你不能发起会议！",
                        "停电了，紧急会议按钮断电了!",
                        "MONJA 已经苏醒，你们这群小笨蛋快逃吧！！！"
                    };
            buttonsTexts = new string[] {
                        "的灵魂 (",
                        "我的职业 ",
                        "击杀我的凶手是 ",
                        "死后的时间 ",
                        "杀死我的凶手职业 "
                    };
            helpersTexts = new string[] {
                        " 并招募一个小弟",
                        "杀死所有人"
                    };
            statusRolesTexts = new string[] {
                        "速度变化！",
                        "你被催眠了！",
                        "目标死亡",
                        "暴走模式",
                        "Seeker 分数: ",
                        "Illusionist 关掉了灯光: ",
                        "地图上有一颗炸弹: ",
                        "受到了惊吓！",
                        "MONJA 醒了: ",
                        "Amnesiac Body Report: 这个身份不能被记住",
                        "Fink 使用了鹰眼！",
                    };
            statusCaptureTheFlagTexts = new string[] {
                        "你成为了<color=#FF0000FF>红队</color>成员！",
                        "你成为了<color=#0000FFFF>蓝队</color>成员！",
                        "<color=#0000FFFF>蓝队</color>旗帜被夺走了<color=#FF0000FF>",
                        "你们家旗帜被夺走了！",
                        "<color=#FF0000FF>红队</color>旗帜被夺走了<color=#0000FFFF>",
                        "<color=#FF0000FF>红队</color>得分！",
                        "<color=#0000FFFF>蓝队</color>得分！"
                    };
            statusPoliceAndThiefsTexts = new string[] {
                        "捕获一名小偷！",
                        "一名小偷越狱了！",
                        "偷到一颗宝石！"
                    };
            statusKingOfTheHillTexts = new string[] {
                        "你成为<color=#00FF00FF>绿队新国王</color>!",
                        "你成为<color=#FFFF00FF>黄队新国王</color>!",
                        "<color=#00FF00FF>绿队</color>国王占领了一块领地！",
                        "<color=#FFFF00FF>黄队</color>国王占领了一块领地！",
                        "你的国王被击杀了！"
                    };
            statusHotPotatoTexts = new string[] {
                        " 是新的烫手山芋!"
                    };
            statusZombieLaboratoryTexts = new string[] {
                        "一个关键物品已送达！",
                        "感染了一名幸存者！",
                        "一位幸存者被感染！"
                    };
            statusBattleRoyaleTexts = new string[] {
                        "一名战士倒下！",
                        "一位<color=#39FF14FF>灰队玩家</color>倒下！",
                        "一位<color=#F2BEFFFF>粉队玩家</color>倒下！",
                        "<color=#808080FF>连环杀手</color>倒下！",
                        "<color=#39FF14FF>灰色阵营</color>的分数！",
                        "<color=#F2BEFFFF>粉色阵营</color>的分数！",
                        "<color=#808080FF>连环杀手</color>的分数！",
                    };
            nextpage ="\n按Tab切换下一页";
            ToLanguageName();
        }
        public static void ToLanguageName()
        {
            if(tolanguagename)
            {
                Rolesnames = new string[]{

                };
            }
            else
            English.Englishname();
        }
    }
}