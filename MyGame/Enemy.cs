namespace MyGame
{
    public class Enemy
    {
        private static int totalCollectedPowerups;

        private string name;
        private float health;
        private float shield;

        static Enemy()
        {
            totalCollectedPowerups = 0;
        }

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public static int GetTotalCollectedPowerups()
        {
            return totalCollectedPowerups;
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

        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        private void SetHealth(float value)
        {
            health = value > 100 ? 100 : value;
        }

        private void SetShield(float value)
        {
            shield = value > 100 ? 100 : value;
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

        public void PickupPowerUp(PowerUp type, float value)
        {
            if (type == PowerUp.Health)
            {
                SetHealth(GetHealth() + value);
            }
            else if (type == PowerUp.Shield)
            {
                SetShield(GetShield() + value);
            }
        }
    }
}
