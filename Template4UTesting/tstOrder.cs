using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
             

            clsOrder Order = new clsOrder();
            Assert.IsNotNull(Order);
        }
    }
}
