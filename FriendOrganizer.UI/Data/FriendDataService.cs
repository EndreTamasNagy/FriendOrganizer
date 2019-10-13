using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;
        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<List<Friend>> GetAllAsync()
        {
            
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
            } 
            //// TODO: Load data from real database
            //yield return new Friend { FirstName = "Endre", LastName = "Nagy" };
            //yield return new Friend { FirstName = "Csilla", LastName = "Böcskei" };
            //yield return new Friend { FirstName = "Zsófia", LastName = "Simándi" };
            //yield return new Friend { FirstName = "Szabolcs", LastName = "Orbán" };
        }
    }
}
