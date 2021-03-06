﻿using System.Collections.Generic;

namespace CachingFramework.Redis.Contracts.RedisObjects
{
    /// <summary>
    /// Managed dictionary using a Redis Hash
    /// </summary>
    public interface IRedisDictionary<TK, TV> : IRedisDictionaryAsync<TK, TV>, IDictionary<TK, TV>, IRedisObject
    {
        /// <summary>
        /// Adds a single element to the dictionary related to the given tag(s).
        /// </summary>
        /// <param name="key">The redis key.</param>
        /// <param name="value">The value.</param>
        /// <param name="tags">The tags to relate.</param>
        void Add(TK key, TV value, string[] tags);
        /// <summary>
        /// Adds multiple elements to the dictionary.
        /// </summary>
        /// <param name="collection">The collection.</param>
        void AddRange(IEnumerable<KeyValuePair<TK, TV>> collection);
        /// <summary>
        /// Returns the number of elements in the hash.
        /// </summary>
        new long Count { get; }
    }
}
