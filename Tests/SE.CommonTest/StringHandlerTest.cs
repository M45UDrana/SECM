using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE.Common;
using System;

namespace SE.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            //----- Arrange
            string source = "MasudRana";
            string expected = "Masud Rana";
            //----- Act
            string actual = source.InsertSpaces();
            //----- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaceTestWithExistinSpace()
        {
            //----- Arrange
            string source = "Masud Rana";
            string expected = "Masud Rana";
            //----- Act
            string actual = source.InsertSpaces();
            //----- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
