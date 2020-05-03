using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplicationObjectDumper.Dto;

namespace WebApplicationObjectDumper.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var dto = new TestDto
            {
                Success = true,
                Status = TestDto.TestDtoStatus.Ok,
                Person = new Entity.Person { Name = "試作", Age = 30 },
                Exception = new NotSupportedException("テスト")
            };
            _logger.LogInformation(ObjectDumper.Dump(dto, DumpStyle.CSharp));

            var dto2 = new TestDto
            {
            };
            _logger.LogInformation(ObjectDumper.Dump(dto2, DumpStyle.CSharp));
        }
    }
}
