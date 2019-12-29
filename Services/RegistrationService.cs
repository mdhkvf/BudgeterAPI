﻿using AuthAPI.Database;
using AuthAPI.Payloads;
using AuthAPI.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Services
{
    public class RegistrationService : IRegistrationService
    {
        private IPasswordHasher _passwordHasher;
        private UserContext _database;


        public RegistrationService()
        {
            HashingOptions opts = new HashingOptions();
            opts.Iterations = 1;

            IOptions<HashingOptions> test = Options.Create<HashingOptions>(opts);
            _passwordHasher = new PasswordHasher(test);

            _database = new UserContext();
        }

        public DataTransfer.User CheckMatch(string username, string password)
        {
            foreach (DataTransfer.User userCheck in _database.GetUsers())
            {
                if (username == userCheck.UserName || username == userCheck.EmailAddress)
                {
                    var (verified, needsUpgrade) = _passwordHasher.Check(userCheck.Password, password);
                    if (verified)
                    {
                        return userCheck;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            return null;
        }

        public DataTransfer.User Register(RegistrationPost registrationData)
        {
            string passwordHash = _passwordHasher.Hash(registrationData.Password);

            DataTransfer.User user = new DataTransfer.User()
            {
                FirstName = registrationData.FirstName,
                LastName = registrationData.LastName,
                EmailAddress = registrationData.EmailAddress,
                UserName = registrationData.UserName,
                Password = passwordHash
            };

            foreach(DataTransfer.User userCheck in _database.GetUsers())
            {
                if (userCheck.EmailAddress == user.EmailAddress || userCheck.UserName == user.UserName)
                {
                    //Already have user with email or username
                    return null;
                }
            }

            _database.AddUser(user);
            return user;
        }
    }
}
