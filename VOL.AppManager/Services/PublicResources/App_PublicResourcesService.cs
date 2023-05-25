/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下App_PublicResourcesService与IApp_PublicResourcesService中编写
 */
using VOL.AppManager.IRepositories;
using VOL.AppManager.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.AppManager.Services
{
    public partial class App_PublicResourcesService : ServiceBase<App_PublicResources, IApp_PublicResourcesRepository>
    , IApp_PublicResourcesService, IDependency
    {
    public App_PublicResourcesService(IApp_PublicResourcesRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IApp_PublicResourcesService Instance
    {
      get { return AutofacContainerModule.GetService<IApp_PublicResourcesService>(); } }
    }
 }
