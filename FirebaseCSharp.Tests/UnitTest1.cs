using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace FirebaseCSharp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        ManualResetEvent allDone = new ManualResetEvent(false);

        [TestMethod]
        public void TestMethod1()
        {
            Firebase fb = Firebase.CreateNew("pun.firebaseio.com");
            //fb.SetOtherThreadDispatcher(new SimpleThreadDispatcherUnitTest());

            var child = fb.Child("testing");

            child.OnUpdateSuccess += (a, b) =>
            {
                int x = 0;
                int y = x;

                allDone.Set();
            };

            child.OnUpdateFailed += (a, b) =>
            {
                int x = 0;
                int y = x;

                allDone.Set();
            };

            child.SetValue("derpherp");


            allDone.WaitOne();
        }
    }


    public class SimpleThreadDispatcherUnitTest : ISimpleThreadDispatcher
    {
        public void Dispatch(Action work)
        {
            if (work != null)
                work();
        }
    }
}
