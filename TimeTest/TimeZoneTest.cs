using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UnitTest_Exercise.BusinessLogicLayer;
using UnitTest_Exercise.Controllers;
using UnitTest_Exercise.DataAccessLayer.Repository;
using UnitTest_Exercise.DataAccessLayer.Repository.Interrfaces;

namespace TimeTest
{
    [TestClass]
    public class TimeZoneTest
    {
        private readonly TimeZoneController _controller;
        private readonly ITimeRepository _timeRepository;

        public TimeZoneTest()
        {
            _timeRepository = new TimeRepository();
            _controller = new TimeZoneController(_timeRepository);
        }

        [TestMethod]
        public void GetConvertTimeZoneOk()
        {
            InputTimeZoneModel inData =new InputTimeZoneModel
            {
                SourceTimeZone = "SA Western Standard Time",
                Datatime = new DateTime(2023,01,04,22,0,0),
                DestinationTimeZone = "E. South America Standard Time"
            };


            var result = _controller.getConvertTimeZone(inData);
            Assert.IsInstanceOfType(result,typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetConvertTimeZoneBadRequest()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "TestUnit",
                Datatime = new DateTime(1, 1, 1, 1, 0, 0),
                DestinationTimeZone = "TestUnit"
            };


            var result = _controller.getConvertTimeZone(inData);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }
   
        // Get Origin Daylight Saving Time
        [TestMethod]
        public void getOriginisDaylightSavingTimeOk()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "SA Western Standard Time",
                Datatime = new DateTime(2023, 01, 04, 22, 0, 0),
                DestinationTimeZone = "E. South America Standard Time"
            };


            var result = _controller.getOriginisDaylightSavingTime(inData);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void getOriginisDaylightSavingTimeBadRequest()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "TestUnit",
                Datatime = new DateTime(1, 1, 1, 0, 0, 0),
                DestinationTimeZone = "TestUnit"
            };


            var result = _controller.getConvertTimeZone(inData);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }


        //Get Destination Daylight Saving Time
        [TestMethod]
        public void getDestinationDaylightSavingTimeOk()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "SA Western Standard Time",
                Datatime = new DateTime(2023, 01, 04, 22, 0, 0),
                DestinationTimeZone = "E. South America Standard Time"
            };


            var result = _controller.getDestinationDaylightSavingTime(inData);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void getDestinationDaylightSavingTimeBadRequest()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "TestUnit",
                Datatime = new DateTime(2023, 01, 04, 22, 0, 0),
                DestinationTimeZone = "TestUnit"
            };


            var result = _controller.getDestinationDaylightSavingTime(inData);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }

        //get Diference Time
        [TestMethod]
        public void getDiferenceTimeOk()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "SA Western Standard Time",
                Datatime = new DateTime(2023, 01, 04, 22, 0, 0),
                DestinationTimeZone = "E. South America Standard Time"
            };


            var result = _controller.getDiferenceTime(inData);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
        [TestMethod]
        public void getDiferenceTimeBadRequest()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "SA Western Standard Time",
                Datatime = new DateTime(2023, 01, 04, 22, 0, 0),
                DestinationTimeZone = "E. South America Standard Time"
            };


            var result = _controller.getDiferenceTime(inData);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }



        //Get Diferent Format Date
        [TestMethod]
        public void getDiferentFormatDateOk()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "SA Western Standard Time",
                Datatime = new DateTime(2023, 01, 04, 22, 0, 0),
                DestinationTimeZone = "E. South America Standard Time"
            };


            var result = _controller.getDiferentFormatDate(inData);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void getDiferentFormatDateBadRequest()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "TestUnit",
                Datatime = new DateTime(1, 1, 1, 0, 0, 0),
                DestinationTimeZone = "TestUnit"
            };


            var result = _controller.getDiferentFormatDate(inData);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }

        //Get Diferent Format Time
        [TestMethod]
        public void getDiferentFormatTimeOk()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "SA Western Standard Time",
                Datatime = new DateTime(2023, 01, 04, 22, 0, 0),
                DestinationTimeZone = "E. South America Standard Time"
            };


            var result = _controller.getDiferentFormatTime(inData);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void getDiferentFormatTimeBadRequest()
        {
            InputTimeZoneModel inData = new InputTimeZoneModel
            {
                SourceTimeZone = "TestUnit",
                Datatime = new DateTime(1, 1, 1, 0, 0, 0),
                DestinationTimeZone = "TestUnit"
            };


            var result = _controller.getDiferentFormatTime(inData);
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }
       
    }
}