using PurchaseDetails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseDetails.DAL.Services.Repository
{


    public class PurchaseDetailsRepository : IPurchaseDetailsRepository
    {
        private readonly ProjectContext _dbContext;
        public PurchaseDetailsRepository(ProjectContext dbContext)
        {
            _dbContext = dbContext;
        }
       
        Task<List<purchasebilldetail>> IPurchaseDetailsRepository.GetPurchaseBillDetails(DateTime fromDate, DateTime toDate, bool isAgent, bool isFarmer)
        {
            throw new NotImplementedException();
            
        }
    }
 }
    
