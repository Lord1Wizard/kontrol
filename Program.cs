Console.WriteLine("Введите количество слов");
int countmax=int.Parse(Console.ReadLine());
string []array= new string[countmax];
for (int count=0;count<countmax;count++)
{
Console.WriteLine("Введите слово №" + (count+1));
array[count]=Console.ReadLine();
}
bool first=true;
for (int count=0;count<countmax;count++)
{
    if (array[count].Length<=3)
    {
        if (first==true) 
        {
            Console.Write("[\""+array[count] +"\"");
            first=false;
        }else  Console.Write(", \""+array[count]+"\"" );   
    }
    

}
if (first==false) Console.Write("]");

