using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace ProjectoAvionCLASES{
    class avion:SPRITE
    {


        private Point velocidad = new Point(7, 0);

        private Point ladoIZQUIEDO = new Point(100, 650);
        private Point ladoDERECHO = new Point(1500, 650);



        Game1 ruta;
        KeyboardState previoestado;

        FUEGO fuego;

        public avion(Game1 Laruta, Point laposicion) : base(laposicion, new Point(200, 150))
        {
            this.ruta = Laruta;
            Posicion = laposicion;
            
            imagen1 = "1nave";

            this.LoadContent();
        }
        private void LoadContent()
        {
            imagen = this.ruta.Content.Load<Texture2D>(imagen1);
        }
        private void MoverIquierda()
        {
            Posicion -= velocidad;
        }
        private void MoverDerecha()
        {
            Posicion += velocidad;
        }
        private void Shoot()
        {
            fuego = new FUEGO(Posicion, ruta);
        }
        public void Update(GameTime gameTime)
        {
            KeyboardState KState = Keyboard.GetState();
            if (KState.IsKeyDown(Keys.Left))//izqierda
            {
                if(Posicion != ladoIZQUIEDO)
                {
                    MoverIquierda();
                }
                    
            
                
            }
            else if (KState.IsKeyDown(Keys.Right))//derecha
            {
                if(Posicion != ladoDERECHO)
                {
                    MoverDerecha();
                }
                
            }
            else if (KState.IsKeyDown(Keys.Space) && !previoestado.IsKeyDown(Keys.Space))
            {
                Shoot();
                fuego.sonido.Play();
            }
            if (fuego != null)
            {
                fuego.Update(gameTime);
                
            }

         

            rectangulo.Location = Posicion;
            previoestado = KState;
            
        }


    }
}
