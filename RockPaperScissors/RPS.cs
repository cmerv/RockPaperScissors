namespace RockPaperScissors;
class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer Human = new HumanPlayer(initPoints:5); // declaration of our objects
        ComputerPlayer Machine = new ComputerPlayer(); 
        PlayGame();

    void PlayGame() // use of a method for separating the object instantiation from the bulk of the code
    { do {
            Human.humanContinueOrNot=null; // reset status of whether we want to continue, every time loop runs so that we are re-prompted.
            Human.HumanDecision();
            Machine.ComputerDecision();
            string machineChoice=Machine.computerChoice;
            string humanChoice=Human.humanChoice;
            Console.WriteLine($"Computer Decision:{machineChoice}");
            Console.WriteLine($"Your Decision:{humanChoice}");
            if (machineChoice!=humanChoice) // efficient way to cut down on if statement usage. kick any equal hands out to the exception.
            {
                switch (humanChoice) // meat of the comparison. only compares two thing: current hand, and hands that are not equal to it
                {
                    case "rock":
                        if (machineChoice=="scissors")
                        {
                            HumanWinLose(humanWin:true);
                            break;
                        }
                        else 
                        {
                            HumanWinLose(humanWin:false);
                            break;
                        }
                    case "scissors":
                        if (machineChoice=="paper")
                        {
                            HumanWinLose(humanWin:true);
                            break;
                        }
                        else
                        {
                            HumanWinLose(humanWin:false);
                            break;
                        }
                    case "paper":
                        if (machineChoice=="rock")
                        {
                            HumanWinLose(humanWin:true);
                            break;
                        }
                        else
                        {
                            HumanWinLose(humanWin:false);
                            break;
                        }
                } 
            }
            else if (machineChoice==humanChoice)
            {  
                switch (humanChoice){
                 default:
                Console.WriteLine("It's a tie.");
                break;
                }
            }
            do {
            Human.GetPoints(); // display points
            if (Human.Points > 0){ // prevent infinite loop
            Console.WriteLine("Play again? Input 'y' to continue or 'n' to exit:");
            Human.humanContinueOrNot = Console.ReadLine().ToLower();
            continue;
            }
            else if (Human.Points == 0)
            {
                break;
            }
            } while (Human.humanContinueOrNot!="y"&&Human.humanContinueOrNot!="n");
    } while (Human.humanContinueOrNot!="n"&&Human.Points > 0);
        if (Human.Points==0)
        {
        Console.WriteLine("You now have 0 points and cannot continue. Thank you for playing. Game Over.");
        }
    }
        void HumanWinLose(bool humanWin) // use of this method cleans up the code in the comparison section
        {
            if (humanWin==true)
            {
                Human.Points += 1;
                Console.WriteLine("You win! +1 point.");
            }
            else
            {
                Human.Points -=1;
                Console.WriteLine("You lose! -1 point.");
            }
        }
    }
}

class HumanPlayer
{
private int points;

public string humanChoice;

public string humanContinueOrNot;

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
    humanChoice = null;
    humanChoice = Console.ReadLine();
    humanChoice = humanChoice.ToLower();
    
    while (humanChoice!="rock"||humanChoice!="paper"||humanChoice!="scissors")
    {
        switch (humanChoice)
        {
            default:
            Console.WriteLine("You have input an invalid shape. Please try again.");
            Console.WriteLine("Input your desired shape: Rock, Paper, or Scissors:");
            humanChoice = Console.ReadLine();
            break;
            case "rock":
            return humanChoice;
            case "paper":
            return humanChoice;
            case "scissors":
            return humanChoice;
        }
    }
    return humanChoice; // this is in place to resolve an error involving no return. it has no use otherwise
    
}
}

class ComputerPlayer
{
    public string computerChoice;
    public string ComputerDecision() // computer uses random numbers to determine
    {
        var randObj = new Random();
        var randNum = randObj.Next(1,4); // upper bound is exclusive
        Console.WriteLine(randNum);
        switch (randNum) // setting computerChoice based on numerals
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