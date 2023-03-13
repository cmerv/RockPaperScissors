namespace RockPaperScissors;
class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer Human = new HumanPlayer(initPoints:0);
        ComputerPlayer Machine = new ComputerPlayer(initPoints:0);
        Console.WriteLine("Hello, World!"); 
    }
}

class HumanPlayer
{
private int points;

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
public string HumanDecision(string humanChoice)
{
    Console.WriteLine("Input your desired shape: Rock, Paper, or Scissors:");
    humanChoice = Console.ReadLine().toLower();
    return humanChoice;
}
}


class ComputerPlayer
{

}