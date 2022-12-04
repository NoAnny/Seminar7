// Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.

int[] array = {1,2,3,5,9,11};
Console.WriteLine($"MEX массива равен {Mex(array)}");

int Mex(int[] array)
{
    int mex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0 & array.Length == 1)
        {
            mex = -1;
            break;
        } 
        else if (array[i] == 1 & array.Length == 1)
        {
            mex = 0;
            break;
        } 
        else if ((array[i] +1) != array[i+1])
        {
            mex = (array[i]+1);  
            break; 
        } 
    }
    return mex; 
}
