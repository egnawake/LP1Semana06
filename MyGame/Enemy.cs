namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
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
            if (shield < 0)
            {
                // get excess damage
                float damageToInflict = -shield;

                // empty shield
                shield = 0;

                // deal excess damage to health
                health -= damageToInflict;

                // empty health
                if (health < 0)
                    health = 0;
            }
        }
    }
}
