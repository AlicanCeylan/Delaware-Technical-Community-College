package murach.rectangle;

import java.text.NumberFormat;

public class Rectangle 
{
  //the instance variables
	private double length;
	private double width;
	private double area; 
	private double perimeter;
	
	//the constructor
    public Rectangle()
    {
    	length = 0.0;
    	width = 0.0;
    	area = 0.0;
    	perimeter = 0.0;
    }
	
  //the set and get methods for the length variable
    public void setLength(double length)
    {
        this.length = length;
    }

    public double getLength() 
    {
       return length;
    } 
    
  //the set and get methods for the width variable
    public void setWidth(double width)
    {
        this.width = width;
    }

    public double getWidth() 
    {
    	return width;
    } 
	
    //method for triangle area
    public double getArea()
    {
    	area = width * length;
    	return area;
    }
	
   //method for perimeter
    public double getPerimeter()
    {
		perimeter = 2*width + 2*length;
    	return area;
    }
    
    //custom get method for the area
    public String getAreaNumberFormatted() 
    {
        NumberFormat number = NumberFormat.getNumberInstance();
        number.setMaximumFractionDigits(3);
        String areaFormatted = number.format(area);
        return areaFormatted;
    }   
    
    public String getPerimeternumberFormatter()
    {
        NumberFormat number = NumberFormat.getNumberInstance();
        number.setMaximumFractionDigits(3);
        String areaFormatted = number.format(perimeter);
        return areaFormatted;
    } 
    
}
