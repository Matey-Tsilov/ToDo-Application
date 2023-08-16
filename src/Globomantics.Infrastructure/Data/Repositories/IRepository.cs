﻿namespace Globomantics.Infrastructure.Data.Repositories
{
    public interface IRepository<T>
    {
        Task<T> GetAsync(Guid id);
        Task<T> GetByAsync(string value);
        Task<IEnumerable<T>> AllAsync(Guid id);
        Task AddAsync(T item);
        Task SaveChangesAsync();

    }
}