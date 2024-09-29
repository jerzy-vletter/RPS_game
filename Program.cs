
namespace RockPaperscissors
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // cleans up the console on execution of the Program, as it is a text based Program
            Console.Clear();

            // define a array of options that we will need later
            var valid_moves = new List<string> { "rock", "paper", "scissors" };

            OpeningDialog();

            String? confirm = Console.ReadLine();

            ConfirmPlay(confirm);

            String? User_move = Console.ReadLine();

            User_move = ConfirmUserMove(User_move, valid_moves);

            String computer_move = SelectComputerMove(valid_moves);

            Console.WriteLine("user move: " + User_move);
            Console.WriteLine("computer move: " + computer_move);

            SelectOutcome(User_move, computer_move);
        }

        public static void OpeningDialog()
        {
            Console.WriteLine("welcome to this console,");
            Console.WriteLine("would you like to play a game of rock paper scissors?");
            Console.WriteLine("insert Y(for yes) or N(for no):");
        }

        public static void ConfirmPlay(string? confirm)
        {
            if (String.IsNullOrEmpty(confirm))
            {
                Console.WriteLine("something went wrong, press any key to close the Program");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

            confirm = confirm.ToLower();

            if (confirm == "n")
            {
                Console.WriteLine("you have entered no, press any key to close the Program");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

            Console.WriteLine("Okay, you want to play,");
            Console.WriteLine("enter either Rock, paper or Scissors below");
        }

        public static string ConfirmUserMove(string? User_move, List<string> valid_moves)
        {
            if (String.IsNullOrEmpty(User_move))
            {
                Console.WriteLine("something went wrong, press any key to close the Program");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

            User_move = User_move.ToLower();

            if (valid_moves.Contains(User_move) == false)
            {
                Console.WriteLine("you entered a non valid move, press any key to close the Program");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

            return User_move;
        }

        public static string SelectComputerMove(List<string> valid_moves)
        {
            var random = new Random();
            int i = random.Next(valid_moves.Count);
            string computer_move = valid_moves[i];
            return computer_move;
        }

        public static void SelectOutcome(String User_move, String computer_move)
        {
            switch (User_move)
            {
                case "rock":
                    switch (computer_move)
                    {
                        case "rock":
                            Console.WriteLine("YOU TIE");
                            break;
                        case "paper":
                            Console.WriteLine("YOU LOSE");
                            break;
                        case "scissors":
                            Console.WriteLine("YOU WIN");
                            break;
                        default:
                            break;
                    }
                    break;
                case "paper":
                    switch (computer_move)
                    {
                        case "paper":
                            Console.WriteLine("YOU TIE");
                            break;
                        case "scissors":
                            Console.WriteLine("YOU LOSE");
                            break;
                        case "rock":
                            Console.WriteLine("YOU WIN");
                            break;
                        default:
                            break;
                    }
                    break;
                case "scissors":
                    switch (computer_move)
                    {
                        case "scissors":
                            Console.WriteLine("YOU TIE");
                            break;
                        case "rock":
                            Console.WriteLine("YOU LOSE");
                            break;
                        case "paper":
                            Console.WriteLine("YOU WIN");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("something went wrong");
                    break;
            }
        }
    }
}
