﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scraper.Models;

namespace Scraper.Services
{
    public interface ISnapshotService
    {
        Task<Snapshot[]> GetSnapshotsAsync();
    }
}
