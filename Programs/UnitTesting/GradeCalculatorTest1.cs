using UniTesting;

namespace StudentGrade.nUnitTests
{
    public class GradeCalculatorTest1
    {
        private GradeCalculator  _gradeCalculator { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _gradeCalculator =new GradeCalculator();
        }

        [TestCase(99,"A")]
        [TestCase(70,"C")]
        [TestCase(60,"D")]
        public void GetGradePercentage_Test(int x, string y)
        {
            //Assign 
            //var per = 99;
            //Act
            var grade = _gradeCalculator.GetGradePercentage(x);
            // Assert

            Assert.AreEqual(y,grade);
        }
    }
}