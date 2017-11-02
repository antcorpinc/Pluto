using Pluto.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Pluto.Models;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

// ToDO: Refactor some of the repository to move to common IRepository
namespace Pluto.Data.DataRepositories
{
    public class SocietyRepository : ISocietyRepository
    {
        private PlutoContext _context;

        public SocietyRepository(PlutoContext context)
        {
            _context = context;
        }
        public void Add(Society newEntity)
        {
            _context.Society.Add(newEntity);
            _context.SaveChanges();
            //ToDO: Need to add SAveChanges?? or use UOW
        }

        public IQueryable<Society> Find(Expression<Func<Society, bool>> predicate)
        {
          return  _context.Society.Where(predicate);

        }

        public Society Get(Guid id)
        {
            return _context.Society.Where(soc => soc.Id == id).FirstOrDefault();
        }

        public void Remove(Society entity)
        {
            _context.Society.Remove(entity);
            _context.SaveChanges();
        }

        public void Remove(Guid id)
        {
            var soc = Get(id);
            _context.Entry<Society>(soc).State = EntityState.Deleted;
            // ToDO:  Need to add SAveChanges?? or use UOW
            _context.SaveChanges();
        }
    }
}
