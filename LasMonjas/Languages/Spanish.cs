using UnityEngine;
using System.Linq;
using LasMonjas.Core;
using static LasMonjas.Languages.Language;

namespace LasMonjas.Languages
{
    public class Spanish
    {
        public static void Spanishlang()
        {
            colorNames = new string[5] { "Lavanda", "Petroleo", "Menta", "Aceituna", "Hielo" };
            for (int i = 0; i < colorNames.Count(); i++)
            {
                CustomColors.ColorStrings[i + 50000] = colorNames[i];
            }
            customOptionNames = new string[] {
                        CustomOptionHolder.cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Plantilla"),
                        CustomOptionHolder.cs(Jailer.color, "Opciones Globales"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Activar roles y gamemodes del mod"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Activar Mapa Personalizado Skeld"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Ocultar animacion rejilla a distancia"),
                        CustomOptionHolder.cs(Detective.color, "Opciones de Roles"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Modo encuentra tu Rol"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Quitar Tarea de la Tarjeta"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Quitar puertas en Airship"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Vision Nocturna en sabotaje de luces"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Agitar Camara en sabotaje de reactor"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Jugadores anonimos en sabotaje de comunicaciones"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Menos velocidad en sabotaje de oxigeno"),
                        CustomOptionHolder.cs(Modifiers.color, "Modificadores"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Lovers"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Lighter"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Blind"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Flash"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Big Chungus"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "The Chosen One"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "The Chosen One") + ": Demora de Reporte",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Performer"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Performer") + ": Duracion de Alarma",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Pro"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Paintball"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Paintball") + ": Duration de Pintura",
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Electrician"),
                        "- " + CustomOptionHolder.cs(Modifiers.color, "Electrician") + ": Duracion de Paralisis",
                        CustomOptionHolder.cs(Sheriff.color, "Capture the Flag"),
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Duracion de Partida",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Puntuacion Necesaria",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Recarga de Matar",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Tiempo para Revivir",
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Capture the Flag") + ": Segundos invencibles tras Revivir",
                        CustomOptionHolder.cs(Coward.color, "Police and Thieves"),
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Duracion de Partida",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Joyas Necesarias",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Recarga de Matar Polis",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Recarga de Arrestar Polis",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Tiempo para Arrestar",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Recarga de Taser",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Duracion de Taser",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Joyas visibles para Polis",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Rango vision Polis",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Tiempo para Revivir Polis",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Ladrones pueden matar", // id 45
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Recarga de Matar Ladrones",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Tiempo para Revivir Ladrones",
                        "- " + CustomOptionHolder.cs(Coward.color, "Police and Thieves") + ": Segundos invencibles tras Revivir",
                        CustomOptionHolder.cs(Squire.color, "King of the Hill"),
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Duracion de Partida",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Puntuacion Necesaria",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Tiempo de Captura",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Recarga de Matar",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Los Reyes pueden matar",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Tiempo para Revivir",
                        "- " + CustomOptionHolder.cs(Squire.color, "King of the Hill") + ": Segundos invencibles tras Revivir",
                        CustomOptionHolder.cs(Shy.color, "Hot Potato"),
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Duracion de Partida",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Tiempo limite para transferir Patata",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Recarga de transferir Patata",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Rango vision Patatas Frias",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Reiniciar tiempo al transferir Patata",
                        "- " + CustomOptionHolder.cs(Shy.color, "Hot Potato") + ": Tiempo extra si no se reinica al transferir",
                        CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory"),
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Duracion de Partida",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Zombies Iniciales",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Tiempo para Infectar",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Recarga de Infectar",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Tiempo para Buscar Cajas",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Rango vision Supervivientes",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Tiempo limite para curar Infeccion",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Recarga de Matar",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Tiempo para Revivir",
                        "- " + CustomOptionHolder.cs(Hunter.color, "Zombie Laboratory") + ": Segundos invencibles tras Revivir",
                        CustomOptionHolder.cs(Sleuth.color, "Battle Royale"),
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Duracion de Partida",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Tipo de Partida", // id 77
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Recarga de Matar",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Cantidad de vidas",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Puntuacion Necesaria",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Tiempo para Revivir",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Battle Royale") + ": Segundos invencibles tras Revivir",
                        CustomOptionHolder.cs(Mimic.color, "Mimic"),
                        "- " + CustomOptionHolder.cs(Mimic.color, "Mimic") + ": Duracion",
                        CustomOptionHolder.cs(Painter.color, "Painter"),
                        "- " + CustomOptionHolder.cs(Painter.color, "Painter") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Painter.color, "Painter") + ": Duracion",
                        CustomOptionHolder.cs(Demon.color, "Demon"),
                        "- " + CustomOptionHolder.cs(Demon.color, "Demon") + ": Demora de muerte",
                        "- " + CustomOptionHolder.cs(Demon.color, "Demon") + ": Puede matar cerca de las Nuns",
                        CustomOptionHolder.cs(Janitor.color, "Janitor"),
                        "- " + CustomOptionHolder.cs(Janitor.color, "Janitor") + ": Recarga",
                        CustomOptionHolder.cs(Illusionist.color, "Illusionist"),
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": Recarga de Sombreros",
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": Recarga de Apagar Luces",
                        "- " + CustomOptionHolder.cs(Illusionist.color, "Illusionist") + ": Duracion de Apagon Duration",
                        CustomOptionHolder.cs(Manipulator.color, "Manipulator"),
                        CustomOptionHolder.cs(Bomberman.color, "Bomberman"),
                        "- " + CustomOptionHolder.cs(Bomberman.color, "Bomberman") + ": Recarga",
                        CustomOptionHolder.cs(Chameleon.color, "Chameleon"),
                        "- " + CustomOptionHolder.cs(Chameleon.color, "Chameleon") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Chameleon.color, "Chameleon") + ": Duracion",
                        CustomOptionHolder.cs(Gambler.color, "Gambler"),
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": Cantidad de Disparos",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": Puede convocar reuniones",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": Puede disparar varias veces",
                        "- " + CustomOptionHolder.cs(Gambler.color, "Gambler") + ": Ignora escudos",
                        CustomOptionHolder.cs(Sorcerer.color, "Sorcerer"),
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": Recarga adicional por hechizo",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": Duracion de Hechizar",
                        "- " + CustomOptionHolder.cs(Sorcerer.color, "Sorcerer") + ": Puede convocar reuniones",
                        CustomOptionHolder.cs(Medusa.color, "Medusa"),
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": Demora de petrificar",
                        "- " + CustomOptionHolder.cs(Medusa.color, "Medusa") + ": Duracion de petrificar",
                        CustomOptionHolder.cs(Hypnotist.color, "Hypnotist"),
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": Cantidad de Espirales",
                        "- " + CustomOptionHolder.cs(Hypnotist.color, "Hypnotist") + ": Duracion de Efecto Spiral",
                        CustomOptionHolder.cs(Archer.color, "Archer"),
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": Anchura de Flecha",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": Distancia de Flecha",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": Distancia de notifiacion",
                        "- " + CustomOptionHolder.cs(Archer.color, "Archer") + ": Duracion de mirilla",
                        CustomOptionHolder.cs(Plumber.color, "Plumber"),
                        "- " + CustomOptionHolder.cs(Plumber.color, "Plumber") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Plumber.color, "Plumber") + ": Cantidad de rejillas",
                        CustomOptionHolder.cs(Librarian.color, "Librarian"),
                        "- " + CustomOptionHolder.cs(Librarian.color, "Librarian") + ": Recarga",
                        CustomOptionHolder.cs(Renegade.color, "Renegade"),
                        "- " + CustomOptionHolder.cs(Renegade.color, "Renegade") + ": Puede usar rejillas",
                        "- " + CustomOptionHolder.cs(Renegade.color, "Renegade") + ": Puede reclutar un Minion",
                        CustomOptionHolder.cs(BountyHunter.color, "Bounty Hunter"),
                        CustomOptionHolder.cs(Trapper.color, "Trapper"),
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Cantidad de Minas",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Duracion de Minas",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Cantidad de Cepos",
                        "- " + CustomOptionHolder.cs(Trapper.color, "Trapper") + ": Duracion de Cepos",
                        CustomOptionHolder.cs(Yinyanger.color, "Yinyanger"),
                        "- " + CustomOptionHolder.cs(Yinyanger.color, "Yinyanger") + ": Recarga",
                        CustomOptionHolder.cs(Challenger.color, "Challenger"),
                        "- " + CustomOptionHolder.cs(Challenger.color, "Challenger") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Challenger.color, "Challenger") + ": Asesinatos para ganar",
                        CustomOptionHolder.cs(Ninja.color, "Ninja"),
                        CustomOptionHolder.cs(Berserker.color, "Berserker"),
                        "- " + CustomOptionHolder.cs(Berserker.color, "Berserker") + ": Tiempo limite para Matar",
                        CustomOptionHolder.cs(Yandere.color, "Yandere"),
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": Recarga de Acechar",
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": Cantidad de acechos",
                        "- " + CustomOptionHolder.cs(Yandere.color, "Yandere") + ": Duracion de Acechar",
                        CustomOptionHolder.cs(Stranded.color, "Stranded"),
                        CustomOptionHolder.cs(Monja.color, "Monja"),
                        CustomOptionHolder.cs(Joker.color, "Joker"),
                        "- " + CustomOptionHolder.cs(Joker.color, "Joker") + ": Puede sabotear",
                        CustomOptionHolder.cs(RoleThief.color, "Role Thief"),
                        "- " + CustomOptionHolder.cs(RoleThief.color, "Role Thief") + ": Recarga",
                        CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac"),
                        "- " + CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Pyromaniac.color, "Pyromaniac") + ": Duracion de Rociar",
                        CustomOptionHolder.cs(TreasureHunter.color, "Treasure Hunter"),
                        "- " + CustomOptionHolder.cs(TreasureHunter.color, "Treasure Hunter") + ": Cantidad de Tesoros",
                        CustomOptionHolder.cs(Devourer.color, "Devourer"),
                        "- " + CustomOptionHolder.cs(Devourer.color, "Devourer") + ": Cantidad de cuerpos",
                        CustomOptionHolder.cs(Poisoner.color, "Poisoner"),
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": Tiempo para Envenenar",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": Rango de infeccion",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": Tiempo para envenenar al 100%",
                        "- " + CustomOptionHolder.cs(Poisoner.color, "Poisoner") + ": Puede sabotear",
                        CustomOptionHolder.cs(Puppeteer.color, "Puppeteer"),
                        "- " + CustomOptionHolder.cs(Puppeteer.color, "Puppeteer") + ": Cantidad de muertes",
                        CustomOptionHolder.cs(Exiler.color, "Exiler"),
                        CustomOptionHolder.cs(Amnesiac.color, "Amnesiac"),
                        CustomOptionHolder.cs(Seeker.color, "Seeker"),
                        "- " + CustomOptionHolder.cs(Seeker.color, "Seeker") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Seeker.color, "Seeker") + ": Puntuacion necesaria",
                        CustomOptionHolder.cs(Captain.color, "Captain"),
                        "- " + CustomOptionHolder.cs(Captain.color, "Captain") + ": Puede forzar los votos una vez",
                        CustomOptionHolder.cs(Mechanic.color, "Mechanic"),
                        "- " + CustomOptionHolder.cs(Mechanic.color, "Mechanic") + ": Cantidad de Reparaciones",
                        "- " + CustomOptionHolder.cs(Mechanic.color, "Mechanic") + ": Reparaciones Expertas",
                        CustomOptionHolder.cs(Sheriff.color, "Sheriff"),
                        "- " + CustomOptionHolder.cs(Sheriff.color, "Sheriff") + ": Puede matar Neutrales",
                        CustomOptionHolder.cs(Detective.color, "Detective"),
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Revelar huellas", // id 186
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Duracion de revelar Huellas",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Huellas Anonimas",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Intervalo de Huellas",
                        "- " + CustomOptionHolder.cs(Detective.color, "Detective") + ": Duracion de Huellas",
                        CustomOptionHolder.cs(Forensic.color, "Forensic"),
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Tiempo para obtener el nombre",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Tiempo para obtener el tipo de color",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Tiempo para saber si el asesino tiene gorro, traje, mascota o visor",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Duracion de Preguntar",
                        "- " + CustomOptionHolder.cs(Forensic.color, "Forensic") + ": Una pregunta por Fantasma",
                        CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler"),
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": Recarga",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": Duracion de Escudo",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": Segundos retrocedidos en el tiempo",
                        "- " + CustomOptionHolder.cs(TimeTraveler.color, "Time Traveler") + ": Revivir jugadores al retroceder en el tiempo",
                        CustomOptionHolder.cs(Squire.color, "Squire"),
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": Mostrar jugador escudado", // id 204
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": Sonido de intento de asesinato del escudado",
                        "- " + CustomOptionHolder.cs(Squire.color, "Squire") + ": Puede escudar de nuevo tras un reunion",
                        CustomOptionHolder.cs(Cheater.color, "Cheater"),
                        "- " + CustomOptionHolder.cs(Cheater.color, "Cheater") + ": Puede convocar reuniones",
                        "- " + CustomOptionHolder.cs(Cheater.color, "Cheater") + ": Puede intercambiar sus votos",
                        CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller"),
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Recarga",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Tiempo para Revelar",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Cantidad de Revelaciones",
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Informacion Revelada", // id 214
                        "- " + CustomOptionHolder.cs(FortuneTeller.color, "Fortune Teller") + ": Mostrar notifiacion", // id 215
                        CustomOptionHolder.cs(Hacker.color, "Hacker"),
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": Duracion",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": Cantidad de usos",
                        "- " + CustomOptionHolder.cs(Hacker.color, "Hacker") + ": Tareas para recargar usos",
                        CustomOptionHolder.cs(Sleuth.color, "Sleuth"),
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": Intervalo de rastreo",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": Puedes rastrear de nuevo tras una reunion",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": Recarga de rastrear cuerpos",
                        "- " + CustomOptionHolder.cs(Sleuth.color, "Sleuth") + ": Duracion de rastrear cuerpos",
                        CustomOptionHolder.cs(Fink.color, "Fink"),
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": Tareas restantes para ser reveleado a Impostores",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": Puede revelar a Renegade / Minion",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Fink.color, "Fink") + ": Duracion de Espiar",
                        CustomOptionHolder.cs(Kid.color, "Kid"),
                        CustomOptionHolder.cs(Welder.color, "Welder"),
                        "- " + CustomOptionHolder.cs(Welder.color, "Welder") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Welder.color, "Welder") + ": Cantidad de Sellados",
                        CustomOptionHolder.cs(Spiritualist.color, "Spiritualist"),
                        "- " + CustomOptionHolder.cs(Spiritualist.color, "Spiritualist") + ": Duracion de Revivir",
                        CustomOptionHolder.cs(Vigilant.color, "Vigilant"),
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": Duracion de Camaras Remotas",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": Cantidad de usos",
                        "- " + CustomOptionHolder.cs(Vigilant.color, "Vigilant") + ": Tareas para recargar usos",
                        CustomOptionHolder.cs(Hunter.color, "Hunter"),
                        "- " + CustomOptionHolder.cs(Hunter.color, "Hunter") + ": Puede marcar de nuevo tras una reunion",
                        CustomOptionHolder.cs(Jinx.color, "Jinx"),
                        "- " + CustomOptionHolder.cs(Jinx.color, "Jinx") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Jinx.color, "Jinx") + ": Cantidad de gafadas",
                        CustomOptionHolder.cs(Coward.color, "Coward"),
                        "- " + CustomOptionHolder.cs(Coward.color, "Coward") + ": Cantidad de reuniones",
                        CustomOptionHolder.cs(Bat.color, "Bat"),
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": Duracion de Frecuencia",
                        "- " + CustomOptionHolder.cs(Bat.color, "Bat") + ": Rango de Frecuencia",
                        CustomOptionHolder.cs(Necromancer.color, "Necromancer"),
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": Tiempo para Revivir",
                        "- " + CustomOptionHolder.cs(Necromancer.color, "Necromancer") + ": Distancia de Habitaciones",
                        CustomOptionHolder.cs(Engineer.color, "Engineer"),
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Cantidad de Trampas",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Duracion de Trampas",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Aumento de Velocidad",
                        "- " + CustomOptionHolder.cs(Engineer.color, "Engineer") + ": Reduccion de Velocidad",
                        CustomOptionHolder.cs(Shy.color, "Shy"),
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": Duracion",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": Rando de Notificacion",
                        "- " + CustomOptionHolder.cs(Shy.color, "Shy") + ": Flecha del color del jugador",
                        CustomOptionHolder.cs(TaskMaster.color, "Task Master"),
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Tareas Comunes Extra",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Tareas Largas Extra",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Tareas Cortas Extra",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Recarga de Velocidad",
                        "- " + CustomOptionHolder.cs(TaskMaster.color, "Task Master") + ": Duracion de Velocidad",
                        CustomOptionHolder.cs(Jailer.color, "Jailer"),
                        "- " + CustomOptionHolder.cs(Jailer.color, "Jailer") + ": Recarga",
                        "- " + CustomOptionHolder.cs(Jailer.color, "Jailer") + ": Tiempo de carcel"
                    };
            for (int o = 0; o < customOptionNames.Count(); o++)
            {
                CustomOption.options[o].name = customOptionNames[o];
                switch (o)
                {
                    case 45:
                        CustomOption.options[o].selections = new string[] { "Taser", "Todos", "Nadie" };
                        break;
                    case 77:
                        CustomOption.options[o].selections = new string[] { "Individual", "Por Equipos", "Por Puntuacion" };
                        break;
                    case 186:
                        CustomOption.options[o].selections = new string[] { "Uso de Boton", "Siempre" };
                        break;
                    case 204:
                        CustomOption.options[o].selections = new string[] { "Squire", "Ambos", "Todos" };
                        break;
                    case 214:
                        CustomOption.options[o].selections = new string[] { "Bueno / Malo", "Nombre Rol" };
                        break;
                    case 215:
                        CustomOption.options[o].selections = new string[] { "Impostores", "Tripulantes", "Todos", "Nadie" };
                        break;
                }
            }
            roleInfoNames = new string[] {
                        "Roba la Bandera <color=#0000FFFF>Azul</color>",
                        "Roba la Bandera <color=#FF0000FF>Roja</color>",
                        "Matar al jugador con bandera para intercambiar equipos",
                        "Matar al jugador con\nbandera para intercambiar equipos",
                        "Captura todos los <color=#D2B48CFF>Ladrones</color>",
                        "Tasea a los <color=#D2B48CFF>Ladrones</color>",//5
                        "Tasea a los <color=#D2B48CFF>Ladrones\ncon clic derecho</color>",
                        "Roba las joyas sin ser capturado",
                        "Roba las joyas\nsin ser capturado",
                        "Captura las zonas",
                        "Protege a tu Rey", //10
                        "Mata al Rey para convertirte en uno",
                        "Dale la patata caliente a otro jugador",
                        "Dale la patata\ncaliente a otro jugador",
                        "Escapa de la <color=#808080FF>Patata Caliente</color>",
                        "Has explotado",//15
                        "Cura supervivientes y crea la cura",
                        "Cura supervivientes\ny crea la cura",
                        "Sobrevive mientras buscas objetos para la cura",
                        "Sobrevive mientras\nbuscas objetos para la cura",
                        "Infecta a los supervivientes",//20
                        "Sobrevive hasta el final",
                        "Mata al <color=#F2BEFFFF>Equipo Rosa</color>",
                        "Mata al <color=#39FF14FF>Equipo Lima</color>",
                        "Imita el aspecto de otro jugador",
                        "Colorea a todos del mismo color",//25
                        "Muerde jugadores para demorar su muerte",
                        "Quita y mueve cuerpos de la escena del crimen",
                        "Quita y mueve cuerpos\nde la escena del crimen",
                        "Crea tu propia red de rejillas y apaga las luces",
                        "Crea tu propia red de\nrejillas y apaga las luces", //30
                        "Manipula a un jugador para matar a su adyacente",
                        "Sabotea poniendo bombas",
                        "Hazte invisible",
                        "Dispara a un jugador durante una reunion adivinando su rol",
                        "Dispara a un jugador durante\nuna reunion adivinando su rol",//35
                        "Hechiza jugadores",
                        "Petrifica jugadores",
                        "Invierte los controles de los jugadores",
                        "Mata a distancia",
                        "Equipa el arco con la F\ny dispara con clic derecho", //40
                        "Crea nuevas rejillas",
                        "Silencia a un jugador para que no hable en la reunion",
                        "Silencia a un jugador\npara que no hable en la reunion",
                        "Recluta un Minion y mata a todos",
                        "Ayuda al Renegade a matar a todos",//45
                        "Mata a tu objetivo",
                        "Pon minas y cepos",
                        "Marca dos jugadores para que mueran si chocan",
                        "Marca dos jugadores\npara que mueran si chocan",
                        "Desafia jugadores a piedra, papel y tijeras",//50
                        "Desafia jugadores\na piedra, papel y tijeras",
                        "Marca y haz muertes dobles",
                        "No puedes parar de matar",
                        "Acecha y mata a tu objetivo",
                        "Encuentra municion y mata a tres jugadores",//55
                        "Lleva los objetos al ritual y despierta a la Monja",
                        "Lleva los objetos al ritual\ny despierta a la Monja",
                        "Consigue que te expulsen fuera para ganar",
                        "Consigue que te expulsen fuera para ganar\nAbre el mapa para activar el boton de sabotajes",
                        "Roba el rol a otro jugador",//60
                        "Rocia a todos para ganar",
                        "Encuentra tesoros para ganar",
                        "Devora cuerpos para ganar",
                        "Envenena a todos para ganar",
                        "Envenena a todos para ganar\nAbre el mapa para activar el boton de sabotajes",//65
                        "Muere haciendo de señuelo para ganar",
                        "Muere haciendo\nde señuelo para ganar",
                        "Expulsa a tu objetivo para ganar",
                        "Recuerda tu rol reportando un cuerpo",
                        "Gana puntos jugando al escondite",//70
                        "Tu voto cuenta doble",
                        "Repara sabotajes a distancia",
                        "Mata a los <color=#FF0000FF>Impostores</color>",
                        "Examina huellas",
                        "Obten informacion reportando cuerpos y hablando con fantasmas",//75
                        "Obten informacion reportando\ncuerpos y hablando con fantasmas",
                        "Rebobina el tiempo",
                        "Protege a un jugador con tu escudo",
                        "Cambia los votos de dos jugadores",
                        "Revela quien es bueno o malo",//80
                        "Usa Admin y Vitales a distancia",
                        "Rastrea jugadores y cuerpos",
                        "Completa tus tareas para revelear a los <color=#FF0000FF>Impostores</color>",
                        "Todos pierden si mueres o te expulsan",
                        "Sella Rejillas",//85
                        "Sacrificate para revivir a otro jugador",
                        "Convoca reuniones a distancia",
                        "Pon camaras adicionales en el mapa",
                        "Activa el Doorlog a distancia con la Q",
                        "El jugador que marques morira si te matan",//90
                        "Gafa las habilidades de los jugadores",
                        "Reduce la recarga de botones y aumenta la de impostores",
                        "Reduce la recarga\nde botones y aumenta la de impostores",
                        "Lleva un cuerpo a su sala para revivirlo",
                        "Pon trampas de velocidad y posicion",//95
                        "Pon trampas de velocidad y posicion\nAlterna el tipo de trampa con la Q",
                        "Comprueba quien esta cerca",
                        "Completa tus tareas y las extra para ganar",
                        "Completa tus tareas\ny las extra para ganar",
                        "Encarcela jugadores",//100
                        "Sabotea y mata a todos",
                        "Encuentra y expulsa a los <color=#FF0000FF>Impostores</color>",
                        "Tienes mas vision",
                        "Tienes menos vision",
                        "Eres mas rapido",//105
                        "Eres mas grande y lento",
                        "Tu asesino reportara tu cuerpo",
                        "Tu muerte activa una alarma y una flecha revela tu posicion",
                        "Tu muerte activa una alarma\ny una flecha revela tu posicion",
                        "Tus controles estan al reves",//110
                        "Tu asesino dejara un rastro de pintura",
                        "Tu asesino quedara paralizado",
                        "♥Sobrevive en pareja♥",
                        "♥Sobrevive en pareja♥",
                        "<color=#FF00D1FF>♥Sobrevive en pareja♥. </color><color=#FF1919FF>Mata al resto</color>",//115
                        "<color=#FF00D1FF>♥Sobrevive en pareja♥. </color><color=#FF1919FF>Mata al resto</color>",
                    };
            exileControllerTexts = new string[] {
                        " era el ",
                        "¡Pensabais que era un Impostor pero era yo, Joker!",
                        "¡Y eso es todo amigos!"
                    };
            introTexts = new string[] {
                        "♥ Sobrevive en pareja con ",
                        "Tiempo Restante: ",
                        "Puntuacion: ",
                        "Joyas Robadas: ",
                        "Ladrones Capturados: ",
                        "Patata Caliente: ",
                        "Patatas Frias: ",
                        "Objetos Clave: ",
                        "Supervivientes: ",
                        "Infectados: ",
                        "Zombies: ",
                        "Luchadores Battle Royale: ",
                        "Equipo Lima: ",
                        "Equipo Rosa: ",
                        "Serial Killer: ",
                        "Objetivo: ",
                        "Puntuacion Serial Killer: ",
                    };
            playerControlTexts = new string[] {
                        "¡Parece que ha sido un suicidio!",
                        "¡El asesino parece ser",
                        "color claro (L)!",
                        "color oscuro (D)!",
                        "¡El asesino parece tener un ",
                        "¡El asesino parece llevar gorro!",
                        "¡El asesino parece que no lleva gorro!",
                        "¡El asesino parece llevar traje!",
                        "¡El asesino parece que no lleva traje!",
                        "¡El asesino parece llevar mascota!",
                        "¡El asesino parece que no lleva mascota!",
                        "¡El asesino parece llevar visor!",
                        "¡El asesino parece que no lleva visor!",
                        "¡Ha pasado demasiado tiempo para obtener informacion!",
                        "Tiempo Transcurrido:"
                    };
            usablesTexts = new string[] {
                        "¡No se puede usar el boton de\nemergencia en los modos de juego!",
                        "¡El Cheater no puede usar\nel boton de emergencia!",
                        "¡El Gambler no puede usar\nel boton de emergencia!",
                        "¡El Sorcerer no puede usar\nel boton de emergencia!",
                        "¡Hay una Bomba, no se puede usar\nel boton de emergencia!",
                        "¡Hay un Apagon, el boton de emergencia no funciona!",
                        "!LA MONJA HA DESPERTADO, CORRED INSENSATOS!"
                    };
            buttonsTexts = new string[] {
                        "Fantasma de (",
                        "Mi rol era ",
                        "Mi asesino tiene un ",
                        "Tiempo muerto ",
                        "Me asesino fue el "
                    };
            helpersTexts = new string[] {
                        " y recluta un Minion",
                        "Mata a todos"
                    };
            statusRolesTexts = new string[] {
                        "¡Velocidad Cambiada!",
                        "¡Hipnotizado!",
                        "Objetivo Muerto",
                        "Modo Asesina",
                        "Puntuacion actual del Seeker: ",
                        "El Illusionist ha apagado las luces: ",
                        "Hay una Bomba en el mapa: ",
                        "¡Petrificado!",
                        "LA MONJA HA DESPERTADO: ",
                        "Amnesiac Body Report: Este rol no puede ser recordado",
                        "!El Fink esta espiando!",
                    };
            statusCaptureTheFlagTexts = new string[] {
                        "¡Ahora eres del <color=#FF0000FF>Equipo Rojo</color>!",
                        "¡Ahora eres del <color=#0000FFFF>Equipo Azul</color>!",
                        "¡<color=#0000FFFF>Bandera Azul</color> robada por <color=#FF0000FF>",
                        "¡Han robado tu bandera!",
                        "¡<color=#FF0000FF>Bandera Roja</color> robada por <color=#0000FFFF>",
                        "¡Punto para el <color=#FF0000FF>Equipo Rojo</color>!",
                        "¡Punto para el <color=#0000FFFF>Equipo Azul</color>!"
                    };
            statusPoliceAndThiefsTexts = new string[] {
                        "¡Un <color=#928B55FF>Ladron</color> ha sido capturado!",
                        "¡Un <color=#928B55FF>Ladron</color> ha sido liberado!",
                        "¡Se ha entregado una <color=#00F7FFFF>Joya</color>!"
                    };
            statusKingOfTheHillTexts = new string[] {
                        "¡Eres el nuevo <color=#00FF00FF>Rey Verde</color>!",
                        "¡Eres el nuevo <color=#FFFF00FF>Rey Amarillo</color>!",
                        "¡El <color=#00FF00FF>Rey Verde</color> ha capturado una zona!",
                        "¡El <color=#FFFF00FF>Rey Amarillo</color> ha capturado una zona!",
                        "¡Tu Rey ha sido asesinado!"
                    };
            statusHotPotatoTexts = new string[] {
                        " es la nueva Patata Caliente!"
                    };
            statusZombieLaboratoryTexts = new string[] {
                        "¡Se ha entregado un <color=#FF00FFFF>Objeto Clave</color>!",
                        "¡Un <color=#00CCFFFF>Superviviente</color> ha sido <color=#FFFF00FF>Infectado</color>!",
                        "¡Un <color=#00CCFFFF>Superviviente</color> se ha convertido en <color=#996633FF>Zombie</color>!"
                    };
            statusBattleRoyaleTexts = new string[] {
                        "¡Ha caido un <color=#009F57FF>Luchador</color>!",
                        "¡Ha caido un <color=#39FF14FF>Luchador Lima</color>!",
                        "¡Ha caido un <color=#F2BEFFFF>Luchador Rosa</color>!",
                        "¡Ha caido el <color=#808080FF>Serial Killer</color>!",
                        "¡Puntos para el <color=#39FF14FF>Equipo Lima</color>!",
                        "¡Puntos para el <color=#F2BEFFFF>Equipo Rosa</color>!",
                        "¡Puntos para el <color=#808080FF>Serial Killer</color>!",
                    };
        }
    }
}