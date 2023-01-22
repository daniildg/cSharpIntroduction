//Метод 4
// принимает, возвращает

string Method4(int count, string c)
{
  int i = 0;
  string result = String.Empty;

  while(i < count)
  {
    result = result + c;
    i++;
  }
  return result;
}
string result = Method4(10, "asdf ");
System.Console.WriteLine(result);