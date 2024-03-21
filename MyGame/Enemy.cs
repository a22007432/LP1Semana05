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

        static int p;

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

        static int GetNumPwrUp()
        {
            return p;
        }

        public void PickupPowerUp(PowerUp powerUp, float f)
        {
            if(powerUp == PowerUp.Health)
            {
                health += f;
                if(health > 100) health = 100;
            }

            if(powerUp == PowerUp.Shield)
            {
                shield += f;
                if(shield > 100) shield = 100;
            }
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