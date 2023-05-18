﻿using Manero_Backend.Contexts;
using Manero_Backend.Models.Entities;
using Manero_Backend.Models.Interfaces.Repositories;

namespace Manero_Backend.Helpers.Repositories
{
    public class ProductColorRepository : BaseRepository<ProductColorEntity>, IProductColorRepository
    {
        private readonly ManeroDbContext _context;
        public ProductColorRepository(ManeroDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

       
    }
}
