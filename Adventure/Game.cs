using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Game
    {
        //set false to end game.
        private bool doGameLoop = true;

        //Constructor
        public Game(Player player, World world)
        {

        }

        //Gameloop
        public void GameLoop()
        {
            while (doGameLoop)
            {

            }
        }

        //Combat Code
        public void Battle(Character Fighter1, Character Fighter2)
        {

        }

        //Saves the game
        public void SaveGame()
        {

        }
    }

    class Character
    {
        //Constructor
        public Character()
        {

        }

        //stats


        //actions

    }

    class Player : Character
    {
        //x and y location
        private int[] location = new int[2];

        //Constructor
        public Player()
        {

        }

        //Inventory


        //Player-only actions


    }

    class World
    {
        public World()
        {

        }
    }

    class Tile
    {

    }
}
