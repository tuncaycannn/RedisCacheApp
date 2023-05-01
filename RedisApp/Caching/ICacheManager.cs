﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        object Get(string key, Type type);
        void Add(string key, object data, int duration, Type type);
        void Add(string key, object data, int duration);
        void Add(string key, object data, Type type);
        void Add(string key, object data);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
