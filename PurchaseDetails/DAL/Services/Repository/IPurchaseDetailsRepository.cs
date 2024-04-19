using PurchaseDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseDetails.DAL.Services.Repository
{
    internal interface IPurchaseDetailsRepository
    {
         Task<List<purchasebilldetail>> GetPurchaseBillDetails(DateTime fromDate, DateTime toDate, bool isAgent, bool isFarmer);

    }
}
