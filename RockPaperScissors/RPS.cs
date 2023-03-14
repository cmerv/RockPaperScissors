namespace RockPaperScissors;
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
                        if (machineChoice=="paper")
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
                    case "paper":
                        if (machineChoice=="rock")
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

public void GetPoints()
{
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
    humanChoice = Console.ReadLine();
    humanChoice = humanChoice.ToLower();
    do {
    switch (humanChoice)
    {
        default:
        Console.WriteLine("You have input an invalid shape. Valid shape are: Rock, Paper, Scissors. Please try again:");
        Console.WriteLine("Input your desired shape: Rock, Paper, or Scissors:");
        humanChoice = Console.ReadLine();
        return humanChoice; 
        case "rock":
         return humanChoice;
        case "paper":
         return humanChoice;
        case "scissors":
         return humanChoice;
    }
    } while (humanChoice!="rock"||humanChoice!="paper"||humanChoice!="scissors");
}
}


class ComputerPlayer
{
    public string computerChoice;
    public string ComputerDecision()
    {
        var randObj = new Random();
        int lowerLimit = 1;
        int upperLimit = 3;
        var randNum = randObj.Next(lowerLimit, upperLimit);
        switch (randNum)
        {
            case 1:
            computerChoice = "rock";
            break;
            case 2:
            computerChoice = "paper";
            break;
            case 3:
            computerChoice = "scissors";
            break;
        }
        return computerChoice;
    }
}