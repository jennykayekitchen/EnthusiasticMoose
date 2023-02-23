using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // Ask a question
    MooseQuestions();
}

// declares a function that does not return anything, and takes a string call message as the argument
void MooseSays(string message)
    {
        // prints the moose to the console, with the message that was provided
        Console.WriteLine($@"
                                            _.--^^^--,
                                            .'          `\
        .-^^^^^^-.                      .'              |
        /          '.                   /            .-._/
        |             `.                |             |
        \              \          .-._ |          _   \
        `^^'-.         \_.-.     \   `          ( \__/
                |             )     '=.       .,   \
            /             (         \     /  \  /
            /`               `\        |   /    `'
            '..-`\        _.-. `\ _.__/   .=.
                |  _    / \  '.-`    `-.'  /
                \_/ |  |   './ _     _  \.'
                    '-'    | /       \ |
                            |  .-. .-.  |
                            \ / o| |o \ /
                            |   / \   |    {message}
                            / `^`   `^` \
                            /             \
                            | '._.'         \
                            |  /             |
                            \ |             |
                            ||    _    _   /
                            /|\  (_\  /_) /
                            \ \'._  ` '_.'
                            `^^` `^^^`
            ");
}

// declares that the function MooseAsks will return either true or false
// it has one argument, which is a string named question
bool MooseAsks(string question)
{
    // tells the console to write out the question, which is the argument, along with a Y/N
    Console.Write($"{question} (Y/N): ");
    // declares a new string variable named answer
    // reads what the user inputs and then turns that string into lowercase and assigns to answer
    string answer = Console.ReadLine().ToLower();

    // creates a loop that executes as long as answer is not y or n
    while (answer != "y" && answer != "n")
    {
        // tells the console to write the prompt to the console
        Console.Write($"{question} (Y/N): ");
        // reads what the user inputs and then turns that string into lowercase and assigns to answer
        answer = Console.ReadLine().ToLower();
    }

    // if the user responds with y, that will equal true
    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

// declares a function that has questions in it and it doesn't have any parameters and doesn't return a value
void MooseQuestions()
{
    // declares a variable that will be either true/false
    // it is equal to the value of MooseAsks which is a question and prints out the question which will also add y/n
    bool isCanada = MooseAsks("Is Canada real?");
    
    // based on the value of of isCanada, the function MooseSays will respond 
    if (isCanada)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }

    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }

    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }

    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}


