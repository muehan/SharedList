using System.Collections.Generic;
using SharedList.Server.Web.Model;

namespace SharedList.Server.Web.ApplicationService.Abstract
{
    public interface IListRepository
    {
        IEnumerable<Item> GetItems();

        Item AddItem(string newItem);

        Item EditItem(Item changedItem);

        bool Delete(Item itemToDelete);
    }
}
