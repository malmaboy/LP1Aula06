using System;


namespace MyGame
{
    class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(String name) // Construtor
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }

        public Enemy(String name, float health, float shield)
        {
            this.name = name;
            this.health = health;
            this.shield = shield;
        }


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
        

    }
}