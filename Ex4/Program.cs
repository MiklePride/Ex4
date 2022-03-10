class program
{ 
    static void Main(string[] args)
    {
        string name;
        string age;
        string job;
        string favoriteSongArtist;
        string zodiacalSing;

        Console.WriteLine("Как вас зовут?");
        name = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        age = Console.ReadLine();
        Console.WriteLine("Кем вы работаете?");
        job = Console.ReadLine();
        Console.WriteLine("Какая ваша любимая песня?");
        favoriteSongArtist = Console.ReadLine();
        Console.WriteLine("Какой ваш знак зодиака?");
        zodiacalSing = Console.ReadLine();
        Console.WriteLine("Меня зовут {0},\nМне {1} лет,\nЯ работаю {2},\nМоя любимая песня {3},\nМой знак зодиака {4}", name, age, job, favoriteSongArtist, zodiacalSing);

    }

}
