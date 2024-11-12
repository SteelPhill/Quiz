using Quiz.Databases;
using Quiz.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Database;

public class UserDB : IUserDB
{
    public List<User> Users { get; }

    public UserDB(List<User> users)
    {
        Users = users;
    }

    public void Add(User user)
    {
        if (Users.Any(u => u.Login == user.Login))
            throw new Exception("Пользователь с таким логином уже существует!");

        Users.Add(user);
    }

    public void Remove(User user)
    {
        if (!Users.Any(u => u.Login == user.Login))
            throw new Exception("Пользователя с таким логином не существует!");

        Users.Remove(user);
    }

    public User GetUser(string login, string password)
    {
        var user = Users.Find(u => u.Login == login && u.Password == password);

        if (user != default(User))
            return user;

        throw new Exception("Неверный логин или пароль!");
    }
}