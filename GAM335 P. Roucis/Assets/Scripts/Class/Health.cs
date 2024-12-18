using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace unity
{

    public class Health : MonoBehaviour
    {
     // Start is called before the first frame update

        public int MaxHealth;
        public int Healthbar
        {
            get
            {
                return m_health;
            }
            set
            {
                m_health = value;
                OnHealthChanged?.Invoke(HealthRatio);
            }
        }
        private int m_health;
        private float HealthRatio => (float)m_health / (float)MaxHealth;
        public bool hasMaxHealth => m_health >= MaxHealth;

        public bool isDead => m_health >= 0;

        public UnityAction<float> OnHealthChanged;

        public UnityAction<int, GameObject> OnDamaged;

        public UnityAction<int, GameObject> OnHeal;

        public UnityAction OnDied;

        void Start()
        {
            m_health = MaxHealth;
        }

        public void TakeDamage(int amount, GameObject instigator)
        {
            if (isDead)
            {
                return;
            }
            int oldHealth = Healthbar;
            Healthbar = Mathf.Clamp(Healthbar - amount, 0, Healthbar); //Mathf.clamp = make sure value is between 0 and max health

            int damageTotal = oldHealth - m_health;
            if (damageTotal > 0)
            {
                OnDamaged?.Invoke(damageTotal, instigator);
            }


            if (isDead)
            {
                OnDied?.Invoke();
            }
        }


        
    }
}
