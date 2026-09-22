using UnityEngine;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        public string id;
        private Vector3 position;
        protected int health;
        // TODO: Implement fields and methods according to Class Diagram

        public virtual void Update()
        {

        }

        public virtual void TakeDamage(int damage)
        {

        }

        private void Move(Vector3 direction)
        {

        }
    }
}
