string? inputNum = Console.ReadLine();

if(inputNum!=null)
{
    int inputNumber1 = int.Parse(inputNum);
    string result = string.Empty;
    for(int i = 2; i < inputNumber1; i = i+2)
    {
        result = result + i + ",";
        
    }
    if(inputNumber1%2 == 0)
    {
        result = result + inputNumber1;  
    }
    Console.WriteLine(result);
}
