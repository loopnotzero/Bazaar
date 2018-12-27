using System;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Egghead.MongoDbStorage.Stores
{
    public interface IAdvertisementCommentsVotesAggregationStore<T, A> : IDisposable where T : class where A : class
    {
        Task<A> CountAdvertisementCommentVotesByCommentIdAsync(ObjectId commentId, CancellationToken cancellationToken);
    }
}