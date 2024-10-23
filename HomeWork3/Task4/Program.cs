int [] array = {-3, 4, 5, -7, -5, 9};
int index = 0;
int count = 0;
while (index != array.Length)
{
    if (0 <= array[index])
   
   
    count++;
    index++;

}
  int [] NewArray = new int[count];
  while (index != array.Length)
{
    if (0 < array[index])
   
   count++;
   index++;
   NewArray[count] = array[index];
   
}
Console.Write("[");
for (int j = 0; j < NewArray.Length; j++)
{
    Console.Write($"{NewArray[j]}," );
}
Console.Write("]");
