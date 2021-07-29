using NUnit.Framework;
using System;
using ExceptionsApp;

namespace ExceptionsDataTypeTest
{
    public class GradeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-34)]
        [TestCase(-1)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains(" Allowed range is 0-100"));
        }
        [TestCase(101)]
        [TestCase(100000)]
        public void WhenMarkisGreaterThan100_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains(" Allowed range is 0-100"));
        }
    }
}