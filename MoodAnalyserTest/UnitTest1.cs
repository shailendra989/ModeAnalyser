using MoodAnalyserDemo;

namespace MoodAnalyserTest
{
   
        public class UnitTest1
        {
            [TestMethod]
            public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
            {
                string message = null;
                object expected = new MoodAnalyser(message);
                //object expected1 = expected;
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser");
                expected.Equals(obj);
                Assert.AreEqual(expected, obj);

            }
            [TestMethod]
            public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
            {
                object expected = new MoodAnalyser("HAPPY");
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "SAD");
                expected.Equals(obj);
            }

            [TestMethod]
            public void GivenMoodHappy_ShouldReturnHappy()
            {
                MoodAnalyser obj = new MoodAnalyser("HAPPY");
                string result = obj.analyseMood();
                Assert.AreEqual("HAPPY", result);

            }

            [TestMethod]
            [ExpectedException(typeof(MoodAnalyserCustomException))]
            public void GivenMoodNull_ShouldThrowException()
            {
                MoodAnalyser obj = new MoodAnalyser(null);
                string result = obj.analyseMood();
                //Assert.AreEqual("HAPPY", result);

            }


            [TestMethod]
            public void GivenMoodHappy_ShouldReturnNull()
            {
                MoodAnalyser obj = new MoodAnalyser("null");
                string result = obj.analyseMood();
                Assert.AreEqual("HAPPY", result);

            }


        }

    
}