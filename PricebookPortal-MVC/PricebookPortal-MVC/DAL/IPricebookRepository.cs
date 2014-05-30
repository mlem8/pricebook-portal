using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PricebookPortal_MVC.Models;

namespace PricebookPortal_MVC.DAL
{
    public interface IPricebookRepository
    {
        IEnumerable<PricebookItem> GetPricebookItems();

        void InsertPricebookItem(PricebookItem item);

        void DeletePricebookItem(string itemId);

        void UpdatePricebookItem(PricebookItem item);
    }
}
