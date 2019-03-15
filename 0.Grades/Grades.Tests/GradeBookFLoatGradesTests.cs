using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System.Collections.Generic;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookFLoatGradesTests
    {
        TestsInitializor testsInitializor = new TestsInitializor();

        private GradeStatistics InitializeTests()
        {
            var grades = new List<float>() { 91, 89.5f, 75 };
            return testsInitializor.Setup(grades);
        }

        [TestMethod]
        public void ComputeHasStatistics()
        {
            var statistics = InitializeTests();
            Assert.AreEqual(true, statistics.HasStatistics);
        }

        [TestMethod]
        public void ComputeAverageGrades()
        {
            var statistics = InitializeTests();
            float res;
            var resConsole = 85.16666f;
            var resCalculator = 85.16666666666667f;
            //res = resConsole;
            res = resCalculator;

            Assert.AreEqual(res, statistics.Average, 0.01);
        }
    }
}
