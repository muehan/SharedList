using System;
using System.Collections.Generic;
using SharedList.Server.Web.ApplicationService.Abstract;
using SharedList.Server.Web.Model;

namespace SharedList.Server.Web.ApplicationService.Concrete
{
    public class ListRepository : IListRepository
    {
        private readonly PersistanceDataAccess persistanceDataAccess;

        public ListRepository()
        {
            persistanceDataAccess = new PersistanceDataAccess();
        }

        public IEnumerable<Item> GetItems()
        {
            var items = persistanceDataAccess.LoadAllItems();

            return items;
        }

        public Item AddItem(string newItem)
        {
            var itemCreated = persistanceDataAccess.AddNewItem(newItem);

            return itemCreated;
        }

        public Item EditItem(Item changedItem)
        {
            var savedItem = persistanceDataAccess.ChangeItem(changedItem);

            return savedItem;
        }

        public bool Delete(Item itemToDelete)
        {
            try
            {
                persistanceDataAccess.Delete(itemToDelete);
            }
            catch (Exception e)
            {
                return false;
            }
            
            return true;
        }
    }
}
