using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Generator
{
    public class Outfit
    {
        public Outfit(PieceOfClothing jacket, PieceOfClothing shirt, PieceOfClothing pants, PieceOfClothing shoes)
        {
            if (jacket == null)
                this.Jacket = new PieceOfClothing("J", "NP", "");
            else
                this.Jacket = jacket;
            this.Shirt = shirt;
            this.ForLegs = pants;
            if (shoes == null)
                this.Shoes = new PieceOfClothing("S", "NP", "");
            else
                this.Shoes = shoes;
        }

        internal PieceOfClothing Jacket { get; set; }
        internal PieceOfClothing Shirt { get; set; }
        internal PieceOfClothing ForLegs { get; set; }
        internal PieceOfClothing Shoes { get; set; }

        public void Randomize(int temp, string occasion)
        {
            

            ArrayList jackets = ClothingData.Instance.Jackets;
            ArrayList tTopsAndCSSShirts = ClothingData.Instance.TTopsAndCSSShirts; //tank tops and casual short sleeved shirts
            ArrayList bSSShirts = ClothingData.Instance.BSSShirts; //business short sleeved shirts
            ArrayList cSSShirts = ClothingData.Instance.CSSShirts; //casual short sleeved shirts
            ArrayList cLSShirts = ClothingData.Instance.CLSShirts; //casual long sleeved shirts
            ArrayList bLSShirts = ClothingData.Instance.BLSShirts; //business long sleeved shirts
            ArrayList cLSShirtsAndcSSShirts = ClothingData.Instance.CLSShirtsAndcSSShirts; //casual long sleeved shirts and casual short sleeved shirts
            ArrayList sweatShirtsAndCLSShirts = ClothingData.Instance.SweatShirtsAndCLSShirts; //sweatshirts and casual long sleeved shirts
            ArrayList bLSShirtsAndBSSShirts = ClothingData.Instance.BLSShirtsAndBSSShirts; //business long sleeved shirts and business short sleeved shirts
            ArrayList bPants = ClothingData.Instance.BPants;
            ArrayList sweatpants = ClothingData.Instance.Sweatpants;
            ArrayList allPants = ClothingData.Instance.AllPants;
            ArrayList allPantsAndShorts = ClothingData.Instance.AllPantsAndShorts;
            ArrayList allShorts = ClothingData.Instance.AllShorts;
            ArrayList sweatpantsAndSShorts = ClothingData.Instance.SweatpantsAndSShorts;
            ArrayList bPantsAndBShorts = ClothingData.Instance.BPantsAndBShorts;
            ArrayList sShorts = ClothingData.Instance.SShorts;
            ArrayList bShoes = ClothingData.Instance.BShoes;
            ArrayList cShoes = ClothingData.Instance.CShoes;
            ArrayList sShoes = ClothingData.Instance.SShoes;

            if (temp < 50)
            {
                if (temp <= 40)
                    this.Jacket = (PieceOfClothing)jackets[RandomNumber(0, jackets.Count)];
                if (occasion == "Business")
                {
                    this.Shirt = (PieceOfClothing)bLSShirts[RandomNumber(0, bLSShirts.Count - 1)];
                    this.ForLegs = (PieceOfClothing)bPants[RandomNumber(0, bPants.Count)];
                    this.Shoes = (PieceOfClothing)bShoes[RandomNumber(0, bShoes.Count)];
                }
                else if (occasion == "Exercise")
                {
                    this.Shirt = (PieceOfClothing)cLSShirtsAndcSSShirts[RandomNumber(0, cLSShirtsAndcSSShirts.Count)];
                    this.ForLegs = (PieceOfClothing)sweatpantsAndSShorts[RandomNumber(0, sweatpantsAndSShorts.Count)];
                    this.Shoes = (PieceOfClothing)sShoes[RandomNumber(0, sShoes.Count)];
                }
                else if (occasion == "Casual")
                {
                    this.Shirt = (PieceOfClothing)cLSShirts[RandomNumber(0, cLSShirts.Count)];
                    this.ForLegs = (PieceOfClothing)allPants[RandomNumber(0, allPants.Count)];
                    this.Shoes = (PieceOfClothing)cShoes[RandomNumber(0, cShoes.Count)];
                }
                else if (occasion == "Home")
                {
                    this.Shirt = (PieceOfClothing)sweatShirtsAndCLSShirts[RandomNumber(0, sweatShirtsAndCLSShirts.Count)];
                    this.ForLegs = (PieceOfClothing)sweatpants[RandomNumber(0, sweatpants.Count)];
                }
            }
            else if (temp >= 50)
            {
                if (occasion == "Business")
                {
                    this.Shirt = (PieceOfClothing)bSSShirts[RandomNumber(0, bSSShirts.Count)];
                    this.ForLegs = (PieceOfClothing)bPantsAndBShorts[RandomNumber(0, bPantsAndBShorts.Count)];
                    this.Shoes = (PieceOfClothing)bShoes[RandomNumber(0, bShoes.Count)];
                    if (temp < 75)
                    {
                        this.Shirt = (PieceOfClothing)bLSShirtsAndBSSShirts[RandomNumber(0, bLSShirtsAndBSSShirts.Count)];
                    }
                }
                else if (occasion == "Exercise")
                {
                    this.Shirt = (PieceOfClothing)tTopsAndCSSShirts[RandomNumber(0, tTopsAndCSSShirts.Count)];
                    this.ForLegs = (PieceOfClothing)sShorts[RandomNumber(0, sShorts.Count)];
                    this.Shoes = (PieceOfClothing)sShoes[RandomNumber(0, sShoes.Count)];
                    if (temp < 75)
                    {
                        this.Shirt = (PieceOfClothing)cSSShirts[RandomNumber(0, cSSShirts.Count)];
                    }
                }
                else if (occasion == "Casual")
                {
                    this.Shirt = (PieceOfClothing)cSSShirts[RandomNumber(0, cSSShirts.Count)];
                    this.ForLegs = (PieceOfClothing)allShorts[RandomNumber(0, allShorts.Count)];
                    this.Shoes = (PieceOfClothing)cShoes[RandomNumber(0, cShoes.Count)];
                    if (temp < 75)
                    {
                        this.Shirt = (PieceOfClothing)cLSShirtsAndcSSShirts[RandomNumber(0, cLSShirtsAndcSSShirts.Count)];
                        this.ForLegs = (PieceOfClothing)allPantsAndShorts[RandomNumber(0, cSSShirts.Count)];
                    }
                }
                else if (occasion == "Home")
                {
                    this.Shirt = (PieceOfClothing)tTopsAndCSSShirts[RandomNumber(0, tTopsAndCSSShirts.Count)];
                    this.ForLegs = (PieceOfClothing)sShorts[RandomNumber(0, sShorts.Count)];
                    if (temp < 75)
                    {
                        this.Shirt = (PieceOfClothing)cSSShirts[RandomNumber(0, cSSShirts.Count)];
                    }
                }
            }
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
