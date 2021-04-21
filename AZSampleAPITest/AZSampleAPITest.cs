using System;
using Xunit;
using AZSampleAPI;
using AZSampleAPI.Controllers;
namespace AZSampleAPITest
{
    public class AZSampleAPITest
    {
        [Fact]
        public void GetTest()
        {
            WeatherForecastController ctl = new WeatherForecastController();
            var result = ctl.Get();
            int resultCount = 0;
            foreach(var item in result)
            {
                resultCount++;
            }

            Assert.Equal<int>(5, resultCount);

        }
    }
}
