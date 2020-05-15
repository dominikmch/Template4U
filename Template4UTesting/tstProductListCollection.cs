using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstProductListCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProductListCollection Products = new clsProductListCollection();

            Assert.IsNotNull(Products);
        }
    }
}
