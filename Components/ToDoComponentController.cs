using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace BlazorTest.Components
{
    public class ToDoComponentController : ComponentBase
    {
        [Parameter] public string Tag { get; set; }

        public IList<string> Items;
        public string ItemInput = "Cats";

        public ToDoComponentController()
        {
            Items = new List<string>{"one", "two","three"};
        }

        public IList<string> GetItems()
        {
            return Items;
        }

        public void UpdateList()
        {
            Items.Add(ItemInput);
        }

        public void UpdateList(string item)
        {
            Items.Add(item);
        }
    }
}
