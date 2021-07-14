using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyse moodAnalyse=new MoodAnalyse();
        /// <summary>
        /// TC 1.1
        /// </summary>
        [TestMethod]
        public void GivenMessageReturnSad()
        {
            ///AAA MEthodology
            //Arrange
            string expected = "sad";
            //Act
            string actual = moodAnalyse.AnalyseMood("I am in sad mood");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 1.2
        /// </summary>
        [TestMethod]
        public void GivenMessageReturnHappy()
        {
            ///AAA MEthodology
            //Arrange
            string expected = "happy";
            //Act
            string actual = moodAnalyse.AnalyseMood("I am in any mood");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
