using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BoardChitless.Shared.DataContracts;

namespace BoardChitless.Tests.Common
{
    public static class Staging
    {

        public static GameFamily CreateTestGameFamily()
        {

            var returnGameFamily = new GameFamily
            {
                name = "Test Game Family",
                addedBy = "Chris",
                isActive = 1
            };

            return returnGameFamily;

        }


        public static rawStorage CreateTestRawStorage()
        {

            var returnVar = new rawStorage
            {
                TheBlob = "THE BLOB IS THE BLOB",
                addedBy = "Chris",
                isActive = 1
            };

            return returnVar;

        }

        public static string getBoardGame()
        {

            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?> <items termsofuse=\"http://boardgamegeek.com/xmlapi/termsofuse\">     <item type=\"boardgame\" id=\"822\">         <thumbnail>//cf.geekdo-images.com/images/pic2337577_t.jpg</thumbnail>         <image>//cf.geekdo-images.com/images/pic2337577.jpg</image>         <name type=\"primary\" sortindex=\"1\" value=\"Carcassonne\" />         <name type=\"alternate\" sortindex=\"1\" value=\"Carcassonne Jubilee Edition\" />         <name type=\"alternate\" sortindex=\"1\" value=\"Carcassonne: Plus\" />         <description>Carcassonne is a tile-placement game in which the players draw and place a tile with a piece of southern French landscape on it. The tile might feature a city, a road, a cloister, grassland or some combination thereof, and it must be placed adjacent to tiles that have already been played, in such a way that cities are connected to cities, roads to roads, etcetera. Having placed a tile, the player can then decide to place one of his meeples on one of the areas on it: on the city as a knight, on the road as a robber, on a cloister as a monk, or on the grass as a farmer. When that area is complete, that meeple scores points for its owner.&amp;#10;&amp;#10;During a game of Carcassonne, players are faced with decisions like: &amp;quot;Is it really worth putting my last meeple there?&amp;quot; or &amp;quot;Should I use this tile to expand my city, or should I place it near my opponent instead, giving him a hard time to complete his project and score points?&amp;quot; Since players place only one tile and have the option to place one meeple on it, turns proceed quickly even if it is a game full of options and possibilities.&amp;#10;&amp;#10;</description>         <yearpublished value=\"2000\" />         <minplayers value=\"2\" />         <maxplayers value=\"5\" />         <poll name=\"suggested_numplayers\" title=\"User Suggested Number of Players\" totalvotes=\"1344\">             <results numplayers=\"1\">                 <result value=\"Best\" numvotes=\"4\" />                 <result value=\"Recommended\" numvotes=\"34\" />                 <result value=\"Not Recommended\" numvotes=\"741\" />             </results>             <results numplayers=\"2\">                 <result value=\"Best\" numvotes=\"703\" />                 <result value=\"Recommended\" numvotes=\"463\" />                 <result value=\"Not Recommended\" numvotes=\"77\" />             </results>             <results numplayers=\"3\">                 <result value=\"Best\" numvotes=\"564\" />                 <result value=\"Recommended\" numvotes=\"599\" />                 <result value=\"Not Recommended\" numvotes=\"27\" />             </results>             <results numplayers=\"4\">                 <result value=\"Best\" numvotes=\"365\" />                 <result value=\"Recommended\" numvotes=\"693\" />                 <result value=\"Not Recommended\" numvotes=\"102\" />             </results>             <results numplayers=\"5\">                 <result value=\"Best\" numvotes=\"123\" />                 <result value=\"Recommended\" numvotes=\"543\" />                 <result value=\"Not Recommended\" numvotes=\"370\" />             </results>             <results numplayers=\"5+\">                 <result value=\"Best\" numvotes=\"23\" />                 <result value=\"Recommended\" numvotes=\"149\" />                 <result value=\"Not Recommended\" numvotes=\"638\" />             </results>         </poll>         <playingtime value=\"45\" />         <minplaytime value=\"30\" />         <maxplaytime value=\"45\" />         <minage value=\"8\" />         <poll name=\"suggested_playerage\" title=\"User Suggested Player Age\" totalvotes=\"379\">             <results>                 <result value=\"2\" numvotes=\"2\" />                 <result value=\"3\" numvotes=\"0\" />                 <result value=\"4\" numvotes=\"2\" />                 <result value=\"5\" numvotes=\"21\" />                 <result value=\"6\" numvotes=\"103\" />                 <result value=\"8\" numvotes=\"181\" />                 <result value=\"10\" numvotes=\"54\" />                 <result value=\"12\" numvotes=\"12\" />                 <result value=\"14\" numvotes=\"3\" />                 <result value=\"16\" numvotes=\"1\" />                 <result value=\"18\" numvotes=\"0\" />                 <result value=\"21 and up\" numvotes=\"0\" />             </results>         </poll>         <poll name=\"language_dependence\" title=\"Language Dependence\" totalvotes=\"420\">             <results>                 <result level=\"1\" value=\"No necessary in-game text\" numvotes=\"412\" />                 <result level=\"2\" value=\"Some necessary text - easily memorized or small crib sheet\" numvotes=\"6\" />                 <result level=\"3\" value=\"Moderate in-game text - needs crib sheet or paste ups\" numvotes=\"1\" />                 <result level=\"4\" value=\"Extensive use of text - massive conversion needed to be playable\" numvotes=\"0\" />                 <result level=\"5\" value=\"Unplayable in another language\" numvotes=\"1\" />             </results>         </poll>         <link type=\"boardgamecategory\" id=\"1035\" value=\"Medieval\" />         <link type=\"boardgamecategory\" id=\"1086\" value=\"Territory Building\" />         <link type=\"boardgamemechanic\" id=\"2080\" value=\"Area Control / Area Influence\" />         <link type=\"boardgamemechanic\" id=\"2002\" value=\"Tile Placement\" />         <link type=\"boardgamefamily\" id=\"2\" value=\"Carcassonne\" />         <link type=\"boardgamefamily\" id=\"11006\" value=\"Country: France\" />         <link type=\"boardgameexpansion\" id=\"167903\" value=\"20 Jahre Darmstadt Spielt\" />         <link type=\"boardgameexpansion\" id=\"31784\" value=\"Carcassonne: Abbey &amp; Mayor\" />         <link type=\"boardgameexpansion\" id=\"167744\" value=\"Carcassonne: Bonusplättchen Spiel 2014\" />         <link type=\"boardgameexpansion\" id=\"186143\" value=\"Carcassonne: Bonusplättchen Spiel 2015\" />         <link type=\"boardgameintegration\" id=\"45748\" value=\"Carcassonne: Wheel of Fortune\" />         <link type=\"boardgamecompilation\" id=\"142057\" value=\"Carcassonne Big Box\" />         <link type=\"boardgamecompilation\" id=\"141008\" value=\"Carcassonne Big Box 2\" />         <link type=\"boardgameimplementation\" id=\"6779\" value=\"The Ark of the Covenant\" />         <link type=\"boardgameimplementation\" id=\"163370\" value=\"Carcassonne: Gold Rush\" />         <link type=\"boardgameimplementation\" id=\"4390\" value=\"Carcassonne: Hunters and Gatherers\" />         <link type=\"boardgamedesigner\" id=\"398\" value=\"Klaus-Jürgen Wrede\" />         <link type=\"boardgameartist\" id=\"74\" value=\"Doris Matthäus\" />         <link type=\"boardgameartist\" id=\"43873\" value=\"Anne Pätzke\" />         <link type=\"boardgameartist\" id=\"14057\" value=\"Chris Quilliams\" />         <link type=\"boardgamepublisher\" id=\"1511\" value=\"Ventura Games\" />         <link type=\"boardgamepublisher\" id=\"538\" value=\"Z-Man Games\" />     </item> </items>";

            return xml;

        }


        public static string searchGames()
        {
            var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><items total=\"10\" termsofuse=\"http://boardgamegeek.com/xmlapi/termsofuse\"><item type=\"boardgame\" id=\"172225\"><name type=\"primary\" value=\"Exploding Kittens\"/><yearpublished value=\"2015\" /></item></items>";
            return xml;
        }

    }
}
