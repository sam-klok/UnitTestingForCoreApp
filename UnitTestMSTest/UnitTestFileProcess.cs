using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
