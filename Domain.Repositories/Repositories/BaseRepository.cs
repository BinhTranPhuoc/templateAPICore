using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository (AppDbContext context)
        {
            _context = context;
        }
    }
}
