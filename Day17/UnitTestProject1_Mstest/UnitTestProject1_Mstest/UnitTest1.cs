using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject1_Mstest
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext tc)
        {
            Trace.WriteLine("Before Assembly");
        }
       
        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Trace.WriteLine("After Assembly");
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            Trace.WriteLine("Class Initializer");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
          Debug.WriteLine("Class Cleanup");
            Trace.WriteLine("hi");

        }
        [TestInitialize]
        public void BeforeTest()
        {
            Trace.WriteLine("Tests Initialized");
        }
        [TestCleanup]
        public void AfterTest()
        {
            Trace.WriteLine("Test Cleanup");
        }
        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine("Test Method 1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Trace.WriteLine("Test Method 2");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Trace.WriteLine("Test Method 3");
        }
    }
}
