﻿namespace RockPaperScissors;
class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer Human = new HumanPlayer(initPoints:5);
        ComputerPlayer Machine = new ComputerPlayer();

        while (Human.Points > 0)
        {
            Human.HumanDecision();
            Machine.ComputerDecision();
            string machineChoice=Machine.computerChoice;
            string humanChoice=Human.humanChoice;
            bool humanWin;
            bool humanTie;
            Console.WriteLine($"Computer Decision:{machineChoice}");
            Console.WriteLine($"Your Decision:{humanChoice}");
            if (machineChoice!=humanChoice)
            {
                switch (humanChoice)
                {
                    case "rock":
                        if (machineChoice=="scissors")
                        {
                            Human.Points+=1;
                            humanWin=true;
                            continue;
                        }
                        else 
                        {
                            Human.Points-=1;
                            humanWin=false;
                            continue;
                        }
                    case "scissors":

                    case "paper":
                } // meat of the program. compare our variables.
                break;
            }
            else
            {
                Console.WriteLine("It's a tie.");
                humanTie=true;
                continue;
            }
        }
        if (Human.Points==0)
        {
        Console.WriteLine("You now have 0 points and cannot continue. Thank you for playing. Game Over.");
        }
    }
}

class HumanPlayer
{
private int points;

public string humanChoice;

public int Points {
    get { return points; }
    set { points = value;}
}

public HumanPlayer (int initPoints) {
    this.Points = initPoints;
}

public int GetPoints() {
    Console.WriteLine($"You have {this.Points} points");
}
public void WinRound()
{
    this.Points += 5;
}
public void LoseRound()
{
    this.Points -= 5;
}
public string HumanDecision()
{
    Console.WriteLine("Input your desired shape: Rock, Paper, or Scissors:");
    humanChoice:
    humanChoice = Console.ReadLine().toLower();
    switch (humanChoice)
    {
         default:
            Console.WriteLine("You have input an invalid shape. Valid shape are: Rock, Paper, Scissors. Please try again:");
            goto humanChoice;
        case "rock":
          return humanChoice;
        case "paper":
         return humanChoice;
        case "scissors":
         return humanChoice;
    }
}
}


class ComputerPlayer
{
    public class Random{}
    public string computerChoice;
    public string ComputerDecision()
    {
        var randObj = new Random();
        int lowerLimit = 1;
        int upperLimit = 3;
        var randNum = Random.Next(lowerLimit, upperLimit);
        switch (randNum)
        {
            case 1:
            computerChoice = "rock";
            case 2:
            computerChoice = "paper";
            case 3:
            computerChoice = "scissors";
        }
        return computerChoice;
    }
}