using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PricebookPortal_MVC.Models;

namespace PricebookPortal_MVC.DAL
{
    public class PricebookRepository : IPricebookRepository
    {
        public IEnumerable<PricebookItem> GetPricebookItems()
        {
            throw new NotImplementedException();
        }

        public void InsertPricebookItem(PricebookItem item)
        {
            throw new NotImplementedException();
        }

        public void DeletePricebookItem(string itemId)
        {
            throw new NotImplementedException();
        }

        public void UpdatePricebookItem(PricebookItem item)
        {
            throw new NotImplementedException();
        }
    }
}