namespace Animals.Models.Animals
{
    class Griffin : Animal
    {
        public Griffin() {
            this.griffinName = "Griffin";
        }
        public string griffinName { get; set; }
        public override void Move()
        {
            Console.WriteLine($"Le {griffinName} court");
        }

        public new void Sleep()
        {
            Console.WriteLine($"Le {griffinName} dort profondement");
        }

        
    }
}
