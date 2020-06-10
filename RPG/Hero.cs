using System;

namespace RPG
{
    public class Hero
    {   
        Random random = new Random();
        public string heroClass;
        public string skillName;
        public bool buf = false;
        public string bufName;
        public int bufDamage;
        public int sleepTime = 0;
        public int maxHealth;
        
        public Hero()
        {
            Health = random.Next(100,200);
            maxHealth = Health;
            Name = Names[random.Next(0,40)];
            Strength = random.Next(10,50);
        }

        public static string[] Names = new string[40]{
            "Ylfat",
            "Gayaz",
            "Mergen",
            "Salih",
            "Hayrat",
            "Salavat",
            "Hattab",
            "Fidel",
            "Mirgalim",
            "Zamam",
            "Zayd",
            "Habib",
            "Azamat",
            "Artyr",
            "Afzal",
            "Amir",
            "Danis",
            "Bayan",
            "Alim",
            "Karim",
            "Rizvan",
            "Shafik",
            "Rasim",
            "Rafail",
            "Ramil",
            "Mars",
            "Naki",
            "Hotaka",
            "Kisho",
            "Yuu",
            "Nikki",
            "Katsuo",
            "Kichiro",
            "Marise",
            "Rinji",
            "Montaro",
            "Mamoru",
            "Ryuu",
            "Takumi",
            "Rafu",
        };
        public string Name { get; protected set; }
        public int Strength { get; protected set; }
        public int Health { get; set; }
        
        public virtual int Skill()
        {
            return 0;
        }

        public int Atack()
        {
            return random.Next(1, Strength);
        }

        public void GetDamage(int damage)
        {
            Health -= damage;
        }
    }
}
