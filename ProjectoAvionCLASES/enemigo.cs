using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace ProjectoAvionCLASES
{
    class enemigo :SPRITE //LLAMADA DE LA OTRA CLASE HERENCIA
    {
        Game1 ruta;
        Point velocidad;
        public enemigo(Game1 Laruta, Point laposicion) : base(laposicion, new Point(100, 150))//LLAMDA DEL CONTRUCTOR ANTERIOR
        {
            this.ruta = Laruta;
            this.velocidad = new Point(5, 0);
            this.imagen1 = "alien";
            
            this.LoadContent();
        }
        public void LoadContent()
        {
            imagen = this.ruta.Content.Load<Texture2D>(imagen1);
        }
        public void Update(GameTime gameTime)
        {

            if (rectangulo.Y > 0)
            {
                rectangulo.Y = rectangulo.Y + 9;
            }
            if(rectangulo.Y >900)
            {
                rectangulo.Y = 100;
            } 
        }



    }
}
