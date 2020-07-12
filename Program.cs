using System;

namespace PromotionEngine
{
    public class SKUIdItemsModel
    {
        public int Aitems {get; set;}
        public int Bitems {get; set;}
        public int Citems {get; set;}
        public int Ditems {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var model = new SKUIdItemsModel();

            Console.WriteLine("\nEnter SKU A items: ");
            model.Aitems = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nEnter SKU B items: ");
            model.Bitems = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWEnter SKU C items: ");
            model.Citems = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter SKU D items: ");
            model.Ditems = Convert.ToInt32(Console.ReadLine());


            var p = new Program();

            float totalPromotionalValue = p.PromotionalTotalValue(model);

            Console.WriteLine($"\nTotal Promotional Value: {totalPromotionalValue}");

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }

        public float PromotionalTotalValue(SKUIdItemsModel model)
        {
            float total = 0;
            int Apromotionncnt=0;
            int Anormalcnt=0;

            for(int i=1; i<=model.Aitems;i++)
            {
                if(i%3==0)
                {
                    Apromotionncnt++;
                    Anormalcnt=0;
                }
                else
                {
                    Anormalcnt++;
                }
            }

            float Atotal = Apromotionncnt * 130 + Anormalcnt * 50;

            int Bpromotionncnt=0;
            int Bnormalcnt=0;

            for(int j=1; j<=model.Bitems;j++)
            {
                if(j%2==0)
                {
                    Bpromotionncnt++;
                    Bnormalcnt=0;
                }
                else
                {
                    Bnormalcnt++;
                }
            }

            float Btotal = Bpromotionncnt * 45 + Bnormalcnt * 30;

            float CDtotal=0;
            
            if(model.Citems==1 && model.Ditems==1)
            {
                CDtotal = 30;
            }
            else
            {
                float Ctotal = model.Citems * 20;
                float Dtotal = model.Ditems * 15;
                CDtotal = Ctotal + Dtotal;
            }

            total = Atotal + Btotal + CDtotal;

            return total;
        }
    }

    

    
}
