using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using System.Linq;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerDAO CustomerDAO;


        public CustomersController(ICustomerDAO CustomerDAO)
        {
            this.CustomerDAO = CustomerDAO;
        }

        public ActionResult CustomerSearch(CustomerSearchModel model)
        {
            IList<Customer> customers = CustomerDAO.SearchForCustomers(model.LastName, model.SearchOrder);
            return View(customers.FirstOrDefault());
        }

        public ActionResult CustomerSearchResult(CustomerSearchModel customer)
        {
            return View();
        }
       
    }
   
}
