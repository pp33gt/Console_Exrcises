using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System.Collections.Generic;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        TestsInitializor testsInitializor = new TestsInitializor();

        private GradeStatistics InitializeTests()
        {
            var grades = new List<float>() { 22, 33 };
            return testsInitializor.Setup(grades);
        }

        [TestMethod]
        public void ComputeHasStatistics()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(true, statistics.HasStatistics);

        }
        [TestMethod]
        public void ComputeHighestGrade()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(33, statistics.High);
        }


        [TestMethod]
        public void ComputeLowestGrade()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(22, statistics.Low);
        }

        [TestMethod]
        public void ComputeTotalGrades()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(55, statistics.Total);
        }

        [TestMethod]
        public void ComputeAverageGrades()
        {
            var statistics = InitializeTests();
            float average = 27.5f;
            Assert.AreEqual(average, statistics.Average);
        }
    }
}
