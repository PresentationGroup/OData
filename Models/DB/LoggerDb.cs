using System;
using System.Collections.Generic;

namespace ODataAlternateKeySample.Models.DB
{
    public partial class LoggerDb
    {
        public Guid? Id { get; set; }
        public long? Tid { get; set; }
        public string UserName { get; set; }
        public int? LogLeven { get; set; }
        public string Message { get; set; }
        public string RawRequest { get; set; }
        public string RawResponse { get; set; }
        public string RawException { get; set; }
        public string Detail { get; set; }
        public DateTime? EventDate { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
