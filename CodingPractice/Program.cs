using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
string s1 = "hello";
string s2 = "hello";
string s3 = new string("hello".ToCharArray());

Console.WriteLine(s1 == s2);
Console.WriteLine(s1 == s3);
Console.WriteLine(object.ReferenceEquals(s1, s2));
Console.WriteLine(object.ReferenceEquals(s1, s3));

Player p1 = new Player("Hero", 10);
Player p2 = new Player("Hero", 10);
Player p3 = p1;

Console.WriteLine($"p1 == p2: {p1 == p2}");
Console.WriteLine($"p1 == p3: {p1 == p3}");
Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}");

Position pos1 = new Position(10, 20);
Position pos2 = new Position(10, 20);
Position pos3 = new Position(40, 20);

Console.WriteLine($"pos1.Equals(pos2): {pos1.Equals(pos2)}");
Console.WriteLine($"pos1.Equals(pos3): {pos1.Equals(pos3)}");

Item item1 = new Item("Sword", 1);
Item item2 = new Item("Sword", 1);
Item item3 = new Item("Shield", 2);

Console.WriteLine($"item1.Equals(item2): {item1.Equals(item2)}");
Console.WriteLine($"item1.Equals(item3): {item1.Equals(item3)}");

HashSet<Item> inventory = new HashSet<Item>();
inventory.Add(item1);
Console.WriteLine($"inventory.Contains(item2): {inventory.Contains(item2)}");

BadItem b1 = new BadItem("Potion");
BadItem b2 = new BadItem("Potion");

Console.WriteLine($"b1.Equals(b2): {b1.Equals(b2)}");

Dictionary<BadItem, int> stock = new Dictionary<BadItem, int>();
stock[b1] = 10;
Console.WriteLine($"stock.ContainsKey(b2): {stock.ContainsKey(b2)}");

List<Monster> monsters = new List<Monster>
{
    new Monster("Goblin", 30),
    new Monster("Dragon", 100),
    new Monster("Slime", 10),
    new Monster("Orc", 50)
};

Console.WriteLine("정렬 전:");
foreach (Monster m in monsters)
{
    Console.WriteLine($"  {m}");
}

monsters.Sort();

Console.WriteLine("정렬 후:");
foreach (Monster m in monsters)
{
    Console.WriteLine($"  {m}");
}

List<Student> students = new List<Student>
{
    new Student("김철수", 2, 85),
    new Student("이영희", 1, 92),
    new Student("박민수", 2, 85),
    new Student("정수진", 1, 88),
    new Student("최동훈", 2, 90),
};

students.Sort();

Console.WriteLine("정렬 결과:");
foreach (Student s in students)
{
    Console.WriteLine($"  {s}");
}

Customer c1 = new Customer("Kim", "Cheolsu");
Customer c2 = new Customer("Kim", "Cheolsu");

Dictionary<Customer, string> dict1 = new Dictionary<Customer, string>();
dict1[c1] = "VIP";
Console.WriteLine($"기본 Dictionary - c2 검색: {dict1.ContainsKey(c2)}");

Dictionary<Customer, string> dict2 = new Dictionary<Customer, string>(new CustomerNameComparer());
dict2[c1] = "VIP";
Console.WriteLine($"커스텀  Dictionary - c2 검색: {dict1.ContainsKey(c2)}");

Dictionary<string, int> caseInsensitive = 
    new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

caseInsensitive["Apple"] = 100;
caseInsensitive["BANANA"] = 200;

Console.WriteLine($"apple 검색: {caseInsensitive["apple"]}");
Console.WriteLine($"Banana 검색: {caseInsensitive["Banana"]}");

Dictionary<string, int> casesensitive = new Dictionary<string, int>();
casesensitive["Apple"] = 100;

Console.WriteLine($"일반 Dictionary에서 'apple' 존재 여부: {casesensitive.ContainsKey("apple")}");

List<Quest> quests = new List<Quest>
{
    new Quest("드래곤 처치", 1, 10000),
    new Quest("약초 수집", 3, 100),
    new Quest("마을 방어", 2, 500),
    new Quest("보물 찾기", 2, 3000)
};

Console.WriteLine("우선순위 기준 정렬:");
quests.Sort(new QuestPriorityComparer());
foreach (Quest quest in quests)
{
    Console.WriteLine($"  {quest}");
}

Console.WriteLine("보상 기준 정렬 (내림차순):");
quests.Sort(new QuestRewardComparer());
foreach (Quest quest in quests)
{
    Console.WriteLine($"  {quest}");
}

string[] fruits = { "apple", "Banana", "CHERRY", "date", "Elderberry" };

Array.Sort(fruits, StringComparer.Ordinal);
Console.WriteLine("Ordinal 정렬 (대소문자 구분):");
Console.WriteLine(String.Join(", ", fruits));

Array.Sort(fruits, StringComparer.OrdinalIgnoreCase);
Console.WriteLine("OrdinalIgnoreCase 정렬:");
Console.WriteLine(String.Join(", ", fruits));

List<Product> products = new List<Product>
{
    new Product("키보드", 50000),
    new Product("마우스", 30000),
    new Product("모니터", 300000),
    new Product("헤드셋", 80000)
};

Comparer<Product> priceAsc = Comparer<Product>.Create(
    (x, y) => x.Price.CompareTo(y.Price)
    );

products.Sort(priceAsc);
Console.WriteLine("가격 오름차순:");
foreach (Product product in products)
{
    Console.WriteLine($"  {product}");
}

Comparer<Product> nameDesc = Comparer<Product>.Create(
    (x, y) => y.Name.CompareTo(x.Name)
    );

products.Sort(nameDesc);
Console.WriteLine("이름 내림차순:");
foreach (Product product in products)
{
    Console.WriteLine($"  {product}");
}

SortedDictionary<int, string> scoreBoard = new SortedDictionary<int, string>(
     Comparer<int>.Create((x, y) => y.CompareTo(x))
    );

scoreBoard[85] = "Kim";
scoreBoard[92] = "Lee";
scoreBoard[78] = "Park";
scoreBoard[92] = "Choi";

Console.WriteLine("점수 순위표:");
int rank = 1;
foreach (KeyValuePair<int, string> entry in scoreBoard)
{
    Console.WriteLine($"  {rank}위: {entry.Value} ({entry.Key}점)");
    rank++;
}

HashSet<Equipment> equippedItems = new HashSet<Equipment>(new EquipmentTypeComparer());

equippedItems.Add(new Equipment("불꽃 검", "무기"));
equippedItems.Add(new Equipment("철 갑옷", "방어구"));
equippedItems.Add(new Equipment("얼음 검", "무기"));
equippedItems.Add(new Equipment("가죽 장갑", "장갑"));


Console.WriteLine("장착된 장비:");
foreach (Equipment e in equippedItems)
{
    Console.WriteLine($"  {e}");
}

int[] numbers = { 1, 2, 3, 4, 5 };
string[] words = { "apple", "banana", "cherry" };

Console.WriteLine($"numbers에 3 포함: {Contains(numbers, 3)}");
Console.WriteLine($"numbers에 10 포함: {Contains(numbers, 10)}");
Console.WriteLine($"words에 'banana' 포함: {Contains(words, "banana")}");
Console.WriteLine($"words에 'grape' 포함: {Contains(words, "grape")}");

static bool Contains<T>(T[] array, T target)
{
    EqualityComparer<T> comparer = EqualityComparer<T>.Default;
    foreach (T item in array)
    {
        if (comparer.Equals(item, target))
        {
            return true; 
        }
    }
    return false;
}