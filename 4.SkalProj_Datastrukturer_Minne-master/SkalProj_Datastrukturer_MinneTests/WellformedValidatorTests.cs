using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkalProj_Datastrukturer_Minne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne.Tests
{
    [TestClass()]
    public class WellformedValidatorTests
    {
        [TestMethod()]
        [Owner("PeterB")]
        public void IsWellFormedParentesisesTest1_IsWellFormed_ShouldBeOk1()
        {
            // Arrange
            var wellformedValidator = new WellformedValidator();

            // Act
            var actual = wellformedValidator.IsWellFormedParentesises("List<int>​ ​lista​ ​=​ ​new​ ​List<int>(){2,​ ​3,​ ​4};");

            //Assert
            Assert.AreEqual<bool>(true, actual);
        }

        [TestMethod()]
        [Owner("PeterB")]
        public void IsWellFormedParentesisesTest1_IsWellFormed_ShouldBeOk2()
        {
            // Arrange
            var wellformedValidator = new WellformedValidator();

            // Act
            var actual = wellformedValidator.IsWellFormedParentesises("List<int>​ ​lista​ ​=​ ​new​ ​List<int>(()){2,​ ​3,​ ​4};");

            //Assert
            Assert.AreEqual<bool>(true, actual);
        }

        [TestMethod()]
        [Owner("PeterB")]
        public void IsWellFormedParentesisesTest1_IsWellFormed_ShouldBeOk3()
        {
            // Arrange
            var wellformedValidator = new WellformedValidator();

            // Act
            var actual = wellformedValidator.IsWellFormedParentesises("()()()()");

            //Assert
            Assert.AreEqual<bool>(true, actual);
        }

        [TestMethod()]
        [Owner("PeterB")]
        public void IsWellFormedParentesisesTest1_IsWellFormed_ShouldBeOk4()
        {
            // Arrange
            var wellformedValidator = new WellformedValidator();

            // Act
            var actual = wellformedValidator.IsWellFormedParentesises("([{}]({}))​");

            //Assert
            Assert.AreEqual<bool>(true, actual);
        }

        [TestMethod()]
        [Owner("PeterB")]
        public void IsWellFormedParentesisesTest1_IsWellFormed_ShouldNotBeOk1()
        {
            // Arrange
            var wellformedValidator = new WellformedValidator();

            // Act
            var actual = wellformedValidator.IsWellFormedParentesises("List<int>​ ​lista​ ​=​ ​new​ ​List<int>)(){2,​ ​3,​ ​4};");

            //Assert
            Assert.AreEqual<bool>(false, actual);
        }

        [TestMethod()]
        [Owner("PeterB")]
        public void IsWellFormedParentesisesTest1_IsWellFormed_ShouldNotBeOk2()
        {
            // Arrange
            var wellformedValidator = new WellformedValidator();

            // Act
            var actual = wellformedValidator.IsWellFormedParentesises("List<int>​ ​lista​ ​=​ ​new​ ​List<int>(()({2,​ ​3,​ ​4};");

            //Assert
            Assert.AreEqual<bool>(false, actual);
        }

        [TestMethod()]
        [Owner("PeterB")]
        public void IsWellFormedParentesisesTest1_IsWellFormed_ShouldNotBeOk3()
        {
            // Arrange
            var wellformedValidator = new WellformedValidator();

            // Act
            var actual = wellformedValidator.IsWellFormedParentesises("()()()()(");

            //Assert
            Assert.AreEqual<bool>(false, actual);
        }

        [TestMethod()]
        [Owner("PeterB")]
        public void IsWellFormedParentesisesTest1_IsWellFormed_ShouldNotBeOk4()
        {
            // Arrange
            var wellformedValidator = new WellformedValidator();

            // Act
            var actual = wellformedValidator.IsWellFormedParentesises("({)}");

            //Assert
            Assert.AreEqual<bool>(false, actual);
        }

    }
}