using PurchaseDetails.DAL.Interfaces;
using PurchaseDetails.DAL.Services.Repository;
using PurchaseDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


    namespace PurchaseDetailsService.DAL.Services
    {
        public class PurchaseDetailsService : IPurchaseDetailsService
        {
            private readonly IPurchaseDetailsRepository _repository;

             PurchaseDetailsService(IPurchaseDetailsRepository repository)
            {
                _repository = repository;
            }

            public Task<List<purchasebilldetail>> GetPurchaseBillDetails(DateTime fromDate, DateTime toDate, bool isAgent, bool isFarmer)
        {
            throw new NotImplementedException();
        }
    }
}

   