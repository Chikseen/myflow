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

    public void createNewUser(String userName, int userId)
    {
        var sql = "INSERT INTO Users VALUES (" + userId + ", '" + userName + "');";
        Console.WriteLine(sql);
        NpgsqlCommand command = new NpgsqlCommand(sql, con);
        NpgsqlDataReader dr = command.ExecuteReader();

    }


    public String getAllUser()
    {
        var sql = "SELECT * FROM Users";
        Console.WriteLine(sql);
        NpgsqlCommand command = new NpgsqlCommand(sql, con);
        NpgsqlDataReader dr = command.ExecuteReader();

        String version = "";

        while (dr.Read())
        {
            Console.Write("{0}\t{1} \n", dr[0], dr[1]);
            version += dr[0] + "\t";
            version += dr[1] + "\t";
            version += "\n";
        }

        return version;
    }

    public String dbInit()
    {
        var sql = "CREATE TABLE Users (PersonID int,Name varchar(255));";
        Console.WriteLine(sql);
        NpgsqlCommand command = new NpgsqlCommand(sql, con);
        NpgsqlDataReader dr = command.ExecuteReader();

        String version = "";

        while (dr.Read())
        {
            Console.Write("{0}\t{1} \n", dr[0], dr[1]);
            version += dr[0] + "\t";
            version += dr[1] + "\t";
            version += "\n";
        }

        return version;
    }
}