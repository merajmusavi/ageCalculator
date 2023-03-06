ConsoleKeyInfo key;
int input;

do{
    input = 0;

    Console.WriteLine("please enter your age");

    getAge();
    int ageAsSec = input*365*24*60*3600;
    
    Console.WriteLine("your age : "+ageAsSec);
    
    Console.WriteLine("do you want continue (y/n)");
    key = Console.ReadKey(true);
    Console.WriteLine();



}while(key.KeyChar!='N' && key.KeyChar!='n');

Console.WriteLine("thanks for using our application");

void getAge(){
    while(true){
    key = Console.ReadKey(true);

    if(char.IsDigit(key.KeyChar)){
    input = input*10 + (int)char.GetNumericValue(key.KeyChar);
    Console.Write(key.KeyChar);

    }else{
        Console.Beep();
    }

    // clicked on enter
    if(key.Key==ConsoleKey.Enter){
    Console.WriteLine();
    break;
    }



    }
}