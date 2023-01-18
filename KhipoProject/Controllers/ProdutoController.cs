using KhipoProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace KhipoProject.Controllers
{
    public class ProdutoController : ApiController
    {

        

        public IEnumerable<Produto> Get()
        {
            using (var context = new KhipoEntities())
            {
                var produtos = context.Database.SqlQuery<Produto>("exec GetAllProduto").ToList();
                return produtos;
            }
        }


        public Produto Get(int id)
        {
            using (var context = new KhipoEntities())
            {
                var produto = context.Produto.SqlQuery("exec GetProdutoById @p0", id).FirstOrDefault();
                return produto;
            }
        }


        public void Post([FromBody] Produto value)
        {
            using (var context = new KhipoEntities())
            {
                value.CreatedAt = DateTime.Now;
                context.Produto.Add(value);
                context.SaveChanges();
            }
        }


        public void Put([FromBody] Produto value)
        {
            using (var context = new KhipoEntities())
            {
                var product = context.Produto.Find(value.Id);
                if (product != null)
                {
                    product.Name = value.Name;
                    product.Brand = value.Brand;
                    product.Price = value.Price;
                    product.UpdatedAt = DateTime.Now;
                    context.SaveChanges();
                }
            }
        }


        public void Delete(int id)
        {
            using (var context = new KhipoEntities())
            {
                var product = context.Produto.Find(id);
                if (product != null)
                {
                    context.Produto.Remove(product);
                    context.SaveChanges();
                }

            }
        }
    }
}