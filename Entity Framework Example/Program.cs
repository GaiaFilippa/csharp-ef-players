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