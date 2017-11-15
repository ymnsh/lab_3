﻿using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor.Commands
{
    class PointCommand : ICommand
    {
        Application app;
        Picture picture;

        public PointCommand(Application app, Picture picture)
        {
            this.app = app;
            this.picture = picture;
        }

        public string Name { get { return "point"; } }

        public string Description
        {
            get
            {
                return "Чтобы нарисовать точку, введите: \n" + 
                    "point x y \nгде x - координата по оси Ox, y - координата по оси Oy";
            }
        }

        public string Help
        {
            get
            {
                return "Рисование точки";
            }
        }


        public string[] Synonyms
        {
            get
            {
                return new string[] { "tochka", "pnt" };
            }
        }

        public void Execute(params string[] parameters)
        {
            
        }
    }
}