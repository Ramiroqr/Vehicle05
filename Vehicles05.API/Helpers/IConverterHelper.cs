using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles05.API.Data.Entities;
using Vehicles05.API.Models;

namespace Vehicles05.API.Helpers
{
    public interface IConverterHelper
    {
        Task<User> ToUserAsync(UserViewModel model, Guid imageId, bool isNew);

        UserViewModel ToUserViewModel(User user);
    }
}
