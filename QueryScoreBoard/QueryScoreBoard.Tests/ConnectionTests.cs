﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueryScoreBoard.Tests
{
    [TestClass]
    public class ConnectionTests
    {
        [TestMethod]
        public void CreateContext()
        {
            Repository.Repository.IUnityOfWork uow = new Repository.Repository.UnityOfWork();
            var list = uow.Environment.FindAll();
            Assert.IsNotNull(list);
        }
    }
}
