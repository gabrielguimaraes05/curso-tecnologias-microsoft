namespace Aula2POO.Classes
{
    class JewelType
    {
        private int Red { get; set; }
        private int Green { get; set; }
        private int Blue { get; set; }

        public JewelType()
        {
            Red = (int)JewelTypesEnum.Red;
            Green = (int)JewelTypesEnum.Green;
            Blue = (int)JewelTypesEnum.Blue;
        }
    }
}
