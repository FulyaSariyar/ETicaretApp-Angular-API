using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repositories
{
    public interface IRepository<T>  where T : BaseEntity  //T tipinin bir class olduğunu garanti et!
    {
        DbSet<T> Table { get; }
    }
}
