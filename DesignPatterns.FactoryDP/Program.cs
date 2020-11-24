
using System;
using DesignPatterns.FactoryDP.Enums;
using DesignPatterns.FactoryDP.Models;
using System.Linq;

namespace DesignPatterns.FactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ödeme işlemi için bir kart seçiniz");

            foreach (var cardType in Enum.GetNames(typeof(CardTypes)).ToList().Select((x, y) => new { x, y}))
            {
                Console.WriteLine($"{cardType.y}={cardType.x}");
            }
            /*
             var result=Enum.GetValues(typeof(CardTypes))

            foreach (var item in result)
            {
                Console.WriteLine($"{(int)item}={item}");
            }          
            */

            Console.Write( "Lütfen bir değer giriniz: ");
            string value = Console.ReadLine().Trim();
            CardTypes? _cardType = null;
            ICreditCard _card = null;
            _cardType = value switch
            {
                "1" => CardTypes.MoneyBack,
                "2" => CardTypes.Titanium,
                "3" => CardTypes.Platinum,
                "4" => CardTypes.Gold,
                "5" => CardTypes.Silver,
                _ => CardTypes.None
            };
            /*
            switch(_cardType)
            {
                case CardTypes.MoneyBack:
                    {
                        _card = new MoneyBack();
                        break;
                    }
                case CardTypes.Titanium:
                    {
                        _card = new Titanium();
                        break;
                    }
                case CardTypes.Platinum:
                    {
                        _card = new Platinum();
                        break;
                    }
                case CardTypes.Gold:
                    {
                        _card = new Gold();
                        break;
                    }
                case CardTypes.Silver:
                    {
                        _card = new Silver();
                        break;
                    }
            }
            */

            _card = _cardType switch
            {
                CardTypes.MoneyBack=> new MoneyBack(),
                CardTypes.Titanium => new Titanium(),
                CardTypes.Platinum => new Platinum(),
                CardTypes.Gold => new Gold(),
                CardTypes.Silver => new Silver(),
                _ => null
            };

            Console.Clear();

            if (_card!=null)
            {
                Console.WriteLine($"Credit Card Type         : {_card.GetCardTypes()}");
                Console.WriteLine($"Credit Card Limit        : {_card.GetCreditLimit()}");
                Console.WriteLine($"Credit Card AnnualCharge : {_card.GetAnnualCharge()}");
            }
            
        }
    }
}
