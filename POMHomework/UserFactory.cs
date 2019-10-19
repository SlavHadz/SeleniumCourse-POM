using System;
using System.Collections.Generic;
using System.Text;

namespace POMHomework
{
    public static class UserFactory
    {
        public static User CreateValidUser()
        {
            return new User
            {
                FirstName = "John",
                LastName = "Doe",
                Year = "1993",
                Month = "4",
                Date = "1",
                Password = "tainoobi4amazis",
                Address = "26 Jump street",
                Gender = "male",
                PostCode = "4324422",
                City = "New York",
                State = "Alabama",
                Phone = "0888888888"
            };
        }
    }
}
