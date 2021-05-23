using System.Collections.Generic;

namespace LinqMethods
{
    public class ShopingData
    {
        public IEnumerable<Customer> GetCustomerDetails()
        {
            return new List<Customer>
            {
                new Customer{CustomerId = 1, Name = "A"},
                new Customer{CustomerId = 2, Name = "B"},
                new Customer{CustomerId = 3, Name = "C"},
                new Customer{CustomerId = 4, Name = "D"},
                new Customer{CustomerId = 5, Name = "E"}
            };
        }

        public IEnumerable<Address> GetAddressDetails()
        {
            return new List<Address>
            {
                new Address(){ CustomerId = 1, AddressId = 1, State = "India", Socity = "A_Socity"},
                new Address(){ CustomerId = 2, AddressId = 2, State = "India", Socity = "B_Socity"},
                new Address(){ CustomerId = 3, AddressId = 3, State = "India", Socity = "C_Socity"},
                new Address(){ CustomerId = 4, AddressId = 4, State = "India", Socity = "D_Socity"},
                new Address(){ CustomerId = 5, AddressId = 5, State = "India", Socity = "E_Socity"}
            };
        }

        public IEnumerable<Cart> GetCartDetails()
        {
            return new List<Cart>
            {
                new Cart() { CartId = 1, CustomerId = 1, ProductName = "Redmi 9 note pro", Quantity = 10 },
                new Cart() { CartId = 2, CustomerId = 2, ProductName = "Apple 12", Quantity = 103 },
                new Cart() { CartId = 3, CustomerId = 1, ProductName = "Oppo 360", Quantity = 103 },
                new Cart() { CartId = 4, CustomerId = 1, ProductName = "Vivo", Quantity = 10 },
                new Cart() { CartId = 5, CustomerId = 3, ProductName = "Apple Smart Watch", Quantity = 10 },
                new Cart() { CartId = 6, CustomerId = 1, ProductName = "Google Pixel", Quantity = 1000 },
                new Cart() { CartId = 7, CustomerId = 5, ProductName = "Jio", Quantity = 10 },
                new Cart() { CartId = 8, CustomerId = 1, ProductName = "Hp laptop", Quantity = 1 },
                new Cart() { CartId = 9, CustomerId = 2, ProductName = "Dell laptop", Quantity = 10 },
                new Cart() { CartId = 10, CustomerId = 1, ProductName = "Lenova laptop", Quantity = 10 },
            };
        }
    }
}
