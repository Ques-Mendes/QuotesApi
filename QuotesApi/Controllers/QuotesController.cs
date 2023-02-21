using QuotesApi.Data;
using QuotesApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotesApi.Controllers
{
    
    public class QuotesController : ApiController
    {
        QuoteDbContext quotesDbContext = new QuoteDbContext();

        // GET: api/Quotes
        public IEnumerable<Quote> Get()
        {
            return quotesDbContext.Quotes;
        }

        // GET: api/Quotes/5
        public Quote Get(int id)
        {
           return quotesDbContext.Quotes.Find(id);
        }

        // POST: api/Quotes
        public void Post([FromBody]Quote quote)
        {
            quotesDbContext.Quotes.Add(quote);
            quotesDbContext.SaveChanges();
        }

        // PUT: api/Quotes/5
        public void Put(int id, [FromBody]Quote quote)
        {
           var entity = quotesDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            quotesDbContext.SaveChangesAsync();
        }

        // DELETE: api/Quotes/5
        public void Delete(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            quotesDbContext.Quotes.Remove(quote);
            quotesDbContext.SaveChangesAsync();
        }
    }
}
