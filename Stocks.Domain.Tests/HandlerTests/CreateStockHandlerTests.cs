using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.Stock;
using Stocks.Domain.Handlers;
using Stocks.Domain.Shared;
using Stocks.Domain.Tests.Repositories;
using System;

namespace Stocks.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateStockHandlerTests
    {
        private readonly Guid _companyId = Guid.NewGuid();
        private readonly string ticker = "AAPL";
        private readonly Guid stockMarketId = Guid.NewGuid();
        
        private readonly Guid _companyIdEmpty = Guid.Empty;
        private readonly string tickerEmpty = string.Empty;
        private readonly Guid stockMarketIdEmpty = Guid.Empty;

        private GenericCommandResult _result = new GenericCommandResult();
        private readonly StockHandler _handler = new StockHandler(new FakeStockRepository());

        [TestMethod]
        public void Dado_company_vazio_retornar_invalido()
        {
            var command = new CreateStockCommand(_companyIdEmpty, ticker, stockMarketId);
            _result = (GenericCommandResult) _handler.Handle(command);

            Assert.AreEqual(false, _result.Success);
        }
        
        [TestMethod]
        public void Dado_company_naovazio_retornar_valido()
        {
            var command = new CreateStockCommand(_companyId, ticker, stockMarketId);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(true, _result.Success);
        }

        [TestMethod]
        public void Dado_stockMarket_vazio_retornar_invalido()
        {
            var command = new CreateStockCommand(_companyId, ticker, stockMarketIdEmpty);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(false, _result.Success);
        }
        
        [TestMethod]
        public void Dado_stockMarket_naovazio_retornar_valido()
        {
            var command = new CreateStockCommand(_companyId, ticker, stockMarketId);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(true, _result.Success);
        }
        
        [TestMethod]
        public void Dado_ticker_vazio_retornar_invalido()
        {
            var command = new CreateStockCommand(_companyId, tickerEmpty, stockMarketId);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(false, _result.Success);
        }
        
        [TestMethod]
        public void Dado_ticker_naovazio_retornar_valido()
        {
            var command = new CreateStockCommand(_companyId, ticker, stockMarketId);
            var _result = (GenericCommandResult)_handler.Handle(command);

            Assert.AreEqual(true, _result.Success);
        }
    }
}
