using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MonefyStats.Bussines.Models;
using MonefyStats.Bussines.Registration;
using MonefyStats.Repository.Models;
using NUnit.Framework;

namespace MonefyStats.UnitTest
{
    [TestFixture]
    public class AutomapperProfilesTest
    {
        [Test]
        public void BussinesAutoMapperTest_Validation()
        {
            //Arrange
            var profile = new BussinesAutoMapperProfile();
            var config = new MapperConfiguration(cfg => cfg.AddProfile(profile));

            //Act&Assert
            config.AssertConfigurationIsValid();
        }
    }
}
