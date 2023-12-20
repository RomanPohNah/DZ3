double[] array = { 2.2, 8.6, 3.3, 4.4, 5.5};
double maxNum = array[0];
double minNum = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > maxNum)
    {
      maxNum = array[i];  
    }
    if (array[i] > minNum)
    {
      minNum = array[i];  
    }
}
double difference = maxNum - minNum;
Console.WriteLine(maxNum);
Console.WriteLine(minNum);
Console.WriteLine(difference);