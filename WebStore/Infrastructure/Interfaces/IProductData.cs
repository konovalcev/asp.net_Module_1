using System.Collections.Generic;
using WebStore.Domain.Entities;

public interface IProductData
{
    /// <summary>
    /// Список секций
    /// </summary>
    /// <returns>The sections.</returns>
    IEnumerable<Section> GetSections();

    /// <summary>
    /// Список брендов
    /// </summary>
    /// <returns>The brands.</returns>
    IEnumerable<Brand> GetBrands();

    /// <summary>
    /// Список товаров
    /// </summary>
    /// <returns>The products.</returns>
    IEnumerable<Product> GetProducts(ProductFilter filter);
}