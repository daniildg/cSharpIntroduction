//Метод 2
// принимает, не возвращает

//void Method2(string msg)
//{
//  System.Console.WriteLine(msg);
//}
//Method2("текст сообщения");

void Method21(string msg, int count)
{
  int i = 0;
  while(i < count)
  {
    System.Console.WriteLine(msg);
    i++;
  }
}
//Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Текст");