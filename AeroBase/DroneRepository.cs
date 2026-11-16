using System.Collections.Generic;
using Npgsql;

namespace AeroBase
{
    public class DroneRepository
    {
        private string connectionString;

        public DroneRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Drone> GetAll()
        {
            List<Drone> result = new List<Drone>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT id, name, model, type, inventory_number, status FROM drones ORDER BY id", connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Drone drone = new Drone
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Model = reader.GetString(2),
                            Type = reader.GetString(3),
                            InventoryNumber = reader.GetString(4),
                            Status = reader.GetString(5)
                        };
                        result.Add(drone);
                    }
                }
            }
            return result;
        }

        public void Add(Drone drone)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(
                    "INSERT INTO drones (name, model, type, inventory_number, status) " +
                    "VALUES (@name, @model, @type, @inv, @status)", connection))
                {
                    command.Parameters.AddWithValue("name", drone.Name);
                    command.Parameters.AddWithValue("model", drone.Model);
                    command.Parameters.AddWithValue("type", drone.Type);
                    command.Parameters.AddWithValue("inv", drone.InventoryNumber);
                    command.Parameters.AddWithValue("status", drone.Status);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool Delete(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(
                    "DELETE FROM drones WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public void Update(Drone drone)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(
                    "UPDATE drones SET name = @name, model = @model, type = @type, " +
                    "inventory_number = @inv, status = @status WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("name", drone.Name);
                    command.Parameters.AddWithValue("model", drone.Model);
                    command.Parameters.AddWithValue("type", drone.Type);
                    command.Parameters.AddWithValue("inv", drone.InventoryNumber);
                    command.Parameters.AddWithValue("status", drone.Status);
                    command.Parameters.AddWithValue("id", drone.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
