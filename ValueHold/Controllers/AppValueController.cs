using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace ValueHold.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppValueController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            var path = $"{Directory.GetCurrentDirectory()}/value.txt";
            return System.IO.File.ReadAllText(path);
        }

        [HttpPost]
        public async void Post(string value)
        {
            var path = $"{Directory.GetCurrentDirectory()}/value.txt";

            using (StreamWriter writer = System.IO.File.CreateText(path))
            {
                writer.Write(value);
            }

        }
    }
}
