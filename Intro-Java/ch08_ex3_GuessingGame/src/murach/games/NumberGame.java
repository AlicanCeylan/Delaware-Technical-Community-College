/*
Alican Ceylan
10.27.2016
Chapter 8-3 
Modify a loop, modify if/else statements, add an if/else statement, and add a try/catch statement. Project contains the Main and NumberGame classes. 
*/

package murach.games;

import java.util.Random;

public class NumberGame 
{
   
	//instance variables
	private int upperLimit;
    private int number;
    private int guessCount;
    
    //constructor
    public NumberGame() 
    {
        this(50);        
    }
    
    //constructor with one parameter
    public NumberGame(int upperLimit) 
    {
        this.upperLimit = upperLimit;
        Random random = new Random();
        number = random.nextInt(upperLimit - 1) + 1;
        guessCount = 1;
    }

    //get and set methods for number variable
    public int getNumber()
    {
        return number;
    }

    //get and set methods for guess count variable
    public int getGuessCount() 
    {
        return guessCount;
    }
    
    //get and set methods for upper limit variable
    public int getUpperLimit() 
    {
        return upperLimit;
    }
    
    
    public void incrementGuessCount() 
    {
        guessCount = guessCount + 1;
    }
}