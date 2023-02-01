namespace BOSSMONSTER;
{
    using System;
    using System.Collections.Generic;

    public class Class1
    {

    using System;
    using System.Collections.Generic;

    namespace CardGame
    {
        class Program
        {
            static void Main(string[] args)
            {
                System.Collections.Generic.List<ICard> deck = new System.Collections.Generic.List<ICard>();
                deck.Add(new IHeroCard(HeroMage, HeroWarrior, HeroEpic));
                deck.Add(new IRoomCard(" "));
                deck.Add(new IBossMonsterCard("Mad Man"));
                deck.Add(new IAdvancedRoomCard("Trap Room", 10, 5, 3));
                deck.Add(new IMagicCard(FireBallCard, );

                foreach (Card card in deck)
                {
                    Console.WriteLine(card.GetInfo());
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }

        abstract class Card //abstract namespace?
        {
            public string Name { get; set; }

            public Card(string name)
            {
                Name = name;
            }

            public abstract string GetInfo();
        }
    }
}