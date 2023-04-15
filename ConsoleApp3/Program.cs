using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var playerHealth = rand.Next(100,500);
            var enemyHealth = rand.Next(500,1000);
            bool rashamon = false;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Заклинания: \nРашамон – призывает теневого духа для нанесения атаки (Отнимает 100 хп игроку) " +
                    "\nХуканзакура (Может быть выполнен только после призыва теневого духа), наносит 100 ед. урона " +
                    "\nМежпространственный разлом – позволяет скрыться в разломе и восстановить 250 хп. Урон босса по вам не проходит");
                string playerSpell = Console.ReadLine();
                switch (playerSpell)
                {
                    case "Рашамон":
                        Console.Clear();
                        Console.WriteLine($"Вы призвали духа, у вас осталось {playerHealth-100} здоровья");
                        playerHealth -= 100;
                        Console.WriteLine($"Босс наносит ответную атаку! Огненый шар снял вам 50 здоровья! у вас осталось {playerHealth - 50} здоровья");
                        playerHealth -= 50;
                        rashamon = true;
                        break;
                    case "Хуканзура":
                        Console.Clear();
                        if (rashamon == true)
                        {
                            Console.WriteLine($"Ваш дух бьёт босса и наносит 100 урона. Здоровье босса сейчас {enemyHealth-100}"); ;
                            enemyHealth -= 100;
                            Console.WriteLine($"Босс наносит ответную атаку и сносит вам 25 здоровья. У вас осталось {playerHealth-25} хп");
                            playerHealth -= 25;
                        }
                        else
                            Console.WriteLine("Вы не призвали духа!");
                            break;
                    case "Межпространственный разлом":
                        Console.Clear();
                        Console.WriteLine($"Вы скрылись в разломе и восстановили 250 здоровья. Ваше здоровье: {playerHealth+250}");
                        playerHealth += 250;
                        Console.WriteLine("Босс не смог по вам попасть.");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такого заклинания нет.");
                        break;
                }
                
            }
                if (playerHealth <= 0)
                        Console.WriteLine("Вы проиграли!");
                else
                    Console.WriteLine("Вы победили!");
        }

    }

}


