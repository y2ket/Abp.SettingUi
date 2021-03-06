﻿using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Authorization;

namespace EasyAbp.Abp.SettingUi
{
    [DependsOn(
        typeof(SettingUiDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class SettingUiApplicationContractsModule : AbpModule
    {

    }
}
