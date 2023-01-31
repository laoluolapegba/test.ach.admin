﻿using Volo.Abp.AuditLogging;
using Volo.Abp.Domain;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;

namespace IntelliPort.AdminService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AdminServiceDomainSharedModule)
)]
[DependsOn(typeof(AbpAuditLoggingDomainModule))]
[DependsOn(typeof(AbpFeatureManagementDomainModule))]
[DependsOn(typeof(AbpPermissionManagementDomainModule))]
[DependsOn(typeof(AbpSettingManagementDomainModule))]
public class AdminServiceDomainModule : AbpModule
{

}