using System;


namespace MyGame
{
    class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int powerUpCount;

        static Enemy()
        {
            powerUpCount = 0;
        }

        public static int GetPowerupCount()
        {
            return powerUpCount;
        }



        public Enemy(String name) // Construtor
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

/*        public Enemy(String name, float health, float shield)
        {
            this.name = name;
            this.health = health;
            this.shield = shield;
        } */


        public string GetName() => name;

        public void SetName(string name) // Retira os espaços do nome
        {
            this.name = name.Trim();
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield() => shield;

        public void TakeDamage(float Damage)
        {
            shield -= Damage;
            if (shield<0)
            {
                float DamageLeft = -shield;
                shield = 0;
                health -= DamageLeft;
                if (health <0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float gain)
        {
            powerUpCount++;

            if (powerUp == PowerUp.Health)
            {
                health += gain;
                if ( health > 100) health = 100;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += gain;
                if (shield > 100) shield = 100;
            }
        }

        

    }
}