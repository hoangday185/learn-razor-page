using _04_partial;
using _04_partial.Services;
using Microsoft.AspNetCore.Mvc;

namespace _04_partial {
//    [ViewComponent]
    public class ProductBox(ProductListService _productListService) : ViewComponent {
        /*
            public string (IViewComponentResult) Invoke(object m)
            //invokeAsync

            3 cách khai báo 1 class là view component 
            1. cho thêm [ViewComponent] trước class từ Microsoft.AspNetCore.Mvc
            2. kế thừa từ ViewComponent
            3. thêm hậu tố ViewComponent cho class đó
        */
        // public string Invoke(){
        //     return "ProductBox";
        // }

        readonly ProductListService productListService = _productListService;

        public IViewComponentResult Invoke(bool isSortIncrease = true){
            

            List<Product> _product = null;

            if(isSortIncrease){
                _product = productListService.listProduct.OrderBy(p => p.Price).ToList();
            }else{
                _product = productListService.listProduct.OrderByDescending(p => p.Price).ToList();
            }
            return View<List<Product>>(_product);
        }
    }
}