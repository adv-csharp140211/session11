using DAL;
using DomainModel;
using ViewModel;

namespace BL;
public class ProductService
{
    public void Create(ProductInput model)
    {

        /*
         *  Validate date
         *  business logic:
         *      Duplicate
         *      ...
         *  log
         */

        var repo = new ProductRepo(); //DI
        Product model1 = new Product
        {
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
        };


        //Map kardan model
        //https://github.com/riok/mapperly


        repo.Create(model1);
    }


    public List<ProductVM> GetList()
    {
        return new List<ProductVM>();
    }
}
