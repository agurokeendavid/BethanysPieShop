﻿using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new() { CategoryId = 1, CategoryName = "Fruit Pies", Description = "All-fruity pies" },
            new() {CategoryId = 2, CategoryName = "Cheese cakes", Description = "Cheesy all the way"},
            new() {CategoryId = 3, CategoryName = "Seasonal pies", Description = "Get in the mood for a seasonal pie"}
        };
    }
}
