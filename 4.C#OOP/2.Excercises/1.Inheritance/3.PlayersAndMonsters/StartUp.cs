namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Gogi", 3);
            System.Console.WriteLine(hero);
            Elf elf = new Elf("Elfi", 2);
            System.Console.WriteLine(elf);

        }
    }
}