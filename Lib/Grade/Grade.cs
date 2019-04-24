namespace Lib
{
    public class Grade
    {
        public MainGrade Main;
        public SubGrade Sub;
        public int Score => 3 * (int)Main + (int)Sub;
        protected Grade() { } 
        public Grade(int value)
        {
            Main = (MainGrade)(value / 3);
            Sub = (SubGrade)(value % 3);
        }
        public Grade(string value)
        {
            switch (value[0])
            {
                case 'A':
                    Main = MainGrade.A;
                    break;
                case 'B':
                    Main = MainGrade.B;
                    break;
                case 'C':
                    Main = MainGrade.C;
                    break;
                case 'D':
                    Main = MainGrade.D;
                    break;
                case 'F':
                    Main = MainGrade.F;
                    break;
                default:
                    Main = MainGrade.F;
                    break;
            }
            if (value.Length == 2)
            {
                if (value[1] == '+')
                {
                    Sub = SubGrade.Plus;
                }
                else
                {
                    Sub = SubGrade.Minus;
                }
            }
            else
            {
                Sub = SubGrade.Zero;
            }
        } 
    }
}
