using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Espresso.Controllers {
    public class ValuesController : ApiController {
        
        public IEnumerable<string> Get() {
            return File.ReadAllLines(HttpContext.Current.Server.MapPath("~/") + "coffee.txt");
        }

        [Route("dados")]
        public void Post([FromBody]string value) {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "coffee.txt", value + Environment.NewLine);
        }
    }

    public class Log {
        public string Text { get; set; }

        public Log(string text) {
            Text = text;
        }

        public Log() {
        }
    }
}
