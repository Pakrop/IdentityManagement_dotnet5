using IdentityManagement_dotnet5.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdentityManagement_dotnet5.Repos
{
    public class UserRepos : IRepos<User, int>
    {
        private readonly DataContext _dataContext;

        public UserRepos(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        //public async Task<IEnumerable<User>> GetAll()
        //{
        //    return await _dataContext.Users.ToListAsync();
        //}

        //public async Task<User> GetById(int id)
        //{
        //    return await _dataContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        //}
    }
}
