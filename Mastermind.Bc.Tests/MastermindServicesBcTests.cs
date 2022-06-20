using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mastermind.Bc.Tests
{
    [TestClass]
    public class MastermindServicesBcTests
    {
        MastermindServicesBc ms = new MastermindServicesBc();

        [DataTestMethod]
        [DataRow("1325", "+--")]
        [DataRow("1245", "++-")]
        [DataRow("1235", "+++")]
        public void CompareAnswer_Input_expectedOutput_AreEqual(string input, string expectedOutput)
        {
            string answer = "1234";
            string output = ms.CompareAnswer(input, answer);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}