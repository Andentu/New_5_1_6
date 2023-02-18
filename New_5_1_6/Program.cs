namespace New_5_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var arr = GetArrayFromConsole(); // Обращение к методу и массиву его включающему. Также получение массива result в arr
            int num;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        num = arr[i];
                        arr[i] = arr[j];
                        arr[j] = num;
                        Console.WriteLine();
                        
                    }
                }
            }
            foreach (var item in arr) 
            {
                Console.Write(item + " ");
            }



        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        
    }
}