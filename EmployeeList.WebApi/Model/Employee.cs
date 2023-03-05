namespace EmployeeList.WebApi.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string? CategoryName { get; set; }
        public string? UnitName { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? ParentCode { get; set; }
        public string? ProductBarcode { get; set; }
        public string? Description { get; set; }
        public string? BrandName { get; set; }
        public string? SizeName { get; set; }
        public string? ColorName { get; set; }
        public string? ModelName { get; set; }
        public string? VariantName { get; set; }
        public int OldPrice { get; set; }
        public int Price { get; set; }
        public int CostPrice { get; set; }
        public string? WarehouseList { get; set; }
        public int stock { get; set; }
        public int TotalPurchase { get; set; }
        public DateTime LastPurchaseDate { get; set; }
        public string? LastPurchaseSupplier { get; set; }
        public int TotalSales { get; set; }
        public DateTime LastSalesDate { get; set; }
        public string? LastSalesCustomer { get; set; }
        public string? ImagePath { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
    }
}
