using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_stack;
using net_stack.exceptions;

using net_stack.model.exceptions;
using EmptyStackException = net_stack.exceptions.EmptyStackException;

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
        public void isEmpty_ShouldReturnFalse_IfNotEmpty()
        {
            stack.push(1);
            Assert.AreEqual(false, stack.isEmpty());
        }

        [TestMethod]
        public void isEmpty_ShouldReturnTrueAfterPushAndPopIsCalled()
        {
            stack.push(1);
            stack.pop();
            Assert.AreEqual(true, stack.isEmpty());
        }

        [TestMethod]
        public void peek_ShouldReturnNull_IfStackIsEmpty()
        {
            Assert.AreEqual(null, stack.peek());
        }

        [TestMethod]
        public void peek_ShouldReturnMostRecentValuePushed()
        {
            stack.push(1);
            Assert.AreEqual(1, stack.peek());
        }

        [TestMethod]
        public void peek_ShouldReturnNull_AfterPushAndPop()
        {
            stack.push(1);
            stack.pop();
            Assert.AreEqual(null, stack.peek());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]       
        public void pop_ThrowsEmptyStackException_IfStackIsEmpty()
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
        public void pop_ReturnsLastValuePushedWhenMultipleValuesPushed()
        {
            stack.push(1);
            stack.push(2);
            Assert.AreEqual(2, stack.pop());
            Assert.AreEqual(1, stack.peek());
        }

        [TestMethod]
        public void contains_ReturnTrueIfPushedValueIsPresent()
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

        [TestMethod]
        public void contains_ReturnFalseIfValueNotIsPresent()
        {
            stack.push("1");
            Assert.AreEqual(false, stack.contains("4"));

        }

    }
}



