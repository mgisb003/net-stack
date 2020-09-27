using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_stack;
<<<<<<< Updated upstream
using net_stack.exceptions;
=======
using net_stack.model.exceptions;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
        public void isEmpty_OnNewStack_ShouldReturnTrue()
        {
            Assert.AreEqual(true, stack.isEmpty());
        }

        [TestMethod]
        public void isEmpty_OnePush_ShouldReturnFalse()
        {
            stack.push("abc");
=======
        public void isEmpty_ShouldReturnTrue_IfStackIsEmpty()
        {
            Assert.AreEqual(true, stack.isEmpty());

        }

        [TestMethod]
        public void isEmpty_ShouldReturnFalse_IfNotEmpty()
        {
            stack.push(1);
>>>>>>> Stashed changes
            Assert.AreEqual(false, stack.isEmpty());
        }

        [TestMethod]
<<<<<<< Updated upstream
        public void isEmpty_ShouldReturnTrueAfterPushAndPop()
=======
        public void isEmpty_ShouldReturnTrueAfterPushAndPopIsCalled()
>>>>>>> Stashed changes
        {
            stack.push(1);
            stack.pop();
            Assert.AreEqual(true, stack.isEmpty());
        }

        [TestMethod]
<<<<<<< Updated upstream
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
=======
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
>>>>>>> Stashed changes
        {
            stack.push(1);
            stack.pop();
            Assert.AreEqual(null, stack.peek());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
<<<<<<< Updated upstream
        public void pop_ThrowsException_newStack()
=======
        public void pop_ThrowsEmptyStackException_IfStackIsEmpty()
>>>>>>> Stashed changes
        {
            stack.pop();
        }

        [TestMethod]
<<<<<<< Updated upstream
        public void pop_ShouldReturnLastValuePushed()
=======
        public void pop_ReturnsMostRecentValuePushed()
>>>>>>> Stashed changes
        {
            stack.push(1);
            Assert.AreEqual(1, stack.pop());
        }

        [TestMethod]
<<<<<<< Updated upstream
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
=======
        public void pop_ReturnsLastValuePushedWhenMultipleValuesPushed()
        {
            stack.push(1);
            stack.push(2);
            Assert.AreEqual(2, stack.pop());
            Assert.AreEqual(1, stack.peek());
        }

        [TestMethod]
        public void contains_ReturnTrueIfPushedValueIsPresent()
>>>>>>> Stashed changes
        {
            stack.push("1");
            stack.push("2");
            stack.push("3");
<<<<<<< Updated upstream
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
=======
            Assert.AreEqual(true, stack.contains("3"));
            Assert.AreEqual(true, stack.contains("2"));
            Assert.AreEqual(true, stack.contains("1"));
        }

        [TestMethod]
        public void contains_ReturnFalseIfValueNotIsPresent()
        {
            stack.push("1");
            Assert.AreEqual(false, stack.contains("4"));

        }


>>>>>>> Stashed changes
    }
}



