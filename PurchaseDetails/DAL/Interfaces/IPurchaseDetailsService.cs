using PurchaseDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseDetails.DAL.Interfaces
{
    public interface IPurchaseDetailsService
    {
        Task<List<purchasebilldetail>> GetPurchaseBillDetails(DateTime fromDate, DateTime toDate, bool isAgent, bool isFarmer); 
    }
}
