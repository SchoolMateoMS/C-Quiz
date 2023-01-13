//Init
Console.Clear();
#nullable disable

//global variables

//Input
//question 1
Console.WriteLine("Hello! welcome to the AMAZING quiz! Are you ready? (y/n)");
string a1 = Console.ReadLine();

if(a1 == "y"){
    int count = 0;

    //first question correct
    count += 1;

    Console.WriteLine("Cool! You got the first question correct!");

    clearMessage();
    
    //increase count if you get question right
    count += question2();

    count += question3();

    count += question4();

    Console.Clear();

    //show score, and make percent
    double perc =  100 * (Convert.ToDouble(count) / 4);
    Console.WriteLine($"you got {count} / 4, ({perc}%)");

    makePig("happy");
    makeBear();
    
}else if(a1 == "n"){
    int count = 0;

    Console.WriteLine("YOU FAIL!");

    Console.WriteLine(" ");

    //show score
    double perc =  100 * (Convert.ToDouble(count) / 4);
    Console.WriteLine($"you got {count} / 4, ({perc}%)");
}


//questions

static int question2(){
    //question 2
    Console.Clear();
    Console.WriteLine("Question 2:How heavy is this pig? (HINT: less than 10)");

    Thread.Sleep(1000);

    makePig("nuetral");
    
    int pigWeight = Convert.ToInt32(Console.ReadLine());

    if(pigWeight > 5){
        //wrong
        Console.Clear();
        Console.WriteLine("WRONG");
        Console.WriteLine("Answer: 5");
        Console.WriteLine(" ");

        Console.WriteLine("Wow, You just ruined this pigs self esteem.");

        makePig("sad");

        clearMessage();
        return 0;
    }else if(pigWeight == 5){
        //correct answer
        Console.Clear();
        Console.WriteLine("CORRECT");
        Console.WriteLine("You got it Man, or Woman!");
        Console.WriteLine(" ");
        Console.WriteLine("Answer: 5");
        makePig("nuetral");
        
        clearMessage();
        return 1;
    }else if(pigWeight < 5){
        //wrong
        Console.Clear();
        Console.WriteLine("WRONG");
        Console.WriteLine("Answer: 5");
        Console.WriteLine(" ");

        Console.WriteLine("Wow! The pig thanks you for the compliment! But you still got it wrong.");

        makePig("happy");
        
        clearMessage();
        return 0;
    }else{
        return 0;
    }
}


static int question3(){
    Console.Clear();
    Console.WriteLine("Question 3: solve this math problem: Pig + Pig = Bear");
    int ans = Convert.ToInt32(Console.ReadLine());

    if(ans == 10){
        //correct answer
        Console.Clear();
        Console.WriteLine("CORRECT");
        Console.WriteLine("Yeah! You got it in the nose!");
        Console.WriteLine(" ");
        makeBear();
        Console.WriteLine("Answer: 10");

        clearMessage();
        return 1;
    }else{
        //wrong
        Console.Clear();
        Console.WriteLine("WRONG");
        Console.WriteLine("Dang, you don't seem to be the sharpest tool in the shed...");
        Console.WriteLine(" ");
        makeBear();
        Console.WriteLine("Answer: 10");

        clearMessage();
        return 0;
    }
}


static int question4(){
    Console.Clear();
    Console.WriteLine("Question 4: solve the math problem: Bear + Pig = Car");
    int ans = Convert.ToInt32(Console.ReadLine());

    if(ans == 15){
        //correct answer
        Console.Clear();
        Console.WriteLine("CORRECT");
        Console.WriteLine("You've got some awesome counting skills!");
        Console.WriteLine(" ");
        Console.WriteLine("Answer: 15");

        clearMessage();
        return 1;
    }else{
        //wrong
        Console.Clear();
        Console.WriteLine("WRONG");
        Console.WriteLine("You've gotta work on your animal counting skills...");
        Console.WriteLine(" ");
        Console.WriteLine("Answer: 15");

        clearMessage();
        return 1;
    }
}


//ASCII art
static void makePig(string emotions){
    if(emotions == "nuetral"){
        Console.WriteLine("    _____");
        Console.WriteLine("^. .^     |9");
        Console.WriteLine("(oo)_____/ ");
        Console.WriteLine("   WW  WW");
    }else if(emotions == "sad"){
        Console.WriteLine("    _____");
        Console.WriteLine("^; ;^     |9");
        Console.WriteLine("(oo)_____/ ");
        Console.WriteLine("   WW  WW");
    }else if(emotions == "happy"){
        Console.WriteLine("    _____");
        Console.WriteLine("^> <^     |9");
        Console.WriteLine("(oo)_____/ ");
        Console.WriteLine("   WW  WW");
    }
}

static void makeBear(){
    Console.WriteLine(" __         __");
    Console.WriteLine("|  |.-----.|  |");
    Console.WriteLine("|    -   -    |");
    Console.WriteLine(" |   o   o   |");
    Console.WriteLine(" |  .-'''-.  |");
    Console.WriteLine("  '-|__Y__|-'");
    Console.WriteLine("     `---`");
}

//clear function
static void clearMessage(){
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}