

List<object> listaBox = new List<object>();

listaBox.Add(7);
listaBox.Add(28);
listaBox.Add(-1);
listaBox.Add(true);
listaBox.Add("chair");



int sum = 0;
for (int i = 0; i < listaBox.Count; i++)
{
    
    if (listaBox[i] is int)
    {
        sum += (int)listaBox[i];
    }
    
};
    Console.WriteLine($"La suma es de {sum}");