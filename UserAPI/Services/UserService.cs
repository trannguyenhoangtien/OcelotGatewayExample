﻿using UserAPI.Data;
using UserAPI.Models;

namespace UserAPI.Services
{
    public class UserService : IUserService
    {
        private readonly DbContextClass _dbContext;

        public UserService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public User AddUser(User user)
        {
            var result = _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteUser(int id)
        {
            var filteredData = _dbContext.Users.Where(x => x.UserId == id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.Where(x => x.UserId == id).FirstOrDefault();
        }

        public IEnumerable<User> GetUserList()
        {
            return _dbContext.Users.ToList();
        }

        public User UpdateUser(User user)
        {
            var result = _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return result.Entity;
        }
    }
}
