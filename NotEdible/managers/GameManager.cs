using NotEdible.models;

namespace NotEdible.managers
{
    public class GameManager
    {
        Map map = new Map();

        public void Update()
        {
            InputManager.Update();
        }

        public void Draw()
        {
            map.Draw();
        }
    }
}
