using System.Security.Cryptography;
using Entities.Models;
using Repositories.Contracts;
using Repositories.Services;
using Repositories.Services.Exceptions;

namespace Repositories;

public class UserRepository : IRepository<User>
{
    private RepositoryDbContext _dbContext;

    public UserRepository(RepositoryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public User GetOne(int id)
    {
        var user = _dbContext.Users.SingleOrDefault(user => user.Id == id);
        if (user == null)
            throw new NotFoundException(id);
        return user;
    }

    public void Post(User entity)
    {
        if (entity == null)
            return;
        // generate salt
        entity.Salt = RandomNumberGenerator.GetInt32(10000);
        // encode password
        entity.Password = entity.Password.Encoder(entity.Salt);

        _dbContext.Users.Add(entity);
        _dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var user = GetOne(id);

        if (user == null)
            throw new BadRequestException();

        _dbContext.Users.Remove(user);
        _dbContext.SaveChanges();
    }

    public User GetData(string email, string password)
    {
        var user = _dbContext.Users.SingleOrDefault(user => user.Email == email);

        if (user is null)
            throw new BadRequestException("Email is wrong");

        // Verify password
        var hashedPassword = password.Encoder(user.Salt);

        if (user.Password.Equals(hashedPassword))
            return user;
        throw new UserBadRequestException(email, password);
    }


}