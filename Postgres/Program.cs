﻿using Npgsql;

var cs = "Host=localhost;Username=postgres;Password=Parvathi2022;Database=testdb";

using var con = new NpgsqlConnection(cs);
con.Open();

using var cmd = new NpgsqlCommand();
cmd.Connection = con;

cmd.CommandText = "DROP TABLE IF EXISTS cars";
cmd.ExecuteNonQuery();

cmd.CommandText = @"CREATE TABLE cars(id SERIAL PRIMARY KEY,
        name VARCHAR(255), price INT)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volvo',29000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Bentley',350000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Citroen',21000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Hummer',41400)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volkswagen',21600)";
cmd.ExecuteNonQuery();

Console.WriteLine("Table cars created");

//PostgreSQL prepared statements

var sql = "INSERT INTO cars(name, price) VALUES(@name, @price)";
using var cmd1 = new NpgsqlCommand(sql, con);
cmd1.Parameters.AddWithValue("name", "BMW");
cmd1.Parameters.AddWithValue("price", 36600);
cmd1.Prepare();

cmd1.ExecuteNonQuery();

Console.WriteLine("row inserted");

//NpgsqlDataReader

string sql1 = "SELECT * FROM cars";
using var cmd2 = new NpgsqlCommand(sql1, con);

using NpgsqlDataReader rdr = cmd2.ExecuteReader();

while (rdr.Read())
{
    Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
            rdr.GetInt32(2));
}

//PostgreSQL column headers

Console.WriteLine($"{rdr.GetName(0),-4} {rdr.GetName(1),-10} {rdr.GetName(2),10}");

while (rdr.Read())
{
    Console.WriteLine($"{rdr.GetInt32(0),-4} {rdr.GetString(1),-10} {rdr.GetInt32(2),10}");
}

