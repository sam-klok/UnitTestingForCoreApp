using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data;
 
namespace UnitTestMSTest
{
    [TestClass]
    public class UnitTestFileProcess
    {
        [TestMethod]
        [Description("Check if file exists.")]
        [Owner("Serge")]
        //[Ignore]
        public void FileNameDoesExists()
        {
            var isFileExists = new ClassLibraryCore.FileProcess().FileExists(@"C:\Windows\notepad.exe");

            Assert.IsTrue(isFileExists);
        }

        [TestMethod]
        [Timeout(2000)]
        [Description("It will fail after 2 sec")]
        public void TestTimeOut()
        {
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Description("MS have all imaginable test methods..")]

        public void AreCollectionsEqualTest()
        {
            var collectionA = new List<int>() { 1,2,34,324,3,9 };
            var collectionB = new List<int>() { 1, 2, 34, 324, 3, 9 };

            CollectionAssert.AreEquivalent(collectionA, collectionB);
        }
    }
}
