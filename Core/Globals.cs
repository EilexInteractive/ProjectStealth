using System;
using System.Collections.Generic;
using Raylib_cs;

namespace EilexFramework
{
    public static class Globals
    {
        public static string GenerateID()
        {
            string id = "";
            string[] characters = {"A", "B", "C", "D", "E", "F", "a", "b", "c", "d", "e", "f", "0", "1", "2", "3", "4", "5", "!", "@", "#",
                "$", "%", "_", "-" };

            int idLength = Raylib.GetRandomValue(4, 8);

            for(int i = 0; i < idLength; i++)
            {
                int val = Raylib.GetRandomValue(0, characters.Length - 1);
                string randomCharacter = characters[val];
                if(randomCharacter != null)
                {
                    id += randomCharacter;
                }
            }

            return id;

        }
    }
}