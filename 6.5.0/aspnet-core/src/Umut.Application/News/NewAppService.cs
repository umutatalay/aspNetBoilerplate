using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umut.News.Dto;

namespace Umut.News
{
    public class NewAppService: AsyncCrudAppService<New,NewDto,long,PagedNewResultRequestDto, CreateNewDto, NewDto>,INewAppService
    {
        public NewAppService(IRepository<New,long> repsitory) : base(repsitory)
        {

        }

    }
}
