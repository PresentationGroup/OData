
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;

namespace ODataAlternateKeySample.Controllers
{
    [ApiController]
    public class TestsController : Controller
    {
        private ODataAlternateKeySample.Models.DB.TestContext _ctx;
        public TestsController(ODataAlternateKeySample.Models.DB.TestContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet()]
        [EnableQuery()]
        public IEnumerable<Models.DB.Test> Get()
        {
            var tmp = _ctx.Tests.ToList();


            return tmp;
        }


        [HttpGet]
        [EnableQuery()]
      //  [Microsoft.AspNetCore.OData.Routing.Attributes.ODataAttributeRouting()]
        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataRouteComponent("MostExpensive3")]
        public IEnumerable<Models.DB.Test> MostExpensive3()
        {
            var tmp = _ctx.Tests.ToList();


            return tmp;
        }


    }
}
