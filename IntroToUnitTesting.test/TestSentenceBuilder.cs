using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntroToUnitTesting.test
{
    [TestClass]
    public class TestSentenceBuilder
    {
        [TestMethod]
        public void TestInstantiatingBuilder()
        {
            //Arrange
            var builder = new SentenceBuilder();

            //Assert
            Assert.IsNotNull(builder);

        }
     
        [TestMethod]
        public void TestItGivesBackAString()
        {
            //Arrange
            var builder = new SentenceBuilder();
            string[] words = new string[] {"this" , "is", "a", "test"};

            //Act
           string output =  builder.BuildSentence(words);

            //Assert
            Assert.IsInstanceOfType(output, typeof(string));
        }
        [TestMethod]
        public void TestBuildingASentence1()
        {
            //Arrange
            var builder = new SentenceBuilder();
            string[] words = new string[] { "This", "is", "a", "test" };

            //Act
            var output = builder.BuildSentence(words);

            //Assert
            string expectedOutput = "This is a test.";
            Assert.AreEqual(expectedOutput, output);
           
        }
        [TestMethod]
        public void TestBuildingASentence2()
        {
            //Arrange
            var builder = new SentenceBuilder();
            string[] words = new string[] { "hello", "world", "from", "Moab" };

            //Act
            var output = builder.BuildSentence(words);

            //Assert
            string expectedOutput = "Hello world from Moab.";
            Assert.AreEqual(expectedOutput, output);

        }      
    }
}
