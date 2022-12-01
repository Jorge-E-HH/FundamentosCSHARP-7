using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;
using FundamentosCSHARP3.Models;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace FundamentosCSHARP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cerveza cerveza = new Cerveza(10, "Cerveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt", miJson);

            string miJson = File.ReadAllText("objeto.txt");
            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);

        }


    }
}