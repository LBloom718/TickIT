using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TickIT.Controllers
{
    public class TicketController : Controller
    {
        [HttpGet]
        public Ticket GetFromQueryString([XXX] XXX location)
        {
            var data = new TicketData();
            data.results = Reader(location.query);
            return data;
        }
    }
    private static List<Result> Reader(string search)
    {
        string _connectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString;
        var results = new List<Result>();
        string commandText = "SELECT * FROM Table"; //Need name of table

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var Date = (int)reader["Date"];
                        var Status = (string)reader["Status"];
                        var Discription = (string)reader["Discription"];
                        var Type = (string)reader["Type"];

                        var result = new Result()
                        {
                            date = Date,
                            status = Status,
                            discription = Discription,
                            type = Type;
                        };
                    }
                }
            }
        }
    }
