Console.WriteLine("Bir eded daxil edin");
int a=int.Parse(Console.ReadLine());
int qaliq = 0;
int temp1 = 1;
int temp = a;
int binary = 0;
while (temp > 0)
{
    qaliq = temp%2;
    temp1 = temp1 * 10 + qaliq;
    temp = temp/2;
    if (temp == 0)
    {
        Console.WriteLine(temp1);
        while (temp1 > 0)
        {
            qaliq = 0;            
            qaliq = temp1 % 10;
            binary = (binary + qaliq) *10;
            temp1 = temp1 / 10;
         }
    }

}
binary = binary / 10;
Console.WriteLine(binary);