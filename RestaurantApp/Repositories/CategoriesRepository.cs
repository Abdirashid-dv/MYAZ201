using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public class CategoriesRepository : IRepository<Categories>
{
    private List<Categories> _categories;

    public CategoriesRepository(List<Categories> categories)
    {
        _categories = categories;
    }

    public Categories GetOne(int id)
    {
        var category = _categories.SingleOrDefault(x => x.Id == id);

        if (category == null)
        {
            throw new Exception("Category not found");
        }
        return category;
    }

    public void Post(Categories entity)
    {
        _categories.Add(entity);
    }

    public void Delete(int id)
    {
        var category = GetOne(id);

        _categories.Remove(category);
    }
}
