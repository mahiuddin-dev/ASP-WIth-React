using Microsoft.AspNetCore.Mvc;
using RankingApp.Models;

namespace RankingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id = 1, Title = "The GodFather", ImageId = 1, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 2, Title = "Highlander", ImageId = 2, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 3, Title = "News", ImageId = 3, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 4, Title = "The New API", ImageId = 4, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 5, Title = "The Father", ImageId = 5, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 6, Title = "Haxi", ImageId = 6, Ranking = 0, ItemType = 1},
            new ItemModel{Id = 7, Title = "New Haven", ImageId = 7, Ranking = 0, ItemType = 1},
        };
        
        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            return items;
        }
    }
}
