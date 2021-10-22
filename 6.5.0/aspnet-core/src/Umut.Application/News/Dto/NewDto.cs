using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umut.News.Dto
{
    [AutoMap(typeof(New))]
    public class NewDto : EntityDto<long>
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string InNewImage { get; set; }
    }
}
