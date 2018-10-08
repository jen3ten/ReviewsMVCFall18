using ReviewsFall18.Controllers;
using ReviewsFall18.Models;
using System;
using Xunit;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;

namespace ReviewsFall18.Tests
{
    public class HomeControllerTests
    {
        IReviewRepository reviewRepo;
        HomeController sut;

        public HomeControllerTests()
        {
            reviewRepo = Substitute.For<IReviewRepository>();
            sut = new HomeController(reviewRepo);
        }

        [Fact]
        public void Index_Action_Should_Return_a_View()
        {
            //var sut = new HomeController();

            var result = sut.Index();

            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void Index_Gets_All_Reviews()
        {
            sut.Index();

            reviewRepo.Received().GetAll();
        }

        [Fact]
        public void Index_Sets_AllReviews_As_Model()
        {
            var expectedModel = new List<Review>();
            reviewRepo.GetAll().Returns(expectedModel);

            var result = sut.Index();

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Returns_a_View()
        {
            var result = sut.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Sets_Review_to_Model()
        {
            var expectedModel = new Review();
            reviewRepo.FindById(1).Returns(expectedModel);

            var result = sut.Details(1);

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }
    }
}
