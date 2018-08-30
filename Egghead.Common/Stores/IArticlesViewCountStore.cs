﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Egghead.Common.Articles;
using MongoDB.Bson;

namespace Egghead.Common.Stores
{
    //todo: Move this interface to Common
    public interface IArticlesViewCountStore<in T> : IDisposable where T : class
    {
        Task<long> CountArticleViewsCountByArticleIdAsync(ObjectId articleId, CancellationToken cancellationToken);
        Task<OperationResult> CreateArticleViewsCountAsync(T entity , CancellationToken cancellationToken);
        Task<IEnumerable<ObjectId>> GetPopularArticlesByViewsCount(int limit, CancellationToken cancellationToken);
    }
}