package murach.ui;

import java.util.Scanner;

public class Console 
{

	//create scanner object
	private static Scanner keyboard = new Scanner(System.in);
    
    public static void displayLine() 
    {
        System.out.println();
    }

    public static void displayLine(String s) 
    {
        System.out.println(s);
    }

    public static String getString(String prompt) 
    {
        System.out.print(prompt);
        String s = keyboard.nextLine();
        return s;
    }

    public static int getInt(String prompt) 
    {
        int i = 0;
        while (true) 
        {
            System.out.print(prompt);
            try 
            {
                i = Integer.parseInt(keyboard.nextLine());
                break;
            } catch (NumberFormatException e) {
                System.out.println("Error! Invalid integer. Try again.");
            }
        }
        return i;
    }

    public static double getDouble(String prompt, double min, double max) 
    {
        double d = 0;
        while (true) 
        {
            System.out.print(prompt);
            try 
            {
                d = Double.parseDouble(keyboard.nextLine());
                if (d < min) 
                {
                    System.out.println(" \nError! This number must be greater than or equal to 10. Try again. \n");                    
                } 
                else if (d > max) 
                {
                    System.out.println("\nError! This number must be less than 100,000. Try again.\n");                    
                }
                else 
                {
                    break;
                }
            } 
            catch (NumberFormatException e) 
            {
                System.out.println("\nError! Invalid decimal. Try again.\n");
            }
        }
        return d;
    }
	
}
