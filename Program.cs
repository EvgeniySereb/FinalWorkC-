string[] InitArray()
{
    Console.WriteLine("Введите любые символы через запятую");
    return Console.ReadLine().Split(",");
    
}

string[] GetNewString(string[] arr )
{
    
    string[] result = new string [arr.Length];
    for(int  i = 0, j =0; i< arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            
            
             result[j] = arr[i];
             j++;
             
        }
       
        
    }
return result;
}



string[] a = InitArray();
 string[] b  = GetNewString(a);
 
Console.WriteLine($"{string.Join(", ", a)} >>>> {string.Join(", " , b)}");

 
