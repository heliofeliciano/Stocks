using ClassLibrary.Models;
using System;
using System.Data.SqlClient;
using Dapper;
using System.Net;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=Stocks;User ID=sa;Password=1q2w3e4r@#$";

            // Need to install the package System.Data.SqlClient
            // Need to install Dapper

            using (var connection = new SqlConnection(connectionString))
            {
                CreateCompany(connection);
            }
        }

        static void CreateCompany(SqlConnection connection)
        {
            var company = new Company();
            company.Id = Guid.NewGuid();
            company.CompanyName = "PET CENTER COMERCIO E PARTICIPACOES S.A.";
            company.TradeName = "PETZ";
            company.CNPJ = "18328118000109";

            var sqlInsert = "INSERT INTO Company VALUES (@Id, @CompanyName, @TradeName, @CNPJ)";

            var rows = connection.Execute(sqlInsert, 
                new {
                company.Id,
                company.CompanyName,
                company.TradeName,
                company.CNPJ
                });

            Console.WriteLine($"{rows} incluida com sucesso");
        }

        static string GetCNPJInStatusInvest()
        {
            var webClient = new WebClient();
            var stringPageContent = webClient.DownloadString($"https://statusinvest.com.br/acoes/petz3");

            var companyCNPJ = RegularExpression.GetMatches(stringPageContent, Patterns.GetPatternCompanyCNPJ());

            return companyCNPJ[0].Groups[1].Value;
        }

    }
}
