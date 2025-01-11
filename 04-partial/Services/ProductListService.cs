namespace _04_partial.Services {
    public class ProductListService {
        //tạo mới list product đi biến ko phải function 
        public List<Product> listProduct {set; get;} =  [
                new() { Name = "Iphone XIII", Description = "Điện thoại đời mới ...." , Price = 1000},
                new() { Name = "Samsung s23 ultra", Description = "Điện thoại đời mới ...." , Price = 2000},
                new() { Name = "Nokia xyz v2", Description = "Điện thoại đời mới ...." , Price = 3000}
            ];
        
    }
}