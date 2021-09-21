using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.Stock;
using Stocks.Domain.Handlers;
using Stocks.Domain.Shared;
using Stocks.Domain.Tests.Repositories;

namespace Stocks.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateStockHandlerTests
    {
        private readonly string companyName = "APPLE";
        private readonly string companyDocument = "123456789";
        private readonly string ticker = "AAPL";
        private readonly string stockMarket = "NASDAQ";
        
        private readonly string companyNameVazio = "";
        private readonly string companyDocumentVazio = "";
        private readonly string tickerVazio = "";
        private readonly string stockMarketVazio = "";

        private GenericCommandResult _result = new GenericCommandResult();
        private readonly StockHandler _handler = new StockHandler(new FakeStockRepository());

        [TestMethod]
        public void Dado_company_vazio_retornar_invalido()
        {
            var command = new CreateStockCommand(companyNameVazio, companyDocument, ticker, stockMarket);
            _result = (GenericCommandResult) _handler.Handle(command);

            Assert.AreEqual(false, _result.Success);
        }
        
        [TestMethod]
        public void Dado_company_naovazio_retornar_valido()
        {
            var command = new CreateStockCommand(companyName, companyDocument, ticker, stockMarket);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(true, _result.Success);
        }

        [TestMethod]
        public void Dado_document_vazio_retornar_invalido()
        {
            var command = new CreateStockCommand(companyName, companyDocumentVazio, ticker, stockMarket);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(false, _result.Success);
        }

        [TestMethod]
        public void Dado_document_naovazio_retornar_valido()
        {
            var command = new CreateStockCommand(companyName, companyDocument, ticker, stockMarket);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(true, _result.Success);
        }

        [TestMethod]
        public void Dado_stockMarket_vazio_retornar_invalido()
        {
            var command = new CreateStockCommand(companyName, companyDocument, ticker, stockMarketVazio);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(false, _result.Success);
        }
        
        [TestMethod]
        public void Dado_stockMarket_naovazio_retornar_valido()
        {
            var command = new CreateStockCommand(companyName, companyDocument, ticker, stockMarket);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(true, _result.Success);
        }
        
        [TestMethod]
        public void Dado_ticker_vazio_retornar_invalido()
        {
            var command = new CreateStockCommand(companyName, companyDocument, tickerVazio, stockMarket);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(false, _result.Success);
        }
        
        [TestMethod]
        public void Dado_ticker_naovazio_retornar_valido()
        {
            var command = new CreateStockCommand(companyName, companyDocument, ticker, stockMarket);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(true, _result.Success);
        }
    }
}
