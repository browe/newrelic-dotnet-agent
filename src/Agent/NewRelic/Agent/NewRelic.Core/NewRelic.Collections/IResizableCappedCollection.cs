﻿using System;
using System.Collections.Generic;

namespace NewRelic.Collections
{
    public interface IResizableCappedCollection<T> : ICollection<T>
    {
        /// <summary>The maximum number of items the collection can contain.</summary>
        UInt32 Size { get; }
        /// <summary>Changes the number of items the collection can contain.</summary>
        /// <param name="newSize">The new maximum numer of items the collection can contain. CONTRACT: newSize < Int32.Max</param>
        void Resize(UInt32 newSize);

        // Represents the count of items that has been attempted to be added to the capped collection.
        UInt64 GetAddAttemptsCount();
    }
}