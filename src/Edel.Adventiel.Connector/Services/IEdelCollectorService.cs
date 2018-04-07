﻿using System.Threading.Tasks;

namespace Edel.Adventiel.Connector.Services
{
    public interface IEdelCollectorService
    {
        Task<string> CollectAsync(int size = 10, string collectorAt = "admin");
    }
}