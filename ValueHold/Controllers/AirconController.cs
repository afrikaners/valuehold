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
    public class AirconController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            var path = $"{Directory.GetCurrentDirectory()}/airconvalues.txt";
            try
            {
                return System.IO.File.ReadAllText(path);
            }
            catch
            {
                return "ERROR";
            }

        }

        [HttpPost]
        public async void On()
        {
            var path = $"{Directory.GetCurrentDirectory()}/airconvalues.txt";

            using (StreamWriter writer = System.IO.File.CreateText(path))
            {
                writer.Write("ON");
            }

        }

        [HttpPost]
        public async void Off()
        {
            var path = $"{Directory.GetCurrentDirectory()}/airconvalues.txt";

            using (StreamWriter writer = System.IO.File.CreateText(path))
            {
                writer.Write("OFF");
            }

        }
    }
}
