﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT111L_Game
{
    internal class Door
    {
        private Label door;

        public Label createDoor(int x, int y)
        {
            door = new Label
            {
                Name = "door",
                Tag = "door",
                Size = new Size(50, 50),
                Location = new Point(x, y),
                Image = Resources.door


            };

            return door;
        }


    }
}
