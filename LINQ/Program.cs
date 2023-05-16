namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> ClothingDesigner = new List<string>() { "Your clothes are so boujie, can you afford that?." };

            ClothingDesigner.Add("Christian Dior");
            ClothingDesigner.Add("Louis Vuitton");
            ClothingDesigner.Add("Chanel");

            var orderedDesigners = ClothingDesigner.OrderByDescending(name => name.Length);

            foreach (var designer in orderedDesigners) 
            {
                Console.WriteLine(designer);
            }
        }
    }
}
