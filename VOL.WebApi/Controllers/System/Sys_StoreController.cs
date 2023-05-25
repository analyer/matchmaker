/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Sys_StoreController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.System.IServices;
namespace VOL.System.Controllers
{
    [Route("api/Sys_Store")]
    [PermissionTable(Name = "Sys_Store")]
    public partial class Sys_StoreController : ApiBaseController<ISys_StoreService>
    {
        public Sys_StoreController(ISys_StoreService service)
        : base(service)
        {
        }
    }
}

