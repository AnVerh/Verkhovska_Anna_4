using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0;
            AppleTree apple = new AppleTree(3, true);
            apple.TransplantTree();
            Console.WriteLine(apple.TreeHealthyAge);
            apple.FruitInfo();
            CherryTree cherry = new CherryTree(25, true);
            cherry.TransplantTree();
            NutsTree nuts = new NutsTree(1, false);
            nuts.TransplantTree();
            PlumTree plum = new PlumTree(3,true);
            plum.TransplantTree();
            Console.WriteLine();
            apple.GetTreeQuantity();
            plum.GetTreeQuantity();
            cherry.GetTreeQuantity();
            nuts.GetTreeQuantity();
        }
    }
    
    abstract class GardenTree
    {
        public int TreeQuantity { get; set; }
        protected abstract string TreeName { get;  }
        public abstract int TreeHealthyAge { get;  }
        protected int TreeActualAge { get; set; }
        protected bool GoodFruits;
        public GardenTree() { TreeQuantity++; }
        public void FruitInfo()
        {
            Console.WriteLine($"The {TreeName} gives {TreeName}s ");
        }
        public void TransplantTree()
        {
            if (TreeActualAge > TreeHealthyAge || GoodFruits == false)
            {
                Console.WriteLine($"The {TreeName} needs to be transplanted");
            }
            else
            {
                Console.WriteLine($"The {TreeName} doesn't need to be transplanted");
            }
        }
        public void GetTreeQuantity()
        {
            Console.WriteLine($"There are {TreeQuantity} trees is the garden");
        }
    }
    class AppleTree : GardenTree
    {
        protected override string TreeName { get { return "apple"; }  }
        public override int TreeHealthyAge { get { return 70; } }
        public AppleTree(int age, bool goodfruits) 
        {
            TreeActualAge = age;
            GoodFruits = goodfruits;
            //TreeQuantity++;
        }
    }
    class CherryTree : GardenTree
    {
        protected override string TreeName { get { return "cherry"; } }
        public override int TreeHealthyAge { get { return 55; } }
        public CherryTree(int age, bool goodfruits)
        {
            TreeActualAge = age;
            GoodFruits = goodfruits;
            //TreeQuantity++;
        }
    }
    class PearTree : GardenTree
    {
        protected override string TreeName { get { return "pear"; } }
        public override int TreeHealthyAge { get { return 30; } }
        public PearTree(int age, bool goodfruits)
        {
            TreeActualAge = age;
            GoodFruits = goodfruits;
           // TreeQuantity++;
        }
    }
    class NutsTree : GardenTree
    {
        protected override string TreeName { get { return "nuts"; } }
        public override int TreeHealthyAge { get { return 85; } }
        public NutsTree(int age, bool goodfruits)
        {
            TreeActualAge = age;
            GoodFruits = goodfruits;
            //TreeQuantity++;
        }
    }
    class PlumTree : GardenTree
    {
        protected override string TreeName { get { return "plum"; } }
        public override int TreeHealthyAge { get { return 15; } }
        public PlumTree(int age, bool goodfruits)
        {
            TreeActualAge = age;
            GoodFruits = goodfruits;
           // TreeQuantity++;
        }
    }
}
