using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using SharedList.Server.Web.Model;

namespace SharedList.Server.Web.ApplicationService.Concrete
{
    public class PersistanceDataAccess
    {
        public IEnumerable<Item> LoadAllItems()
        {
            throw new System.NotImplementedException();
        }

        public Item AddNewItem(Item newItem)
        {
            throw new System.NotImplementedException();
        }

        public Item ChangeItem(Item changedItem)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Item itemToDelete)
        {
            throw new System.NotImplementedException();
        }

        private void SerializeList(IEnumerable<Item> items)
        {
            string json = JsonConvert.SerializeObject(items);
            
        }

        private IEnumerable<Item> DeserializeList(string json)
        {
            return (IEnumerable<Item>) JsonConvert.DeserializeObject<IEnumerable<Item>>(json);
        } 
    }
}
