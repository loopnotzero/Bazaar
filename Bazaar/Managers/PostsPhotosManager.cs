using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Bazaar.Common.Posts;
using Bazaar.Common.Stores;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Bazaar.Managers
{
    public class PostsPhotosManager<T> : IDisposable where T : IPostPhotos
    {      
        private bool _disposed;    
        
        private readonly ILogger _logger;      
        private ILookupNormalizer _keyNormalizer { get; set; }
        protected internal IPostsPhotosStore<T> _store { get; set; }

        protected virtual CancellationToken CancellationToken => CancellationToken.None;

        public PostsPhotosManager(IPostsPhotosStore<T> store, ILoggerFactory loggerFactory, ILookupNormalizer keyNormalizer)
        {
            _store = store ?? throw new ArgumentNullException(nameof(store));
            _logger = loggerFactory.CreateLogger<PostsPhotosManager<T>>();
            _keyNormalizer = keyNormalizer;
        }
     
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        public async Task CreatePostPhotosAsync(T entity)
        {
            ThrowIfDisposed();
            await _store.CreatePostPhotosAsync(entity, CancellationToken);
        }    

        private void Dispose(bool disposing)
        {
            if (!disposing || _disposed)
                return;

            _store.Dispose();

            _disposed = true;
        }
        
        private string NormalizeKey(string key)
        {
            return _keyNormalizer != null ? _keyNormalizer.Normalize(key) : key;
        }

        protected void ThrowIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }
    }
}