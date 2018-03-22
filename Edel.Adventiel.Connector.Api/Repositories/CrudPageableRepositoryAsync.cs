using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Autumn.Mvc.Models.Paginations;
using Autumn.Mvc.Models.Queries;
using Edel.Adventiel.Connector.Api.Models;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Api.Repositories
{
    public class CrudPageableRepositoryAsync<TDocument> : ICrudPageableRepositoryAsync<TDocument>
        where TDocument : AbstractElementModel
    {

        private readonly ParameterExpression _parameter;
        private readonly IMongoCollection<TDocument> _collection;
        private readonly FilterDefinitionBuilder<TDocument> _filterDefinitionBuilder;
     
        public CrudPageableRepositoryAsync(IMongoClient client)
        {
            _collection = client
                .GetDatabase("edle")
                .GetCollection<TDocument>(typeof(TDocument).Name.Replace("Model","").ToLowerInvariant());
            _parameter = Expression.Parameter(typeof(TDocument));
            _filterDefinitionBuilder = new FilterDefinitionBuilder<TDocument>();
        }

        #region FindOneAsync
        
        public async Task<TDocument> FindOneAsync(string id)
        {
            var filter = Expression.Lambda<Func<TDocument, bool>>(
                Expression.Equal(
                    Expression.Property(_parameter,"Id"),
                    Expression.Constant(id)
                )
                , _parameter
            );
            return await _collection
                .Find(filter)
                .SingleOrDefaultAsync();
        }

        #endregion
        
        #region FindAsync

        public async Task<IPage<TDocument>> FindAsync(Expression<Func<TDocument, bool>> filter = null,
            IPageable<TDocument> pageable = null)
        {
            var count = (int) await _collection.CountAsync(filter);
            if (count ==0 ) return new Page<TDocument>(new List<TDocument>(),pageable,0);
            var find = _collection.Find(filter);

            var offset = pageable?.PageNumber * pageable?.PageSize;
            var limit = pageable?.PageSize;
            find = find.Skip(offset).Limit(limit);
            if (pageable?.Sort?.OrderBy?.Count() > 0)
            {
                var isFirst = true;
                foreach (var item in pageable.Sort.OrderBy)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        find = find.SortBy(item);
                    }
                    else
                    {
                        find = ((IOrderedFindFluent<TDocument, TDocument>) find).ThenBy(item);
                    }
                }
            }
            if (pageable?.Sort?.OrderDescendingBy?.Count() > 0)
            {
                var isFirst = true;
                foreach (var item in pageable.Sort.OrderDescendingBy)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        find = find.SortByDescending(item);
                    }
                    else
                    {
                        find = ((IOrderedFindFluent<TDocument, TDocument>) find).ThenByDescending(item);
                    }
                }
            }
            var content = await find.ToListAsync();
            return new Page<TDocument>(content, pageable, count);
        }
        
        #endregion

        #region InsertAsync
        
        public async Task<TDocument> InsertAsync(TDocument document)
        {
            await _collection.InsertOneAsync(document);
            return document;
        }
        
        #endregion
        
        #region UpdateAsync

        public async Task<TDocument> UpdateAsync(TDocument document, string id)
        {
            var filter = Expression.Lambda<Func<TDocument, bool>>(
                Expression.Equal(
                    Expression.Property(_parameter, "Id"),
                    Expression.Constant(id)
                ),
                _parameter
            );
            var filterDefinition = _filterDefinitionBuilder.Where(filter);
            await _collection.ReplaceOneAsync(filterDefinition, document);
            return document;
        }
       
        #endregion
        
        #region DeleteAsync

        public async Task<TDocument> DeleteAsync(string id)
        {
            var filter = Expression.Lambda<Func<TDocument, bool>>(
                Expression.Equal(
                    Expression.Property(_parameter, "Id"),
                    Expression.Constant(id)
                )
                ,
                _parameter
            );
            var filterDefinition = _filterDefinitionBuilder.Where(filter);
            return await _collection.FindOneAndDeleteAsync(filterDefinition);
        }

        #endregion
        
        #region CountAsync

        public async Task<long> CountAsync(Expression<Func<TDocument, bool>> filter = null)
        {
            var filterDefinition = _filterDefinitionBuilder.Where(filter ?? QueryExpressionHelper.True<TDocument>());
            return await _collection.CountAsync(filterDefinition);
        }

        #endregion
        
    }
}