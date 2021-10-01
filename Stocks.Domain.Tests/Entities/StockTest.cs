using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.ValueObjects;

namespace Stocks.Domain.Tests.Entities
{
    [TestClass]
    public class StockTest
    {
        private readonly Stock _validStock = new Stock(new Company("Company Test", new Document("123", EDocumentType.CNPJ)).Id, "CT", new StockMarket("B3").Id);

        [TestMethod]
        public void Dado_um_novo_stock_o_campo_active_deve_ser_verdadeiro()
        {
            Assert.AreEqual(true, _validStock.Active);
        } 

        [TestMethod]
        public void Utilizar_o_metodo_ActivateStock_o_campo_Active_deve_retornar_verdadeiro()
        {
            _validStock.ActivateStock();

            Assert.AreEqual(true, _validStock.Active);
        } 
        
        [TestMethod]
        public void Utilizar_o_metodo_InactivateStock_o_campo_Active_deve_retornar_falso()
        {
            _validStock.InactivateStock();

            Assert.AreEqual(false, _validStock.Active);
        }
        
    }
}
