using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System.Collections.Generic;

namespace Grades.Tests
{
    

    [TestClass]
    public class GradeBookNoGradesTests
    {
        TestsInitializor testsInitializor = new TestsInitializor();
        private GradeStatistics InitializeTests()
        {
            var grades = new List<float>();
            return testsInitializor.Setup(grades);
        }

        [TestMethod]
        public void ComputeHasStatistics()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(false, statistics.HasStatistics);

        }
        [TestMethod]
        public void ComputeHighestGrade()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(0, statistics.High);
        }


        [TestMethod]
        public void ComputeLowestGrade()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(0, statistics.Low);
        }

        [TestMethod]
        public void ComputeTotalGrades()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(0, statistics.Total);
        }

        [TestMethod]
        public void ComputeAverageGrades()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(0, statistics.Average);
        }
    }
}
