using Entity_Framework_Example;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

string stringaDiConnessione = "Data Source=localhost;Initial Catalog=Sport;Integrated Security=True;Pooling=False;TrustServerCertificate=True";


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