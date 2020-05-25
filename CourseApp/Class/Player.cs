using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Player
    {
        private List<string> sampleNames = new List<string>() { "John", "James", "Arthur", "Samplename", "Nick", "Victor" };

        public Player()
        {
            Name = SetName();
            Active = new List<ISpell>();
            Passive = new List<ISpell>();
        }

        public int PlayerMaxHp { get; set; }

        public string Name { get; set; }

        public string ClassName { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int CurrentHp { get; set; }

        public bool IsStunned { get; set; }

        public List<ISpell> Active { get; set; }

        public List<ISpell> Passive { get; set; }

        public int MaxHp
        {
            get { return this.PlayerMaxHp; }
            set { this.PlayerMaxHp = 100 + (this.Strength / 2); }
}

        public string SetName()
        {
            Random rnd = new Random();

            return sampleNames[rnd.Next(0, 5)];
        }

        public void Attack(Player target)
        {
            Random rnd = new Random();
            ISpell choise = this.Active[rnd.Next(0, this.Active.Count)];
            choise.Use(this, target);
        }

        public void SetFullHp()
        {
            this.CurrentHp = 5 + (this.Strength / 2);
        }

        public void SetClassName(string name)
        {
            this.ClassName = name;
        }

        public void GetDamage(int dmg)
        {
            this.CurrentHp = this.CurrentHp - dmg;
        }
    }
}