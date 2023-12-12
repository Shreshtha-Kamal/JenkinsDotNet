namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! from Jenkins Pipeline Created by Shreshtha";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                SampleAppForJenkins.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}