﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GruempelLeonRemo
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 1; i > 0; i++)
            {




                Console.WriteLine("Was wollen sie machen? Spieler verwalten (1), Teams verwalten (2)");
                string Auswahl = Console.ReadLine();
                if (Auswahl == "1")
                {
                    Console.WriteLine("Spielerverwaltung:");
                    Console.WriteLine("Möchten sie einen Spieler erstellen(1), alle Spieler anzeigen(2), einen Spieler suchen(3) oder einen Spieler löschen(4)?");
                    PlayerService person = new PlayerService();
                    TeamService team = new TeamService();
                    string AuswahlSpieler = Console.ReadLine();
                    if (AuswahlSpieler == "1")
                    {
                        person.PersonEinlesen();

                    }

                    else if (AuswahlSpieler == "2")
                    {
                        var playerService = new PlayerService();
                        playerService.PersonenAusgeben();
                    }

                    else if (AuswahlSpieler == "3")
                    {
                        var playerService = new PlayerService();
                        var players = playerService.PersonSuchen();
                        foreach (var player in players)
                        {
                            player.Print();
                        }
                        Console.WriteLine("Choose Player Id");

                        int a = ConsoleHelper.ReadNumber();
                        var pl = players.FirstOrDefault(p => p.ID == a);

                        pl.Print();
                    }
                    
                    else if (AuswahlSpieler == "4")
                    {

                    }
                    Console.ReadKey();

                }
                else if (Auswahl == "2")
                {
                    Console.WriteLine("Teamverwaltung:");
                    Console.WriteLine("Möchten sie ein Team erstellen(1), alle Teams anzeigen(2), eins löschen(3) oder einen Spieler einfügen(4)?");
                    var teamService = new TeamService();
                    string AuswahlTeam = Console.ReadLine();
                    if (AuswahlTeam == "1")
                    {
                        teamService.TeamEinlesen();
                    }

                    else if (AuswahlTeam == "2")
                    {
                        teamService.TeamAusgeben();
                    }

                    else if (AuswahlTeam == "3")
                    {
                        Console.WriteLine("Coming soon");
                        Console.ReadKey();
                    }
                    else if (AuswahlTeam == "4")
                    {
                        Console.WriteLine();
                    }

                }
            }
                
            }   
    }
}
