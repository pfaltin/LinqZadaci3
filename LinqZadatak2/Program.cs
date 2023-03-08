using LinqZadatak2;

Console.WriteLine("LinqZadatak2!");


IList<Product> _productList = new List<Product>()
                {
                            new Product { productID = 1001, productCategory = "Electronics", productName = "Speakers", productCost = 2880 },
                            new Product { productID = 1002, productCategory = "Electronics", productName = "Graphics-Card", productCost = 3000 },
                            new Product { productID = 1003, productCategory = "Electronics", productName = "KeyBoard", productCost = 1540 },
                            new Product { productID = 1004, productCategory = "Electronics", productName = "Pendrive", productCost = 475 },
                            new Product { productID = 1009, productCategory = "Stationery", productName = "A4 Sheet Bunddle", productCost = 100 },
                            new Product { productID = 1010, productCategory = "Stationery", productName = "Pencil Box", productCost = 52 },
                            new Product { productID = 1011, productCategory = "Stationery", productName = "Ink-Bottle", productCost = 45 },
                            new Product { productID = 1012, productCategory = "Stationery", productName = "NoteBooks", productCost = 75 }
                };

Console.WriteLine("---------------------------------------------------------------");

foreach (Product _product in _productList)
{
    Console.WriteLine(" product id {0} , naziv {2} kategorija {1} , cijena {3} eura", _product.productID, _product.productCategory, _product.productName, _product.productCost);
}

Console.WriteLine("---------------------------------------------------------------");
IEnumerable<Product> _chosenProducts = _productList
                                                    .Where(e => e.productName.Contains('-'))
                                                   .Select(e => e);
foreach (Product _product in _chosenProducts)
{
    Console.WriteLine("artikl sa crticom {0}", _product.productName);
}

Console.WriteLine("---------------------------------------------------------------");

IEnumerable<Product> productsModuo = _productList
                                                    .Where(e => e.productCost%2 == 0)
                                                   .Select(e => e);
foreach (Product _product in productsModuo)
{
    Console.WriteLine("artikl djeljiv sa 2  {0}", _product.productName);
}

Console.WriteLine("---------------------------------------------------------------");