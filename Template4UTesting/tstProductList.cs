﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstProductList
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsProductList Product = new clsProductList();
            Assert.IsNotNull(Product);
        }
    }
}
