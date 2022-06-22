// Welcome to Fizz Buzz by Kristopher Kihaun and Kevion aka Team 10
Console.WriteLine("Hello!");
Console.WriteLine("How long would you like to Fizz Buzz?");
string Fizz = Console.ReadLine();
int time = int.Parse(Fizz);

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
