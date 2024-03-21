using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;

        private float shield;

        //construct
        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }

        //checks if name is more than 8 chars and deletes the extras
        public string SetName(string nametoset)
        {
            if(nametoset.Length > 8)
            {
                name = nametoset.Remove(8);

                return name;
            }
            else
            {
                name = nametoset;
                return name;
            }
            
            
        }

        //Overload as a failsafe 
        public string SetName()
        {
            return name;
            
        }

        
        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float penetrationdmg = -shield;
                shield = 0;
                health -= penetrationdmg;
                if(health < 0) health = 0;
            }
        }
    }
}