﻿using Learn.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Entities.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category> 
    {
        void Update(Category category);
    }
}
