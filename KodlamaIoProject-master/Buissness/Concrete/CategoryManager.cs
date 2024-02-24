using Buissness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buissness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ILogger _logger;
        public CategoryManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add(Category category)
        {
            Console.WriteLine("Kategoriya elave olundu: "+category.CategoryName);
            _logger.Log(category.CategoryName);
        }

        public void Delete(Category category)
        {
            Console.WriteLine("Kategoriya silindi: " + category.CategoryName);
        }

        public void Get(Category category)
        {
            Console.WriteLine("Kategoriya getirildi: " + category.CategoryName);
        }

        public void Update(Category category)
        {
            Console.WriteLine("Kategoriya guncellendi: " + category.CategoryName);
        }
    }
}
