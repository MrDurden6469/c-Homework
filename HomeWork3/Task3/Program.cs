double [] array = new double [10]{3,5,4,6,7,8,9,1,2,10};

double sum = 0;

for (int index = 0; index < array.Length; index++)
{
    sum = sum + array[index];
}

double result = sum / array.Length;
Console.WriteLine(result);