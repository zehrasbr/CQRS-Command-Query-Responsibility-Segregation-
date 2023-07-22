using CQRS_Casgem.CQRSPattern.Results;
using CQRS_Casgem.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CQRS_Casgem.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;
        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Brand = x.Brand,
                Category = x.Category,
                Name = x.Name,
                Price = x.Price,
                ProductID = x.ProductID,
                Stock = x.Stock
            }).ToList();
            return values;
        }
    }
}