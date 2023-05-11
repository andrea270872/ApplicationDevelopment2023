using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Stack_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_1_SimpleCase()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4 };
            int[] arr3;
            MissingClass m = new MissingClass();
            arr3 = m.missing(arr1, arr2);
            
            Assert.IsTrue(arr3.Length == 3);
            Assert.AreEqual(arr3[0] + " " + arr3[1] + " " + arr3[2], "1 2 3");
            Console.Write(arr3[0] + " " + arr3[1] + " " + arr3[2]);
        }
        [TestMethod]
        public void Test_2_SimpleCaseB()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 2 };
            int[] arr3;
            MissingClass m = new MissingClass();
            arr3 = m.missing(arr1, arr2);

            Console.Write(arr3[0] + " " + arr3[1] );

            Assert.IsTrue(arr3.Length == 2);
            Assert.AreEqual(arr3[0] + " " + arr3[1] , "1 3");
        }

        [TestMethod]
        public void Test_3_CaseWith2Elements()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 2 , 4 };
            int[] arr3;
            MissingClass m = new MissingClass();
            arr3 = m.missing(arr1, arr2);

            Console.Write(arr3[0] + " " + arr3[1]);

            Assert.IsTrue(arr3.Length == 2);
            Assert.AreEqual(arr3[0] + " " + arr3[1], "1 3");
        }

        [TestMethod]
        public void Test_4_CaseWith2ElementsB()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 2, 1 };
            int[] arr3;
            MissingClass m = new MissingClass();
            arr3 = m.missing(arr1, arr2);

            Console.Write(arr3[0] );

            Assert.IsTrue(arr3.Length == 1);
            Assert.AreEqual(arr3[0]+"" , "3");
        }

        [TestMethod]
        public void Test_5_Repetition()
        {
            int[] arr1 = { 1, 2, 3 , 1, 3, 4, 2 };
            int[] arr2 = { 2, 1 , 2};
            int[] arr3;
            MissingClass m = new MissingClass();
            arr3 = m.missing(arr1, arr2);

            Assert.IsTrue(arr3.Length == 3);
            Assert.AreEqual(arr3[0] + " " + arr3[1] + " " + arr3[2], "3 3 4");
        }
    }
}
