namespace Operations
{
    public class Operations
    {
        public List<double> Up(string operation, List<double> Listik)
        {
            switch (operation)
            {
                case "+":
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] = Listik[1] + Listik[3];
                    break;
                case "-":
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] = Listik[1] - Listik[3];
                    break;
                case "/":
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] = Listik[1] / Listik[3];
                    break;
                case "*":
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] = Listik[1] * Listik[3];
                    break;
                default:
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] = 0d;
                    break;
            }
            return Listik;
        }
        public void Down(List<double> Listik)
        {

            Listik[3] = Listik[2];
            Listik[2] = Listik[1];
            Listik[1] = Listik[0];
        }
        public void Switch(List<double> Listik)
        {
            double buff = Listik[3];
            Listik[3] = Listik[2];
            Listik[2] = buff;
        }
        public void Turn(List<double> Listik)
        {
            double buff = Listik[3];
            Listik[3] = Listik[2];
            Listik[2] = Listik[1];
            Listik[1] = Listik[0];
            Listik[0] = buff;
        }
    }
}