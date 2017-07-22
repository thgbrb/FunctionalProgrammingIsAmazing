﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace QueryScoreBoard.Tests
{
    public class ConnectionTests
    {
        [Fact]
        public void CreateContext()
        {
            QueryScoreBoard.Repository.Repository.IUnitOfWork uow = new Repository.Repository.UnityOfWork();
            var list = uow.Plan.FindAll();
            Assert.NotNull(list);
        }
    }
}
