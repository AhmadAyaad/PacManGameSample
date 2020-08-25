using PacManGameSample;
using PacManGameSample.Box_Factory;
using PacManGameSample.Key_Factory;
using System;

namespace PacManGameSample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creation Objs

            //creating Map
            Map map = new Map();

            //Creating Player
            Player player = Player.GetPlayer();
            player.Map = map;
            player.Walk(new Cell(1, 1));

            //Creating Enemy
            Enemy enemy = new Enemy(new Cell(5, 5));

            //Creating BronzeKey
            IkeyCreator keyCreator = new BronzeKeyCreator();
            var bronzeKey = keyCreator.CreateKey();
            bronzeKey.Cell = new Cell(2, 3);

            //Creating GoldenKey
            keyCreator = new GoldenKeyCreator();
            var goldenKey = keyCreator.CreateKey();
            goldenKey.Cell = new Cell(7, 8);

            //Creating SilverKey
            keyCreator = new SilverKeyCreator();
            var silverKey = keyCreator.CreateKey();
            silverKey.Cell = new Cell(12, 0);


            //Creating BronzeBox
            IBoxCreator boxCreator = new BronzeBoxCreator();
            var bronzeBox = boxCreator.CreateBox();
            bronzeBox.Cell = new Cell(1, 13);

            //Creating GoldenBox
            boxCreator = new GoldenBoxCreator();
            var goldenBox = boxCreator.CreateBox();
            goldenBox.Cell = new Cell(12, 1);

            //Creating SilverBox
            boxCreator = new SilverBoxCreator();
            var silverBox = boxCreator.CreateBox();
            silverBox.Cell = new Cell(0, 1);

            #endregion


            player.Ikey = bronzeKey;
            player.Walk(bronzeBox.Cell);
            bronzeBox.DoMagic(10, player);


            if (player.playerCell.Equals(silverBox.Cell) && silverBox.HasKey(player))
            {
                Box box = new Box(boxCreator.CreateBox());
                player.BoxStrategy = box.BoxStrategy;

            }
            else if (player.playerCell.Equals(goldenBox.Cell) && bronzeBox.HasKey(player))
            {
                boxCreator = new GoldenBoxCreator();
                Box box = new Box(boxCreator.CreateBox());
                player.BoxStrategy = box.BoxStrategy;
            }
            else if (player.playerCell.Equals(bronzeBox.Cell) && goldenBox.HasKey(player))
            {
                boxCreator = new BronzeBoxCreator();
                Box box = new Box(boxCreator.CreateBox());
                player.BoxStrategy = box.BoxStrategy;

            }

            enemy.DecreaseHealth(player);



        }
    }




}