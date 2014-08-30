using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

//Create a database holding users and groups. 
//Create a transactional EF based method that creates an user and puts it in a group "Admins". 
//In case the group "Admins" do not exist, create the group in the same transaction. 
//If some of the operations fail (e.g. the username already exist), cancel the entire transaction.

namespace _11.SocialGroups
{
    class Program
    {
        public static void AddUser(string userName)
        {
            SocialGroupsEntities entities = new SocialGroupsEntities();

            using (entities)
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (entities.Groups.Count(g => g.GroupName == "AdminGroup") == 0)
                    {
                        Group adminGroup = new Group()
                        {
                            GroupName = "AdminGroup"
                        };

                        entities.Groups.Add(adminGroup);
                        Console.WriteLine("New group added!");
                        scope.Complete();
                    }
                    else
                    {
                        Group adminGroup = entities.Groups.Where(x => x.GroupName == "AdminGroup").First();

                        if (entities.Users.Count(u => u.UserName == userName) >= 0)
                        {
                            Console.WriteLine("User already exist!");
                            scope.Dispose();
                        }
                        User user = new User()
                        {
                            UserName = userName,
                            GroupID = adminGroup.GroupID
                        };

                        adminGroup.Users.Add(user);
                        scope.Complete();
                        Console.WriteLine("User added in admin group!");
                    }
                }
            }
        }

        static void Main()
        {

            AddUser("Pesho izroda!");
        }
    }
}
