using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirebaseCSharp.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Firebase fb = Firebase.CreateNew("pun.firebaseio.com");
            var child = fb.Child("testing");

            System.Diagnostics.Debug.WriteLine("------------------TESTING-----------------------");


            child.OnUpdateSuccess += (a, b) =>
            {
                int x = 0;
                int y = x;


            };

            child.OnUpdateFailed += (a, b) =>
            {
                int x = 0;
                int y = x;
            };

            child.SetValue("newvalue666");



            allDone.WaitOne();
        }
    }
}
