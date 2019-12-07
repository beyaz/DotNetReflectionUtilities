﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetReflectionUtilities
{
    [TestClass]
    public class CastingTest
    {
        #region Public Methods
        [TestMethod]
        public void cast()
        {
            Assert.IsTrue(Cast.To<CastingTest>(this) == this);
            Assert.IsTrue(Cast.To<CastingTest>(this) == this);
        }
        #endregion
    }
}