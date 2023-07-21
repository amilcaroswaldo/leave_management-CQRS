﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leave_management.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync (int id);
        Task<T> CreateAsync (T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);        
    }
}
