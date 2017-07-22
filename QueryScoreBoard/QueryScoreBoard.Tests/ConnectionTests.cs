﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueryScoreBoard.Tests
{
    [TestClass]
    public class ConnectionTests
    {
        [TestMethod]
        public void CreateContext()
        {
            Repository.Repository.IUnitOfWork uow = new Repository.Repository.UnityOfWork();
            var list = uow.Plan.FindAll();
            Assert.IsNotNull(list);
        }
    }
}