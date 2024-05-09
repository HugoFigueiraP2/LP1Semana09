﻿using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        private static void Main(string[] args)
        {
            Player player1 = new Player(PlayerClass.Tank, "Ana");

            HashSet<Player> players = new HashSet<Player> 
            { 
                new Player(PlayerClass.Tank,        "Ana"), 
                new Player(PlayerClass.Slayer,      "Paulo"),
                new Player(PlayerClass.Tank,        "Ana"), 
                

                new Player(PlayerClass.Marksman,    "John"),
                new Player(PlayerClass.Controller,  "Mary"),
                new Player(PlayerClass.Slayer,      "Paulo"),
                new Player(PlayerClass.Fighter,     "Lucas"),
            };

            foreach (Player player in players)
            {
                Console.Write($"{player.Name} is a {player.PClass} | Hash: ");

                // Test of hash code
                Console.Write(player.GetHashCode() + " | " );


                // Test of Equals
                Console.WriteLine(player.Equals(player1));
         
            }
        }
    }
}