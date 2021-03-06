﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scraper.Services;
using Scraper.Models;

namespace Scraper.Controllers
{
    public class StockDisplayController : Controller
    {
        private readonly IStockItemService _stockItemService;

        public StockDisplayController(IStockItemService stockItemService)
        {
            _stockItemService = stockItemService;
        }
        public async Task<IActionResult> Index(Guid snapshotId)
        {
            var stocks = await _stockItemService.GetSnapshotStocksAsync(snapshotId);

            var model = new StockViewModel()
            {
                Stocks = stocks
            };

            return View(model);
        }
    }
}