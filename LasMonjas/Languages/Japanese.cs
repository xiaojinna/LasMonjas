using UnityEngine;
using System.Linq;
using LasMonjas.Core;
using static LasMonjas.Languages.Language;

namespace LasMonjas.Languages
{
    public class Japanese
    {
        public static void Japaneselang()
        {
            colorNames = new string[5] { "ラベンダー", "ペトロリウム", "ミント", "オリーブ", "アイス" };
            for (int i = 0; i < colorNames.Count(); i++)
            {
                CustomColors.ColorStrings[i + 50000] = colorNames[i];
            }
            customOptionNames = new string[] {
                        CustomOptionHolder.cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "プリセット"),
                        CustomOptionHolder.cs(Jailer.color, "全体設定"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Mod のロールとゲームモードを有効にします"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "カスタム Skeld マップを有効にします。"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "影のベントのアニメーションを非表示にします"),
                        CustomOptionHolder.cs(Detective.color, "ロールの設定"),
                        "- " + CustomOptionHolder.cs(Detective.color, "ロールモードを探します"),
                        "- " + CustomOptionHolder.cs(Detective.color, "カードをスワイプするタスクを削除します"),
                        "- " + CustomOptionHolder.cs(Detective.color, "飛行船のドアのタスクを削除します。"),
                        "- " + CustomOptionHolder.cs(Detective.color, "照明妨害時の暗視"),
                        "- " + CustomOptionHolder.cs(Detective.color, "原子炉妨害時のスクリーンシェイク"),
                        "- " + CustomOptionHolder.cs(Detective.color, "通信妨害の匿名プレイヤー"),
                        "- " + CustomOptionHolder.cs(Detective.color, "酸素妨害時の速度低下"),
                        CustomOptionHolder.cs(Modifiers.color, "修飾子"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Lovers"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Lighter"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Blind"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Flash"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Big Chungus"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "The Chosen One"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "The Chosen One") + ": レポートの遅れ",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Performer"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Performer") + ": アラーム機関",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Pro"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Paintball"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Paintball") + ": ペイント期間",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Electrician"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Electrician") + ": 放電期間",
                        CustomOptionHolder.cs(Sheriff.color, "Capture the Flag"),
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": 一致期間",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": スコア番号",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Kill のクールダウン",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": 復活の待ち時間",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": 復活後の無敵時間",
                        CustomOptionHolder.cs(Coward.color, "Police and Thieves"),
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 一致期間",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 宝石番号",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察 Kill のクールダウン",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察のクールダウン逮捕",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 逮捕時間",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察のスタンガンのクールダウン",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察のスタンガンの期間",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察は宝石をみることができる",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察の視界の距離",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 警察復活の待ち時間",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 泥棒は誰を殺すことができますか", // 45
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 泥棒 Kill のクールダウン",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 泥棒復活の待ち時間",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": 復活後の無敵時間",
                        CustomOptionHolder.cs(Squire.color, "King of the Hill"),
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 一致期間",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": スコア番号",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": クールダウンのキャプチャ",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Kill のクールダウン",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 王は Kill 可能",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 復活の待ち時間",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": 復活後の無敵時間",
                        CustomOptionHolder.cs(Shy.color, "Hot Potato"),
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": 一致期間",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": ホットポテトの転送時間制限",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": ホットポテトの転送クールダウン",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": コールドポテトの視界の距離",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": 転送後のホットポテトの時間のリセット",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": タイマーがリセットされない場合の追加時間",
                        CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory"),
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 一致期間",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 最初のゾンビ",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 感染までの時間",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 感染のクールダウン",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": ボックスタイマーの探索",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 生存者の視野の範囲",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 応急処置キットの使用時間",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Kill のクールダウン",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 復活の待ち時間",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": 復活後の無敵時間",
                        CustomOptionHolder.cs(Sleuth.color, "Battle Royale"),
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 一致期間",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 試合の種類", // 77
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Kill のクールダウン",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 戦士のライフ",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": スコア番号",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 復活の待ち時間",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": 復活後の無敵時間",
                        CustomOptionHolder.cs(Mimic.color, "Mimic"),
                        "- " + CustomOptionHolder.cs(Mimic.color, "Mimic") + ": 期間",
                        CustomOptionHolder.cs(Painter.color, "Painter"),
                        "- " + CustomOptionHolder.cs(Painter.color, "Painter") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Painter.color, "Painter") + ": 期間",
                        CustomOptionHolder.cs(Demon.color, "Demon"),
                        "- " + CustomOptionHolder.cs(Demon.color, "Demon") + ": 遅延時間",
                        "- " + CustomOptionHolder.cs(Demon.color, "Demon") + ": 修道女の近くでの Kill",
                        CustomOptionHolder.cs(Janitor.color, "Janitor"),
                        "- " + CustomOptionHolder.cs(Janitor.color, "Janitor") + ": クールダウン",
                        CustomOptionHolder.cs(Illusionist.color, "Illusionist"),
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": 防止の来るダウン",
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": 照明のクールダウン",
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": 停電の期間",
                        CustomOptionHolder.cs(Manipulator.color, "Manipulator"),
                        CustomOptionHolder.cs(Bomberman.color, "Bomberman"),
                        "- " + CustomOptionHolder.cs(Bomberman.color, "Bomberman") + ": クールダウン",
                        CustomOptionHolder.cs(Chameleon.color, "Chameleon"),
                        "- " + CustomOptionHolder.cs(Chameleon.color, "Chameleon") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Chameleon.color, "Chameleon") + ": 期間",
                        CustomOptionHolder.cs(Gambler.color, "Gambler"),
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": 撮影番号",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": 緊急ボタンの使用",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": 複数回の撮影",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": シールドの無視",
                        CustomOptionHolder.cs(Sorcerer.color, "Sorcerer"),
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": スペル毎の追加のクールダウン",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": スペルの期間",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": 緊急ボタンの使用",
                        CustomOptionHolder.cs(Medusa.color, "Medusa"),
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": 石化の遅延",
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": 石化期間",
                        CustomOptionHolder.cs(Hypnotist.color, "Hypnotist"),
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": スパイラル番号",
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": スパイラル効果期間",
                        CustomOptionHolder.cs(Archer.color, "Archer"),
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": 矢のサイズ",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": 矢の範囲",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": 通知範囲",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": 標的の範囲",
                        CustomOptionHolder.cs(Plumber.color, "Plumber"),
                        "- " + CustomOptionHolder.cs(Plumber.color, "Plumber") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Plumber.color, "Plumber") + ": ベントの回数",
                        CustomOptionHolder.cs(Librarian.color, "Librarian"),
                        "- " + CustomOptionHolder.cs(Librarian.color, "Librarian") + ": クールダウン",
                        CustomOptionHolder.cs(Renegade.color, "Renegade"),
                        "- " + CustomOptionHolder.cs(Renegade.color, "Renegade") + ": ベントの使用可",
                        "- " + CustomOptionHolder.cs(Renegade.color, "Renegade") + ": ミニオンのリクルート",
                        CustomOptionHolder.cs(BountyHunter.color, "Bounty Hunter"),
                        CustomOptionHolder.cs(Trapper.color, "Trapper"),
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": 鉱山番号",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": 鉱山の期間",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": トラップ番号",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": トラップ期間",
                        CustomOptionHolder.cs(Yinyanger.color, "Yinyanger"),
                        "- " + CustomOptionHolder.cs(Yinyanger.color, "Yinyanger") + ": クールダウン",
                        CustomOptionHolder.cs(Challenger.color, "Challenger"),
                        "- " + CustomOptionHolder.cs(Challenger.color, "Challenger") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Challenger.color, "Challenger") + ": 勝つために殺す",
                        CustomOptionHolder.cs(Ninja.color, "Ninja"),
                        CustomOptionHolder.cs(Berserker.color, "Berserker"),
                        "- " + CustomOptionHolder.cs(Berserker.color, "Berserker") + ": Kill の時間制限",
                        CustomOptionHolder.cs(Yandere.color, "Yandere"),
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": 見つめているクールダウン",
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": 凝視時間",
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": 凝視期間",
                        CustomOptionHolder.cs(Stranded.color, "Stranded"),
                        CustomOptionHolder.cs(Monja.color, "Monja"),
                        CustomOptionHolder.cs(Joker.color, "Joker"),
                        "- " + CustomOptionHolder.cs(Joker.color, "Joker") + ": 妨害可能",
                        CustomOptionHolder.cs(RoleThief.color, "Role Thief"),
                        "- " + CustomOptionHolder.cs(RoleThief.color, "Role Thief") + ": クールダウン",
                        CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac"),
                        "- " + CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac") + ": 点火期間",
                        CustomOptionHolder.cs(TreasureHunter.color, "Treasure Hunter"),
                        "- " + CustomOptionHolder.cs(TreasureHunter.color, "Treasure Hunter") + ": 勝つための宝物",
                        CustomOptionHolder.cs(Devourer.color, "Devourer"),
                        "- " + CustomOptionHolder.cs(Devourer.color, "Devourer") + ": 勝つために貪ります",
                        CustomOptionHolder.cs(Poisoner.color, "Poisoner"),
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": 毒する時間",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": 毒感染範囲",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": 完全に毒する時間",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": 妨害可能",
                        CustomOptionHolder.cs(Puppeteer.color, "Puppeteer"),
                        "- " + CustomOptionHolder.cs(Puppeteer.color, "Puppeteer") + ": キルの数",
                        CustomOptionHolder.cs(Exiler.color, "Exiler"),
                        CustomOptionHolder.cs(Amnesiac.color, "Amnesiac"),
                        CustomOptionHolder.cs(Seeker.color, "Seeker"),
                        "- " + CustomOptionHolder.cs(Seeker.color, "Seeker") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Seeker.color, "Seeker") + ": 勝つためのポイント",
                        CustomOptionHolder.cs(Captain.color, "Captain"),
                        "- " + CustomOptionHolder.cs(Captain.color, "Captain") + ": 一度特別投票できます",
                        CustomOptionHolder.cs(Mechanic.color, "Mechanic"),
                        "- " + CustomOptionHolder.cs(Mechanic.color, "Mechanic") + ": 修理番号",
                        "- " + CustomOptionHolder.cs(Mechanic.color, "Mechanic") + ": 専門家の修理",
                        CustomOptionHolder.cs(Sheriff.color, "Sheriff"),
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Sheriff") + ": ニュートラルを殺すことができます",
                        CustomOptionHolder.cs(Detective.color, "Detective"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": フットプリント", // 186
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": フットプリントの期間を表示します",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": 匿名のフットプリント",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": フットプリント間隔",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": フットプリントの期間",
                        CustomOptionHolder.cs(Forensic.color, "Forensic"),
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 名前を知る時間",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 色のカラーを知る時間",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 殺人者が帽子、服、ペット、またはバイザーを持っているかどうかを知る時間",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": 質問期間",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": ゴーストごとに1つの質問",
                        CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler"),
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": シールド期間",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": 巻き戻し期間",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": 巻き戻し中にプレーヤーを復活させます",
                        CustomOptionHolder.cs(Squire.color, "Squire"),
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": シールドプレーヤーを", // 204
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": シールドされた場合、殺人試みの音を再生します",
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": 会った後、再びシールドできます",
                        CustomOptionHolder.cs(Cheater.color, "Cheater"),
                        "- " + CustomOptionHolder.cs(Cheater.color, "Cheater") + ": 緊急ボタンの使用",
                        "- " + CustomOptionHolder.cs(Cheater.color, "Cheater") + ": 自分を交換できます",
                        CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller"),
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 時間を明らかにします",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 数字を明らかにします",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 明らかにされた情報", // 214
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": 通知を示す", // 215
                        CustomOptionHolder.cs(Hacker.color, "Hacker"),
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": 期間",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": バッテリーの使用",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": 充電バッテリーのタスク",
                        CustomOptionHolder.cs(Sleuth.color, "Sleuth"),
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": トラック間隔",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": 会議後にもう一度追跡できます",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": 死体のクールダウンを追跡します",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": 死体の期間を追跡します",
                        CustomOptionHolder.cs(Fink.color, "Fink"),
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": 詐欺師に啓示されるためのタスク",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": 明らかにすることができます Renegade / Minion",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": タカの目の期間",
                        CustomOptionHolder.cs(Kid.color, "Kid"),
                        CustomOptionHolder.cs(Welder.color, "Welder"),
                        "- " + CustomOptionHolder.cs(Welder.color, "Welder") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Welder.color, "Welder") + ": シール番号",
                        CustomOptionHolder.cs(Spiritualist.color, "Spiritualist"),
                        "- " + CustomOptionHolder.cs(Spiritualist.color, "Spiritualist") + ": プレーヤーの時間を復活させます",
                        CustomOptionHolder.cs(Vigilant.color, "Vigilant"),
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": リモートカメラの期間",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": バッテリーの使用",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": 充電バッテリーのタスク",
                        CustomOptionHolder.cs(Hunter.color, "Hunter"),
                        "- " + CustomOptionHolder.cs(Hunter.color, "Hunter") + ": 会った後にもう一度マークできます",
                        CustomOptionHolder.cs(Jinx.color, "Jinx"),
                        "- " + CustomOptionHolder.cs(Jinx.color, "Jinx") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Jinx.color, "Jinx") + ": ジンクスナンバー",
                        CustomOptionHolder.cs(Coward.color, "Coward"),
                        "- " + CustomOptionHolder.cs(Coward.color, "Coward") + ": 会議の数",
                        CustomOptionHolder.cs(Bat.color, "Bat"),
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": エミット期間",
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": エミット範囲",
                        CustomOptionHolder.cs(Necromancer.color, "Necromancer"),
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": 復活します",
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": 部屋の距離",
                        CustomOptionHolder.cs(Engineer.color, "Engineer"),
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": トラップ番号",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": トラップ期間",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": 速度の上昇",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": 速度が低下します",
                        CustomOptionHolder.cs(Shy.color, "Shy"),
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": 期間",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": 通知範囲",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": 矢印の色はプレイヤーの色",
                        CustomOptionHolder.cs(TaskMaster.color, "Task Master"),
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 追加の一般的なタスク",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 余分な長いタスク",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 余分な短いタスク",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 速度のクールダウン",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": 速度の期間",
                        CustomOptionHolder.cs(Jailer.color, "Jailer"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Jailer") + ": クールダウン",
                        "- " + CustomOptionHolder.cs(Jailer.color, "Jailer") + ": 刑務所の期間"
                    };
            for (int o = 0; o < customOptionNames.Count(); o++)
            {
                CustomOption.options[o].name = customOptionNames[o];
                switch (o)
                {
                    case 45:
                        CustomOption.options[o].selections = new string[] { "Taser", "全て", "誰でもない" };
                        break;
                    case 77:
                        CustomOption.options[o].selections = new string[] { "全て vs 全て", "チームバトル", "スコアバトル" };
                        break;
                    case 186:
                        CustomOption.options[o].selections = new string[] { "ボタンの使用", "常に" };
                        break;
                    case 204:
                        CustomOption.options[o].selections = new string[] { "Squire", " 双方", "全て" };
                        break;
                    case 214:
                        CustomOption.options[o].selections = new string[] { " 善い / 悪い", "ロール名" };
                        break;
                    case 215:
                        CustomOption.options[o].selections = new string[] { "詐欺師", "クルー", "全て", "誰でもない" };
                        break;
                }
            }
            roleInfoNames = new string[] {
                        "<color=#0000FFFF>ブルー</color>チームフラグを盗みます",
                        "<color=#FF0000FF>レッド</color>チームフラグを盗みます",
                        "旗でプレイヤーを殺すためにチームを切り替える",
                        "旗でプレイヤーを殺すためにチームを切り替える",
                        "すべての<color=#D2B48CFF>泥棒</color>を捕まえます",
                        "<color=#D2B48CFF>泥棒</color>をターセします",//5
                        "右クリックで<color=#D2B48CFF>Thieves</color>をターセします",
                        "捕らえられることなく、すべての宝石を盗みます",
                        "捕らえられることなく、すべての宝石を盗みます",
                        "ゾーンをキャプチャします",
                        "あなたの王を守ってください", //10
                        "王を殺して1人になります",
                        "ポットポテトを他のプレイヤーに渡します",
                        "ポットポテトを他のプレイヤーに渡します",
                        "<color=#808080FF>ホットポテト</color>から走ります",
                        "あなたは燃えています",//15
                        "生存者を癒し、治療を作成します",
                        "生存者を癒し、治療を作成します",
                        "治療法を作るためのアイテムを探している間生き残り​​ます",
                        "治療法を作るためのアイテムを探している間生き残り​​ます",
                        "すべての生存者に感染します",//20
                        "生きている最後のものになりなさい",
                        "<color=#F2BEFFFF>ピンクのチーム</color>を殺します",
                        "<color=#39FF14FF>ライムチーム</color>を殺します",
                        "他のプレイヤーの外観を模倣します",
                        "同じ色のプレイヤーをペイントします",//25
                        "彼らの死を遅らせるためにプレイヤーを噛みます",
                        "犯罪現場から体を取り除き、移動します",
                        "犯罪現場から体を取り除き、移動します",
                        "独自のベントネットワークを作成し、ライトをオフにします",
                        "独自のベントネットワークを作成し\nライトをオフにします", //30
                        "プレイヤーを操作して隣接する",
                        "爆弾を置くことによる妨害",
                        "自分を見えないようにしてください",
                        "会議中に自分の役割を選択するプレイヤーを撃ちます",
                        "会議中に自分の役割を選択するプレイヤーを撃ちます",//35
                        "プレイヤーに呪文をキャストします",
                        "プレイヤーを石化します",
                        "プレーヤーの動きを反転させます",
                        "範囲キルをする",
                        "Fと右クリックで弓を選んで撃ちます", //40
                        "新しい通気口を作成します",
                        "彼が話すのを防ぐためにプレイヤーを沈黙させます",
                        "彼が話すのを防ぐためにプレイヤーを沈黙させます",
                        "ミニオンを募集し、みんなを殺します",
                        "反逆者がみんなを殺すのを手伝ってください",//45
                        "ターゲットを追い詰めます",
                        "プランスランドマインとルートトラップ",
                        "2人のプレイヤーが衝突した場合に死ぬようにマークします",
                        "2人のプレイヤーが衝突した場合に死ぬようにマークします",
                        "ロックペーパーシッサーの決闘にプレイヤーに挑戦します",//50
                        "ロックペーパーシッサーの決闘にプレイヤーに挑戦します",
                        "マークとダブルキルを行います",
                        "殺すのを止めることはできません",
                        "茎とターゲットを殺します",
                        "弾薬を見つけて、3人のプレイヤーを殺します",//55
                        "アイテムを回復し、モンジャに変身します",
                        "アイテムを回復し、モンジャに変身します",
                        "投票して勝ち",
                        "投票して勝ち\nマップを開いて妨害ボタンをアクティブにします",
                        "他のプレイヤーの役割を盗みます",//60
                        "すべての生存者に勝つために発火します",
                        "勝つための宝物を見つけます",
                        "勝つために体をむさぼり食う",
                        "すべてのプレイヤーを毒して勝ち",
                        "すべてのプレイヤーを毒して勝ち\nマップを開いて妨害ボタンをアクティブにする",//65
                        "ダミーを作り、彼らを殺して勝ちます",
                        "ダミーを作り\n彼らを殺して勝ちます",
                        "あなたのターゲットを勝ち取るために投票してください",
                        "身体を報告する役割を覚えておいてください",
                        "かくれんぼをするポイントを獲得します",//70
                        "あなたの投票は2回カウントされます",
                        "船の妨害行為を修理します",
                        "詐欺師を殺します",
                        "フットプリントを調べます",
                        "身体を報告し、幽霊に尋ねる手がかりを見つけてください",//75
                        "身体を報告し\n幽霊に尋ねる手がかりを見つけてください",
                        "時間を巻き戻します",
                        "シールドでプレーヤーを保護します",
                        "2人のプレーヤーの投票を交換します",
                        "誰が詐欺師であるかを明らかにします",//80
                        "どこからでも管理者とバイタルを使用します",
                        "プレーヤーと死体を追跡します",
                        "詐欺師を明らかにするためにタスクを完了します",
                        "あなたが死んだり投票したりすると、誰もが負けます",
                        "ベントシール",//85
                        "自分を犠牲にしてプレイヤーを復活させる",
                        "どこからでも会議に電話します",
                        "追加のカメラをマップに置きます",
                        "Qキーを使用してリモートドアログをアクティブにします",
                        "あなたが殺されたら死ぬようにプレーヤーをマークしてください",//90
                        "ジンクスプレーヤーの能力",
                        "ボタンのクールダウンを削減し、詐欺師のボタンを増やします",
                        "ボタンのクールダウンを削減し\n詐欺師のボタンを増やします",
                        "体をその部屋に持って行き、それを復活させてください",
                        "速度と位置トラップを配置し",//95
                        "速度と位置トラップを配置し\nQキーでトラップタイプを切り替えます",
                        "クローズプレイヤーを確認してください",
                        "すべてのタスクを完了し、勝つための余分なタスクを作成します",
                        "すべてのタスクを完了し\n勝つための余分なタスクを作成します",
                        "殺人者を刑務所に送ります",//100
                        "妨害し、みんなを殺します",
                        "詐欺師を見つけて亡命します",
                        "あなたはより多くのビジョンを持っています",
                        "あなたは視力が少ないです",
                        "あなたはより速いです",//105
                        "あなたは大きくて遅くなります",
                        "あなたの殺害はあなたの体を報告します",
                        "あなたの死はアラームを引き起こし、あなたの体がどこにあるかを明らかにします",
                        "あなたの死はアラームを引き起こし\nあなたの体がどこにあるかを明らかにします",
                        "あなたの動きのコントロールは反転します",//110
                        "あなたのキラーはペイントトレイルを残します",
                        "あなたの殺人者は所定の位置に麻痺します",
                        "♥あなたのパートナーと一緒にカップルとして生き残ります。♥",
                        "♥あなたのパートナーと一緒にカップルとして生き残ります。♥",
                        "<color=#FF00D1FF>♥あなたのパートナーと一緒にカップルとして生き残ります。♥. </color><color=#FF1919FF>残りを殺します</color>",//115
                        "<color=#FF00D1FF>♥あなたのパートナーと一緒にカップルとして生き残ります。♥. </color><color=#FF1919FF>残りを殺します</color>",
                    };
            exileControllerTexts = new string[] {
                        " だった ",
                        "インポスターと思ったようですが私は Joker！",
                        "以上！"
                    };
            introTexts = new string[] {
                        "♥ とカップルとして生き残る ",
                        "残り時間: ",
                        "スコア: ",
                        "盗まれた宝石: ",
                        "捕まえられた盗賊: ",
                        "ホットポテト: ",
                        "コールドポテト: ",
                        "キーアイテム: ",
                        "生存者: ",
                        "感染者: ",
                        "ゾンビ: ",
                        "バトルロイヤルファイターズ: ",
                        "ライムチーム: ",
                        "ピンクチーム: ",
                        "連続殺人犯: ",
                        "ゴール: ",
                        "連続殺人犯ポイント: ",
                    };
            playerControlTexts = new string[] {
                        "自殺のようです!",
                        "殺人者はそうあるように見えます",
                        "明るい (L) 色です！",
                        "暗い (D) 色です！",
                        "私を殺した人は",
                        "キラーは帽子を着用している！",
                        "キラーは帽子着ていないようです！",
                        "キラーは衣装を着用している！",
                        "キラーは衣装着ていないようです！",
                        "キラーはペットを着用している！",
                        "キラーはペット着ていないようです！",
                        "キラーはバイザーを着用している！",
                        "キラーはバイザー着ていないようです！",
                        "体は古すぎて情報を得られません！",
                        "時間が経過した:"
                    };
            usablesTexts = new string[] {
                        "カスタムモードでは緊急招集ボタンを使用できません！",
                        "Cheater 非常ボタンが使えない！",
                        "Gambler 非常ボタンが使えない！",
                        "Sorcerer 非常ボタンが使えない！",
                        "爆弾があります、緊急招集ボタンは使用できません！",
                        "停電中です。緊急招集ボタンは使用できません！",
                        "MONJA 目覚めた, 走る！"
                    };
            buttonsTexts = new string[] {
                        "Player のゴースト (",
                        "私はでした ",
                        "私を殺した人は ",
                        "亡くなってからの時間 ",
                        "私を殺した人の役割はです "
                    };
            helpersTexts = new string[] {
                        " ミニオンを募集します。",
                        "みんなを殺します"
                    };
            statusRolesTexts = new string[] {
                        "速度の変更！",
                        "眠らされた！",
                        "ターゲットは死にました！",
                        "ランページモード",
                        "Seeker 現在のポイント: ",
                        "Illusionist は明かりを消した: ",
                        "地図に爆弾があります: ",
                        "石化！",
                        "MONJA 目覚めた: ",
                        "Amnesiac Body Report: この役割を思い出させることはできません",
                        "Fink はホークアイを使用しています！",
                    };
            statusCaptureTheFlagTexts = new string[] {
                        "あなたは今新しい<color=#FF0000FF>レッドチームプレーヤーです！</color>",
                        "あなたは今新しい<color=#0000FFFF>ブルーチームプレーヤーです！</color>",
                        "によって盗まれ<color=#0000FFFF>た青い旗</color> <color=#FF0000FF>",
                        "あなたの旗は盗まれました！",
                        "によって盗まれ<color=#FF0000FF>た赤い旗</color> <color=#0000FFFF>",
                        "<color=#FF0000FF>レッドチーム</color>が得点しました！",
                        "<color=#0000FFFF>ブルーチーム</color>が得点しました！"
                    };
            statusPoliceAndThiefsTexts = new string[] {
                        "<color=#928B55FF>泥棒</color>が捕らえられました！",
                        "<color=#928B55FF>泥棒</color>が釈放されました！",
                        "<color=#00F7FFFF>宝石</color>が配達されました！"
                    };
            statusKingOfTheHillTexts = new string[] {
                        "あなたは新しい<color=#00FF00FF>緑王です</color>！",
                        "あなたは新しい<color=#FFFF00FF>黄色の王です</color>！",
                        "<color=#00FF00FF>緑王です</color>キングがゾーンを獲得しました！",
                        "<color=#FFFF00FF>黄色の王です</color>キングがゾーンを獲得しました！",
                        "あなたの王は殺されました！"
                    };
            statusHotPotatoTexts = new string[] {
                        " は新しいホットポテトです！"
                    };
            statusZombieLaboratoryTexts = new string[] {
                        "<color=#FF00FFFF>重要なアイテ</color>ムが配信されました！",
                        "<color=#00CCFFFF>生存者</color><color=#FFFF00FF>が感染しています</color>！",
                        "<color=#00CCFFFF>生存者</color><color=#996633FF>はゾンビになりました</color>！"
                    };
            statusBattleRoyaleTexts = new string[] {
                        "一人の <color=#009F57FF>戦闘機</color>ダウン！",
                        "<color=#39FF14FF>ライム戦闘機</color>ダウン！",
                        "一人の <color=#F2BEFFFF>ピンクの戦闘機</color>ダウン！",
                        "<color=#808080FF>シリアルキラーダウン</color>ダウン！",
                        "<color=#39FF14FF>ライムのチーム</color>ポイント！",
                        "<color=#F2BEFFFF>ピンクのチーム</color>ポイント！",
                        "<color=#808080FF>シリアルキラーの</color>ポイント！",
                    };
        }
    }
}