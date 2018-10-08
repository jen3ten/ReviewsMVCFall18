using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewsFall18.Tests
{
    public class ReviewRepositoryTests
    {
        [Fact]
        public void GetAll_Should_Return_4_Castles()
        {
            var sut = new ReviewRepository();

            var result = sut.GetAll();

            Assert.Equal(4, result.Count);
        }

        [Fact]
        public void FindById_Returns_Correct_Castle()
        {
            var sut = new ReviewRepository();

            var result = sut.FindById(1);

            Assert.Equal(1, result.ID);
            Assert.Equal("Burg Eltz", result.Title);
        }
    }
}
