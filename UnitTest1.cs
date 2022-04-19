using System;
using Xunit;
using log4net;

namespace EnrichAutoTest
{
    public class UnitTest1
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UnitTest1));
        [Fact]
        void Test()
        {
            log.Debug("Start test");
            Assert.Equal(4, Add(2, 2));
            log.Debug("End test");
        }
        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
