using Grpc.Core;
using System.Threading.Tasks;

namespace GrpcService.services{
public class ProductService : ServicesProduct.ServicesProductBase
    {
        public override Task<ProductReply> SendProduct(ProductRequest request, ServerCallContext context)
        {
            var product = new Product
            {
                Id = request.Id,
                Name = "Sample Product",
                Price = 29.99f
            };

            return Task.FromResult(new ProductReply { Product = product });
        }
    }
}
    


