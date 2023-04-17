/*
Alican Ceylan
10.18.2016
Chapter 7-3 
Use the increment operator, combine statements, use a constant, add an if statement that uses the modulus operator, and apply currency formatting. Project contains the Main class only. 
*/

package murach.fv;

import java.text.NumberFormat;
import java.util.Scanner;

public class Main 
{

    public static void main(String[] args) 
    {
        // display a welcome message
        System.out.println("Welcome to the Future Value Calculator");
        System.out.println();

        Scanner keyboard = new Scanner(System.in);        
        String choice = "y";
        while (choice.equalsIgnoreCase("y")) 
        {

            // get input from user
            System.out.print("Enter monthly investment:   ");
            double monthlyInvestment = Double.parseDouble(keyboard.nextLine());

            System.out.print("Enter yearly interest rate: ");
            double yearlyInterestRate = Double.parseDouble(keyboard.nextLine());

            System.out.print("Enter number of years:      ");
            int years = Integer.parseInt(keyboard.nextLine());                        
            
            // convert yearly values to monthly values
            double monthlyInterestRate = yearlyInterestRate / 12 / 100;
            int months = years * 12;        

            // calculate the future value
            double futureValue = 0;
            int i = 1;
            while (i <= months) 
            {	
            	futureValue = futureValue + monthlyInvestment;
                double monthlyInterestAmount = 
                        futureValue * monthlyInterestRate;
                futureValue = futureValue + monthlyInterestAmount;          
                i = i++;
            }            

            // format and display the result
            System.out.println("Future value:               " + 
                    NumberFormat.getCurrencyInstance().format(futureValue));
            System.out.println();

            // see if the user wants to continue
            System.out.print("Continue? (y/n): ");
            choice = keyboard.nextLine();
            System.out.println();
        }
        
        //EOP message
        System.out.println("End of Program.");
        
        //close scanner object
        keyboard.close();
    }
}