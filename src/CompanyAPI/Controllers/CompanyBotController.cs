// API Controller for a Chat Bot Interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Company.Models;
using Company.Data;

namespace Company.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyBotController : ControllerBase
    {
        private readonly ILogger<CompanyBotController> _logger;
        private readonly CompanyDBContext _context;

        public CompanyBotController(ILogger<CompanyBotController> logger, CompanyDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetStore")]
        public ActionResult<Store> GetStore(int id)
        {
            Store store = _context.Stores.Find(id);
            if (store == null)
            {
                return NotFound();
            }
            return store;
        }

        [HttpGet(Name = "GetProduct")]
        public ActionResult<Product> GetProduct(int id)
        {
            Product product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpGet(Name = "GetStockEntry")]
        public ActionResult<StockEntry> GetStockEntry(int id)
        {
            StockEntry stockEntry = _context.StockEntries.Find(id);
            if (stockEntry == null)
            {
                return NotFound();
            }
            return stockEntry;
        }

        [HttpGet(Name = "GetStockEntries")]
        public ActionResult<IEnumerable<StockEntry>> GetStockEntries(int storeId)
        {
            IEnumerable<StockEntry> stockEntries = _context.StockEntries.Where(s => s.StoreId == storeId);
            if (stockEntries == null)
            {
                return NotFound();
            }
            return stockEntries.ToList();
        }

        [HttpGet(Name = "GetStockEntriesForProduct")]
        public ActionResult<IEnumerable<StockEntry>> GetStockEntriesForProduct(int storeId, int productId)
        {
            IEnumerable<StockEntry> stockEntries = _context.StockEntries.Where(s => s.StoreId == storeId && s.ProductId == productId);
            if (stockEntries == null)
            {
                return NotFound();
            }
            return stockEntries.ToList();
        }

        [HttpGet(Name = "GetStockEntriesForProductInAllStores")]
        public ActionResult<IEnumerable<StockEntry>> GetStockEntriesForProductInAllStores(int productId)
        {
            IEnumerable<StockEntry> stockEntries = _context.StockEntries.Where(s => s.ProductId == productId);
            if (stockEntries == null)
            {
                return NotFound();
            }
            return stockEntries.ToList();
        }

    }
}