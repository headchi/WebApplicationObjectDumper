using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationObjectDumper.Entity;

namespace WebApplicationObjectDumper.Dto
{
    public class TestDto : TestDtoBase
    {
        public TestDtoStatus Status { get; set; } = TestDtoStatus.Unknown;

        public Exception Exception { get; set; }

        public Person Person { get; set; }

        public enum TestDtoStatus
        {
            Unknown,
            Ok,
            Ng,
        }
    }
}
