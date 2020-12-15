using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {

        // Write uncondensed tests
        /*
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OnlyEmptyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void OnlyBracketsOnEndsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void EmptyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void PartialBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]Code"));
        }

        [TestMethod]
        public void OnlyOneBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void OnlyReversedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void MultipleOrderedPairsTogetherReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][][]"));
        }

        [TestMethod]
        public void MultipleUnorderedPairsTogetherReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][][]["));
        }

        [TestMethod]
        public void OrderedBracketsInBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[]]]"));
        }

        [TestMethod]
        public void UnorderedBracketsInBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]][[]"));
        }

        [TestMethod]
        public void TooManyBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[[[[]"));
        }
        */

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
