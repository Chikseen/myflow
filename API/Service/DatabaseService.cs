using Npgsql;
public class DatabaseService
{
    private string name = "";
    private string location = "";
    private NpgsqlConnection con;

    public DatabaseService()
    {
        var cs = "Host=localhost;Port=5432;Username=admin;Password=12345678;Database=test";
        con = new NpgsqlConnection(cs);
        con.Open();
    }

    public String createNewUser()
    {
        var sql = "SELECT * FROM Persons";
        NpgsqlCommand command = new NpgsqlCommand(sql, con);
        NpgsqlDataReader dr = command.ExecuteReader();

        String version = "";

        while (dr.Read())
        {
            Console.Write("{0}\t{1}\t{2}\t{3}\t{4} \n", dr[0], dr[1], dr[2], dr[3], dr[4]);
            version += dr[0] + "\t";
            version += dr[1] + "\t";
            version += dr[2] + "\t";
            version += dr[3] + "\t";
            version += dr[4] + "\t";
            version += "\n";
        }

        return version;
    }


    public String getAllUser()
    {
        var sql = "SELECT * FROM Persons";
        NpgsqlCommand command = new NpgsqlCommand(sql, con);
        NpgsqlDataReader dr = command.ExecuteReader();

        String version = "";

        while (dr.Read())
        {
            Console.Write("{0}\t{1}\t{2}\t{3}\t{4} \n", dr[0], dr[1], dr[2], dr[3], dr[4]);
            version += dr[0] + "\t";
            version += dr[1] + "\t";
            version += dr[2] + "\t";
            version += dr[3] + "\t";
            version += dr[4] + "\t";
            version += "\n";
        }

        return version;
    }
}