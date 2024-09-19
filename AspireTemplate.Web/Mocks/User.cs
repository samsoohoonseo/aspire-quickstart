using AspireTemplate.Web.Models;

namespace AspireTemplate.Web.Mocks
{
    public static class MockUsers
    {
        public static List<User> Users = new List<User>
        {
            new User()
            {
                UserId = 1, Name="User A", Title="Title A", Date = DateTime.Now
            },
            new User()
            {
                UserId = 2, Name="User B", Title="Title B", Date = DateTime.Now
            },
            new User()
            {
                UserId = 3, Name="User C", Title="Title C", Date = DateTime.Now
            },
            new User()
            {
                UserId = 4, Name="User D", Title="Title D", Date = DateTime.Now
            },
            new User()
            {
                UserId = 5, Name="User E", Title="Title E", Date = DateTime.Now
            },
            new User()
            {
                UserId = 6, Name="User F", Title="Title F", Date = DateTime.Now
            },
        };
    }
}
