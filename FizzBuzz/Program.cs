/*
    Welcome to Fizz Buzz by: Kristopher, Kihaun, and Kevion aka Team 10 (Name Pending)
    This code asks the user for a number greater than 1.
    If the user enters a number less than 1 the code will ask for another number.
    This occurs until a valid number has been entered.
*/ 
Console.WriteLine("Hello!");
Console.WriteLine("How long would you like to Fizz Buzz? Please enter a number greater than or equal to 1:");
string Fizz = Console.ReadLine();
int time = int.Parse(Fizz);
while (time <1){
    Console.WriteLine("I am sorry please enter a number greater than or equal to 1.: ");
    Fizz = Console.ReadLine();
    time = int.Parse(Fizz);
}

for(int i = 1; i<=time; i++){
    if(i%3 == 0 && i%5 ==0){
        Console.WriteLine("fizz buzz"); // if divisible by 3 and 5 print "fizz buzz"
    }
    else if(i%5 == 0){
        Console.WriteLine("buzz"); // if divisible by 5 print "buzz"
    }
    else if (i%3 == 0){
        Console.WriteLine("fizz"); // if divisible by 3 print "fizz"
    }else{
        Console.WriteLine(i);
    }
}
