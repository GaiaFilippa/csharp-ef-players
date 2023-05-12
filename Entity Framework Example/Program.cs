using Entity_Framework_Example;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Xml.Serialization;

string stringaDiConnessione = "Data Source=localhost;Initial Catalog=Sport;Integrated Security=True;Pooling=False;TrustServerCertificate=True";

/*
Player player1 = new Player("Sofia", "Goggia", 584, 48, 22);

using (PlayerContext db = new PlayerContext())
{
    db.Add(player1);
    db.SaveChanges();
}

Console.WriteLine(player1.ToString());

Player player2 = new Player("Federica", "Brignone", 989, 56, 21);

using (PlayerContext db2 = new PlayerContext())
{
    db2.Add(player2);
    db2.SaveChanges();
}

Console.WriteLine(player2.ToString());


using (PlayerContext db = new PlayerContext())
{
    db.Remove(player1);
    db.SaveChanges();
}

Console.WriteLine(player1.ToString());
*/


bool go = true;
Console.WriteLine("------- MENU -------\n");
Console.WriteLine("1. Insert a new player");
Console.WriteLine("2. Serach and print a player by Id");
Console.WriteLine("3. Esci");
Console.WriteLine("\n-------------------\n");
while (go)
{
    Console.Write("Choose an option: ");
    int response = int.Parse(Console.ReadLine());
    switch (response)
    {
        case 1:
            Console.Write("Insert the name of the player: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Insert the surname : ");
            string playerSurname = Console.ReadLine();
            using (PlayerContext db = new PlayerContext())
            {
                Random random = new Random();
                int randomScore = random.Next(1, 11);
                int randomNumberOfMatches = random.Next(1, 101);
                int randomNumberOfVicories = random.Next(1, randomNumberOfMatches);
                Player newPlayer = new Player(playerName, playerSurname, randomNumberOfMatches, randomNumberOfVicories, randomScore);
                db.Add(newPlayer);
                db.SaveChanges();
            }
            break;
        case 2:
            Console.Write("Insert the Id to search: ");
            break;
        case 3:
            Console.WriteLine("Thank you and goodbye");
            go = false;
            break;
        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
    }
}