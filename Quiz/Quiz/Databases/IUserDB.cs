using Quiz.Entities;
using System.Collections.Generic;

namespace Quiz.Databases;

public interface IUserDB
{
    List<User> Users { get; }

    void Add(User user);
    void Remove(User user);
    User GetUser(string login, string password);
}