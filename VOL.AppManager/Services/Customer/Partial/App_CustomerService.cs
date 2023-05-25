/*
 *所有关于App_Customer类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*App_CustomerService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.AppManager.IRepositories;
using System.Threading.Tasks;
using System;
using VOL.Core.Services;
using VOL.Core.Enums;

namespace VOL.AppManager.Services
{
    public partial class App_CustomerService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IApp_CustomerRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public App_CustomerService(
            IApp_CustomerRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }
        WebResponseContent webResponse = new WebResponseContent();

        /// <summary>
        /// 添加客户信息
        /// </summary>
        /// <param name="customerInfo"></param>
        /// <returns></returns>
        public async Task<WebResponseContent> AddCustomer(CustomerInfo customerInfo)
        {
            string error = "";
            try
            {
                App_Customer customer = new App_Customer() 
                {
                    Id= Guid.NewGuid(),
                };
                repository.Add(customer, true);
                webResponse.OK("添加客户信息成功");
            }
            catch (Exception ex)
            {
                error = ex.Message + ex.StackTrace + ex.Source;
                webResponse.Error("token替换出错了..");
            }
            finally
            {
                Logger.Info("添加用户信息完成");
            }
            return webResponse;
        }
    }
}
