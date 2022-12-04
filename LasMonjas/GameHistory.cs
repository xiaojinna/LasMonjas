using System.Collections.Generic;
using System;
using UnityEngine;


namespace LasMonjas
{
    public class DeadPlayer
    {
        public PlayerControl player;
        public DateTime timeOfDeath;
        public DeathReason deathReason;
        public PlayerControl killerIfExisting;

        public DeadPlayer(PlayerControl player, DateTime timeOfDeath, DeathReason deathReason, PlayerControl killerIfExisting) {
            this.player = player;
            this.timeOfDeath = timeOfDeath;
            this.deathReason = deathReason;
            this.killerIfExisting = killerIfExisting;
        }
    }

    static class GameHistory {
        public static List<Tuple<Vector3, DateTime>> localPlayerPositions = new List<Tuple<Vector3, DateTime>>();
        public static List<DeadPlayer> deadPlayers = new List<DeadPlayer>();

        public static void clearGameHistory() {
            localPlayerPositions = new List<Tuple<Vector3, DateTime>>();
            deadPlayers = new List<DeadPlayer>();
        }
    }
}