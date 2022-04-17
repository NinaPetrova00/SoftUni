using System;
using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private readonly double baseHealth;

        private readonly double baseArmor;

        protected readonly double abilityPoints;

        private double health;

        private double armor;
        public string Name { get; }

        public double BaseArmor
        {
            get => this.baseArmor;
        }

        public double BaseHealth
        {
            get => this.baseHealth;
        } 
        public double AbilityPoints
        {
            get => this.abilityPoints;
        }

        public double Health
        {
            get => this.health;
            set
            {

                if (value < 0)
                {
                    this.health = 0;
                }
                else if (value > baseHealth)
                {
                    this.health = baseHealth;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public double Armor
        {
            get => this.armor;

            set
            {
                if (value < 0)
                {
                    this.armor = 0;
                }
                else
                {
                    this.armor = value;
                }
            }
        }

        public IBag Bag { get; }

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
            }

            this.Name = name;
            this.baseHealth = health;
            this.Health = health;
            this.baseArmor = armor;
            this.Armor = armor;
            this.abilityPoints = abilityPoints;
            this.Bag = bag;
        }
        public bool IsAlive { get; set; } = true;

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public virtual void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();
            double healthReduce = hitPoints - this.Armor;
            this.Armor -= hitPoints;

            if (healthReduce > 0)
            {
                this.Health -= healthReduce;
            }

            if (this.Health == 0)
            {
                this.IsAlive = false;
            }
        }

        public virtual void UseItem(Item item)
        {
            this.EnsureAlive();

            item.AffectCharacter(this);
        }
    }
}