// See https://aka.ms/new-console-template for more information
string[] items = {"Bröd","Korv","Gurka","Mjölk","Ost"};

int [] weight = new int[5];

 Random generator = new Random();

//skapar slumpmässiga vikter för föremålen att ha
for (int i = 0; i < 5; i++){
    weight [i] = generator.Next(0, 100);
} 
int carry= 0;
bool repeat = false;    
//skriver ut information och spelar om informationen om man inte skriver något
while(repeat== false)
{
    
    for (int i = 0; i < 5; i++){
        Console.WriteLine($"{items [i]}");
        Console.WriteLine($"{weight [i]}");
    }
    Console.WriteLine($"Write how much you want to carry");
    repeat = int.TryParse(Console.ReadLine(),out carry );    

}
//skriver ut föremålen som kan bäras med den carrying capacity spelaren valde
for (int i = 0; i < 5; i++){
    if(weight[i] <=carry)
    {
        Console.WriteLine($"{items[i]}");
    }
} 

Console.ReadLine();
