using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace shopingApi.Controllers
{
    [Route("api/test/async")]
    [ApiController]
    public class TaskAsyncController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> RunTasks()
        {
            // create a bunch of tasks
            for(int i = 1; i <= 10; i++)
            {
                
                Task.Run(() =>
                {
                    // should do something that takes time
                    var j = i;
                    string taskName = $"task {j}"; // make this super sting things for c#
                    //Thread.Sleep(10 * i);
                    Console.WriteLine($"task name={taskName}, is now complete");
                    return;
                });
            }
            // fired up these changes now should return something
            return "made everything";
        }
    }
}