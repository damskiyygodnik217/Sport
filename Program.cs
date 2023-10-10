point:
Console.Write("Введите количество спортсменов: ");
var count = Console.ReadLine();
if (string.IsNullOrWhiteSpace(count))
{
    Console.WriteLine("Неверное количество спортсменов. Повторите попытку.");
    goto point;
}
if (Convert.ToInt32(count) <= 0)
{
    Console.WriteLine("Неверное количество спортсменов. Повторите попытку.");
    goto point;
}
Console.Clear();
Dictionary<string, float> person = new Dictionary<string, float>();
point2:
for (int i = 0; i < int.Parse(count); i++)
{
    Console.Write("Введите ФИО спортсмена: ");
    string tempName = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(tempName))
    {
        Console.WriteLine("Неправильно введено ФИО. Повторите попытку.");
        goto point2;
    }
    var varCheck = tempName.ToCharArray();
    int x = 0;
    for (int j = 0; j < varCheck.Length; j++)
    {
        if (varCheck[j] == ' ')
        {
            x++;
        }
        if (x != 2 && j == varCheck.Length - 1)
        {
            Console.WriteLine("Неправильно введено ФИО. Повторите попытку.");
            goto point2;
        }
    }
    Console.WriteLine($"Введите результат {tempName}: ");
    string tempValue = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(tempValue))
    {
        Console.WriteLine("Неправильно введено время. Повторите попытку.");
        goto point2;
    }
    if (float.Parse(tempValue) <= 0)
    {
        Console.WriteLine("Неправильно введено время. Повторите попытку.");
        goto point2;
    }
    else
    {
        person.Add(tempName, float.Parse(tempValue));
    }
}
var sortedDict = person.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
int h = 1;
foreach (var persona in sortedDict)
{
    Console.WriteLine($"Место:{h}" + " ФИО: {0} Результат: {1}", persona.Key, persona.Value);
    h++;
}