using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roulette_game.Properties
{
    public class Game_logic
    {
        public int load_position { get; set; }
        public int spin_position { get; set; }
        public int shoot_position { get; set; }
        public int shootaway_data { get; set; }
        public int chances = 0;
        public int Shoot_method()
        {
            if (load_position == spin_position)
            {
                return 1;
            }
            else if (spin_position == 6)
            {
                spin_position = 1;
                return 0;
            }
            else
            {
                spin_position++;
                return 0;
            }

        }
    }

}




