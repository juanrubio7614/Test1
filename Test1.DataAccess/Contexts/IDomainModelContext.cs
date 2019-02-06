using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test1.Library.DataEntities;

namespace Test1.DataAccess.Contexts
{
  public interface IDomainModelContext:IDisposable
    {
        DbSet<Country> Countries { get; set; }
        int SaveChanges();
        void SetEntityState(object value, EntityState entityState);
        EntityState GetEntityState(object value);
        void SetEntityPropertyModified(object user, string propertyName);
    }
}
