namespace Operations
{
    public class Operations
    {
        public Operations(List<double> listik)
        {
            Listik = listik;
        }

        List<double> Listik { get; set; }

        public List<double> Up(string operation)
        {
            switch (operation)
            {
                case "+":
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] += Listik[1];
                    break;
                case "-":
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] -= Listik[1];
                    break;
                case "/":
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] /= Listik[1];
                    break;
                case "*":
                    Listik[0] = Listik[1];
                    Listik[1] = Listik[2];
                    Listik[2] = Listik[3];
                    Listik[3] *= Listik[1];
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
        public List<double> Down()
        {

            Listik[3] = Listik[2];
            Listik[2] = Listik[1];
            Listik[1] = Listik[0];
            return Listik;
        }
        public List<double> Switch()
        {
            double buff = Listik[3];
            Listik[3] = Listik[2];
            Listik[2] = buff;
            return Listik;
        }
        public List<double> Turn()
        {
            double buff = Listik[0];
            Listik[0] = Listik[1];
            Listik[1] = Listik[2];
            Listik[2] = Listik[3];
            Listik[3] = buff;
            return Listik;
        }
    }
}