using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace ProjectoAvionCLASES
{
    class FUEGO
    {
        public Point Posicion { get; set; }
        private Point size { get; set; }



        private Point velocidad = new Point(0, 20);

          public SoundEffect sonido;

        private const string imagen1 = "fuego1";
        Texture2D imagen;
        Rectangle rectangulo;

        Game1 ruta;

        public FUEGO(Point inicioposicion, Game1 laruta) 
        {
            Posicion = inicioposicion;
            size = new Point(30);
            rectangulo = new Rectangle(Posicion, size);
            ruta = laruta;
            this.LoadContent();
        }
        private void Mover()
        {
            Posicion -= velocidad;
           
        }
        private void LoadContent()
        {
            imagen = this.ruta.Content.Load<Texture2D>(imagen1);
            sonido = this.ruta.Content.Load<SoundEffect>("sonido1");
        }
        public void Update(GameTime game)
        {
            Mover();
            rectangulo.Location = Posicion;


        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {


            spriteBatch.Draw(imagen, rectangulo, Color.White);


        }
    }
}
