using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Template4UBackend;

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
