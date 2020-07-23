namespace ClassDiagram
{
    class Register
    {
        Shape[] Shapes;
        public Register(int size)
        {
            Shapes = new Shape[size];
        }
        public Shape this [int index]
        {
            get => Shapes[index];
            set => Shapes[index] = value;
        }
    }
}
