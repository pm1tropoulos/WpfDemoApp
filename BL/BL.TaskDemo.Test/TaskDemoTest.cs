using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BL.TaskDemo.Test
{
    [TestClass]
    public class TaskDemoTest
    {
        [TestMethod]
        public void DoSearch_DoesNotReturnEmpty_InAnyCase()
        {
            //Act
            var result = TaskDemo.DoSearch();
            var fileLines = result.Result.Count;

            //Assert
            Assert.AreEqual(100000, fileLines);

        }
    }
}
