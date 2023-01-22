//Цикл for
// на примере Method 4

string Method4(int count, string text)
{
  string result = String.Empty;

  for(int i = 0; i < count; i++) // позволяет сократить запись цикла
  {
    result = result + text;
  }
  return result;
}
//string result = Method4(10, "asdf ");
string result = Method4(text: "asdf ", count: 10);
//System.Console.WriteLine(result);