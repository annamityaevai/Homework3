// Задача 23. Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Insert number: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int i = 0;
  int length = cube.Length;
  while (i <  length){
    cube[i] = Convert.ToInt32(Math.Pow(i, 3));
    i++;
  }
}

void PrintArray(int[] coll){
  int j = coll.Length;
  int index = 1;
  while(index < j){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);