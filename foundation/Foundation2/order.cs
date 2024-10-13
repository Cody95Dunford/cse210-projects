using System;

public class Order{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    
    public Order(List<Product> productList, Customer customer){
        _productList = productList;
        _customer = customer;
    }

    public float TotalPrice(){
        float total = 0;
        foreach (Product product in _productList){
            total += product.GetTotalCost();
        }
        if (_customer.IsUSA()){
            total += 5;
        }
        else{
            total += 35;
        }
        return total;
    }

    public string PackingLabel(){
        string label = "";
        foreach (Product product in _productList){
            label += product.GetLabel() + "/n";
        }
        return label;
    }

    public string ShippingList(){
        return _customer.GetLabel();
    }
}