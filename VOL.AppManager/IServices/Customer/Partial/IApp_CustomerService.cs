/*
*所有关于App_Customer类的业务代码接口应在此处编写
*/
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VOL.AppManager.IServices
{
    public partial interface IApp_CustomerService
    {
        Task<WebResponseContent> AddCustomer(CustomerInfo customerInfo);
    }
 }
