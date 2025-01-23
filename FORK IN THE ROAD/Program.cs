//step 1:
using System.Runtime.InteropServices;

int score = 100;
float health = 59.9f;
string name = "lou santos1";

// step 2: tell player they found a fork in the road 

Console.WriteLine(" you find a fork in the road ");
// step 3: tell player options they have to procceed
Console.WriteLine("you can go [left] to a town");
Console.WriteLine("you can go [right] to the mountain");
Console.WriteLine("which direction do you choose");

// Step 4: get player input
string  input = Console.ReadLine();

// Step 5:check players response, go in differant directions
if (input == "left")
{
    Console.WriteLine("you are in town");
    Console.WriteLine("welcome to town lou. my name is rowin here is a chest with items for you");

    Console.WriteLine(2 + " medkits");

    Console.WriteLine(3 + " peices of meat");
    Console.WriteLine(1 + " deed to a hut ");
    Console.WriteLine(" thanks rowin for the items and the hut i will take good care of it  " +
        "but im off to bed i'll see you in the morning ");
 
 



}
else if (input == "right")
{
    Console.WriteLine(" you are in the mountain");
    Console.WriteLine(" the town is starting to seem like a better idea now ");
    Console.WriteLine(" you are getting tired");
    // step 6:tell player options to continue
    Console.WriteLine(" you can go [left] to rest");
    Console.WriteLine(" you can go [right] to keep moving");
    Console.WriteLine(" what direction do you choose");
    // step 7:get player input
    string input1 = Console.ReadLine();
    Console.WriteLine("you are now resting till the morning");
    // step 8: give the player options to continue
    Console.WriteLine("good morning you need to find supplys");
    Console.WriteLine("you here a noise as you wake up suprise there a mountain lion in your night camp");
    Console.WriteLine("you are attacked by the lion and your leg is torn open");
    Console.WriteLine("grab the sharp stick [left] to kill the lion");
    Console.WriteLine("[right] to punch the lion");
    //step 9: player input
    string input2 = Console.ReadLine();
    //step 10: player options
    Console.WriteLine("you are attacked by the lion shredding your leg and pulling you around" +
        "you grab the sharp stick on your left and stab the lion in the head");
    //step 11: get supply's player options 
    Console.WriteLine("you have killed the lion but your leg is torn apart you need to find medical kit");
    Console.WriteLine("you see a shed in the distance");
    Console.WriteLine("you approch the shed to bash the door open [open] in hopes of supplies");
    //step 12: players input
    string input3 = Console.ReadLine();
    Console.WriteLine("you found supplies you have aquired");
    Console.WriteLine(1 + "medkit");
    Console.WriteLine(1 + "oatbar");
    
}
else
{
    Console.WriteLine("you did not type [right] or [left].");
    

}




















