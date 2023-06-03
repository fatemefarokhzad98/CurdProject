using CurdProject.Entity;

namespace CurdProject.DAL
{
    public class Repository
    {
        ProductContext repository=new ProductContext();
        public void Insert(Product product)
        {
            repository.Add(product);
            repository.SaveChanges();

        }
        public void Update(Product product)
        {
            var productedit = repository.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            productedit.Name = product.Name;
            productedit.Price = product.Price;
            productedit.Count=product.Count;
            repository.Products.Add(productedit);
            repository.SaveChanges();

        }
        public void Delete(int id)
        {
          var product=  repository.Products.Where(x => x.Id == id).FirstOrDefault();
            repository.Products.Remove(product);
            repository.SaveChanges();

        }
        public List<Product> Read()
        {
            var products = repository.Products.ToList();
            return products;


        }


    }
}
