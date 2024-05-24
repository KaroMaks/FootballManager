﻿namespace FootballManager.Events;

public class RedCardEvent(Team team, int minute, Player player) : Event(team, minute, player)
{
    public Team Team { get; set; } = team;
    public int Minute { get; set; } = minute;
    public Player Player { get; set; } = player;
}