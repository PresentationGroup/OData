using System;
using System.Collections.Generic;

namespace ODataAlternateKeySample.Models.DB
{
    public partial class LogTable
    {
        public string LogFilename { get; set; }
        public int? LogRow { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        public string CIp { get; set; }
        public string CsUsername { get; set; }
        public string SSitename { get; set; }
        public string SComputername { get; set; }
        public string SIp { get; set; }
        public int? SPort { get; set; }
        public string CsMethod { get; set; }
        public string CsUriStem { get; set; }
        public string CsUriQuery { get; set; }
        public int? ScStatus { get; set; }
        public int? ScSubstatus { get; set; }
        public int? ScWin32Status { get; set; }
        public int? ScBytes { get; set; }
        public int? CsBytes { get; set; }
        public int? TimeTaken { get; set; }
        public string CsVersion { get; set; }
        public string CsHost { get; set; }
        public string CsUserAgent { get; set; }
        public string CsCookie { get; set; }
        public string CsReferer { get; set; }
        public string SEvent { get; set; }
        public string SProcessType { get; set; }
        public float? SUserTime { get; set; }
        public float? SKernelTime { get; set; }
        public int? SPageFaults { get; set; }
        public int? STotalProcs { get; set; }
        public int? SActiveProcs { get; set; }
        public int? SStoppedProcs { get; set; }
    }
}
