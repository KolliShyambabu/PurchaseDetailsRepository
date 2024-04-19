using PurchaseDetails.DAL.Interfaces;
using PurchaseDetails.Models;
using System;
using System.Linq;
using System.Web.Http;
using System.Threading.Tasks;



namespace PurchaseDetails.Controllers
{
    public class PurchaseDetailsController : ApiController
    {
        private readonly IPurchaseDetailsService _service;

       public PurchaseDetailsController(IPurchaseDetailsService service)
       {
            _service = service;
       }

  
        [HttpGet]
        [Route("api/PurchaseDetails/GetPurchaseBillDetails")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetPurchaseBillDetails(DateTime fromDate, DateTime toDate, bool isAgent, bool isFarmer)
        {
            var PurchaseDetails = await _service.GetPurchaseBillDetails(fromDate, toDate, isAgent, isFarmer);

            var result = PurchaseDetails
           .Where(bill => bill.BillDate >= fromDate && bill.BillDate <= toDate && bill.IsAgent == isAgent && bill.IsFarmer == isFarmer)
           .Select(bill => new
           {
               SlNo = bill.BillId,
               BillDate = bill.BillDate,
               BillNo = bill.BillNo,
               FarmerName = isFarmer ? farmerdetail.FarmerName : farmerdetail.FarmerContact,
               AgentName = isAgent ? bill.agentdetail.AgentName : bill.agentdetail.AgentContact,
               Quantity = bill.Quantity,
               BillAmount = bill.Amount
           }).ToList();

            return  Ok (result);
        

            
        }
    }
}