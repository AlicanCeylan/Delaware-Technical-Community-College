/*
Alican Ceylan
10.27.2016
Chapter 8-3 
Modify a loop, modify if/else statements, add an if/else statement, and add a try/catch statement. Project contains the Main and NumberGame classes. 
*/

package murach.games;

import java.util.Scanner;

public class Main 
{

    public static void main(String args[]) 
    {
        System.out.println("Welcome to the Number Guessing Game");
        System.out.println();

        //create scanner object
        Scanner keyboard = new Scanner(System.in);
        NumberGame game = new NumberGame();
        System.out.println("I have selected a number between 0 and " +
                game.getUpperLimit());
        System.out.println();
        
        //get input from user
        System.out.print("Enter your guess: ");
        int guess = Integer.parseInt(keyboard.nextLine());
        while (true) 
        {
            if (guess < game.getNumber()) 
            {
                System.out.println("Your guess is too low.\n");
            } 
            else if ((guess - 10 ) >  game.getNumber())
            {
            	System.out.println("Way too high!\n");
            }
            else if (guess > game.getNumber()) 
            {
            
            	System.out.println("Your guess is too high.\n");
            }
            
            else if (guess == game.getNumber())
            {
            	break;
            }
            game.incrementGuessCount();
            System.out.print("Enter your guess: ");
            guess = Integer.parseInt(keyboard.nextLine());
        }        
        System.out.println("Correct!\n");
        
        System.out.println("You got it in " +
                game.getGuessCount() + " tries.");
        
        if (game.getGuessCount() <= 3)
        {
        	System.out.println("Great work! You are a mathematical wizard.\n");
        }
        else if (game.getGuessCount() > 3 && game.getGuessCount() <= 7)
        {
        	System.out.println("Not too bad! You've got some potential.\n");
        }
        else if (game.getGuessCount() > 7)
        {
        	System.out.println("What took you so long? Maybe you should take some lessons.\n");
        }
        
        //EOP message
        System.out.println("End of Program.");
        keyboard.close();
    }
}