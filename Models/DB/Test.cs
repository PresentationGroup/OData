using System;
using System.Collections.Generic;

namespace ODataAlternateKeySample.Models.DB
{
    public partial class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
    }
}
