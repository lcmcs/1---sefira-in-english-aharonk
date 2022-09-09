using EnglishSefirah;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWeekCalc()
        {
            Sefirah.GetWeeks(1).Should().Be(0);
            Sefirah.GetWeeks(7).Should().Be(1);
            Sefirah.GetWeeks(17).Should().Be(2);
        }

        [TestMethod]
        public void TestDays()
        {
            Sefirah.GetEnglishSefira(3).Should().Contain("three");
            Sefirah.GetEnglishSefira(9).Should().Contain("nine").And
                .Contain("one week").And
                .Contain("two days");
            Sefirah.GetEnglishSefira(19).Should().Contain("nineteen").And
                .Contain("two weeks").And
                .Contain("five days");
            Sefirah.GetEnglishSefira(20).Should().Contain("twenty").And
                .Contain("two weeks").And
                .Contain("six days");
            Sefirah.GetEnglishSefira(39).Should().Contain("thirty-nine").And
                .Contain("five weeks").And
                .Contain("four days");
        }

        [TestMethod]
        public void TestEarlyDay()
        {
            Sefirah.GetEnglishSefira(2).Should()
                .NotContain("week").And
                .NotContain("which").And
                .NotContain("and").And
                .NotContain("0").And
                .NotContain(",");
        }

        [TestMethod]
        public void TestExactWeek()
        {
            Sefirah.GetEnglishSefira(49).Should()
                .Contain("week").And
                .NotContain("and");
        }

        [TestMethod]
        public void TestExactOne()
        {
            Sefirah.GetEnglishSefira(8).Should()
                .Contain("week").And
                .NotContain("weeks");

            Sefirah.GetEnglishSefira(1).Should()
                .Contain("day").And
                .NotContain("days");

            Sefirah.GetEnglishSefira(22).Should()
                .Contain("two days").And
                .Contain("one day").And
                .NotContain("one days");
        }
    }
}