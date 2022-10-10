int[] MyArrays(string[] args)
{
    Console.Write("Введите количество элементов массива: ");
    int elementsCount = int.Parse(Console.ReadLine());   

    int[] MyArray = new int[elementsCount];
    for (int i = 0; i < MyArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        MyArray[i] = int.Parse(Console.ReadLine());

    }
    return MyArray;

}


    void printArray(int[] arrayToPrint)
{
     Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}


void ManyZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }  
       else
        {
            array[i]= array[i];
        } 
    }
    Console.Write($"Кол-во чисел больше нуля: {count}");
    
}
int[] array = MyArrays(args);
printArray(array);
ManyZero(array);
 