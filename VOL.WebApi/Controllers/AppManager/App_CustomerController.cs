/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹App_CustomerController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.AppManager.IServices;
namespace VOL.AppManager.Controllers
{
    [Route("api/App_Customer")]
    [PermissionTable(Name = "App_Customer")]
    public partial class App_CustomerController : ApiBaseController<IApp_CustomerService>
    {
        public App_CustomerController(IApp_CustomerService service)
        : base(service)
        {
        }
    }
}

