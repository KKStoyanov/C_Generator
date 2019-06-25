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
        private ArrayList jackets = new ArrayList();
        private ArrayList tTops = new ArrayList();
        private ArrayList tTopsAndCSSShirts = new ArrayList(); //tank tops and casual short sleeved shirts
        private ArrayList bSSShirts = new ArrayList(); //business short sleeved shirts
        private ArrayList cSSShirts = new ArrayList(); //casual short sleeved shirts
        private ArrayList sweatShirts = new ArrayList();
        private ArrayList cLSShirts = new ArrayList(); //casual long sleeved shirts
        private ArrayList bLSShirts = new ArrayList(); //business long sleeved shirts
        private ArrayList cLSShirtsAndcSSShirts = new ArrayList(); //casual long sleeved shirts and casual short sleeved shirts
        private ArrayList sweatShirtsAndCLSShirts = new ArrayList(); //sweatshirts and casual long sleeved shirts
        private ArrayList bLSShirtsAndBSSShirts = new ArrayList(); //business long sleeved shirts and business short sleeved shirts
        private ArrayList bPants = new ArrayList();
        private ArrayList jeans = new ArrayList();
        private ArrayList sweatpants = new ArrayList();
        private ArrayList allPants = new ArrayList();
        private ArrayList allPantsAndShorts = new ArrayList();
        private ArrayList allShorts = new ArrayList();
        private ArrayList sweatpantsAndSShorts = new ArrayList();
        private ArrayList bPantsAndBShorts = new ArrayList();
        private ArrayList sShorts = new ArrayList();
        private ArrayList bShoes = new ArrayList();
        private ArrayList cShoes = new ArrayList();
        private ArrayList sShoes = new ArrayList();

        private ClothingData() {
            //NP : no preference
            PieceOfClothing blackDenimJacket = new PieceOfClothing("J", "NP", "Black Denim Jacket");
            PieceOfClothing denimJacket = new PieceOfClothing("J", "NP", "Blue Denim Jacket");
            PieceOfClothing leatherJacket = new PieceOfClothing("J", "NP", "Leather Jacket");
            jackets.Add(blackDenimJacket);
            jackets.Add(denimJacket);
            jackets.Add(leatherJacket);

            PieceOfClothing darkBlueCollarShortSleevedShirt = new PieceOfClothing("SSS", "B", "Dark Blue Collared Short Sleeve Shirt");
            bSSShirts.Add(darkBlueCollarShortSleevedShirt);
            bLSShirtsAndBSSShirts.Add(darkBlueCollarShortSleevedShirt);

            PieceOfClothing lSS1 = new PieceOfClothing("LSS", "B", "Long Sleeved Jean Shirt");
            bLSShirtsAndBSSShirts.Add(lSS1);
            bLSShirts.Add(lSS1);

            PieceOfClothing tightKahkiPants = new PieceOfClothing("P", "B", "Tight Kahki Pants");
            bPants.Add(tightKahkiPants);

            PieceOfClothing brownDressShoes = new PieceOfClothing("S", "B", "Brown Dress Shoes");
            bShoes.Add(brownDressShoes);
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

        public ArrayList Jackets { get => jackets; set => jackets = value; }
        public ArrayList TTops { get => tTops; set => tTops = value; }
        public ArrayList TTopsAndCSSShirts { get => tTopsAndCSSShirts; set => tTopsAndCSSShirts = value; }
        public ArrayList BSSShirts { get => bSSShirts; set => bSSShirts = value; }
        public ArrayList CSSShirts { get => cSSShirts; set => cSSShirts = value; }
        public ArrayList SweatShirts { get => sweatShirts; set => sweatShirts = value; }
        public ArrayList CLSShirts { get => cLSShirts; set => cLSShirts = value; }
        public ArrayList BLSShirts { get => bLSShirts; set => bLSShirts = value; }
        public ArrayList CLSShirtsAndcSSShirts { get => cLSShirtsAndcSSShirts; set => cLSShirtsAndcSSShirts = value; }
        public ArrayList SweatShirtsAndCLSShirts { get => sweatShirtsAndCLSShirts; set => sweatShirtsAndCLSShirts = value; }
        public ArrayList BLSShirtsAndBSSShirts { get => bLSShirtsAndBSSShirts; set => bLSShirtsAndBSSShirts = value; }
        public ArrayList BPants { get => bPants; set => bPants = value; }
        public ArrayList Jeans { get => jeans; set => jeans = value; }
        public ArrayList Sweatpants { get => sweatpants; set => sweatpants = value; }
        public ArrayList AllPants { get => allPants; set => allPants = value; }
        public ArrayList AllPantsAndShorts { get => allPantsAndShorts; set => allPantsAndShorts = value; }
        public ArrayList AllShorts { get => allShorts; set => allShorts = value; }
        public ArrayList SweatpantsAndSShorts { get => sweatpantsAndSShorts; set => sweatpantsAndSShorts = value; }
        public ArrayList BPantsAndBShorts { get => bPantsAndBShorts; set => bPantsAndBShorts = value; }
        public ArrayList SShorts { get => sShorts; set => sShorts = value; }
        public ArrayList BShoes { get => bShoes; set => bShoes = value; }
        public ArrayList CShoes { get => cShoes; set => cShoes = value; }
        public ArrayList SShoes { get => sShoes; set => sShoes = value; }
    }
}
