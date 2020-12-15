using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // Write condensed test methods with data rows
        [DataTestMethod]
        [DataRow("[]")]
        [DataRow("")]
        [DataRow("[LaunchCode]")]
        [DataRow("[]LaunchCode")]
        [DataRow("[Launch]Code")]
        [DataRow("[][][]")]
        [DataRow("[[[]]]")]
        public void ReturnsTrue(string brackets)
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(brackets));
        }

        [DataTestMethod]
        [DataRow("[")]
        [DataRow("][")]
        [DataRow("][][][")]
        [DataRow("[]][[]")]
        [DataRow("[[[[[]")]
        public void ReturnsFalse(string brackets)
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(brackets));
        }
    }
}
