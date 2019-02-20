using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TherapyAPI.Entities;

namespace TherapyAPI.Repository {
    public class Repository<T> : IRepository<T> where T : class {
        protected RepositoryContext repositoryContext { get; set; }
        public Repository (RepositoryContext RepositoryContext) {
            this.repositoryContext = RepositoryContext;
        }
        public async Task<IEnumerable<T>> GetAllAsync () {
            return await this.repositoryContext.Set<T> ().ToListAsync ();
        }

        public async Task<T> GetById (Guid Id) {
            return await this.repositoryContext.Set<T> ().FindAsync (Id);
        }
        public void Create (T entity) {
            this.repositoryContext.Set<T> ().Add (entity);
            this.repositoryContext.SaveChangesAsync();
        }

        public void Delete (Guid Id) {
            T entity = this.repositoryContext.Set<T> ().Find (Id);
            this.repositoryContext.Set<T> ().Remove (entity);
            this.repositoryContext.SaveChangesAsync();
        }

        public void Update (T entity) {
            this.repositoryContext.Set<T> ().Update (entity);
            this.repositoryContext.SaveChangesAsync();
        }
    }
}