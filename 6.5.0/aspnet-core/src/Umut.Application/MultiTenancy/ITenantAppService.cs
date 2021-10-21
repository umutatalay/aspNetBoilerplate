using Abp.Application.Services;
using Umut.MultiTenancy.Dto;

namespace Umut.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

