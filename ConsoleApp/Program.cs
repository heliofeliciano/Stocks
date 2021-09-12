using ClassLibrary.Models;
using System;
using System.Data.SqlClient;
using Dapper;
using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Patterns.GetPatternTickerCurrentValue());
            //return;




            const string connectionString = "Server=localhost,1433;Database=Stocks;User ID=sa;Password=1q2w3e4r@#$";

            // Need to install the package System.Data.SqlClient
            // Need to install Dapper
            using (var connection = new SqlConnection(connectionString))
            {
                var searchEngine = new SearchStatusInvest(
                    Guid.NewGuid(),
                    "Status Invest",
                    "https://statusinvest.com.br/acoes/"
                    );

                /*
                 * Get all actives companies
                 */
                var companies = GetCompaniesInDatabase(connection);
                var stringPageContent = "";
                foreach (var company in companies)
                {
                    using (var client = new WebClient())
                    {
                        var fullPath = $"{searchEngine.Url}{company.TradeName}";
                        Console.WriteLine($"URL: {fullPath}");
                        stringPageContent = client.DownloadString(fullPath);

                        string cnpj = RegularExpression.GetResult(stringPageContent, searchEngine.GetPatternCNPJ());
                        string quote = RegularExpression.GetResult(stringPageContent, searchEngine.GetCurrentQuote());
                        Console.WriteLine($"Company: {company.CompanyName} - Current Quote: {quote}");

                    }
                }

                
                
                




                //GetTickerInformationsInStatusInvest(connection);


                // var sites = GetSearchSiteInDatabase(connection);

                //var companies = GetCompaniesInformationsInStatusInvest();
                //CreateCompaniesInDataBase(connection, companies);

            }

        }

        /*
         * Get informations in Status Invest
         * Quote, 
         */
        static void GetTickerInformationsInStatusInvest(Company company, SearchStatusInvest site)
        {
            var webClient = new WebClient();
            var stringPageContent = "";

            var fullPath = $"{site.Url}{company.TradeName}";
            Console.WriteLine($"URL: {fullPath}");
            stringPageContent = webClient.DownloadString(fullPath);

            var quote = GetCurrentQuoteInStatusInvest(stringPageContent);

            Console.WriteLine($"Stock: {company.TradeName} - Current quote: {quote}");

            //GetCompanyNameInStatusInvest(stringPageContent);
            //GetTickerInStatusInvest(stringPageContent);
            //RegularExpression.GetOnlyNumbers(GetCNPJInStatusInvest(stringPageContent));
             
        }

        static List<Company> GetCompaniesInformationsInStatusInvest()
        {
            var tickers = new List<string>();

            //tickers.Add("AAPL34");
            //tickers.Add("AMZO34");
            //tickers.Add("BKNG34");
            //tickers.Add("FBOK34");
            //tickers.Add("GOGL34");
            //tickers.Add("JDCO34");
            //tickers.Add("MELI34");
            //tickers.Add("SSFO34");
            tickers.Add("BPAC11");
            tickers.Add("BRAP4");
            tickers.Add("BRPR3");
            tickers.Add("BRSR6");
            tickers.Add("EGIE3");
            tickers.Add("ENBR3");
            tickers.Add("ITUB4");
            tickers.Add("MYPK3");
            tickers.Add("PETR4");
            tickers.Add("PETZ3");
            tickers.Add("SEER3");
            tickers.Add("SHUL4");
            tickers.Add("SUZB3");
            tickers.Add("VALE3");

            var webClient = new WebClient();
            var stringPageContent = "";
            var url = "";

            var companies = new List<Company>();

            foreach (var item in tickers)
            {
                url = $"https://statusinvest.com.br/acoes/{item}";
                Console.WriteLine(url);
                stringPageContent = webClient.DownloadString(url);

                companies.Add(new Company(
                    Guid.NewGuid(),
                    GetCompanyNameInStatusInvest(stringPageContent),
                    GetTickerInStatusInvest(stringPageContent),
                    RegularExpression.GetOnlyNumbers(GetCNPJInStatusInvest(stringPageContent))
                    )
                );

            }

            return companies;
        }

        static List<Company> GetCompaniesInDatabase(SqlConnection connection)
        {
            var sql = "select * from company";
            var companies = connection.Query<Company>(sql);

            return companies.ToList();

            /*foreach (var company in companies)
            {
                Console.WriteLine($"Id: {company.Id} Company: {company.CompanyName} / Ticker: {company.TradeName} / CNPJ: {company.CNPJ}");
            }*/
        }
        
        static List<SearchSite> GetSearchSiteInDatabase(SqlConnection connection)
        {
            var sql = "select * from searchsite";
            var sites = connection.Query<SearchSite>(sql);

            return sites.ToList();

        }

        static void CreateCompanyInDataBase(SqlConnection connection)
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
        
        static void CreateSearchSiteInDataBase(SqlConnection connection)
        {
            var site = new SearchStatusInvest();
            site.Id = Guid.NewGuid();
            site.Name = "Status Invest";
            site.Url = "https://statusinvest.com.br/";
            
            var sqlInsert = "INSERT INTO SearchSite VALUES (@Id, @Name, @Url)";

            var rows = connection.Execute(sqlInsert, site);

            Console.WriteLine($"{rows} incluida com sucesso");
        }
        
        static void CreateCompaniesInDataBase(SqlConnection connection, List<Company> companies)
        {
            var sqlInsert = "INSERT INTO Company VALUES (@Id, @CompanyName, @TradeName, @CNPJ)";

            var rows = connection.Execute(sqlInsert, companies);

            Console.WriteLine($"{rows} incluida com sucesso");
        }
       
        static string GetCNPJInStatusInvest(string stringPageContent)
        {           
            var CNPJMatches = RegularExpression.GetMatches(stringPageContent, Patterns.GetPatternCompanyCNPJ());
            var CNPJCompany = CNPJMatches[0].Groups[1].Value;


            return CNPJCompany;
        }
        
        static string GetCompanyNameInStatusInvest(string stringPageContent)
        {
            var matchesFounded = RegularExpression.GetMatches(stringPageContent, Patterns.GetPatternCompanyName());
            var companyName = matchesFounded[0].Groups[1].Value;


            return companyName;
        }
        
        static string GetTickerInStatusInvest(string stringPageContent)
        {
            var matchesFounded = RegularExpression.GetMatches(stringPageContent, Patterns.GetPatternTickerName());
            var tickerName = matchesFounded[0].Groups[1].Value;

            return tickerName;
        }
        
        static string GetCurrentQuoteInStatusInvest(string stringPageContent)
        {
            var matchesFounded = RegularExpression.GetMatches(stringPageContent, Patterns.GetPatternTickerCurrentQuote());
            var currentQuote = matchesFounded[0].Groups[1].Value;

            return currentQuote;
        }

    }
}
