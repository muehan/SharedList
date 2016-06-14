using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using SharedList.Server.Web.Model;

namespace SharedList.Server.Web.ApplicationService.Concrete
{
    public class PersistanceDataAccess
    {
        public List<Item> LoadAllItems()
        {
            return DeserializeList();
        }

        public Item AddNewItem(string text)
        {
            var list = DeserializeList();
            var newItem = new Item();
            newItem.Text = text;
            newItem.ItemId = list.OrderByDescending(x => x.ItemId).FirstOrDefault().ItemId++;

            list.Add(newItem);
            SerializeList(list);

            return newItem;
        }

        public Item ChangeItem(Item changedItem)
        {
            var list = DeserializeList();
            var oldItem = list.Single(x => x.ItemId == changedItem.ItemId);

            oldItem.Checked = changedItem.Checked;
            oldItem.Text = changedItem.Text;

            SerializeList(list);

            return changedItem;
        }

        public void Delete(Item itemToDelete)
        {
            var list = DeserializeList();
            list.Remove(itemToDelete);

            SerializeList(list);
        }

        private void SerializeList(List<Item> items)
        {
            string json = JsonConvert.SerializeObject(items);
            File.WriteAllText("list.json", json);
        }

        private List<Item> DeserializeList()
        {
            string json = File.ReadAllText("list.json");
            return (List<Item>)JsonConvert.DeserializeObject<List<Item>>(json);
        }
    }
}
