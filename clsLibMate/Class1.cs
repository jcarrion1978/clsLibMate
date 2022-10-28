namespace clsLibMate
{
    public class Numero
    {
        private int num1;
        private int num2;

        public Numero()
        {
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }

        public int Suma()
        {
            return num1 + num2;
        }
    }
}