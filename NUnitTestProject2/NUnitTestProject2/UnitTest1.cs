using NUnit.Framework;
using MoodAnalyserOfPerson;
using System;
using System.Runtime.Serialization;

namespace MoodAnalyserNUnitTest
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser();
        }
        /// <summary>
        /// TC1.1 : Given message " I am in sad Mood " message in construator  should return SAD
        /// </summary>
        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSad()
        {
            moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", message);
        }
        /// <summary>
        /// TC1.2: Given message " I am in Happy Mood " message in constructor should return Happy
        /// </summary>

        [Test]
        public void GivenMessage_WhenHappy_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }
        public void Given_Message_WhenNull_Using_CustomException_Should_ReturnNullMood()
        {
            
            try
            {
                moodAnalyser= new MoodAnalyser(null);
                string message = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be null", exception.Message);
            }
        }


    }
}