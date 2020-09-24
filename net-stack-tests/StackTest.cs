using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_stack;
using net_stack.exceptions;

namespace net_stack_tests
{
    [TestClass]
    public class StackTest
    {
        private Stack stack;

        [TestInitialize]
        public void SetUp()
        {
            stack = new Stack();
        }

        [TestMethod]
        public void isEmpty_OnNewStack_ShouldReturnTrue()
        {
            Assert.AreEqual(true, stack.isEmpty());
        }

        [TestMethod]
        public void isEmpty_OnePush_ShouldReturnFalse()
        {
            stack.push("abc");
            Assert.AreEqual(false, stack.isEmpty());
        }

        [TestMethod]
        public void isEmpty_ShouldReturnTrueAfterPushAndPop()
        {
            stack.push(1);
            stack.pop();
            Assert.AreEqual(true, stack.isEmpty());
        }

        [TestMethod]
        public void peek_ShouldReturnLastValuePushed()
        {
            stack.push("abc");
            Assert.AreEqual("abc", stack.peek());
        }

        [TestMethod]
        public void peek_NewStackShouldReturnNull()
        {
            Assert.AreEqual(null, stack.peek());
        }

        [TestMethod]
        public void peek_ShouldReturnNullAfterPushAndPop()
        {
            stack.push(1);
            stack.pop();
            Assert.AreEqual(null, stack.peek());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void pop_ThrowsException_newStack()
        {
            stack.pop();
        }

        [TestMethod]
        public void pop_ShouldReturnLastValuePushed()
        {
            stack.push(1);
            Assert.AreEqual(1, stack.pop());
        }

        [TestMethod]
        public void pop_ShouldReturnPushedValuesReversed()
        {
            stack.push("a");
            stack.push("b");
            stack.push("c");
            Assert.AreEqual("c", stack.pop());
            Assert.AreEqual("b", stack.pop());
            Assert.AreEqual("a", stack.pop());
        }

        [TestMethod]
        public void contains_PushMultipleValuesAndReturnTrueForThoseValues()
        {
            stack.push("1");
            stack.push("2");
            stack.push("3");
            Assert.AreEqual(true, stack.contains("1"));
            Assert.AreEqual(true, stack.contains("2"));
            Assert.AreEqual(true, stack.contains("3"));
        }

        [TestMethod]
        public void contains_PushMultipleValuesAndReturnFalseForDifferentValues()
        {
            stack.push(1);
            stack.push(2);
            stack.push(3);
            Assert.AreEqual(false, stack.contains(4));
            Assert.AreEqual(false, stack.contains(5));
            Assert.AreEqual(false, stack.contains(6));
        }
    }
}



