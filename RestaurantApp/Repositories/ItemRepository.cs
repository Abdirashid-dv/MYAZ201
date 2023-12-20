using Entities.Models;
using Repositories.Contracts;
using Repositories.Services;
using Repositories.Services.Exceptions;

namespace Repositories;

public class ItemRepository : IRepository<Items>
{
    private RepositoryDbContext dbContext;

    public ItemRepository(RepositoryDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Items GetOne(int id)
    {
        var item = dbContext.Items.SingleOrDefault(x => x.Id == id);

        if (item == null)
            throw new NotFoundException(id);
        return item;
    }

    public void Post(Items entity)
    {
        dbContext.Items.Add(entity);
        dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var item = GetOne(id);

        if (item == null)
            throw new NotFoundException(id);

        dbContext.Items.Remove(item);
        dbContext.SaveChanges();
    }

    public List<Items> GetAll()
    {
        return dbContext.Items.ToList();
    }

}