using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Template4UBackend;
using Template4UClassLib;

namespace Template4UTesting
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview Review = new clsReview();
            Assert.IsNotNull(Review);
        }
    }

    
}
