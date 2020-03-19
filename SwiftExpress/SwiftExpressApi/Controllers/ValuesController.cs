using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwiftExpressApi.Controllers
{
    public class ValuesController : ApiController
    {
        //1.改东西了，先提交，再拉取，最后推送
        //2.没改东西，先拉取，再修改，再提交，最后推送
        // GET api/values
        public IEnumerable<string> Get()
        {
            //修改了这个获取接口
            //刘青
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
