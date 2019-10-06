﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KworkPracticeTask.MultiTenancy.Dto;

namespace KworkPracticeTask.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

