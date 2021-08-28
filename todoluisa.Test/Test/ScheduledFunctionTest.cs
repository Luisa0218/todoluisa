using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using todoluisa.Functions.Functions;
using todoluisa.Test.Helpers;
using Xunit;

namespace todoluisa.Test.Test
{
     public class ScheduledFunctionTest
    {

        
        [Fact]
            public void ScheduledFunction_Should_log_Message()
           {

            //Arrange
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1/devstoreaccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);

            //Act 
            ScheduledFunction.Run(null, mockTodos, logger);
            string message = logger.Logs[0];

            //Assert

            Assert.Contains("Deleting Completed", message);

        }
    }
    
}
