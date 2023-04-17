/*
Alican Ceylan
11.17.2016
Chapter 10-3 
Work with a two-dimensional (rectangular) array. Implement three methods. Display product information by index and by code. Display information for all products. Project contains the Main, ProductDB, and Product classes. 
*/

package murach.db;

import murach.business.Product;

public class ProductDB 
{
    private static String[][] productsArray = 
    	{
        {"java", "Murach's Java Programming", "57.50"},
        {"jsp", "Murach's Java Server Pages", "57.50"},
        {"mysql", "Murach's MySQL", "54.50"}
    };
    
    public static Product getProductByIndex(int i) 
    {
        // TODO: Add code here to return Product object
    	String[] row = productsArray [i];
    	Product p = getProductFromArray[row];
        return null;
    }
    
    public static Product getProductByCode(String code) 
    {
        // TODO: Add code here to return Product object
    	
        return null;
    }
    
    public static Product[] getAllProducts()
    {
        // TODO: Add code here to return array of Product objects
        return null;
    }    
}