﻿using WebFormsMvp;
using ZobShop.Services.Contracts;

namespace ZobShop.ModelViewPresenter.Product.Create
{
    public class CreateProductPresenter : Presenter<ICreateProductView>
    {
        private readonly IProductService service;

        public CreateProductPresenter(ICreateProductView view, IProductService service) : base(view)
        {
            this.service = service;
            this.View.MyCreateProduct += OnCreateProduct;
        }

        public void OnCreateProduct(object sender, CreateProductEventArgs e)
        {
            // TODO: add buffer and image type to product
            var product = this.service.CreateProduct(e.Name, e.CategoryName, e.Quantity, e.Price, e.Volume, e.Maker, e.ImageMimeType, e.ImageBuffer);
            this.View.Model.Id = product.ProductId;
        }
    }
}
