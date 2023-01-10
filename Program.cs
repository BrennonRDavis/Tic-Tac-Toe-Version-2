// Optimization attempts
// int computerPickMethod()
//{
//    for (int i = 0; gameBoard[i] != 'X' && gameBoard[i] != 'O';)
//    {
//        i = random.Next(gameBoard.Length);
//        return i;
//    }
// problem: Not all code paths return a value

// 1/10/23 -> I have completed the following tasks
// Dont repeat loop twice get both games in one loop
// Clear at end of game to update board
// make game type bool
// still need to optimize the computer picker part to not just throw randomness at an if or while statement.

// do *something* while(computerChoice != 'X' && computerChoice != 'Y')

    using System.Reflection.Metadata.Ecma335;
using Tic_Tack_Toe_version_2;

//menu
bool IsSinglePlayer()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("TicTacToe");
    Console.WriteLine("Please select a game mode");
    Console.WriteLine("1: 1 Player ");
    Console.WriteLine("2: 2 Player Hotseat");
    int gameMode = Convert.ToInt32(Console.ReadLine());
    if (gameMode != 1)
    {
        return false;
    }
    else return true;
    
    
}

//game
bool singlePlayerMode= IsSinglePlayer();
    char[] gameBoard = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
char[] pcSelections = gameBoard;
    char playerID = 'X';
    Random random = new Random();
    int turnCount = 1;
    int choice;
// some computer pick method here that takes gameBoard and checks the random number to make sure the number in the array hasn't been selected. Something like
// Random cpu = new Random(gameBoard.length) except it doesnt take that cos there is no .length for char [] it seems... 
do

{

    if (turnCount % 2 == 0)
    {
        playerID = 'O';

    }
    else
    {
        playerID = 'X';
    }
    var board = new Board();
    board.GetGameBoard(gameBoard, playerID);

    if (playerID == 'O' && singlePlayerMode == true)
    {

        do
        {
            choice = random.Next(1,9);
            if (gameBoard[choice] == 'X' || gameBoard[choice] == 'O')
            {
                choice = random.Next(1, 9);
            }

        } while (gameBoard[choice] == 'X' || gameBoard[choice] == 'O');

    }
    else choice = Convert.ToInt32(Console.ReadLine());


    if (gameBoard[choice] == 'X' || gameBoard[choice] == 'O')
    {
        do
        {
            Console.WriteLine("You can't go there. It is already " + gameBoard[choice]);
            Console.WriteLine("Try again buddy, this time no funny business ");
            choice = Convert.ToInt32(Console.ReadLine());

        } while (gameBoard[choice] == 'X' || gameBoard[choice] == 'O');
    }
    else
    {
        gameBoard[choice] = playerID;
        Console.Clear();
        turnCount++;
        //var CheckWinConditions();
        //the below can be improved with some sort of method in Tic_Tack_Toe_Version_2 perhaps that runs the check separately 
    }
    if (gameBoard[1] == 'X' && gameBoard[2] == 'X' && gameBoard[3] == 'X')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 1 Wins Horizontally across the top! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[1] == 'O' && gameBoard[2] == 'O' && gameBoard[3] == 'O')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 2 Wins Horizontally across the top! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;

    }
    if (gameBoard[4] == 'X' && gameBoard[5] == 'X' && gameBoard[6] == 'X')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 1 Wins Horizontally through the middle! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[4] == 'O' && gameBoard[5] == 'O' && gameBoard[6] == 'O')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 2 Wins Horizontally through the middle! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[7] == 'X' && gameBoard[8] == 'X' && gameBoard[9] == 'X')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 1 Wins Horizontally across the bottom! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[7] == 'O' && gameBoard[8] == 'O' && gameBoard[9] == 'O')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 2 Wins Horizontally across the bottom! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[1] == 'X' && gameBoard[4] == 'X' && gameBoard[7] == 'X')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 1 Wins Vertically down the left side! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[1] == 'O' && gameBoard[4] == 'O' && gameBoard[7] == 'O')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 2 Wins Vertically down the left side! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[2] == 'X' && gameBoard[5] == 'X' && gameBoard[8] == 'X')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 1 Wins Vertically straight down the middle! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[2] == 'O' && gameBoard[5] == 'O' && gameBoard[8] == 'O')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 2 Wins Vertically down the middle! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[3] == 'X' && gameBoard[6] == 'X' && gameBoard[9] == 'X')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);

        Console.WriteLine("Player 1 Wins Vertically straight down the right side! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[3] == 'O' && gameBoard[6] == 'O' && gameBoard[9] == 'O')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 2 Wins Vertically down the right side! ");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[1] == 'X' && gameBoard[5] == 'X' && gameBoard[9] == 'X')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 1 Wins Diagonally!");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[1] == 'O' && gameBoard[5] == 'O' && gameBoard[9] == 'O')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 2 Wins Diagonally!");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[3] == 'X' && gameBoard[5] == 'X' && gameBoard[7] == 'X')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 1 Wins Diagonally!");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
    if (gameBoard[3] == 'O' && gameBoard[5] == 'O' && gameBoard[7] == 'O')
    {
        Console.Clear();
        board = new Board();
        board.GetGameBoard(gameBoard, playerID);
        Console.WriteLine("Player 2 Wins Diagonally!");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
        break;
    }
} while (true);

