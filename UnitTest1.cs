using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValidationApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 20;
            int b = 8;

            int result = a * b;

            int expected = 160;

            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        [DataRow("456 78")]
        [DataRow("456 79")]
        [DataRow("456 99")]

        public void should_give_true_if_input_is_nnn_nn(string zipcode)
        {
            var z = new ZipCodeService();

            bool result = z.Validate(zipcode);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        [DataRow(" 45 888")]
        [DataRow(" 45    ")]
        [DataRow("01111  ")]


        public void should_give_false_if_input_is_bad(string zip)
        {
            var z = new ZipCodeService();

            bool result = z.Validate(zip);

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void should_give_false_if_input_is_null()
        {
            var z = new ZipCodeService();

            bool result = z.Validate(null);

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void test1()
        {
            var z = new ZipCodeService();
            int[] result = z.SlashZipCode("111 22");

            Assert.AreEqual(111, result[0]);
            Assert.AreEqual(22, result[1]);
        }

        [TestMethod]
        public void test2()
        {
            var z = new ZipCodeService();
            int[] result = z.SlashZipCode("333 77");

            Assert.AreEqual(333, result[0]);
            Assert.AreEqual(77, result[1]);
        }

        [TestMethod]
        [DataRow("a33 77")]
        [DataRow("")]
        [DataRow("a33 77")]
        [DataRow(null)]
        public void test3(string badZip)
        {
            var z = new ZipCodeService();

            Assert.ThrowsException<ArgumentException>(() =>

           z.SlashZipCode(badZip)
            );

        }

    }

}
