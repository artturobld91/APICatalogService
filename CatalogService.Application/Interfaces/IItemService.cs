using CatalogService.Application.Dtos;
using CatalogService.Domain.Models;

namespace CatalogService.Application.Interfaces
{
    public interface IItemService
    {
        public IEnumerable<Item> GetItems();

        public IEnumerable<Item> GetItemsPagination(PaginationDto paginationDto);

        public IEnumerable<Item> GetItemsByCategoryId(int id);

        public Item GetItem(int id);

        public void AddItem(Item item);

        public void DeleteItem(int id);

        public void UpdateItem(ItemUpdateDto item);
    }
}
