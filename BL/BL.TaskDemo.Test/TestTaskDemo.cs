using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT = BL.TaskDemo;

namespace BL.TaskDemo.Test
{
    [TestClass]
    public class TestTaskDemo
    {
        [TestMethod]
        public void DoSearch_DoesNotReturnEmpty_InAnyCase()
        {
            //Act
            var result = SUT.TaskDemo.DoSearch();
            var fileLines = result.Count;

            //Assert
            Assert.AreEqual(100000, fileLines);

        }
    }
}
