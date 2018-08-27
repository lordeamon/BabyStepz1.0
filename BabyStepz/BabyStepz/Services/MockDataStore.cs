using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabyStepz.Models;

namespace BabyStepz.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Tabbed Layout", Description="Framework done." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Transsions", Description="Next item." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Make Styling Easy", Description="Must have." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Firestore opkobling", Description="Must have."  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Integrate Sensors", Description="Nice to have" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Integrate API´s fb, twit, etc", Description="Nice to have" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}