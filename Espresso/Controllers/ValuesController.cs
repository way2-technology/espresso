using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Http;
using MiniBiggy;

namespace Espresso.Controllers {
    public class ValuesController : ApiController {
        
        public IEnumerable<string> Get() {
            return PersistentList.Create<Log>().Select(x => x.Text);
        }

        [Route("dados")]
        public void Post([FromBody]string value) {
            var log = new Log(value);
            var list = PersistentList.Create<Log>();
            list.AutoSave = true;
            list.Add(log);
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
