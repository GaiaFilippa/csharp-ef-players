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
Console.WriteLine("0. Esci");
Console.WriteLine("1. Insert a new player");
Console.WriteLine("2. Search and print a player by Id");
Console.WriteLine("3. Search and print a player by its Name and Surname");
Console.WriteLine("4. Modify player matches and score of player by its Id");
while (go)
{
    Console.Write("Choose an option: ");
    int response = int.Parse(Console.ReadLine());
    switch (response)
    {
        case 0:
            Console.WriteLine("Thank you and goodbye");
            go = false;
            break;

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
            int playerIdToSearch = int.Parse(Console.ReadLine());
            
            using (PlayerContext db = new PlayerContext())
            {
                Player playerFound = db.Player.Where(player => player.PlayerId == playerIdToSearch).First();
                Console.WriteLine(playerFound);
            }
            break;

        case 3:
            Console.Write("Insert the name of the player you want to search:");
            string playerNameToSearch = Console.ReadLine();
            Console.WriteLine("Insert the surname of the player you want to search : ");
            string playerSurnameToSearch = Console.ReadLine();
            using (PlayerContext db = new PlayerContext())
            {
                Player playerFound = db.Player.Where(player => player.Name == playerNameToSearch && player.Surname == playerSurnameToSearch).First();
                Console.WriteLine(playerFound.ToString());

            }
            break;

        case 4:
            Console.Write("Insert the Id to search: ");
            int playerIdToModify = int.Parse(Console.ReadLine());
            
            using (PlayerContext db = new PlayerContext())
            {
                if (db.Player.Where(player => player.PlayerId == playerIdToModify).Any())
                {
                    Player playerToModify = db.Player.Where(player => player.PlayerId == playerIdToModify).First();
                    
                    Console.Write("Insert the new player matches done: ");
                    int newPlayerMatches = int.Parse(Console.ReadLine());
                    
                    Console.Write("Insert the new score points done: ");
                    int newPlayerScore = int.Parse(Console.ReadLine());
                    
                    playerToModify.PlayedGames = newPlayerMatches;
                    playerToModify.Score = newPlayerScore;
                    
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Non è stato trovato nessun giocatore con id = " + playerIdToModify);
                }

            }
            break;

        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
    }
}