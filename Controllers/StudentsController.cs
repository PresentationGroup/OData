
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;

namespace ODataAlternateKeySample.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private ODataAlternateKeySample.Models.DB.TestContext _ctx;
        public StudentsController(ODataAlternateKeySample.Models.DB.TestContext ctx)
        {
            _ctx = ctx;
        }

        //[HttpGet]
        //[EnableQuery()]
        //public IEnumerable<Student> Get()
        //{
        //    var tmp = new List<Student>
        //    {
        //        CreateNewStudent("Cody Allen", 130),
        //        CreateNewStudent("Todd Ostermeier", 160),
        //        CreateNewStudent("Viral Pandya", 140)
        //    };

        //    return tmp;
        //}

        [Microsoft.AspNetCore.OData.Routing.Attributes.ODataRouteComponent]
        [HttpGet("aa")]
        [EnableQuery()]
        public IEnumerable<Models.DB.Test> Get()
        {
            var tmp = _ctx.Tests.ToList();


            return tmp;
        }


        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Models.DB.Test> MostExpensive()
        {
            var tmp = _ctx.Tests.ToList();


            return tmp;
        }

        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Models.DB.Test> MostExpensive2(ODataActionParameters parameters)
        {
            var tmp = _ctx.Tests.ToList();


            return tmp;
        }

        [HttpGet("Rate")]
        public IEnumerable<Models.DB.Test> Rate([FromODataUri] int key, ODataActionParameters parameters)
        {
            var tmp = _ctx.Tests.ToList();


            return tmp;
        }

        [HttpGet]
        public IEnumerable<Models.DB.Test> Rate2(ODataActionParameters parameters)
        {
            var tmp = _ctx.Tests.ToList();


            return tmp;
        }

        //[HttpGet]
        //public IEnumerable<Models.DB.Test> MostExpensive4()
        //{
        //    var tmp = _ctx.Tests.ToList();


        //    return tmp; ;
        //}



        [HttpGet]
        [EnableQuery()]
    
        public IEnumerable<Models.DB.Test> MostExpensive3()
        {
            var tmp = _ctx.Tests.ToList();


            return tmp;
        }



        private static Student CreateNewStudent(string name, int score)
        {
            return new Student
            {
                Id = Guid.NewGuid(),
                Name = name,
                Score = score
            };
        }

        public class Student
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public int Score { get; set; }
        }


        public class Test
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

    }
}
