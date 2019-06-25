using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Generator
{
    public sealed class ClothingData
    {
        private ClothingData() {
            //NP : no preference
            PieceOfClothing blackDenimJacket = new PieceOfClothing("J", "NP", "Black Denim Jacket");
            PieceOfClothing denimJacket = new PieceOfClothing("J", "NP", "Blue Denim Jacket");
            PieceOfClothing leatherJacket = new PieceOfClothing("J", "NP", "Leather Jacket");
            Jackets.Add(blackDenimJacket);
            Jackets.Add(denimJacket);
            Jackets.Add(leatherJacket);

            PieceOfClothing darkBlueCollarShortSleevedShirt = new PieceOfClothing("SSS", "B", "Dark Blue Collared Short Sleeve Shirt");
            BSSShirts.Add(darkBlueCollarShortSleevedShirt);
            BLSShirtsAndBSSShirts.Add(darkBlueCollarShortSleevedShirt);

            PieceOfClothing lSS1 = new PieceOfClothing("LSS", "B", "Long Sleeved Jean Shirt");
            BLSShirtsAndBSSShirts.Add(lSS1);
            BLSShirts.Add(lSS1);

            PieceOfClothing tightKahkiPants = new PieceOfClothing("P", "B", "Tight Kahki Pants");
            BPants.Add(tightKahkiPants);

            PieceOfClothing brownDressShoes = new PieceOfClothing("S", "B", "Brown Dress Shoes");
            BShoes.Add(brownDressShoes);
        }

        private static ClothingData instance = null;

        public static ClothingData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClothingData();
                }
                return instance;
            }
        }

        public ArrayList Jackets { get; set; } = new ArrayList();
        public ArrayList TTops { get; set; } = new ArrayList();
        public ArrayList TTopsAndCSSShirts { get; set; } = new ArrayList();
        public ArrayList BSSShirts { get; set; } = new ArrayList();
        public ArrayList CSSShirts { get; set; } = new ArrayList();
        public ArrayList SweatShirts { get; set; } = new ArrayList();
        public ArrayList CLSShirts { get; set; } = new ArrayList();
        public ArrayList BLSShirts { get; set; } = new ArrayList();
        public ArrayList CLSShirtsAndcSSShirts { get; set; } = new ArrayList();
        public ArrayList SweatShirtsAndCLSShirts { get; set; } = new ArrayList();
        public ArrayList BLSShirtsAndBSSShirts { get; set; } = new ArrayList();
        public ArrayList BPants { get; set; } = new ArrayList();
        public ArrayList Jeans { get; set; } = new ArrayList();
        public ArrayList Sweatpants { get; set; } = new ArrayList();
        public ArrayList AllPants { get; set; } = new ArrayList();
        public ArrayList AllPantsAndShorts { get; set; } = new ArrayList();
        public ArrayList AllShorts { get; set; } = new ArrayList();
        public ArrayList SweatpantsAndSShorts { get; set; } = new ArrayList();
        public ArrayList BPantsAndBShorts { get; set; } = new ArrayList();
        public ArrayList SShorts { get; set; } = new ArrayList();
        public ArrayList BShoes { get; set; } = new ArrayList();
        public ArrayList CShoes { get; set; } = new ArrayList();
        public ArrayList SShoes { get; set; } = new ArrayList();
    }
}
