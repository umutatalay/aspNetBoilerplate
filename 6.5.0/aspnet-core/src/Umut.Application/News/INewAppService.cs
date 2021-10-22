using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umut.News.Dto;

namespace Umut.News
{
    public interface INewAppService : IAsyncCrudAppService<NewDto, long, PagedNewResultRequestDto, CreateNewDto, NewDto>
    {

    }
}
