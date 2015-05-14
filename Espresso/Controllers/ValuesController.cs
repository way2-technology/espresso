using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;

namespace Espresso.Controllers {
    public class ValuesController : ApiController {
        
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        [Route("dados")]
        public void Post([FromBody]string value) {
            Debug.WriteLine("POST -> " + value);
        }
    }
}
