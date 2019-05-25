using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Chetina
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public RushOrder ShippingType { get; set; }

        public DateTime QuoteDate { get; set; }

        public decimal QuotePrice { get; set; }

        //enums
        public enum RushOrder
        {
            Day3Rush,
            Day5Rush,
            Day7Rush,
            Day14NoRush
                 
        }

        // declared constant variables based on 
        const decimal BASE_DESK_PRICE = 200.00M;
        //const decimal SURFACE_AREA_PRICE = 1.00M;
        const decimal DRAWER_PRICE = 50.00M;
        const decimal OAK_PRICE = 200.00M;
        const decimal LAMINATE_PRICE = 100.00M;
        const decimal PINE_PRICE = 50.00M;
        const decimal ROSEWOO_PRICED = 300.00M;
        const decimal VENEER_PRICE = 125.00M;


        //created a function that calculates total price
        public decimal GetQuotePrice()
        {

            //declared variable
            decimal quotePrice = BASE_DESK_PRICE;

            //calculate a surfacearea
            decimal surfaceArea = this.Desk.Depth * this.Desk.Width;

            //declare a variable
            decimal surfaceAreaPrice;

            if (surfaceArea > 1000)
            {
                surfaceAreaPrice = (surfaceArea - 1000) * 1;
            }

            //new var for 
            var DrawersPrice = Desk.NumberOfDrawers * 50;

            //new var
            var surfaceMaterialPrice = 0;

            //here I wrote a switch statement, because our price is based on materia
            switch (Desk.SurfaceMaterial)
            {
                case Desk.DesktopMaterial.Oak:
                    surfaceMaterialPrice = 200;
                    break;

                case Desk.DesktopMaterial.Laminate:
                    surfaceMaterialPrice = 100;
                    break;

                case Desk.DesktopMaterial.Pine:
                    surfaceMaterialPrice = 50;
                    break;

                case Desk.DesktopMaterial.Rosewood:
                    surfaceMaterialPrice = 300;
                    break;

                case Desk.DesktopMaterial.Veneer:
                    surfaceMaterialPrice = 125;
                    break;
            }
            

            //this shoud be for calculate a delivery based on rush days
            //this text file it will store prices for 
            int[,] rushOrderArray = getRushOrder(@"rushOrderPrices.txt");


            int RUSH_3DAY_LESS_THAN_1000 = rushOrderArray[0, 0];
            int RUSH_3DAY_1000_TO_2000 = rushOrderArray[0, 1];
            int RUSH_3DAY_GREATER_THAN_2000 = rushOrderArray[0, 2];
            int RUSH_5DAY_LESS_THAN_1000 = rushOrderArray[1, 0];
            int RUSH_5DAY_1000_TO_2000 = rushOrderArray[1, 1];
            int RUSH_5DAY_GREATER_THAN_2000 = rushOrderArray[1, 2];
            int RUSH_7DAY_LESS_THAN_1000 = rushOrderArray[2, 0];
            int RUSH_7DAY_1000_TO_2000 = rushOrderArray[2, 1];
            int RUSH_7DAY_GREATER_THAN_2000 = rushOrderArray[2, 2];

            var shippingPrice = 0;
            switch (ShippingType)
            {
                //case statement based on surface area
                case RushOrder.Day3Rush:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 60;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 70;
                    }
                    else
                    {
                        shippingPrice = 80;
                    }
                    break;

                case RushOrder.Day5Rush:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 40;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 50;
                    }
                    else
                    {
                        shippingPrice = 60;
                    }
                    break;

                case RushOrder.Day7Rush:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 30;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 35;
                    }
                    else
                    {
                        shippingPrice = 40;
                    }
                    break;

                default:
                    shippingPrice = 0;
                    break;
            }


            //this is a total price
            quotePrice = 200 + surfaceAreaPrice + DrawersPrice + surfaceMaterialPrice + shippingPrice;

            return quotePrice;
        }

        


        }


    }
}
