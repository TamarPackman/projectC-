using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class Product

{ 
   public   int _id { get; set; }
    public  string _nameProduct { get; set; }
    public CategoryName _category { get; set; }
    
    public  double _price { get; set; }
    public  int _quantityInStock { get;set; }
  public  List<SaleInProduct> _saleList { get;set; }


    public Product()
    {
        
    }

    public Product(int id,string nameProduct,CategoryName category,double price,int quantityInStock, List<SaleInProduct> saleList)
    {
        _id = id;
        _nameProduct = nameProduct;
            _category = category;
        _price = price;
        _quantityInStock = quantityInStock;
        _saleList = saleList;



    }
    public override string ToString() => Tools.ToStringProperty(this);



}