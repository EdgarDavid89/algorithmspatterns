using System.Data.Common;
using System.Formats.Tar;
using System.Runtime.Intrinsics.X86;
using Acme.Collections;
using ExampleAbsFact;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program test foreach practice");



FactoryPanaderia panaderia = new PanaderiaPolanco();
Pan pan = panaderia.CrearPan();
Cafe cafe = panaderia.CrearCafe();

panaderia = new PanaderiaVeracruz();

Pan pan1 = panaderia.CrearPan();
Cafe cafe1 = panaderia.CrearCafe();






var CharPop = (List<char> l) => {
  var result = l[l.Count - 1];
  l.RemoveAt(l.Count - 1);
  return result;
};

var isValid = (string s) => {
  List<char> listChar = new List<char>();

  foreach(var c in s)
  {
    switch(c)
    {
      case '[':
      case '(':
      case '{':
      listChar.Add(c);
      break;

      case '}': 
      if(listChar.Count == 0 || CharPop(listChar) != '{')
      return false;
      break;

      case ')': 
      if(listChar.Count == 0 || CharPop(listChar) != '(')
      return false;
      break;

      case ']': 
      if(listChar.Count == 0 || CharPop(listChar) != '[')
      return false;
      break;
    }



  }

  return listChar.Count == 0;
};


List<string> inputs = new() { "{})", "[(({}))]", "{[]}", "[(})]", "{[(]}", "{()}]" };

var result = inputs.Select(str => new { result = $"{str} {(isValid(str) ? "YES" : "NO")} balanced" }).ToList();
foreach(var s in  result)
{
  Console.WriteLine(s.result);
}




/*var a = new List<int> { 3, 8, 4, 10};


var a2 =  a.Skip(1);
int maximunRest  =  -1;
int interRest = a[0];


foreach (var valueItem in a2)
{
   if(interRest < valueItem)
   {
     int temRest = valueItem - interRest;
     maximunRest = temRest > maximunRest ? temRest : maximunRest;

   }
   else
    interRest = valueItem;
}

Console.WriteLine($"la máxima resta encontrada es {maximunRest}");*/

//[{}









//EventExample.Usage();

/*MyList<string> names = new();
names.Add("Liz");
names.Add("Martha");
names.Add("Beth");
for (int i = 0; i < names.Count; i++)
{
    string s = names[i];
    names[i] = s.ToUpper();
}*/