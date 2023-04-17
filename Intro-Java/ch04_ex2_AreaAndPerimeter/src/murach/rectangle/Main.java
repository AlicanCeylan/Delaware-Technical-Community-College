/* 
Alican Ceylan
09.22.2016
Chapter 4-2 
Create and use an object, overload the constructor, and test the application. Project contains the Main and Rectangle classes. 
*/

package murach.rectangle;

import java.util.Scanner;

public class Main 
{

    public static void main(String args[]) 
    {
        System.out.println("Welcome to the Area and Perimeter Calculator");
        System.out.println();

        Scanner keyboard = new Scanner(System.in);
        String choice = "y";
        while (choice.equalsIgnoreCase("y")) 
        {
            
        	//Rectangle object
        	Rectangle r = new Rectangle();
        	
        	// get input from user
            
                      
            //  display output
            String message = 
                "Area:         " + rectangle.getArea() + "\n" +
                "Perimeter:    " + rectangle.getPerimeter() + "\n";
            System.out.println(message);

            // see if the user wants to continue
            System.out.print("Continue? (y/n): ");
            choice = keyboard.nextLine();
            System.out.println();
        }
        keyboard.close();
        
        //EOP message
        System.out.println("Bye!");
    }
}